using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using ZedGraph;
using System.Threading;
using System.Text.RegularExpressions;
using System.Timers;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace BurnInPitStop
{

    public partial class Form1 : Form
    {
        string dataOUT;
        string dataIN_Chamber;
        string dataIN_Tester;
        string[] NestStatus;
        string ChamberStatus;
        Color[] ColorF;
        Color[] ColorB;
        int[] TempProfilx = new int[1];
        int[] TempProfily = new int[1];
        int[] Devinitx = new int[1];
        int[] Devinity = new int[1];
        private static string receiveBuffer = "";
        DateTime date;
        private Thread _startprocess;
        public AddListItem myDelegate;
        private Button myButton;
        private Thread myThread;
        private ListBox myListBox;
        public string hexValue;
        int buffLen;
        int buffPos;
        string data;
        string tempdata;

        public Form1()
        {
            InitializeComponent();
            NestStatus = new string[216];
            ColorF = new Color[216];
            ColorB = new Color[216];
            ComBoxChamber.Visible = true;
            StartButton.Enabled = false;
            ComBoxCart.Visible = true;
            ComBoxTester.Visible = true;
            button14.Enabled = false;
            button2.Enabled = false;
            foreach (string portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbComPort.Items.Add(portName);
            }
            cmbComPort.SelectedIndex = 0;
            cmbComSpeed.SelectedIndex = 4;
            cmbCanBitrate.SelectedIndex = 4;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            Label220.Text = "Available Slot STTS=1";
            Label220.BackColor = Color.White;
            Label220.ForeColor = Color.Black;

            Label221.Text = "Blocked Slot STTS=2";
            Label221.BackColor = Color.Black;
            Label221.ForeColor = Color.White;

            Label222.Text = "Pretest Fail (may remain on cart) STTS=3";
            Label222.BackColor = Color.Cyan;
            Label222.ForeColor = Color.Black;

            Label223.Text = "*Prior Step FAIL* STTS=4";
            Label223.BackColor = Color.Red;
            Label223.ForeColor = Color.White;

            Label224.Text = "PASS STTS=5";
            Label224.BackColor = Color.Lime;
            Label224.ForeColor = Color.Black;

            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPort.Items.AddRange(ports);
            comboBox5.Items.AddRange(ports);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            string TempProfilString;
            string Devinit;

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                zedGraphControl1.GraphPane.Title.Text = "Thermoprofile";
                zedGraphControl1.GraphPane.XAxis.Title.Text = "Time, min";
                zedGraphControl1.GraphPane.YAxis.Title.Text = "Temperature, degrees of celsius";
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files(*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
                fileContent = fileContent.Replace("\r", "!");
                fileContent = fileContent.Replace("\n", "");
                fileContent = fileContent.Replace("\t", ":");
                TempProfilString = fileContent.Split('>')[0];
                Devinit = fileContent.Split('>')[1];
                TempProfilString = TempProfilString.Split('<')[1];
                Devinit = Devinit.Split('<')[1];
                int a = 0, b = 0;
                int i = 1;
                while (i == 1)
                {
                    int pos = TempProfilString.LastIndexOf(':');
                    TempProfily[b] = int.Parse(TempProfilString.Substring(pos + 1));
                    TempProfilString = TempProfilString.Substring(0, pos);
                    b++;
                    if (TempProfilString == "0")
                        break;
                    Array.Resize(ref TempProfily, b + 1);
                    pos = TempProfilString.LastIndexOf("!");
                    TempProfilx[a] = int.Parse(TempProfilString.Substring(pos + 1));
                    TempProfilString = TempProfilString.Substring(0, pos);
                    a++;
                    Array.Resize(ref TempProfilx, a + 1);
                }
                Array.Reverse(TempProfily);
                Array.Reverse(TempProfilx);
                a = 0; b = 0;
                i = 1;
                while (i == 1)
                {
                    int pos = Devinit.LastIndexOf(':');
                    Devinity[b] = int.Parse(Devinit.Substring(pos + 1));
                    Devinit = Devinit.Substring(0, pos);
                    b++;
                    if (Devinit == "0")
                        break;
                    Array.Resize(ref Devinity, b + 1);
                    pos = Devinit.LastIndexOf("!");
                    Devinitx[a] = int.Parse(Devinit.Substring(pos + 1));
                    Devinit = Devinit.Substring(0, pos);
                    a++;
                    Array.Resize(ref Devinitx, a + 1);
                }
                Array.Reverse(Devinity);
                Array.Reverse(Devinitx);
            }
            GraphPane pane = zedGraphControl1.GraphPane;
            pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            for (int i = 0; i <= TempProfilx.Length - 1; i++)
            {
                list.Add(TempProfilx[i], TempProfily[i]);
            }
            LineItem myCurve = pane.AddCurve("Sinc", list, Color.Blue, SymbolType.None);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();

            zedGraphControl2.GraphPane.Title.Text = "Power cycle";
            zedGraphControl2.GraphPane.XAxis.Title.Text = "Time, min";
            zedGraphControl2.GraphPane.YAxis.Title.Text = "Status";

            GraphPane pane2 = zedGraphControl2.GraphPane;
            pane2.CurveList.Clear();
            PointPairList list2 = new PointPairList();

            for (int i = 0; i <= Devinitx.Length - 1; i++)
            {
                list2.Add(Devinitx[i], Devinity[i]);
            }
            LineItem myCurve2 = pane2.AddCurve("Sinc", list2, Color.Red, SymbolType.None);
            zedGraphControl2.AxisChange();
            zedGraphControl2.Invalidate();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        Point last;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point cur = MousePosition;
                int dx = cur.X - last.X;
                int dy = cur.Y - last.Y;
                Point loc = new Point(Location.X + dx, Location.Y + dy);
                Location = loc;
                last = cur;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
                frm.WindowState = FormWindowState.Minimized;

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            /* teoretycznie odczytuje z pliku*/

            NestStatus[78] = "STTS2";
            NestStatus[150] = "STTS2";
            NestStatus[15] = "STTS2";
            NestStatus[13] = "STTS2";
            NestStatus[150] = "STTS2";

            Label78.BackColor = ColorB[78];
            Label150.BackColor = ColorB[150];
            Label15.BackColor = ColorB[15];
            Label23.BackColor = ColorB[23];
            Label150.BackColor = ColorB[150];

            Label78.ForeColor = ColorF[78];
            Label150.ForeColor = ColorF[150];
            Label15.ForeColor = ColorF[15];
            Label23.ForeColor = ColorF[23];
            Label150.ForeColor = ColorF[150];

            button10.PerformClick();
            button11.PerformClick();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen & serialPort3.IsOpen)
            {
                serialPort3.WriteLine("Power ON");
                MessageBox.Show("Make sure the products have been loaded and plugged into all available slots in the cart!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = 0; i < 216; i++)
                {
                    if (NestStatus[i] == null)/*Próba podlączenia do wózka i odzczytywania SN, nadanie statusu NG przy prubie podlaczenia*/
                    {
                        int buffLen = receiveBuffer.Length;
                        int buffPos = -1;
                        int c = ' ';
                        rtboxReceive.Text = String.Empty;
                        if (i < 16)
                        {
                            string hexValue = i.ToString("X");
                            tbxID.Text = "";
                            tbxID.Text = "00" + hexValue;
                        }
                        else
                        {
                            string hexValue = i.ToString("X");
                            tbxID.Text = "";
                            tbxID.Text = "0" + hexValue;
                        }
                        string canFrameData = "";

                        if (cboxRtr.Checked == true)        // RTR Frame
                        {
                            if (cboxExt.Checked == true)    // 29bit Frame
                            {
                                canFrameData += "R";
                            }
                            else                            // 11bit frame
                            {
                                canFrameData += "r";
                            }
                            canFrameData += tbxID.Text + numDlc.Value.ToString();
                        }
                        else                                // Normal Frame
                        {
                            if (cboxExt.Checked == true)    // 29bit Frame
                            {
                                canFrameData += "T";
                            }
                            else                            // 11bit frame
                            {
                                canFrameData += "t";
                            }
                            canFrameData += tbxID.Text + numDlc.Value.ToString();
                            if (numDlc.Value >= 1)
                            {
                                canFrameData += tbxHex1.Text;
                            }
                            if (numDlc.Value >= 2)
                            {
                                canFrameData += tbxHex2.Text;
                            }
                            if (numDlc.Value >= 3)
                            {
                                canFrameData += tbxHex3.Text;
                            }
                            if (numDlc.Value >= 4)
                            {
                                canFrameData += tbxHex4.Text;
                            }
                            if (numDlc.Value >= 5)
                            {
                                canFrameData += tbxHex5.Text;
                            }
                            if (numDlc.Value >= 6)
                            {
                                canFrameData += tbxHex6.Text;
                            }
                            if (numDlc.Value >= 7)
                            {
                                canFrameData += tbxHex7.Text;
                            }
                            if (numDlc.Value >= 8)
                            {
                                canFrameData += tbxHex8.Text;
                            }
                        }
                        if (serialPort2.IsOpen)
                        {
                            serialPort2.Write(canFrameData);
                            serialPort2.Write("\r");
                        }
                        lblResult.Text = "Resulting command: " + canFrameData + "[CR]";
                        receiveBuffer = serialPort2.ReadExisting();
                        if (buffLen > 1)
                        {
                            // More than one character
                            if ((buffPos = receiveBuffer.IndexOf("\r")) >= 0)
                            {
                                rtboxReceive.AppendText(receiveBuffer.Substring(0, buffPos));
                                rtboxReceive.AppendText("[CR]");
                                rtboxReceive.AppendText(receiveBuffer.Substring(buffPos, (buffLen - buffPos)));
                            }
                            else
                            {
                                rtboxReceive.AppendText(receiveBuffer);
                            }
                        }
                        if (rtboxReceive.Text == "")
                            NestStatus[i] = "STTS3";
                        else
                            NestStatus[i] = "STTS5";
                        RichTextBox1.AppendText("Nest" + (i + 1) + " SN: " + rtboxReceive.Text + " :" + NestStatus[i] + "\r\n");
                    }
                }
                for (int i = 0; i < 216; i++)
                {
                    int j = i + 1;
                    RichTextBox1.AppendText("Nest" + j + ":" + NestStatus[i] + "\r\n");
                }
                button10.PerformClick();
                button11.PerformClick();
                StartButton.Enabled = true;
                serialPort3.WriteLine("Power OFF");
            }
            else
                MessageBox.Show("Please connect the tester and carts first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            RichTextBox1.Clear();
            Random random = new Random();

            for (int i = 0; i < 216; i++)
            {
                int number = random.Next(1, 6);
                NestStatus[i] = "STTS" + number;
            }

            for (int i = 0; i < 216; i++)
            {

                //RichTextBox1.Text = RichTextBox1.Text + "Nest" + i + ": STTS1";
                int j = i + 1;
                RichTextBox1.AppendText("Nest" + j + ":" + NestStatus[i] + "\r\n");
                //RichTextBox1.ScrollToCaret();
            }

            button10.PerformClick();
            button11.PerformClick();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            RichTextBox1.Clear();

            for (int i = 0; i < 6; i++)
            {
                NestStatus[i] = "STTS1";
            }

            for (int i = 6; i < 12; i++)
            {
                NestStatus[i] = "STTS2";
            }

            for (int i = 12; i < 18; i++)
            {
                NestStatus[i] = "STTS3";
            }

            for (int i = 18; i < 24; i++)
            {
                NestStatus[i] = "STTS4";
            }

            for (int i = 24; i < 108; i++)
            {
                NestStatus[i] = "STTS5";
            }

            for (int i = 108; i < 120; i++)
            {
                NestStatus[i] = "STTS1";
            }

            for (int i = 120; i < 132; i++)
            {
                NestStatus[i] = "STTS2";
            }

            for (int i = 132; i < 144; i++)
            {
                NestStatus[i] = "STTS3";
            }

            for (int i = 144; i < 168; i++)
            {
                NestStatus[i] = "STTS4";
            }

            for (int i = 168; i < 216; i++)
            {
                NestStatus[i] = "STTS5";
            }

            for (int i = 0; i < 216; i++)
            {

                //RichTextBox1.Text = RichTextBox1.Text + "Nest" + i + ": STTS1";
                int j = i + 1;
                RichTextBox1.AppendText("Nest" + j + ":" + NestStatus[i] + "\r\n");
                //RichTextBox1.ScrollToCaret();
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 216; i++)
            {
                switch (NestStatus[i])
                {

                    case "STTS1":
                        {
                            ColorB[i] = Color.White;
                            ColorF[i] = Color.Black;
                            break;
                        }
                    case "STTS2":
                        {
                            ColorB[i] = Color.Black;
                            ColorF[i] = Color.White;
                            break;
                        }
                    case "STTS3":
                        {
                            ColorB[i] = Color.Cyan;
                            ColorF[i] = Color.Black;
                            break;
                        }
                    case "STTS4":
                        {
                            ColorB[i] = Color.Red;
                            ColorF[i] = Color.White;
                            break;
                        }
                    case "STTS5":
                        {
                            ColorB[i] = Color.Lime;
                            ColorF[i] = Color.Black;
                            break;
                        }
                    default:
                        ColorB[i] = Color.White;
                        ColorF[i] = Color.Black;
                        break;
                }
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Label1.ForeColor = ColorF[0];
            Label2.ForeColor = ColorF[1];
            Label3.ForeColor = ColorF[2];
            Label4.ForeColor = ColorF[3];
            Label5.ForeColor = ColorF[4];
            Label6.ForeColor = ColorF[5];
            Label7.ForeColor = ColorF[6];
            Label8.ForeColor = ColorF[7];
            Label9.ForeColor = ColorF[8];
            Label10.ForeColor = ColorF[9];
            Label11.ForeColor = ColorF[10];
            Label12.ForeColor = ColorF[11];
            Label13.ForeColor = ColorF[12];
            Label14.ForeColor = ColorF[13];
            Label15.ForeColor = ColorF[14];
            Label16.ForeColor = ColorF[15];
            Label17.ForeColor = ColorF[16];
            Label18.ForeColor = ColorF[17];
            Label19.ForeColor = ColorF[18];
            Label20.ForeColor = ColorF[19];
            Label21.ForeColor = ColorF[20];
            Label22.ForeColor = ColorF[21];
            Label23.ForeColor = ColorF[22];
            Label24.ForeColor = ColorF[23];
            Label25.ForeColor = ColorF[24];
            Label26.ForeColor = ColorF[25];
            Label27.ForeColor = ColorF[26];
            Label28.ForeColor = ColorF[27];
            Label29.ForeColor = ColorF[28];
            Label30.ForeColor = ColorF[29];
            Label31.ForeColor = ColorF[30];
            Label32.ForeColor = ColorF[31];
            Label33.ForeColor = ColorF[32];
            Label34.ForeColor = ColorF[33];
            Label35.ForeColor = ColorF[34];
            Label36.ForeColor = ColorF[35];
            Label37.ForeColor = ColorF[36];
            Label38.ForeColor = ColorF[37];
            Label39.ForeColor = ColorF[38];
            Label40.ForeColor = ColorF[39];
            Label41.ForeColor = ColorF[40];
            Label42.ForeColor = ColorF[41];
            Label43.ForeColor = ColorF[42];
            Label44.ForeColor = ColorF[43];
            Label45.ForeColor = ColorF[44];
            Label46.ForeColor = ColorF[45];
            Label47.ForeColor = ColorF[46];
            Label48.ForeColor = ColorF[47];
            Label49.ForeColor = ColorF[48];
            Label50.ForeColor = ColorF[49];
            Label51.ForeColor = ColorF[50];
            Label52.ForeColor = ColorF[51];
            Label53.ForeColor = ColorF[52];
            Label54.ForeColor = ColorF[53];
            Label55.ForeColor = ColorF[54];
            Label56.ForeColor = ColorF[55];
            Label57.ForeColor = ColorF[56];
            Label58.ForeColor = ColorF[57];
            Label59.ForeColor = ColorF[58];
            Label60.ForeColor = ColorF[59];
            Label61.ForeColor = ColorF[60];
            Label62.ForeColor = ColorF[61];
            Label63.ForeColor = ColorF[62];
            Label64.ForeColor = ColorF[63];
            Label65.ForeColor = ColorF[64];
            Label66.ForeColor = ColorF[65];
            Label67.ForeColor = ColorF[66];
            Label68.ForeColor = ColorF[67];
            Label69.ForeColor = ColorF[68];
            Label70.ForeColor = ColorF[69];
            Label71.ForeColor = ColorF[70];
            Label72.ForeColor = ColorF[71];
            Label73.ForeColor = ColorF[72];
            Label74.ForeColor = ColorF[73];
            Label75.ForeColor = ColorF[74];
            Label76.ForeColor = ColorF[75];
            Label77.ForeColor = ColorF[76];
            Label78.ForeColor = ColorF[77];
            Label79.ForeColor = ColorF[78];
            Label80.ForeColor = ColorF[79];
            Label81.ForeColor = ColorF[80];
            Label82.ForeColor = ColorF[81];
            Label83.ForeColor = ColorF[82];
            Label84.ForeColor = ColorF[83];
            Label85.ForeColor = ColorF[84];
            Label86.ForeColor = ColorF[85];
            Label87.ForeColor = ColorF[86];
            Label88.ForeColor = ColorF[87];
            Label89.ForeColor = ColorF[88];
            Label90.ForeColor = ColorF[89];
            Label91.ForeColor = ColorF[90];
            Label92.ForeColor = ColorF[91];
            Label93.ForeColor = ColorF[92];
            Label94.ForeColor = ColorF[93];
            Label95.ForeColor = ColorF[94];
            Label96.ForeColor = ColorF[95];
            Label97.ForeColor = ColorF[96];
            Label98.ForeColor = ColorF[97];
            Label99.ForeColor = ColorF[98];
            Label100.ForeColor = ColorF[99];
            Label101.ForeColor = ColorF[100];
            Label102.ForeColor = ColorF[101];
            Label103.ForeColor = ColorF[102];
            Label104.ForeColor = ColorF[103];
            Label105.ForeColor = ColorF[104];
            Label106.ForeColor = ColorF[105];
            Label107.ForeColor = ColorF[106];
            Label108.ForeColor = ColorF[107];
            Label109.ForeColor = ColorF[108];
            Label110.ForeColor = ColorF[109];
            Label111.ForeColor = ColorF[110];
            Label112.ForeColor = ColorF[111];
            Label113.ForeColor = ColorF[112];
            Label114.ForeColor = ColorF[113];
            Label115.ForeColor = ColorF[114];
            Label116.ForeColor = ColorF[115];
            Label117.ForeColor = ColorF[116];
            Label118.ForeColor = ColorF[117];
            Label119.ForeColor = ColorF[118];
            Label120.ForeColor = ColorF[119];
            Label121.ForeColor = ColorF[120];
            Label122.ForeColor = ColorF[121];
            Label123.ForeColor = ColorF[122];
            Label124.ForeColor = ColorF[123];
            Label125.ForeColor = ColorF[124];
            Label126.ForeColor = ColorF[125];
            Label127.ForeColor = ColorF[126];
            Label128.ForeColor = ColorF[127];
            Label129.ForeColor = ColorF[128];
            Label130.ForeColor = ColorF[129];
            Label131.ForeColor = ColorF[130];
            Label132.ForeColor = ColorF[131];
            Label133.ForeColor = ColorF[132];
            Label134.ForeColor = ColorF[133];
            Label135.ForeColor = ColorF[134];
            Label136.ForeColor = ColorF[135];
            Label137.ForeColor = ColorF[136];
            Label138.ForeColor = ColorF[137];
            Label139.ForeColor = ColorF[138];
            Label140.ForeColor = ColorF[139];
            Label141.ForeColor = ColorF[140];
            Label142.ForeColor = ColorF[141];
            Label143.ForeColor = ColorF[142];
            Label144.ForeColor = ColorF[143];
            Label145.ForeColor = ColorF[144];
            Label146.ForeColor = ColorF[145];
            Label147.ForeColor = ColorF[146];
            Label148.ForeColor = ColorF[147];
            Label149.ForeColor = ColorF[148];
            Label150.ForeColor = ColorF[149];
            Label151.ForeColor = ColorF[150];
            Label152.ForeColor = ColorF[151];
            Label153.ForeColor = ColorF[152];
            Label154.ForeColor = ColorF[153];
            Label155.ForeColor = ColorF[154];
            Label156.ForeColor = ColorF[155];
            Label157.ForeColor = ColorF[156];
            Label158.ForeColor = ColorF[157];
            Label159.ForeColor = ColorF[158];
            Label160.ForeColor = ColorF[159];
            Label161.ForeColor = ColorF[160];
            Label162.ForeColor = ColorF[161];
            Label163.ForeColor = ColorF[162];
            Label164.ForeColor = ColorF[163];
            Label165.ForeColor = ColorF[164];
            Label166.ForeColor = ColorF[165];
            Label167.ForeColor = ColorF[166];
            Label168.ForeColor = ColorF[167];
            Label169.ForeColor = ColorF[168];
            Label170.ForeColor = ColorF[169];
            Label171.ForeColor = ColorF[170];
            Label172.ForeColor = ColorF[171];
            Label173.ForeColor = ColorF[172];
            Label174.ForeColor = ColorF[173];
            Label175.ForeColor = ColorF[174];
            Label176.ForeColor = ColorF[175];
            Label177.ForeColor = ColorF[176];
            Label178.ForeColor = ColorF[177];
            Label179.ForeColor = ColorF[178];
            Label180.ForeColor = ColorF[179];
            Label181.ForeColor = ColorF[180];
            Label182.ForeColor = ColorF[181];
            Label183.ForeColor = ColorF[182];
            Label184.ForeColor = ColorF[183];
            Label185.ForeColor = ColorF[184];
            Label186.ForeColor = ColorF[185];
            Label187.ForeColor = ColorF[186];
            Label188.ForeColor = ColorF[187];
            Label189.ForeColor = ColorF[188];
            Label190.ForeColor = ColorF[189];
            Label191.ForeColor = ColorF[190];
            Label192.ForeColor = ColorF[191];
            Label193.ForeColor = ColorF[192];
            Label194.ForeColor = ColorF[193];
            Label195.ForeColor = ColorF[194];
            Label196.ForeColor = ColorF[195];
            Label197.ForeColor = ColorF[196];
            Label198.ForeColor = ColorF[197];
            Label199.ForeColor = ColorF[198];
            Label200.ForeColor = ColorF[199];
            Label201.ForeColor = ColorF[200];
            Label202.ForeColor = ColorF[201];
            Label203.ForeColor = ColorF[202];
            Label204.ForeColor = ColorF[203];
            Label205.ForeColor = ColorF[204];
            Label206.ForeColor = ColorF[205];
            Label207.ForeColor = ColorF[206];
            Label208.ForeColor = ColorF[207];
            Label209.ForeColor = ColorF[208];
            Label210.ForeColor = ColorF[209];
            Label211.ForeColor = ColorF[210];
            Label212.ForeColor = ColorF[211];
            Label213.ForeColor = ColorF[212];
            Label214.ForeColor = ColorF[213];
            Label215.ForeColor = ColorF[214];
            Label216.ForeColor = ColorF[215];

            Label1.BackColor = ColorB[0];
            Label2.BackColor = ColorB[1];
            Label3.BackColor = ColorB[2];
            Label4.BackColor = ColorB[3];
            Label5.BackColor = ColorB[4];
            Label6.BackColor = ColorB[5];
            Label7.BackColor = ColorB[6];
            Label8.BackColor = ColorB[7];
            Label9.BackColor = ColorB[8];
            Label10.BackColor = ColorB[9];
            Label11.BackColor = ColorB[10];
            Label12.BackColor = ColorB[11];
            Label13.BackColor = ColorB[12];
            Label14.BackColor = ColorB[13];
            Label15.BackColor = ColorB[14];
            Label16.BackColor = ColorB[15];
            Label17.BackColor = ColorB[16];
            Label18.BackColor = ColorB[17];
            Label19.BackColor = ColorB[18];
            Label20.BackColor = ColorB[19];
            Label21.BackColor = ColorB[20];
            Label22.BackColor = ColorB[21];
            Label23.BackColor = ColorB[22];
            Label24.BackColor = ColorB[23];
            Label25.BackColor = ColorB[24];
            Label26.BackColor = ColorB[25];
            Label27.BackColor = ColorB[26];
            Label28.BackColor = ColorB[27];
            Label29.BackColor = ColorB[28];
            Label30.BackColor = ColorB[29];
            Label31.BackColor = ColorB[30];
            Label32.BackColor = ColorB[31];
            Label33.BackColor = ColorB[32];
            Label34.BackColor = ColorB[33];
            Label35.BackColor = ColorB[34];
            Label36.BackColor = ColorB[35];
            Label37.BackColor = ColorB[36];
            Label38.BackColor = ColorB[37];
            Label39.BackColor = ColorB[38];
            Label40.BackColor = ColorB[39];
            Label41.BackColor = ColorB[40];
            Label42.BackColor = ColorB[41];
            Label43.BackColor = ColorB[42];
            Label44.BackColor = ColorB[43];
            Label45.BackColor = ColorB[44];
            Label46.BackColor = ColorB[45];
            Label47.BackColor = ColorB[46];
            Label48.BackColor = ColorB[47];
            Label49.BackColor = ColorB[48];
            Label50.BackColor = ColorB[49];
            Label51.BackColor = ColorB[50];
            Label52.BackColor = ColorB[51];
            Label53.BackColor = ColorB[52];
            Label54.BackColor = ColorB[53];
            Label55.BackColor = ColorB[54];
            Label56.BackColor = ColorB[55];
            Label57.BackColor = ColorB[56];
            Label58.BackColor = ColorB[57];
            Label59.BackColor = ColorB[58];
            Label60.BackColor = ColorB[59];
            Label61.BackColor = ColorB[60];
            Label62.BackColor = ColorB[61];
            Label63.BackColor = ColorB[62];
            Label64.BackColor = ColorB[63];
            Label65.BackColor = ColorB[64];
            Label66.BackColor = ColorB[65];
            Label67.BackColor = ColorB[66];
            Label68.BackColor = ColorB[67];
            Label69.BackColor = ColorB[68];
            Label70.BackColor = ColorB[69];
            Label71.BackColor = ColorB[70];
            Label72.BackColor = ColorB[71];
            Label73.BackColor = ColorB[72];
            Label74.BackColor = ColorB[73];
            Label75.BackColor = ColorB[74];
            Label76.BackColor = ColorB[75];
            Label77.BackColor = ColorB[76];
            Label78.BackColor = ColorB[77];
            Label79.BackColor = ColorB[78];
            Label80.BackColor = ColorB[79];
            Label81.BackColor = ColorB[80];
            Label82.BackColor = ColorB[81];
            Label83.BackColor = ColorB[82];
            Label84.BackColor = ColorB[83];
            Label85.BackColor = ColorB[84];
            Label86.BackColor = ColorB[85];
            Label87.BackColor = ColorB[86];
            Label88.BackColor = ColorB[87];
            Label89.BackColor = ColorB[88];
            Label90.BackColor = ColorB[89];
            Label91.BackColor = ColorB[90];
            Label92.BackColor = ColorB[91];
            Label93.BackColor = ColorB[92];
            Label94.BackColor = ColorB[93];
            Label95.BackColor = ColorB[94];
            Label96.BackColor = ColorB[95];
            Label97.BackColor = ColorB[96];
            Label98.BackColor = ColorB[97];
            Label99.BackColor = ColorB[98];
            Label100.BackColor = ColorB[99];
            Label101.BackColor = ColorB[100];
            Label102.BackColor = ColorB[101];
            Label103.BackColor = ColorB[102];
            Label104.BackColor = ColorB[103];
            Label105.BackColor = ColorB[104];
            Label106.BackColor = ColorB[105];
            Label107.BackColor = ColorB[106];
            Label108.BackColor = ColorB[107];
            Label109.BackColor = ColorB[108];
            Label110.BackColor = ColorB[109];
            Label111.BackColor = ColorB[110];
            Label112.BackColor = ColorB[111];
            Label113.BackColor = ColorB[112];
            Label114.BackColor = ColorB[113];
            Label115.BackColor = ColorB[114];
            Label116.BackColor = ColorB[115];
            Label117.BackColor = ColorB[116];
            Label118.BackColor = ColorB[117];
            Label119.BackColor = ColorB[118];
            Label120.BackColor = ColorB[119];
            Label121.BackColor = ColorB[120];
            Label122.BackColor = ColorB[121];
            Label123.BackColor = ColorB[122];
            Label124.BackColor = ColorB[123];
            Label125.BackColor = ColorB[124];
            Label126.BackColor = ColorB[125];
            Label127.BackColor = ColorB[126];
            Label128.BackColor = ColorB[127];
            Label129.BackColor = ColorB[128];
            Label130.BackColor = ColorB[129];
            Label131.BackColor = ColorB[130];
            Label132.BackColor = ColorB[131];
            Label133.BackColor = ColorB[132];
            Label134.BackColor = ColorB[133];
            Label135.BackColor = ColorB[134];
            Label136.BackColor = ColorB[135];
            Label137.BackColor = ColorB[136];
            Label138.BackColor = ColorB[137];
            Label139.BackColor = ColorB[138];
            Label140.BackColor = ColorB[139];
            Label141.BackColor = ColorB[140];
            Label142.BackColor = ColorB[141];
            Label143.BackColor = ColorB[142];
            Label144.BackColor = ColorB[143];
            Label145.BackColor = ColorB[144];
            Label146.BackColor = ColorB[145];
            Label147.BackColor = ColorB[146];
            Label148.BackColor = ColorB[147];
            Label149.BackColor = ColorB[148];
            Label150.BackColor = ColorB[149];
            Label151.BackColor = ColorB[150];
            Label152.BackColor = ColorB[151];
            Label153.BackColor = ColorB[152];
            Label154.BackColor = ColorB[153];
            Label155.BackColor = ColorB[154];
            Label156.BackColor = ColorB[155];
            Label157.BackColor = ColorB[156];
            Label158.BackColor = ColorB[157];
            Label159.BackColor = ColorB[158];
            Label160.BackColor = ColorB[159];
            Label161.BackColor = ColorB[160];
            Label162.BackColor = ColorB[161];
            Label163.BackColor = ColorB[162];
            Label164.BackColor = ColorB[163];
            Label165.BackColor = ColorB[164];
            Label166.BackColor = ColorB[165];
            Label167.BackColor = ColorB[166];
            Label168.BackColor = ColorB[167];
            Label169.BackColor = ColorB[168];
            Label170.BackColor = ColorB[169];
            Label171.BackColor = ColorB[170];
            Label172.BackColor = ColorB[171];
            Label173.BackColor = ColorB[172];
            Label174.BackColor = ColorB[173];
            Label175.BackColor = ColorB[174];
            Label176.BackColor = ColorB[175];
            Label177.BackColor = ColorB[176];
            Label178.BackColor = ColorB[177];
            Label179.BackColor = ColorB[178];
            Label180.BackColor = ColorB[179];
            Label181.BackColor = ColorB[180];
            Label182.BackColor = ColorB[181];
            Label183.BackColor = ColorB[182];
            Label184.BackColor = ColorB[183];
            Label185.BackColor = ColorB[184];
            Label186.BackColor = ColorB[185];
            Label187.BackColor = ColorB[186];
            Label188.BackColor = ColorB[187];
            Label189.BackColor = ColorB[188];
            Label190.BackColor = ColorB[189];
            Label191.BackColor = ColorB[190];
            Label192.BackColor = ColorB[191];
            Label193.BackColor = ColorB[192];
            Label194.BackColor = ColorB[193];
            Label195.BackColor = ColorB[194];
            Label196.BackColor = ColorB[195];
            Label197.BackColor = ColorB[196];
            Label198.BackColor = ColorB[197];
            Label199.BackColor = ColorB[198];
            Label200.BackColor = ColorB[199];
            Label201.BackColor = ColorB[200];
            Label202.BackColor = ColorB[201];
            Label203.BackColor = ColorB[202];
            Label204.BackColor = ColorB[203];
            Label205.BackColor = ColorB[204];
            Label206.BackColor = ColorB[205];
            Label207.BackColor = ColorB[206];
            Label208.BackColor = ColorB[207];
            Label209.BackColor = ColorB[208];
            Label210.BackColor = ColorB[209];
            Label211.BackColor = ColorB[210];
            Label212.BackColor = ColorB[211];
            Label213.BackColor = ColorB[212];
            Label214.BackColor = ColorB[213];
            Label215.BackColor = ColorB[214];
            Label216.BackColor = ColorB[215];

        }



        private void ComOpen_Click_1(object sender, EventArgs e)
        {
            try
            {
                ComprogressChaber.Value = 1;
                ComProgresHomeChamber.Value = 1;
                SerialPort1.PortName = cBoxCOMPort.Text;
                SerialPort1.BaudRate = Convert.ToInt32(CBoxBaundRate.Text);
                SerialPort1.DataBits = Convert.ToInt32(CBoxDataBits.Text);
                SerialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                SerialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParity.Text);
                SerialPort1.Open();
                ComprogressChaber.Value = 100;
                ComProgresHomeChamber.Value = 100;
                button14.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComSend_Click_1(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                dataOUT = richTextBoxRX.Text;
                SerialPort1.WriteLine(dataOUT);
            }
        }

        private void ComClose_Click_1(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                ComprogressChaber.Value = 99;
                SerialPort1.Close();
                ComprogressChaber.Value = 0;
                ComProgresHomeChamber.Value = 0;
            }
        }


        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                ComProgresTester.Value = 1;
                serialPort3.PortName = comboBox5.Text;
                serialPort3.BaudRate = Convert.ToInt32(comboBox4.Text);
                serialPort3.DataBits = Convert.ToInt32(comboBox3.Text);
                serialPort3.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox1.Text);
                serialPort3.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox2.Text);
                serialPort3.Open();
                ComProgresTester.Value = 100;
                ComProgressHomeTester.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (serialPort3.IsOpen)
            {
                dataOUT = richTextBox5.Text;
                serialPort3.WriteLine(dataOUT);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (serialPort3.IsOpen)
            {
                serialPort3.Close();
                ComProgresTester.Value = 0;
                ComProgressHomeTester.Value = 0;
            }
        }

        private void serialPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN_Tester = serialPort3.ReadExisting();
            this.Invoke(new EventHandler(ShowData3));
        }
        private void ShowData3(object sender, EventArgs e)
        {
            richTextBox4.Text += dataIN_Tester;
        }




        private void button14_Click(object sender, EventArgs e)
        {
            if (TempProfilx.Length < 1)
                MessageBox.Show("Recepie not loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    if (SerialPort1.IsOpen)
                    {
                        progressBar1.Value = 1;
                        int status;
                        for (int i = 0; i < TempProfilx.Length; i++)
                        {
                            if (i == 0)
                            {
                                SerialPort1.WriteLine("Start sending termoprofile\n");
                            }
                            string dataOUT = "Point " + Convert.ToString(i + 1) + " Tempreture: " + TempProfily[i] + " Time, min: " + TempProfilx[i] + " \n";
                            SerialPort1.WriteLine(dataOUT);
                            status = (i / TempProfilx.Length) * 100;
                            progressBar1.Value = status;
                        }
                        int check = 0, a = 0;
                        richTextBox8.Text = String.Empty;
                        while (check < 2)
                        {
                            if (a == 0)
                                SerialPort1.WriteLine("End of termoprofile");
                            dataIN_Chamber = SerialPort1.ReadExisting();
                            richTextBox8.Text += dataIN_Chamber;
                            if (richTextBox8.Text == "Done\n")
                            {
                                check = 2;
                                MessageBox.Show("Thermoprofile was loaded successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ChamberStatus = "Ready";
                            }
                            a++;
                            if (a > 1000000)
                            {
                                MessageBox.Show("Waiting time for reply is overestimated. Check the connection to the chamber", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                        progressBar1.Value = 100;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressBar1.Value = 1;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void blockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _startprocess = new Thread(new ThreadStart(TestProcess));
            _startprocess.Start();
            button24.Enabled = false;
            Button1.Enabled = false;
            button2.Enabled = true;
            StartButton.Enabled = true;
        }
        private ManualResetEvent _eventStop = new ManualResetEvent(false);

        public delegate void updateInfo();
        public delegate void sendInfo();

        public void ShowInfo()
        {
            RichTextBox2.Text = "Waiting for the chamber to be ready";
        }
        public void ShowInfo2()
        {
            RichTextBox2.Text = "Process started, Power ON";
        }
        public void ShowInfo3()
        {
            RichTextBox2.Text = "Process started, Power OFF";
        }
        public void Saveword()
        {
            richTextBox9.Text += dataIN_Chamber;
        }
        public void empty()
        {
            rtboxReceive.Text = String.Empty;
        }
        public void _tbxID()
        {
            tbxID.Text = data;
        }
        public void _richboxcontrol()
        {
            RichTextBox1.Text += data;
            button10.PerformClick();
            button11.PerformClick();
        }
        public void _richboxcontrolempty()
        {
            RichTextBox1.Text += String.Empty;
        }


        private void TestProcess()
        {

            if (serialPort2.IsOpen & serialPort3.IsOpen & SerialPort1.IsOpen)
            {
                MessageBox.Show("Please make sure that the thermo-profile is displayed correctly on the PLC of chember screen for tests. Close the camera doors and press START on the PLC screen. Once the chember has reached the required temperature, the test will start automatically!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int a = 0, check = 0;
                RichTextBox2.Invoke(new updateInfo(ShowInfo));
                    while (check < 2 & !_eventStop.WaitOne(1,false))
                {
                    if (a == 0)
                        SerialPort1.WriteLine("Requested to start the process");
                    dataIN_Chamber = SerialPort1.ReadExisting();
                    richTextBox9.Invoke(new updateInfo(Saveword));
                    if (dataIN_Chamber == "Start\n")
                    {
                        check = 5;
                        for (int i = 0; i < Devinitx.Length; i++)
                        {
                            if (Devinity[i] == 1)
                            {
                                serialPort3.WriteLine("Power ON");
                                RichTextBox2.Invoke(new updateInfo(ShowInfo2));
                                Thread.Sleep(10000);
                                date = DateTime.Now;
                                Stopwatch stopWatch = new Stopwatch();
                                stopWatch.Start();
                                for (int x = 0; x < 216; x++)
                                {

                                    buffLen = receiveBuffer.Length;
                                    buffPos = -1;
                                    int c = ' ';
                                    rtboxReceive.Invoke(new updateInfo(empty));
                                    if (x < 16)
                                    {
                                        hexValue = x.ToString("X");
                                        data = "10" + hexValue;
                                    }
                                    else
                                    {
                                        hexValue = x.ToString("X");
                                        data = "1" + hexValue;
                                    }
                                    string canFrameData = "";

                                    if (cboxRtr.Checked == true)        // RTR Frame
                                    {
                                        if (cboxExt.Checked == true)    // 29bit Frame
                                        {
                                            canFrameData += "R";
                                        }
                                        else                            // 11bit frame
                                        {
                                            canFrameData += "r";
                                        }
                                        canFrameData += data + numDlc.Value.ToString();
                                    }
                                    else                                // Normal Frame
                                    {
                                        if (cboxExt.Checked == true)    // 29bit Frame
                                        {
                                            canFrameData += "T";
                                        }
                                        else                            // 11bit frame
                                        {
                                            canFrameData += "t";
                                        }
                                        canFrameData += data + numDlc.Value.ToString();
                                        if (numDlc.Value >= 1)
                                        {
                                            canFrameData += tbxHex1.Text;
                                        }
                                        if (numDlc.Value >= 2)
                                        {
                                            canFrameData += tbxHex2.Text;
                                        }
                                        if (numDlc.Value >= 3)
                                        {
                                            canFrameData += tbxHex3.Text;
                                        }
                                        if (numDlc.Value >= 4)
                                        {
                                            canFrameData += tbxHex4.Text;
                                        }
                                        if (numDlc.Value >= 5)
                                        {
                                            canFrameData += tbxHex5.Text;
                                        }
                                        if (numDlc.Value >= 6)
                                        {
                                            canFrameData += tbxHex6.Text;
                                        }
                                        if (numDlc.Value >= 7)
                                        {
                                            canFrameData += tbxHex7.Text;
                                        }
                                        if (numDlc.Value >= 8)
                                        {
                                            canFrameData += tbxHex8.Text;
                                        }
                                    }
                                    if (serialPort2.IsOpen)
                                    {
                                        serialPort2.Write(canFrameData);
                                        serialPort2.Write("\r");
                                    }
                                    receiveBuffer = serialPort2.ReadExisting();
                                    rtboxReceive.Invoke(new updateInfo(_reciveBoxUpdate));
                                    Thread.Sleep(1);
                                    if (tempdata == "")
                                        NestStatus[x] = "STTS3";
                                    else
                                        NestStatus[x] = "STTS5";
                                    data = "Nest" + (x + 1) + " SN: " + tempdata + " :" + NestStatus[x] + "\r\n";
                                    RichTextBox1.Invoke(new updateInfo(_richboxcontrol));
                                    Thread.Sleep(1);
                                }
                                stopWatch.Stop();
                                int n = 50000;
                                n = n - Convert.ToInt32(stopWatch.Elapsed.TotalMilliseconds);
                                Thread.Sleep(n);
                                rtboxReceive.Invoke(new updateInfo(_richboxcontrolempty));
                            }
                            if (Devinity[i] == 0)
                            {
                                serialPort3.WriteLine("Power OFF");
                                RichTextBox2.Invoke(new updateInfo(ShowInfo3));
                                Thread.Sleep(60000);
                            }
                            if (Devinity[i + 1] == 0)
                                serialPort3.WriteLine("Power OFF");

                        }
                    }
                    a++;
                    if (a > 100000000)
                    {
                        MessageBox.Show("Waiting time for start is overestimated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
            else
                MessageBox.Show("Please check the connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _reciveBoxUpdate()
        {
            buffPos = receiveBuffer.IndexOf("\r");
            if ((buffPos = receiveBuffer.IndexOf("\r")) >= 0)
            {
                rtboxReceive.AppendText(receiveBuffer.Substring(0, buffPos));
                rtboxReceive.AppendText("[CR]");
                rtboxReceive.AppendText(receiveBuffer.Substring(buffPos, (buffLen - buffPos)));
            }
            tempdata = rtboxReceive.Text;
            data = "";
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("S");
                serialPort2.Write(cmbCanBitrate.SelectedIndex.ToString());
                serialPort2.Write("\r");
            }
        }

        private void btnCanOpen_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("O\r");
            }
        }

        private void btnCanClose_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("C\r");
            }
        }

        private void btnCanVersion_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("V\r");
            }
        }

        private void btnCanFlags_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("F\r");
            }
        }

        private void btnPollOne_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("P\r");
            }
        }

        private void btnPollAll_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("A\r");
            }
        }

        private void btnTimeStampOn_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("Z1\r");
            }
        }

        private void btnAutoOn_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("X1\r");
            }
        }

        private void btnAutoOff_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Write("X0\r");
            }
        }

        private void btnSendFrame_Click(object sender, EventArgs e)
        {
            string canFrameData = "";

            if (cboxRtr.Checked == true)        // RTR Frame
            {
                if (cboxExt.Checked == true)    // 29bit Frame
                {
                    canFrameData += "R";
                }
                else                            // 11bit frame
                {
                    canFrameData += "r";
                }
                canFrameData += tbxID.Text + numDlc.Value.ToString();
            }
            else                                // Normal Frame
            {
                if (cboxExt.Checked == true)    // 29bit Frame
                {
                    canFrameData += "T";
                }
                else                            // 11bit frame
                {
                    canFrameData += "t";
                }
                canFrameData += tbxID.Text + numDlc.Value.ToString();
                if (numDlc.Value >= 1)
                {
                    canFrameData += tbxHex1.Text;
                }
                if (numDlc.Value >= 2)
                {
                    canFrameData += tbxHex2.Text;
                }
                if (numDlc.Value >= 3)
                {
                    canFrameData += tbxHex3.Text;
                }
                if (numDlc.Value >= 4)
                {
                    canFrameData += tbxHex4.Text;
                }
                if (numDlc.Value >= 5)
                {
                    canFrameData += tbxHex5.Text;
                }
                if (numDlc.Value >= 6)
                {
                    canFrameData += tbxHex6.Text;
                }
                if (numDlc.Value >= 7)
                {
                    canFrameData += tbxHex7.Text;
                }
                if (numDlc.Value >= 8)
                {
                    canFrameData += tbxHex8.Text;
                }
            }
            if (serialPort2.IsOpen)
            {
                serialPort2.Write(canFrameData);
                serialPort2.Write("\r");
            }
            lblResult.Text = "Resulting command: " + canFrameData + "[CR]";
        }

        private void cboxRtr_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxRtr.Checked == true)
            {
                tbxHex1.Visible = false;
                tbxHex2.Visible = false;
                tbxHex3.Visible = false;
                tbxHex4.Visible = false;
                tbxHex5.Visible = false;
                tbxHex6.Visible = false;
                tbxHex7.Visible = false;
                tbxHex8.Visible = false;
            }
            else
            {
                UpdateDataBoxes();
            }
        }
        private void UpdateDataBoxes()
        {
            if (numDlc.Value < 8)
            {
                tbxHex8.Visible = false;
            }
            else
            {
                tbxHex8.Visible = true;
            }

            if (numDlc.Value < 7)
            {
                tbxHex7.Visible = false;
            }
            else
            {
                tbxHex7.Visible = true;
            }

            if (numDlc.Value < 6)
            {
                tbxHex6.Visible = false;
            }
            else
            {
                tbxHex6.Visible = true;
            }

            if (numDlc.Value < 5)
            {
                tbxHex5.Visible = false;
            }
            else
            {
                tbxHex5.Visible = true;
            }

            if (numDlc.Value < 4)
            {
                tbxHex4.Visible = false;
            }
            else
            {
                tbxHex4.Visible = true;
            }

            if (numDlc.Value < 3)
            {
                tbxHex3.Visible = false;
            }
            else
            {
                tbxHex3.Visible = true;
            }

            if (numDlc.Value < 2)
            {
                tbxHex2.Visible = false;
            }
            else
            {
                tbxHex2.Visible = true;
            }

            if (numDlc.Value < 1)
            {
                tbxHex1.Visible = false;
            }
            else
            {
                tbxHex1.Visible = true;
            }
        }
        private void CheckHexValue(object sender, KeyPressEventArgs e, int maxLen)
        {
            if ((sender as TextBox).TextLength < maxLen)
            {
                if (char.IsDigit(e.KeyChar) || (e.KeyChar >= 'a' && e.KeyChar <= 'f') || (e.KeyChar >= 'A' && e.KeyChar <= 'F') || (e.KeyChar == '\b'))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (e.KeyChar == '\b')  // Backspace?
                {
                    e.Handled = false;
                }
                else if ((sender as TextBox).SelectionLength > 0)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

        }

        private void btnComOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort2.IsOpen)
                {
                    ComProgresshomecard.Value = 1;
                    // Open Port
                    serialPort2.PortName = cmbComPort.SelectedItem.ToString();
                    serialPort2.BaudRate = int.Parse(cmbComSpeed.SelectedItem.ToString());
                    serialPort2.Open();

                    cmbComPort.Enabled = false;
                    cmbComSpeed.Enabled = false;
                    grpboxCanCommands.Enabled = true;
                    grpboxCanFrameTransmit.Enabled = true;
                    btnComOpen.Enabled = false;
                    btnComClose.Enabled = true;

                    // Set status
                    ComProgresshomecard.Value = 100;
                }
                else
                {
                    rtboxReceive.Text = "Failed to open COM port";
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnComClose_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Close();
                grpboxCanCommands.Enabled = false;
                grpboxCanFrameTransmit.Enabled = false;
                btnComClose.Enabled = false;
                btnComOpen.Enabled = true;
                cmbComPort.Enabled = true;
                cmbComSpeed.Enabled = true;
                ComProgresshomecard.Value = 0;
            }
        }

        private void DisplayText(object s, EventArgs e)
        {
            int buffLen = receiveBuffer.Length;
            int buffPos = -1;
            int c = ' ';
            if (buffLen > 1)
            {
                // More than one character
                if ((buffPos = receiveBuffer.IndexOf("\r")) >= 0)
                {
                    rtboxReceive.AppendText(receiveBuffer.Substring(0, buffPos));
                    rtboxReceive.AppendText("[CR]");
                    //rtboxReceive.AppendText(receiveBuffer.Substring(buffPos, (buffLen - buffPos)));
                }
                else
                {
                    rtboxReceive.AppendText(receiveBuffer);
                }
            }
            else
            {
                // Only one character
                c = receiveBuffer[0];
                if (c == 13)
                {
                    rtboxReceive.AppendText("[CR]");
                    rtboxReceive.AppendText(receiveBuffer);
                }
                else if (c == 7)
                {
                    rtboxReceive.AppendText("[BELL]\n");
                }
            }
        }

        private void tbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboxExt.Checked == true)
            {
                CheckHexValue(sender, e, 8);
            }
            else
            {
                CheckHexValue(sender, e, 3);
            }
        }

        private void tbxHex1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex3_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex4_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex5_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex6_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex7_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxHex8_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void tbxID_Leave(object sender, EventArgs e)
        {
            if (cboxExt.Checked == true)
            {
                if (tbxID.TextLength == 0)
                {
                    tbxID.Text = "00000000";
                }
                else if (tbxID.TextLength == 1)
                {
                    tbxID.Text = "0000000" + tbxID.Text;
                }
                else if (tbxID.TextLength == 2)
                {
                    tbxID.Text = "000000" + tbxID.Text;
                }
                else if (tbxID.TextLength == 3)
                {
                    tbxID.Text = "00000" + tbxID.Text;
                }
                else if (tbxID.TextLength == 4)
                {
                    tbxID.Text = "0000" + tbxID.Text;
                }
                else if (tbxID.TextLength == 5)
                {
                    tbxID.Text = "000" + tbxID.Text;
                }
                else if (tbxID.TextLength == 6)
                {
                    tbxID.Text = "00" + tbxID.Text;
                }
                else if (tbxID.TextLength == 7)
                {
                    tbxID.Text = "0" + tbxID.Text;
                }
            }
            else
            {
                if (tbxID.TextLength == 0)
                {
                    tbxID.Text = "000";
                }
                else if (tbxID.TextLength == 1)
                {
                    tbxID.Text = "00" + tbxID.Text;
                }
                else if (tbxID.TextLength == 2)
                {
                    tbxID.Text = "0" + tbxID.Text;
                }
            }
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex1_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex2_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex3_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex4_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex5_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex6_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex7_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void tbxHex8_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void numDlc_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataBoxes();
        }

        private void cboxExt_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxExt.Checked == true)
            {
                tbxID.Text = "00000" + tbxID.Text;
            }
            else
            {
                tbxID.Text = tbxID.Text.Substring(tbxID.Text.Length - 3);
            }
        }

        private void serialPort2_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                receiveBuffer = serialPort2.ReadExisting();
                this.Invoke(new EventHandler(DisplayText));
            }
            catch (System.TimeoutException)
            {
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

                dataIN_Tester = SerialPort1.ReadExisting();
                this.Invoke(new EventHandler(ShowData));

        }
        private void ShowData(object sender, EventArgs e)
        {
            richTextBoxTX.Text += dataIN_Tester;
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _eventStop.Set();
            button24.Enabled = true;
            Button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
