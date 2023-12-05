using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace BurnInPitStop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private double f(double x)
        {
            if (x==0)
            {
                return 1;
            }
            return Math.Sin(x) / x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TempProfilString;
            string Devinit;
            int [] TempProfilx = new int[1];
            int [] TempProfily = new int[1];
            int [] Devinitx = new int[1];
            int [] Devinity = new int[1];
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
                if(openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
                fileContent=fileContent.Replace("\r", "!");
                fileContent=fileContent.Replace("\n", "");
                fileContent = fileContent.Replace("\t", ":");
                TempProfilString = fileContent.Split('>')[0];
                Devinit = fileContent.Split('>')[1];
                TempProfilString = TempProfilString.Split('<')[1];
                Devinit = Devinit.Split('<')[1];
                int a = 0, b = 0;
                int i = 1;
                while (i==1)
                {
                    int pos = TempProfilString.LastIndexOf(':');
                    TempProfily[b] = int.Parse(TempProfilString.Substring(pos+1));
                    TempProfilString = TempProfilString.Substring(0, pos);
                    b++;
                    if (TempProfilString == "0")
                        break;
                    Array.Resize(ref TempProfily, b+1);
                    pos = TempProfilString.LastIndexOf("!");
                    TempProfilx[a] = int.Parse(TempProfilString.Substring(pos+1));
                    TempProfilString = TempProfilString.Substring(0, pos);
                    a++;
                    Array.Resize(ref TempProfilx, a+1);
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

            for(int i = 0; i<=TempProfilx.Length-1;i++)
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
