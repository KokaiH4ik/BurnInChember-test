using System.Xml.Serialization;

namespace BurnInPitStop
{
    partial class Form1
    {
        public delegate void AddListItem();
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public void MyformControl()
        {
            
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label233 = new System.Windows.Forms.Label();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ComBoxCart = new System.Windows.Forms.GroupBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.grpboxComPort = new System.Windows.Forms.GroupBox();
            this.btnComClose = new System.Windows.Forms.Button();
            this.btnComOpen = new System.Windows.Forms.Button();
            this.lblComSpeed = new System.Windows.Forms.Label();
            this.lblComPort = new System.Windows.Forms.Label();
            this.cmbComSpeed = new System.Windows.Forms.ComboBox();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.grpboxCanFrameTransmit = new System.Windows.Forms.GroupBox();
            this.lblDataBytes = new System.Windows.Forms.Label();
            this.lblDlc = new System.Windows.Forms.Label();
            this.lblCanId = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.btnSendFrame = new System.Windows.Forms.Button();
            this.tbxHex1 = new System.Windows.Forms.TextBox();
            this.cboxRtr = new System.Windows.Forms.CheckBox();
            this.tbxHex2 = new System.Windows.Forms.TextBox();
            this.cboxExt = new System.Windows.Forms.CheckBox();
            this.numDlc = new System.Windows.Forms.NumericUpDown();
            this.tbxHex3 = new System.Windows.Forms.TextBox();
            this.tbxHex8 = new System.Windows.Forms.TextBox();
            this.tbxHex4 = new System.Windows.Forms.TextBox();
            this.tbxHex7 = new System.Windows.Forms.TextBox();
            this.tbxHex5 = new System.Windows.Forms.TextBox();
            this.tbxHex6 = new System.Windows.Forms.TextBox();
            this.grpboxCanCommands = new System.Windows.Forms.GroupBox();
            this.btnAutoOff = new System.Windows.Forms.Button();
            this.btnAutoOn = new System.Windows.Forms.Button();
            this.btnTimeStampOff = new System.Windows.Forms.Button();
            this.btnTimeStampOn = new System.Windows.Forms.Button();
            this.btnPollAll = new System.Windows.Forms.Button();
            this.btnPollOne = new System.Windows.Forms.Button();
            this.btnSerNo = new System.Windows.Forms.Button();
            this.btnCanVersion = new System.Windows.Forms.Button();
            this.btnCanFlags = new System.Windows.Forms.Button();
            this.btnCanClose = new System.Windows.Forms.Button();
            this.btnCanOpen = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.label254 = new System.Windows.Forms.Label();
            this.cmbCanBitrate = new System.Windows.Forms.ComboBox();
            this.grpboxCanFrameReceive = new System.Windows.Forms.GroupBox();
            this.rtboxReceive = new System.Windows.Forms.RichTextBox();
            this.ComBoxTester = new System.Windows.Forms.GroupBox();
            this.ComProgresTester = new System.Windows.Forms.ProgressBar();
            this.button7 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.label235 = new System.Windows.Forms.Label();
            this.label236 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button18 = new System.Windows.Forms.Button();
            this.label237 = new System.Windows.Forms.Label();
            this.label238 = new System.Windows.Forms.Label();
            this.label239 = new System.Windows.Forms.Label();
            this.label240 = new System.Windows.Forms.Label();
            this.label241 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label253 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.ComBoxChamber = new System.Windows.Forms.GroupBox();
            this.ComprogressChaber = new System.Windows.Forms.ProgressBar();
            this.ComSend = new System.Windows.Forms.Button();
            this.ComClose = new System.Windows.Forms.Button();
            this.ComOpen = new System.Windows.Forms.Button();
            this.label231 = new System.Windows.Forms.Label();
            this.label230 = new System.Windows.Forms.Label();
            this.richTextBoxTX = new System.Windows.Forms.RichTextBox();
            this.richTextBoxRX = new System.Windows.Forms.RichTextBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxParity = new System.Windows.Forms.ComboBox();
            this.CBoxDataBits = new System.Windows.Forms.ComboBox();
            this.CBoxBaundRate = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.ComOk = new System.Windows.Forms.Button();
            this.Label229 = new System.Windows.Forms.Label();
            this.Label228 = new System.Windows.Forms.Label();
            this.Label227 = new System.Windows.Forms.Label();
            this.Label226 = new System.Windows.Forms.Label();
            this.Label225 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button14 = new System.Windows.Forms.Button();
            this.label232 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label252 = new System.Windows.Forms.Label();
            this.label251 = new System.Windows.Forms.Label();
            this.label250 = new System.Windows.Forms.Label();
            this.ComProgresshomecard = new System.Windows.Forms.ProgressBar();
            this.ComProgressHomeTester = new System.Windows.Forms.ProgressBar();
            this.ComProgresHomeChamber = new System.Windows.Forms.ProgressBar();
            this.label249 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label216 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.blockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unblockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label215 = new System.Windows.Forms.Label();
            this.Label214 = new System.Windows.Forms.Label();
            this.Label213 = new System.Windows.Forms.Label();
            this.Label212 = new System.Windows.Forms.Label();
            this.Label211 = new System.Windows.Forms.Label();
            this.Label210 = new System.Windows.Forms.Label();
            this.Label209 = new System.Windows.Forms.Label();
            this.Label208 = new System.Windows.Forms.Label();
            this.Label207 = new System.Windows.Forms.Label();
            this.Label206 = new System.Windows.Forms.Label();
            this.Label205 = new System.Windows.Forms.Label();
            this.Label204 = new System.Windows.Forms.Label();
            this.Label203 = new System.Windows.Forms.Label();
            this.Label202 = new System.Windows.Forms.Label();
            this.Label201 = new System.Windows.Forms.Label();
            this.Label200 = new System.Windows.Forms.Label();
            this.Label199 = new System.Windows.Forms.Label();
            this.Label198 = new System.Windows.Forms.Label();
            this.Label197 = new System.Windows.Forms.Label();
            this.Label196 = new System.Windows.Forms.Label();
            this.Label195 = new System.Windows.Forms.Label();
            this.Label194 = new System.Windows.Forms.Label();
            this.Label193 = new System.Windows.Forms.Label();
            this.Label192 = new System.Windows.Forms.Label();
            this.Label191 = new System.Windows.Forms.Label();
            this.Label190 = new System.Windows.Forms.Label();
            this.Label189 = new System.Windows.Forms.Label();
            this.Label188 = new System.Windows.Forms.Label();
            this.Label187 = new System.Windows.Forms.Label();
            this.Label186 = new System.Windows.Forms.Label();
            this.Label185 = new System.Windows.Forms.Label();
            this.Label184 = new System.Windows.Forms.Label();
            this.Label183 = new System.Windows.Forms.Label();
            this.Label182 = new System.Windows.Forms.Label();
            this.Label181 = new System.Windows.Forms.Label();
            this.Label180 = new System.Windows.Forms.Label();
            this.Label179 = new System.Windows.Forms.Label();
            this.Label178 = new System.Windows.Forms.Label();
            this.Label177 = new System.Windows.Forms.Label();
            this.Label176 = new System.Windows.Forms.Label();
            this.Label175 = new System.Windows.Forms.Label();
            this.Label174 = new System.Windows.Forms.Label();
            this.Label173 = new System.Windows.Forms.Label();
            this.Label172 = new System.Windows.Forms.Label();
            this.Label171 = new System.Windows.Forms.Label();
            this.Label170 = new System.Windows.Forms.Label();
            this.Label169 = new System.Windows.Forms.Label();
            this.Label168 = new System.Windows.Forms.Label();
            this.Label167 = new System.Windows.Forms.Label();
            this.Label166 = new System.Windows.Forms.Label();
            this.Label165 = new System.Windows.Forms.Label();
            this.Label164 = new System.Windows.Forms.Label();
            this.Label163 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label54 = new System.Windows.Forms.Label();
            this.Label53 = new System.Windows.Forms.Label();
            this.Label52 = new System.Windows.Forms.Label();
            this.Label51 = new System.Windows.Forms.Label();
            this.Label50 = new System.Windows.Forms.Label();
            this.Label49 = new System.Windows.Forms.Label();
            this.Label48 = new System.Windows.Forms.Label();
            this.Label47 = new System.Windows.Forms.Label();
            this.Label46 = new System.Windows.Forms.Label();
            this.Label45 = new System.Windows.Forms.Label();
            this.Label44 = new System.Windows.Forms.Label();
            this.Label43 = new System.Windows.Forms.Label();
            this.Label42 = new System.Windows.Forms.Label();
            this.Label41 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label39 = new System.Windows.Forms.Label();
            this.Label38 = new System.Windows.Forms.Label();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label217 = new System.Windows.Forms.Label();
            this.RichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Label218 = new System.Windows.Forms.Label();
            this.Label224 = new System.Windows.Forms.Label();
            this.Label223 = new System.Windows.Forms.Label();
            this.Label219 = new System.Windows.Forms.Label();
            this.Label221 = new System.Windows.Forms.Label();
            this.Label220 = new System.Windows.Forms.Label();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Label222 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label162 = new System.Windows.Forms.Label();
            this.Label161 = new System.Windows.Forms.Label();
            this.Label160 = new System.Windows.Forms.Label();
            this.Label159 = new System.Windows.Forms.Label();
            this.Label158 = new System.Windows.Forms.Label();
            this.Label157 = new System.Windows.Forms.Label();
            this.Label156 = new System.Windows.Forms.Label();
            this.Label155 = new System.Windows.Forms.Label();
            this.Label154 = new System.Windows.Forms.Label();
            this.Label153 = new System.Windows.Forms.Label();
            this.Label152 = new System.Windows.Forms.Label();
            this.Label151 = new System.Windows.Forms.Label();
            this.Label150 = new System.Windows.Forms.Label();
            this.Label149 = new System.Windows.Forms.Label();
            this.Label148 = new System.Windows.Forms.Label();
            this.Label147 = new System.Windows.Forms.Label();
            this.Label146 = new System.Windows.Forms.Label();
            this.Label145 = new System.Windows.Forms.Label();
            this.Label144 = new System.Windows.Forms.Label();
            this.Label143 = new System.Windows.Forms.Label();
            this.Label142 = new System.Windows.Forms.Label();
            this.Label141 = new System.Windows.Forms.Label();
            this.Label140 = new System.Windows.Forms.Label();
            this.Label139 = new System.Windows.Forms.Label();
            this.Label138 = new System.Windows.Forms.Label();
            this.Label137 = new System.Windows.Forms.Label();
            this.Label136 = new System.Windows.Forms.Label();
            this.Label135 = new System.Windows.Forms.Label();
            this.Label134 = new System.Windows.Forms.Label();
            this.Label133 = new System.Windows.Forms.Label();
            this.Label132 = new System.Windows.Forms.Label();
            this.Label131 = new System.Windows.Forms.Label();
            this.Label130 = new System.Windows.Forms.Label();
            this.Label129 = new System.Windows.Forms.Label();
            this.Label128 = new System.Windows.Forms.Label();
            this.Label127 = new System.Windows.Forms.Label();
            this.Label126 = new System.Windows.Forms.Label();
            this.Label125 = new System.Windows.Forms.Label();
            this.Label124 = new System.Windows.Forms.Label();
            this.Label123 = new System.Windows.Forms.Label();
            this.Label122 = new System.Windows.Forms.Label();
            this.Label121 = new System.Windows.Forms.Label();
            this.Label120 = new System.Windows.Forms.Label();
            this.Label119 = new System.Windows.Forms.Label();
            this.Label118 = new System.Windows.Forms.Label();
            this.Label117 = new System.Windows.Forms.Label();
            this.Label116 = new System.Windows.Forms.Label();
            this.Label115 = new System.Windows.Forms.Label();
            this.Label114 = new System.Windows.Forms.Label();
            this.Label113 = new System.Windows.Forms.Label();
            this.Label112 = new System.Windows.Forms.Label();
            this.Label111 = new System.Windows.Forms.Label();
            this.Label110 = new System.Windows.Forms.Label();
            this.Label109 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label108 = new System.Windows.Forms.Label();
            this.Label107 = new System.Windows.Forms.Label();
            this.Label106 = new System.Windows.Forms.Label();
            this.Label105 = new System.Windows.Forms.Label();
            this.Label104 = new System.Windows.Forms.Label();
            this.Label103 = new System.Windows.Forms.Label();
            this.Label102 = new System.Windows.Forms.Label();
            this.Label101 = new System.Windows.Forms.Label();
            this.Label100 = new System.Windows.Forms.Label();
            this.Label99 = new System.Windows.Forms.Label();
            this.Label98 = new System.Windows.Forms.Label();
            this.Label97 = new System.Windows.Forms.Label();
            this.Label96 = new System.Windows.Forms.Label();
            this.Label95 = new System.Windows.Forms.Label();
            this.Label94 = new System.Windows.Forms.Label();
            this.Label93 = new System.Windows.Forms.Label();
            this.Label92 = new System.Windows.Forms.Label();
            this.Label91 = new System.Windows.Forms.Label();
            this.Label90 = new System.Windows.Forms.Label();
            this.Label89 = new System.Windows.Forms.Label();
            this.Label88 = new System.Windows.Forms.Label();
            this.Label87 = new System.Windows.Forms.Label();
            this.Label86 = new System.Windows.Forms.Label();
            this.Label85 = new System.Windows.Forms.Label();
            this.Label84 = new System.Windows.Forms.Label();
            this.Label83 = new System.Windows.Forms.Label();
            this.Label82 = new System.Windows.Forms.Label();
            this.Label81 = new System.Windows.Forms.Label();
            this.Label80 = new System.Windows.Forms.Label();
            this.Label79 = new System.Windows.Forms.Label();
            this.Label78 = new System.Windows.Forms.Label();
            this.Label77 = new System.Windows.Forms.Label();
            this.Label76 = new System.Windows.Forms.Label();
            this.Label75 = new System.Windows.Forms.Label();
            this.Label74 = new System.Windows.Forms.Label();
            this.Label73 = new System.Windows.Forms.Label();
            this.Label72 = new System.Windows.Forms.Label();
            this.Label71 = new System.Windows.Forms.Label();
            this.Label70 = new System.Windows.Forms.Label();
            this.Label69 = new System.Windows.Forms.Label();
            this.Label68 = new System.Windows.Forms.Label();
            this.Label67 = new System.Windows.Forms.Label();
            this.Label66 = new System.Windows.Forms.Label();
            this.Label65 = new System.Windows.Forms.Label();
            this.Label64 = new System.Windows.Forms.Label();
            this.Label63 = new System.Windows.Forms.Label();
            this.Label62 = new System.Windows.Forms.Label();
            this.Label61 = new System.Windows.Forms.Label();
            this.Label60 = new System.Windows.Forms.Label();
            this.Label59 = new System.Windows.Forms.Label();
            this.Label58 = new System.Windows.Forms.Label();
            this.Label57 = new System.Windows.Forms.Label();
            this.Label56 = new System.Windows.Forms.Label();
            this.Label55 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.button12 = new System.Windows.Forms.Button();
            this.label234 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.ComBoxCart.SuspendLayout();
            this.grpboxComPort.SuspendLayout();
            this.grpboxCanFrameTransmit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDlc)).BeginInit();
            this.grpboxCanCommands.SuspendLayout();
            this.grpboxCanFrameReceive.SuspendLayout();
            this.ComBoxTester.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.ComBoxChamber.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialPort1
            // 
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1360, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 47);
            this.button3.TabIndex = 263;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button13.Dock = System.Windows.Forms.DockStyle.Right;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(1241, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(119, 47);
            this.button13.TabIndex = 264;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label233);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 47);
            this.panel1.TabIndex = 265;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label233
            // 
            this.label233.AutoSize = true;
            this.label233.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label233.ForeColor = System.Drawing.Color.Snow;
            this.label233.Location = new System.Drawing.Point(3, 2);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(412, 45);
            this.label233.TabIndex = 265;
            this.label233.Text = "BURN IN CHAMBER TEST";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.statusStrip1);
            this.metroTabPage3.Controls.Add(this.ComBoxCart);
            this.metroTabPage3.Controls.Add(this.ComBoxTester);
            this.metroTabPage3.Controls.Add(this.groupBox5);
            this.metroTabPage3.Controls.Add(this.ComBoxChamber);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1471, 733);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Configuration";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1471, 22);
            this.statusStrip1.TabIndex = 284;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ComBoxCart
            // 
            this.ComBoxCart.Controls.Add(this.statusStrip2);
            this.ComBoxCart.Controls.Add(this.grpboxComPort);
            this.ComBoxCart.Controls.Add(this.grpboxCanFrameTransmit);
            this.ComBoxCart.Controls.Add(this.grpboxCanCommands);
            this.ComBoxCart.Controls.Add(this.grpboxCanFrameReceive);
            this.ComBoxCart.Location = new System.Drawing.Point(220, 19);
            this.ComBoxCart.Name = "ComBoxCart";
            this.ComBoxCart.Size = new System.Drawing.Size(650, 465);
            this.ComBoxCart.TabIndex = 283;
            this.ComBoxCart.TabStop = false;
            this.ComBoxCart.Text = " COM Port Settings CART";
            this.ComBoxCart.Visible = false;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(3, 440);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(644, 22);
            this.statusStrip2.TabIndex = 29;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // grpboxComPort
            // 
            this.grpboxComPort.Controls.Add(this.btnComClose);
            this.grpboxComPort.Controls.Add(this.btnComOpen);
            this.grpboxComPort.Controls.Add(this.lblComSpeed);
            this.grpboxComPort.Controls.Add(this.lblComPort);
            this.grpboxComPort.Controls.Add(this.cmbComSpeed);
            this.grpboxComPort.Controls.Add(this.cmbComPort);
            this.grpboxComPort.Location = new System.Drawing.Point(16, 29);
            this.grpboxComPort.Name = "grpboxComPort";
            this.grpboxComPort.Size = new System.Drawing.Size(197, 102);
            this.grpboxComPort.TabIndex = 28;
            this.grpboxComPort.TabStop = false;
            this.grpboxComPort.Text = "COM Port Settings";
            // 
            // btnComClose
            // 
            this.btnComClose.Enabled = false;
            this.btnComClose.Location = new System.Drawing.Point(108, 64);
            this.btnComClose.Name = "btnComClose";
            this.btnComClose.Size = new System.Drawing.Size(75, 23);
            this.btnComClose.TabIndex = 18;
            this.btnComClose.Text = "Close";
            this.btnComClose.UseVisualStyleBackColor = true;
            this.btnComClose.Click += new System.EventHandler(this.btnComClose_Click);
            // 
            // btnComOpen
            // 
            this.btnComOpen.Location = new System.Drawing.Point(6, 64);
            this.btnComOpen.Name = "btnComOpen";
            this.btnComOpen.Size = new System.Drawing.Size(75, 23);
            this.btnComOpen.TabIndex = 17;
            this.btnComOpen.Text = "Open";
            this.btnComOpen.UseVisualStyleBackColor = true;
            this.btnComOpen.Click += new System.EventHandler(this.btnComOpen_Click);
            // 
            // lblComSpeed
            // 
            this.lblComSpeed.AutoSize = true;
            this.lblComSpeed.Location = new System.Drawing.Point(120, 21);
            this.lblComSpeed.Name = "lblComSpeed";
            this.lblComSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblComSpeed.TabIndex = 16;
            this.lblComSpeed.Text = "Speed";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(26, 21);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(26, 13);
            this.lblComPort.TabIndex = 15;
            this.lblComPort.Text = "Port";
            // 
            // cmbComSpeed
            // 
            this.cmbComSpeed.FormattingEnabled = true;
            this.cmbComSpeed.Items.AddRange(new object[] {
            "2400",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbComSpeed.Location = new System.Drawing.Point(92, 37);
            this.cmbComSpeed.Name = "cmbComSpeed";
            this.cmbComSpeed.Size = new System.Drawing.Size(99, 21);
            this.cmbComSpeed.TabIndex = 14;
            // 
            // cmbComPort
            // 
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(6, 37);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(75, 21);
            this.cmbComPort.TabIndex = 0;
            // 
            // grpboxCanFrameTransmit
            // 
            this.grpboxCanFrameTransmit.Controls.Add(this.lblDataBytes);
            this.grpboxCanFrameTransmit.Controls.Add(this.lblDlc);
            this.grpboxCanFrameTransmit.Controls.Add(this.lblCanId);
            this.grpboxCanFrameTransmit.Controls.Add(this.lblResult);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxID);
            this.grpboxCanFrameTransmit.Controls.Add(this.btnSendFrame);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex1);
            this.grpboxCanFrameTransmit.Controls.Add(this.cboxRtr);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex2);
            this.grpboxCanFrameTransmit.Controls.Add(this.cboxExt);
            this.grpboxCanFrameTransmit.Controls.Add(this.numDlc);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex3);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex8);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex4);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex7);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex5);
            this.grpboxCanFrameTransmit.Controls.Add(this.tbxHex6);
            this.grpboxCanFrameTransmit.Enabled = false;
            this.grpboxCanFrameTransmit.Location = new System.Drawing.Point(121, 295);
            this.grpboxCanFrameTransmit.Name = "grpboxCanFrameTransmit";
            this.grpboxCanFrameTransmit.Size = new System.Drawing.Size(350, 150);
            this.grpboxCanFrameTransmit.TabIndex = 27;
            this.grpboxCanFrameTransmit.TabStop = false;
            this.grpboxCanFrameTransmit.Text = "CAN Transmit Frame (HEX)";
            // 
            // lblDataBytes
            // 
            this.lblDataBytes.AutoSize = true;
            this.lblDataBytes.Location = new System.Drawing.Point(106, 25);
            this.lblDataBytes.Name = "lblDataBytes";
            this.lblDataBytes.Size = new System.Drawing.Size(82, 13);
            this.lblDataBytes.TabIndex = 16;
            this.lblDataBytes.Text = "Databytes (1-8):";
            // 
            // lblDlc
            // 
            this.lblDlc.AutoSize = true;
            this.lblDlc.Location = new System.Drawing.Point(69, 25);
            this.lblDlc.Name = "lblDlc";
            this.lblDlc.Size = new System.Drawing.Size(31, 13);
            this.lblDlc.TabIndex = 15;
            this.lblDlc.Text = "DLC:";
            // 
            // lblCanId
            // 
            this.lblCanId.AutoSize = true;
            this.lblCanId.Location = new System.Drawing.Point(6, 25);
            this.lblCanId.Name = "lblCanId";
            this.lblCanId.Size = new System.Drawing.Size(46, 13);
            this.lblCanId.TabIndex = 14;
            this.lblCanId.Text = "CAN ID:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(6, 120);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(250, 13);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "Resulting command: t10080000000000000000[CR]";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(6, 41);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(60, 20);
            this.tbxID.TabIndex = 0;
            this.tbxID.Text = "100";
            this.tbxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxID_KeyPress);
            this.tbxID.Leave += new System.EventHandler(this.tbxID_Leave);
            // 
            // btnSendFrame
            // 
            this.btnSendFrame.Location = new System.Drawing.Point(251, 84);
            this.btnSendFrame.Name = "btnSendFrame";
            this.btnSendFrame.Size = new System.Drawing.Size(75, 23);
            this.btnSendFrame.TabIndex = 12;
            this.btnSendFrame.Text = "Send Frame";
            this.btnSendFrame.UseVisualStyleBackColor = true;
            this.btnSendFrame.Click += new System.EventHandler(this.btnSendFrame_Click);
            // 
            // tbxHex1
            // 
            this.tbxHex1.Location = new System.Drawing.Point(108, 41);
            this.tbxHex1.Name = "tbxHex1";
            this.tbxHex1.Size = new System.Drawing.Size(22, 20);
            this.tbxHex1.TabIndex = 2;
            this.tbxHex1.Text = "00";
            this.tbxHex1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex1_KeyPress);
            this.tbxHex1.Leave += new System.EventHandler(this.tbxHex1_Leave);
            // 
            // cboxRtr
            // 
            this.cboxRtr.AutoSize = true;
            this.cboxRtr.Location = new System.Drawing.Point(6, 90);
            this.cboxRtr.Name = "cboxRtr";
            this.cboxRtr.Size = new System.Drawing.Size(81, 17);
            this.cboxRtr.TabIndex = 11;
            this.cboxRtr.Text = "RTR Frame";
            this.cboxRtr.UseVisualStyleBackColor = true;
            this.cboxRtr.CheckedChanged += new System.EventHandler(this.cboxRtr_CheckedChanged);
            // 
            // tbxHex2
            // 
            this.tbxHex2.Location = new System.Drawing.Point(136, 41);
            this.tbxHex2.Name = "tbxHex2";
            this.tbxHex2.Size = new System.Drawing.Size(22, 20);
            this.tbxHex2.TabIndex = 3;
            this.tbxHex2.Text = "00";
            this.tbxHex2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex2_KeyPress);
            this.tbxHex2.Leave += new System.EventHandler(this.tbxHex2_Leave);
            // 
            // cboxExt
            // 
            this.cboxExt.AutoSize = true;
            this.cboxExt.Location = new System.Drawing.Point(6, 67);
            this.cboxExt.Name = "cboxExt";
            this.cboxExt.Size = new System.Drawing.Size(120, 17);
            this.cboxExt.TabIndex = 10;
            this.cboxExt.Text = "Extended ID (29 bit)";
            this.cboxExt.UseVisualStyleBackColor = true;
            this.cboxExt.CheckedChanged += new System.EventHandler(this.cboxExt_CheckedChanged);
            // 
            // numDlc
            // 
            this.numDlc.Location = new System.Drawing.Point(72, 42);
            this.numDlc.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numDlc.Name = "numDlc";
            this.numDlc.ReadOnly = true;
            this.numDlc.Size = new System.Drawing.Size(30, 20);
            this.numDlc.TabIndex = 1;
            this.numDlc.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numDlc.ValueChanged += new System.EventHandler(this.numDlc_ValueChanged);
            // 
            // tbxHex3
            // 
            this.tbxHex3.Location = new System.Drawing.Point(164, 41);
            this.tbxHex3.Name = "tbxHex3";
            this.tbxHex3.Size = new System.Drawing.Size(22, 20);
            this.tbxHex3.TabIndex = 4;
            this.tbxHex3.Text = "00";
            this.tbxHex3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex3_KeyPress);
            this.tbxHex3.Leave += new System.EventHandler(this.tbxHex3_Leave);
            // 
            // tbxHex8
            // 
            this.tbxHex8.Location = new System.Drawing.Point(304, 41);
            this.tbxHex8.Name = "tbxHex8";
            this.tbxHex8.Size = new System.Drawing.Size(22, 20);
            this.tbxHex8.TabIndex = 9;
            this.tbxHex8.Text = "00";
            this.tbxHex8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex8_KeyPress);
            this.tbxHex8.Leave += new System.EventHandler(this.tbxHex8_Leave);
            // 
            // tbxHex4
            // 
            this.tbxHex4.Location = new System.Drawing.Point(192, 41);
            this.tbxHex4.Name = "tbxHex4";
            this.tbxHex4.Size = new System.Drawing.Size(22, 20);
            this.tbxHex4.TabIndex = 5;
            this.tbxHex4.Text = "00";
            this.tbxHex4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex4_KeyPress);
            this.tbxHex4.Leave += new System.EventHandler(this.tbxHex4_Leave);
            // 
            // tbxHex7
            // 
            this.tbxHex7.Location = new System.Drawing.Point(276, 41);
            this.tbxHex7.Name = "tbxHex7";
            this.tbxHex7.Size = new System.Drawing.Size(22, 20);
            this.tbxHex7.TabIndex = 8;
            this.tbxHex7.Text = "00";
            this.tbxHex7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex7_KeyPress);
            this.tbxHex7.Leave += new System.EventHandler(this.tbxHex7_Leave);
            // 
            // tbxHex5
            // 
            this.tbxHex5.Location = new System.Drawing.Point(220, 41);
            this.tbxHex5.Name = "tbxHex5";
            this.tbxHex5.Size = new System.Drawing.Size(22, 20);
            this.tbxHex5.TabIndex = 6;
            this.tbxHex5.Text = "00";
            this.tbxHex5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex5_KeyPress);
            this.tbxHex5.Leave += new System.EventHandler(this.tbxHex5_Leave);
            // 
            // tbxHex6
            // 
            this.tbxHex6.Location = new System.Drawing.Point(248, 41);
            this.tbxHex6.Name = "tbxHex6";
            this.tbxHex6.Size = new System.Drawing.Size(22, 20);
            this.tbxHex6.TabIndex = 7;
            this.tbxHex6.Text = "00";
            this.tbxHex6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxHex6_KeyPress);
            this.tbxHex6.Leave += new System.EventHandler(this.tbxHex6_Leave);
            // 
            // grpboxCanCommands
            // 
            this.grpboxCanCommands.Controls.Add(this.btnAutoOff);
            this.grpboxCanCommands.Controls.Add(this.btnAutoOn);
            this.grpboxCanCommands.Controls.Add(this.btnTimeStampOff);
            this.grpboxCanCommands.Controls.Add(this.btnTimeStampOn);
            this.grpboxCanCommands.Controls.Add(this.btnPollAll);
            this.grpboxCanCommands.Controls.Add(this.btnPollOne);
            this.grpboxCanCommands.Controls.Add(this.btnSerNo);
            this.grpboxCanCommands.Controls.Add(this.btnCanVersion);
            this.grpboxCanCommands.Controls.Add(this.btnCanFlags);
            this.grpboxCanCommands.Controls.Add(this.btnCanClose);
            this.grpboxCanCommands.Controls.Add(this.btnCanOpen);
            this.grpboxCanCommands.Controls.Add(this.btnSetup);
            this.grpboxCanCommands.Controls.Add(this.label254);
            this.grpboxCanCommands.Controls.Add(this.cmbCanBitrate);
            this.grpboxCanCommands.Enabled = false;
            this.grpboxCanCommands.Location = new System.Drawing.Point(474, 19);
            this.grpboxCanCommands.Name = "grpboxCanCommands";
            this.grpboxCanCommands.Size = new System.Drawing.Size(170, 414);
            this.grpboxCanCommands.TabIndex = 26;
            this.grpboxCanCommands.TabStop = false;
            this.grpboxCanCommands.Text = "CAN232 Commands";
            // 
            // btnAutoOff
            // 
            this.btnAutoOff.Location = new System.Drawing.Point(92, 267);
            this.btnAutoOff.Name = "btnAutoOff";
            this.btnAutoOff.Size = new System.Drawing.Size(75, 23);
            this.btnAutoOff.TabIndex = 29;
            this.btnAutoOff.Text = "Auto Off";
            this.btnAutoOff.UseVisualStyleBackColor = true;
            this.btnAutoOff.Click += new System.EventHandler(this.btnAutoOff_Click);
            // 
            // btnAutoOn
            // 
            this.btnAutoOn.Location = new System.Drawing.Point(6, 267);
            this.btnAutoOn.Name = "btnAutoOn";
            this.btnAutoOn.Size = new System.Drawing.Size(75, 23);
            this.btnAutoOn.TabIndex = 28;
            this.btnAutoOn.Text = "Auto On";
            this.btnAutoOn.UseVisualStyleBackColor = true;
            this.btnAutoOn.Click += new System.EventHandler(this.btnAutoOn_Click);
            // 
            // btnTimeStampOff
            // 
            this.btnTimeStampOff.Location = new System.Drawing.Point(92, 223);
            this.btnTimeStampOff.Name = "btnTimeStampOff";
            this.btnTimeStampOff.Size = new System.Drawing.Size(75, 23);
            this.btnTimeStampOff.TabIndex = 27;
            this.btnTimeStampOff.Text = "Time Off";
            this.btnTimeStampOff.UseVisualStyleBackColor = true;
            // 
            // btnTimeStampOn
            // 
            this.btnTimeStampOn.Location = new System.Drawing.Point(6, 223);
            this.btnTimeStampOn.Name = "btnTimeStampOn";
            this.btnTimeStampOn.Size = new System.Drawing.Size(75, 23);
            this.btnTimeStampOn.TabIndex = 26;
            this.btnTimeStampOn.Text = "Time On";
            this.btnTimeStampOn.UseVisualStyleBackColor = true;
            this.btnTimeStampOn.Click += new System.EventHandler(this.btnTimeStampOn_Click);
            // 
            // btnPollAll
            // 
            this.btnPollAll.Location = new System.Drawing.Point(92, 180);
            this.btnPollAll.Name = "btnPollAll";
            this.btnPollAll.Size = new System.Drawing.Size(75, 23);
            this.btnPollAll.TabIndex = 25;
            this.btnPollAll.Text = "Poll All";
            this.btnPollAll.UseVisualStyleBackColor = true;
            this.btnPollAll.Click += new System.EventHandler(this.btnPollAll_Click);
            // 
            // btnPollOne
            // 
            this.btnPollOne.Location = new System.Drawing.Point(6, 180);
            this.btnPollOne.Name = "btnPollOne";
            this.btnPollOne.Size = new System.Drawing.Size(75, 23);
            this.btnPollOne.TabIndex = 24;
            this.btnPollOne.Text = "Poll One";
            this.btnPollOne.UseVisualStyleBackColor = true;
            this.btnPollOne.Click += new System.EventHandler(this.btnPollOne_Click);
            // 
            // btnSerNo
            // 
            this.btnSerNo.Location = new System.Drawing.Point(6, 136);
            this.btnSerNo.Name = "btnSerNo";
            this.btnSerNo.Size = new System.Drawing.Size(75, 23);
            this.btnSerNo.TabIndex = 23;
            this.btnSerNo.Text = "S/No";
            this.btnSerNo.UseVisualStyleBackColor = true;
            // 
            // btnCanVersion
            // 
            this.btnCanVersion.Location = new System.Drawing.Point(6, 107);
            this.btnCanVersion.Name = "btnCanVersion";
            this.btnCanVersion.Size = new System.Drawing.Size(75, 23);
            this.btnCanVersion.TabIndex = 22;
            this.btnCanVersion.Text = "Version";
            this.btnCanVersion.UseVisualStyleBackColor = true;
            this.btnCanVersion.Click += new System.EventHandler(this.btnCanVersion_Click);
            // 
            // btnCanFlags
            // 
            this.btnCanFlags.Location = new System.Drawing.Point(92, 136);
            this.btnCanFlags.Name = "btnCanFlags";
            this.btnCanFlags.Size = new System.Drawing.Size(75, 23);
            this.btnCanFlags.TabIndex = 21;
            this.btnCanFlags.Text = "Flags";
            this.btnCanFlags.UseVisualStyleBackColor = true;
            this.btnCanFlags.Click += new System.EventHandler(this.btnCanFlags_Click);
            // 
            // btnCanClose
            // 
            this.btnCanClose.Location = new System.Drawing.Point(92, 63);
            this.btnCanClose.Name = "btnCanClose";
            this.btnCanClose.Size = new System.Drawing.Size(75, 23);
            this.btnCanClose.TabIndex = 20;
            this.btnCanClose.Text = "Close";
            this.btnCanClose.UseVisualStyleBackColor = true;
            this.btnCanClose.Click += new System.EventHandler(this.btnCanClose_Click);
            // 
            // btnCanOpen
            // 
            this.btnCanOpen.Location = new System.Drawing.Point(6, 63);
            this.btnCanOpen.Name = "btnCanOpen";
            this.btnCanOpen.Size = new System.Drawing.Size(75, 23);
            this.btnCanOpen.TabIndex = 19;
            this.btnCanOpen.Text = "Open";
            this.btnCanOpen.UseVisualStyleBackColor = true;
            this.btnCanOpen.Click += new System.EventHandler(this.btnCanOpen_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(92, 34);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSetup.TabIndex = 18;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // label254
            // 
            this.label254.AutoSize = true;
            this.label254.Location = new System.Drawing.Point(3, 20);
            this.label254.Name = "label254";
            this.label254.Size = new System.Drawing.Size(37, 13);
            this.label254.TabIndex = 17;
            this.label254.Text = "Bitrate";
            // 
            // cmbCanBitrate
            // 
            this.cmbCanBitrate.FormattingEnabled = true;
            this.cmbCanBitrate.Items.AddRange(new object[] {
            "10Kbit",
            "20Kbit",
            "50Kbit",
            "100Kbit",
            "125Kbit",
            "250Kbit",
            "500Kbit",
            "800Kbit",
            "1Mbit"});
            this.cmbCanBitrate.Location = new System.Drawing.Point(6, 36);
            this.cmbCanBitrate.Name = "cmbCanBitrate";
            this.cmbCanBitrate.Size = new System.Drawing.Size(75, 21);
            this.cmbCanBitrate.TabIndex = 16;
            // 
            // grpboxCanFrameReceive
            // 
            this.grpboxCanFrameReceive.Controls.Add(this.rtboxReceive);
            this.grpboxCanFrameReceive.Location = new System.Drawing.Point(219, 24);
            this.grpboxCanFrameReceive.Name = "grpboxCanFrameReceive";
            this.grpboxCanFrameReceive.Size = new System.Drawing.Size(252, 265);
            this.grpboxCanFrameReceive.TabIndex = 25;
            this.grpboxCanFrameReceive.TabStop = false;
            this.grpboxCanFrameReceive.Text = "CAN Receive Frames (HEX)";
            // 
            // rtboxReceive
            // 
            this.rtboxReceive.Location = new System.Drawing.Point(6, 19);
            this.rtboxReceive.Name = "rtboxReceive";
            this.rtboxReceive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtboxReceive.Size = new System.Drawing.Size(240, 226);
            this.rtboxReceive.TabIndex = 1;
            this.rtboxReceive.Text = "";
            // 
            // ComBoxTester
            // 
            this.ComBoxTester.Controls.Add(this.ComProgresTester);
            this.ComBoxTester.Controls.Add(this.button7);
            this.ComBoxTester.Controls.Add(this.button15);
            this.ComBoxTester.Controls.Add(this.button16);
            this.ComBoxTester.Controls.Add(this.label235);
            this.ComBoxTester.Controls.Add(this.label236);
            this.ComBoxTester.Controls.Add(this.richTextBox4);
            this.ComBoxTester.Controls.Add(this.richTextBox5);
            this.ComBoxTester.Controls.Add(this.comboBox1);
            this.ComBoxTester.Controls.Add(this.comboBox2);
            this.ComBoxTester.Controls.Add(this.comboBox3);
            this.ComBoxTester.Controls.Add(this.comboBox4);
            this.ComBoxTester.Controls.Add(this.comboBox5);
            this.ComBoxTester.Controls.Add(this.button18);
            this.ComBoxTester.Controls.Add(this.label237);
            this.ComBoxTester.Controls.Add(this.label238);
            this.ComBoxTester.Controls.Add(this.label239);
            this.ComBoxTester.Controls.Add(this.label240);
            this.ComBoxTester.Controls.Add(this.label241);
            this.ComBoxTester.Location = new System.Drawing.Point(1273, 329);
            this.ComBoxTester.Name = "ComBoxTester";
            this.ComBoxTester.Size = new System.Drawing.Size(173, 305);
            this.ComBoxTester.TabIndex = 282;
            this.ComBoxTester.TabStop = false;
            this.ComBoxTester.Text = " COM Port Settings TESTER";
            this.ComBoxTester.Visible = false;
            // 
            // ComProgresTester
            // 
            this.ComProgresTester.Location = new System.Drawing.Point(55, 271);
            this.ComProgresTester.Name = "ComProgresTester";
            this.ComProgresTester.Size = new System.Drawing.Size(111, 23);
            this.ComProgresTester.TabIndex = 24;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(63, 242);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 23);
            this.button7.TabIndex = 23;
            this.button7.Text = "Send";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(118, 242);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(48, 23);
            this.button15.TabIndex = 22;
            this.button15.Text = "Close";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(12, 242);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(45, 23);
            this.button16.TabIndex = 21;
            this.button16.Text = "Open";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label235
            // 
            this.label235.AutoSize = true;
            this.label235.Location = new System.Drawing.Point(117, 153);
            this.label235.Name = "label235";
            this.label235.Size = new System.Drawing.Size(21, 13);
            this.label235.TabIndex = 20;
            this.label235.Text = "TX";
            // 
            // label236
            // 
            this.label236.AutoSize = true;
            this.label236.Location = new System.Drawing.Point(37, 153);
            this.label236.Name = "label236";
            this.label236.Size = new System.Drawing.Size(22, 13);
            this.label236.TabIndex = 19;
            this.label236.Text = "RX";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(93, 169);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(73, 67);
            this.richTextBox4.TabIndex = 18;
            this.richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(14, 169);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(73, 67);
            this.richTextBox5.TabIndex = 17;
            this.richTextBox5.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBox1.Location = new System.Drawing.Point(71, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBox2.Location = new System.Drawing.Point(71, 102);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBox3.Location = new System.Drawing.Point(71, 75);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(97, 21);
            this.comboBox3.TabIndex = 14;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "600",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000",
            ""});
            this.comboBox4.Location = new System.Drawing.Point(71, 50);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(97, 21);
            this.comboBox4.TabIndex = 13;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(71, 26);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(97, 21);
            this.comboBox5.TabIndex = 12;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(12, 271);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(37, 23);
            this.button18.TabIndex = 10;
            this.button18.Text = "OK";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // label237
            // 
            this.label237.AutoSize = true;
            this.label237.Location = new System.Drawing.Point(13, 137);
            this.label237.Name = "label237";
            this.label237.Size = new System.Drawing.Size(46, 13);
            this.label237.TabIndex = 4;
            this.label237.Text = "StopBits";
            // 
            // label238
            // 
            this.label238.AutoSize = true;
            this.label238.Location = new System.Drawing.Point(12, 110);
            this.label238.Name = "label238";
            this.label238.Size = new System.Drawing.Size(33, 13);
            this.label238.TabIndex = 3;
            this.label238.Text = "Parity";
            // 
            // label239
            // 
            this.label239.AutoSize = true;
            this.label239.Location = new System.Drawing.Point(12, 83);
            this.label239.Name = "label239";
            this.label239.Size = new System.Drawing.Size(47, 13);
            this.label239.TabIndex = 2;
            this.label239.Text = "DataBits";
            // 
            // label240
            // 
            this.label240.AutoSize = true;
            this.label240.Location = new System.Drawing.Point(12, 58);
            this.label240.Name = "label240";
            this.label240.Size = new System.Drawing.Size(55, 13);
            this.label240.TabIndex = 1;
            this.label240.Text = "BaudRate";
            // 
            // label241
            // 
            this.label241.AutoSize = true;
            this.label241.Location = new System.Drawing.Point(12, 29);
            this.label241.Name = "label241";
            this.label241.Size = new System.Drawing.Size(53, 13);
            this.label241.TabIndex = 0;
            this.label241.Text = "COM Port";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label253);
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.richTextBox3);
            this.groupBox5.Location = new System.Drawing.Point(8, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 84);
            this.groupBox5.TabIndex = 281;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Slots";
            // 
            // label253
            // 
            this.label253.AutoSize = true;
            this.label253.Location = new System.Drawing.Point(6, 29);
            this.label253.Name = "label253";
            this.label253.Size = new System.Drawing.Size(66, 13);
            this.label253.TabIndex = 21;
            this.label253.Text = "Cart Number";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(76, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Unblock";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(76, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Block";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(6, 50);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(64, 21);
            this.richTextBox3.TabIndex = 18;
            this.richTextBox3.Text = "";
            // 
            // ComBoxChamber
            // 
            this.ComBoxChamber.Controls.Add(this.ComprogressChaber);
            this.ComBoxChamber.Controls.Add(this.ComSend);
            this.ComBoxChamber.Controls.Add(this.ComClose);
            this.ComBoxChamber.Controls.Add(this.ComOpen);
            this.ComBoxChamber.Controls.Add(this.label231);
            this.ComBoxChamber.Controls.Add(this.label230);
            this.ComBoxChamber.Controls.Add(this.richTextBoxTX);
            this.ComBoxChamber.Controls.Add(this.richTextBoxRX);
            this.ComBoxChamber.Controls.Add(this.cBoxStopBits);
            this.ComBoxChamber.Controls.Add(this.cBoxParity);
            this.ComBoxChamber.Controls.Add(this.CBoxDataBits);
            this.ComBoxChamber.Controls.Add(this.CBoxBaundRate);
            this.ComBoxChamber.Controls.Add(this.cBoxCOMPort);
            this.ComBoxChamber.Controls.Add(this.ComOk);
            this.ComBoxChamber.Controls.Add(this.Label229);
            this.ComBoxChamber.Controls.Add(this.Label228);
            this.ComBoxChamber.Controls.Add(this.Label227);
            this.ComBoxChamber.Controls.Add(this.Label226);
            this.ComBoxChamber.Controls.Add(this.Label225);
            this.ComBoxChamber.Location = new System.Drawing.Point(1273, 19);
            this.ComBoxChamber.Name = "ComBoxChamber";
            this.ComBoxChamber.Size = new System.Drawing.Size(173, 304);
            this.ComBoxChamber.TabIndex = 280;
            this.ComBoxChamber.TabStop = false;
            this.ComBoxChamber.Text = " COM Port Settings CHAMBER";
            this.ComBoxChamber.Visible = false;
            // 
            // ComprogressChaber
            // 
            this.ComprogressChaber.Location = new System.Drawing.Point(55, 271);
            this.ComprogressChaber.Name = "ComprogressChaber";
            this.ComprogressChaber.Size = new System.Drawing.Size(113, 23);
            this.ComprogressChaber.TabIndex = 24;
            // 
            // ComSend
            // 
            this.ComSend.Location = new System.Drawing.Point(63, 242);
            this.ComSend.Name = "ComSend";
            this.ComSend.Size = new System.Drawing.Size(49, 23);
            this.ComSend.TabIndex = 23;
            this.ComSend.Text = "Send";
            this.ComSend.UseVisualStyleBackColor = true;
            this.ComSend.Click += new System.EventHandler(this.ComSend_Click_1);
            // 
            // ComClose
            // 
            this.ComClose.Location = new System.Drawing.Point(118, 242);
            this.ComClose.Name = "ComClose";
            this.ComClose.Size = new System.Drawing.Size(48, 23);
            this.ComClose.TabIndex = 22;
            this.ComClose.Text = "Close";
            this.ComClose.UseVisualStyleBackColor = true;
            this.ComClose.Click += new System.EventHandler(this.ComClose_Click_1);
            // 
            // ComOpen
            // 
            this.ComOpen.Location = new System.Drawing.Point(12, 242);
            this.ComOpen.Name = "ComOpen";
            this.ComOpen.Size = new System.Drawing.Size(45, 23);
            this.ComOpen.TabIndex = 21;
            this.ComOpen.Text = "Open";
            this.ComOpen.UseVisualStyleBackColor = true;
            this.ComOpen.Click += new System.EventHandler(this.ComOpen_Click_1);
            // 
            // label231
            // 
            this.label231.AutoSize = true;
            this.label231.Location = new System.Drawing.Point(117, 153);
            this.label231.Name = "label231";
            this.label231.Size = new System.Drawing.Size(21, 13);
            this.label231.TabIndex = 20;
            this.label231.Text = "TX";
            // 
            // label230
            // 
            this.label230.AutoSize = true;
            this.label230.Location = new System.Drawing.Point(37, 153);
            this.label230.Name = "label230";
            this.label230.Size = new System.Drawing.Size(22, 13);
            this.label230.TabIndex = 19;
            this.label230.Text = "RX";
            // 
            // richTextBoxTX
            // 
            this.richTextBoxTX.Location = new System.Drawing.Point(93, 169);
            this.richTextBoxTX.Name = "richTextBoxTX";
            this.richTextBoxTX.Size = new System.Drawing.Size(73, 67);
            this.richTextBoxTX.TabIndex = 18;
            this.richTextBoxTX.Text = "";
            // 
            // richTextBoxRX
            // 
            this.richTextBoxRX.Location = new System.Drawing.Point(14, 169);
            this.richTextBoxRX.Name = "richTextBoxRX";
            this.richTextBoxRX.Size = new System.Drawing.Size(73, 67);
            this.richTextBoxRX.TabIndex = 17;
            this.richTextBoxRX.Text = "";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(71, 129);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(96, 21);
            this.cBoxStopBits.TabIndex = 16;
            // 
            // cBoxParity
            // 
            this.cBoxParity.FormattingEnabled = true;
            this.cBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParity.Location = new System.Drawing.Point(71, 102);
            this.cBoxParity.Name = "cBoxParity";
            this.cBoxParity.Size = new System.Drawing.Size(97, 21);
            this.cBoxParity.TabIndex = 15;
            // 
            // CBoxDataBits
            // 
            this.CBoxDataBits.FormattingEnabled = true;
            this.CBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.CBoxDataBits.Location = new System.Drawing.Point(71, 75);
            this.CBoxDataBits.Name = "CBoxDataBits";
            this.CBoxDataBits.Size = new System.Drawing.Size(97, 21);
            this.CBoxDataBits.TabIndex = 14;
            // 
            // CBoxBaundRate
            // 
            this.CBoxBaundRate.FormattingEnabled = true;
            this.CBoxBaundRate.Items.AddRange(new object[] {
            "600",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000",
            ""});
            this.CBoxBaundRate.Location = new System.Drawing.Point(71, 50);
            this.CBoxBaundRate.Name = "CBoxBaundRate";
            this.CBoxBaundRate.Size = new System.Drawing.Size(97, 21);
            this.CBoxBaundRate.TabIndex = 13;
            // 
            // cBoxCOMPort
            // 
            this.cBoxCOMPort.FormattingEnabled = true;
            this.cBoxCOMPort.Location = new System.Drawing.Point(71, 26);
            this.cBoxCOMPort.Name = "cBoxCOMPort";
            this.cBoxCOMPort.Size = new System.Drawing.Size(97, 21);
            this.cBoxCOMPort.TabIndex = 12;
            // 
            // ComOk
            // 
            this.ComOk.Location = new System.Drawing.Point(12, 271);
            this.ComOk.Name = "ComOk";
            this.ComOk.Size = new System.Drawing.Size(37, 23);
            this.ComOk.TabIndex = 10;
            this.ComOk.Text = "OK";
            this.ComOk.UseVisualStyleBackColor = true;
            // 
            // Label229
            // 
            this.Label229.AutoSize = true;
            this.Label229.Location = new System.Drawing.Point(13, 137);
            this.Label229.Name = "Label229";
            this.Label229.Size = new System.Drawing.Size(46, 13);
            this.Label229.TabIndex = 4;
            this.Label229.Text = "StopBits";
            // 
            // Label228
            // 
            this.Label228.AutoSize = true;
            this.Label228.Location = new System.Drawing.Point(12, 110);
            this.Label228.Name = "Label228";
            this.Label228.Size = new System.Drawing.Size(33, 13);
            this.Label228.TabIndex = 3;
            this.Label228.Text = "Parity";
            // 
            // Label227
            // 
            this.Label227.AutoSize = true;
            this.Label227.Location = new System.Drawing.Point(12, 83);
            this.Label227.Name = "Label227";
            this.Label227.Size = new System.Drawing.Size(47, 13);
            this.Label227.TabIndex = 2;
            this.Label227.Text = "DataBits";
            // 
            // Label226
            // 
            this.Label226.AutoSize = true;
            this.Label226.Location = new System.Drawing.Point(12, 58);
            this.Label226.Name = "Label226";
            this.Label226.Size = new System.Drawing.Size(55, 13);
            this.Label226.TabIndex = 1;
            this.Label226.Text = "BaudRate";
            // 
            // Label225
            // 
            this.Label225.AutoSize = true;
            this.Label225.Location = new System.Drawing.Point(12, 29);
            this.Label225.Name = "Label225";
            this.Label225.Size = new System.Drawing.Size(53, 13);
            this.Label225.TabIndex = 0;
            this.Label225.Text = "COM Port";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.zedGraphControl2);
            this.metroTabPage2.Controls.Add(this.zedGraphControl1);
            this.metroTabPage2.Controls.Add(this.panel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1471, 733);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Recepie";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(233, 487);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(1230, 243);
            this.zedGraphControl2.TabIndex = 4;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.zedGraphControl1.Location = new System.Drawing.Point(233, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1230, 478);
            this.zedGraphControl1.TabIndex = 3;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.richTextBox8);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.label232);
            this.panel2.Controls.Add(this.button4);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 727);
            this.panel2.TabIndex = 2;
            // 
            // richTextBox8
            // 
            this.richTextBox8.Location = new System.Drawing.Point(5, 286);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(215, 46);
            this.richTextBox8.TabIndex = 26;
            this.richTextBox8.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 260);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(216, 20);
            this.progressBar1.TabIndex = 25;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Snow;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(3, 151);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(218, 103);
            this.button14.TabIndex = 4;
            this.button14.Text = "Send setup to chamber";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label232
            // 
            this.label232.AutoSize = true;
            this.label232.Location = new System.Drawing.Point(84, 17);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(44, 13);
            this.label232.TabIndex = 3;
            this.label232.Text = "TO DO:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Snow;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(3, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 103);
            this.button4.TabIndex = 1;
            this.button4.Text = "Load Recepie";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.richTextBox9);
            this.metroTabPage1.Controls.Add(this.button2);
            this.metroTabPage1.Controls.Add(this.label252);
            this.metroTabPage1.Controls.Add(this.label251);
            this.metroTabPage1.Controls.Add(this.label250);
            this.metroTabPage1.Controls.Add(this.ComProgresshomecard);
            this.metroTabPage1.Controls.Add(this.ComProgressHomeTester);
            this.metroTabPage1.Controls.Add(this.ComProgresHomeChamber);
            this.metroTabPage1.Controls.Add(this.label249);
            this.metroTabPage1.Controls.Add(this.StartButton);
            this.metroTabPage1.Controls.Add(this.button24);
            this.metroTabPage1.Controls.Add(this.panel3);
            this.metroTabPage1.Controls.Add(this.GroupBox4);
            this.metroTabPage1.Controls.Add(this.GroupBox1);
            this.metroTabPage1.Controls.Add(this.Button1);
            this.metroTabPage1.Controls.Add(this.Label217);
            this.metroTabPage1.Controls.Add(this.RichTextBox2);
            this.metroTabPage1.Controls.Add(this.Label218);
            this.metroTabPage1.Controls.Add(this.Label224);
            this.metroTabPage1.Controls.Add(this.Label223);
            this.metroTabPage1.Controls.Add(this.Label219);
            this.metroTabPage1.Controls.Add(this.Label221);
            this.metroTabPage1.Controls.Add(this.Label220);
            this.metroTabPage1.Controls.Add(this.RichTextBox1);
            this.metroTabPage1.Controls.Add(this.Label222);
            this.metroTabPage1.Controls.Add(this.GroupBox3);
            this.metroTabPage1.Controls.Add(this.GroupBox2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1471, 733);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Home";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // richTextBox9
            // 
            this.richTextBox9.Location = new System.Drawing.Point(158, 415);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(119, 44);
            this.richTextBox9.TabIndex = 301;
            this.richTextBox9.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1005, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 114);
            this.button2.TabIndex = 300;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label252
            // 
            this.label252.AutoSize = true;
            this.label252.BackColor = System.Drawing.Color.Transparent;
            this.label252.Location = new System.Drawing.Point(37, 117);
            this.label252.Name = "label252";
            this.label252.Size = new System.Drawing.Size(49, 13);
            this.label252.TabIndex = 299;
            this.label252.Text = "Chamber";
            // 
            // label251
            // 
            this.label251.AutoSize = true;
            this.label251.Location = new System.Drawing.Point(283, 117);
            this.label251.Name = "label251";
            this.label251.Size = new System.Drawing.Size(26, 13);
            this.label251.TabIndex = 298;
            this.label251.Text = "Cart";
            // 
            // label250
            // 
            this.label250.AutoSize = true;
            this.label250.Location = new System.Drawing.Point(155, 117);
            this.label250.Name = "label250";
            this.label250.Size = new System.Drawing.Size(37, 13);
            this.label250.TabIndex = 297;
            this.label250.Text = "Tester";
            // 
            // ComProgresshomecard
            // 
            this.ComProgresshomecard.Location = new System.Drawing.Point(241, 110);
            this.ComProgresshomecard.Name = "ComProgresshomecard";
            this.ComProgresshomecard.Size = new System.Drawing.Size(103, 33);
            this.ComProgresshomecard.TabIndex = 296;
            // 
            // ComProgressHomeTester
            // 
            this.ComProgressHomeTester.Location = new System.Drawing.Point(118, 110);
            this.ComProgressHomeTester.Name = "ComProgressHomeTester";
            this.ComProgressHomeTester.Size = new System.Drawing.Size(117, 33);
            this.ComProgressHomeTester.TabIndex = 295;
            // 
            // ComProgresHomeChamber
            // 
            this.ComProgresHomeChamber.Location = new System.Drawing.Point(18, 110);
            this.ComProgresHomeChamber.Name = "ComProgresHomeChamber";
            this.ComProgresHomeChamber.Size = new System.Drawing.Size(94, 33);
            this.ComProgresHomeChamber.TabIndex = 294;
            this.ComProgresHomeChamber.Tag = "";
            // 
            // label249
            // 
            this.label249.AutoSize = true;
            this.label249.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label249.Location = new System.Drawing.Point(127, 91);
            this.label249.Name = "label249";
            this.label249.Size = new System.Drawing.Size(97, 16);
            this.label249.TabIndex = 293;
            this.label249.Text = "CONNCETION";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(509, 16);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(490, 69);
            this.StartButton.TabIndex = 292;
            this.StartButton.Text = "Start Test";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.Location = new System.Drawing.Point(18, 16);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(485, 69);
            this.button24.TabIndex = 291;
            this.button24.Text = "Cart load confirmation ";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox4.Controls.Add(this.Label216);
            this.GroupBox4.Controls.Add(this.Label215);
            this.GroupBox4.Controls.Add(this.Label214);
            this.GroupBox4.Controls.Add(this.Label213);
            this.GroupBox4.Controls.Add(this.Label212);
            this.GroupBox4.Controls.Add(this.Label211);
            this.GroupBox4.Controls.Add(this.Label210);
            this.GroupBox4.Controls.Add(this.Label209);
            this.GroupBox4.Controls.Add(this.Label208);
            this.GroupBox4.Controls.Add(this.Label207);
            this.GroupBox4.Controls.Add(this.Label206);
            this.GroupBox4.Controls.Add(this.Label205);
            this.GroupBox4.Controls.Add(this.Label204);
            this.GroupBox4.Controls.Add(this.Label203);
            this.GroupBox4.Controls.Add(this.Label202);
            this.GroupBox4.Controls.Add(this.Label201);
            this.GroupBox4.Controls.Add(this.Label200);
            this.GroupBox4.Controls.Add(this.Label199);
            this.GroupBox4.Controls.Add(this.Label198);
            this.GroupBox4.Controls.Add(this.Label197);
            this.GroupBox4.Controls.Add(this.Label196);
            this.GroupBox4.Controls.Add(this.Label195);
            this.GroupBox4.Controls.Add(this.Label194);
            this.GroupBox4.Controls.Add(this.Label193);
            this.GroupBox4.Controls.Add(this.Label192);
            this.GroupBox4.Controls.Add(this.Label191);
            this.GroupBox4.Controls.Add(this.Label190);
            this.GroupBox4.Controls.Add(this.Label189);
            this.GroupBox4.Controls.Add(this.Label188);
            this.GroupBox4.Controls.Add(this.Label187);
            this.GroupBox4.Controls.Add(this.Label186);
            this.GroupBox4.Controls.Add(this.Label185);
            this.GroupBox4.Controls.Add(this.Label184);
            this.GroupBox4.Controls.Add(this.Label183);
            this.GroupBox4.Controls.Add(this.Label182);
            this.GroupBox4.Controls.Add(this.Label181);
            this.GroupBox4.Controls.Add(this.Label180);
            this.GroupBox4.Controls.Add(this.Label179);
            this.GroupBox4.Controls.Add(this.Label178);
            this.GroupBox4.Controls.Add(this.Label177);
            this.GroupBox4.Controls.Add(this.Label176);
            this.GroupBox4.Controls.Add(this.Label175);
            this.GroupBox4.Controls.Add(this.Label174);
            this.GroupBox4.Controls.Add(this.Label173);
            this.GroupBox4.Controls.Add(this.Label172);
            this.GroupBox4.Controls.Add(this.Label171);
            this.GroupBox4.Controls.Add(this.Label170);
            this.GroupBox4.Controls.Add(this.Label169);
            this.GroupBox4.Controls.Add(this.Label168);
            this.GroupBox4.Controls.Add(this.Label167);
            this.GroupBox4.Controls.Add(this.Label166);
            this.GroupBox4.Controls.Add(this.Label165);
            this.GroupBox4.Controls.Add(this.Label164);
            this.GroupBox4.Controls.Add(this.Label163);
            this.GroupBox4.Location = new System.Drawing.Point(857, 157);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(142, 460);
            this.GroupBox4.TabIndex = 278;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = " Side 4 ";
            // 
            // Label216
            // 
            this.Label216.BackColor = System.Drawing.Color.White;
            this.Label216.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label216.ContextMenuStrip = this.contextMenuStrip1;
            this.Label216.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label216.Location = new System.Drawing.Point(92, 429);
            this.Label216.Name = "Label216";
            this.Label216.Size = new System.Drawing.Size(38, 20);
            this.Label216.TabIndex = 269;
            this.Label216.Text = "216";
            this.Label216.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blockToolStripMenuItem,
            this.unblockToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 48);
            // 
            // blockToolStripMenuItem
            // 
            this.blockToolStripMenuItem.Name = "blockToolStripMenuItem";
            this.blockToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.blockToolStripMenuItem.Text = "Block";
            this.blockToolStripMenuItem.Click += new System.EventHandler(this.blockToolStripMenuItem_Click);
            // 
            // unblockToolStripMenuItem
            // 
            this.unblockToolStripMenuItem.Name = "unblockToolStripMenuItem";
            this.unblockToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.unblockToolStripMenuItem.Text = "Unblock";
            // 
            // Label215
            // 
            this.Label215.BackColor = System.Drawing.Color.White;
            this.Label215.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label215.ContextMenuStrip = this.contextMenuStrip1;
            this.Label215.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label215.Location = new System.Drawing.Point(51, 429);
            this.Label215.Name = "Label215";
            this.Label215.Size = new System.Drawing.Size(38, 20);
            this.Label215.TabIndex = 268;
            this.Label215.Text = "215";
            this.Label215.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label214
            // 
            this.Label214.BackColor = System.Drawing.Color.White;
            this.Label214.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label214.ContextMenuStrip = this.contextMenuStrip1;
            this.Label214.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label214.Location = new System.Drawing.Point(10, 429);
            this.Label214.Name = "Label214";
            this.Label214.Size = new System.Drawing.Size(38, 20);
            this.Label214.TabIndex = 267;
            this.Label214.Text = "214";
            this.Label214.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label213
            // 
            this.Label213.BackColor = System.Drawing.Color.White;
            this.Label213.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label213.ContextMenuStrip = this.contextMenuStrip1;
            this.Label213.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label213.Location = new System.Drawing.Point(92, 408);
            this.Label213.Name = "Label213";
            this.Label213.Size = new System.Drawing.Size(38, 20);
            this.Label213.TabIndex = 266;
            this.Label213.Text = "213";
            this.Label213.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label212
            // 
            this.Label212.BackColor = System.Drawing.Color.White;
            this.Label212.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label212.ContextMenuStrip = this.contextMenuStrip1;
            this.Label212.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label212.Location = new System.Drawing.Point(51, 408);
            this.Label212.Name = "Label212";
            this.Label212.Size = new System.Drawing.Size(38, 20);
            this.Label212.TabIndex = 265;
            this.Label212.Text = "212";
            this.Label212.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label211
            // 
            this.Label211.BackColor = System.Drawing.Color.White;
            this.Label211.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label211.ContextMenuStrip = this.contextMenuStrip1;
            this.Label211.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label211.Location = new System.Drawing.Point(10, 408);
            this.Label211.Name = "Label211";
            this.Label211.Size = new System.Drawing.Size(38, 20);
            this.Label211.TabIndex = 264;
            this.Label211.Text = "211";
            this.Label211.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label210
            // 
            this.Label210.BackColor = System.Drawing.Color.White;
            this.Label210.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label210.ContextMenuStrip = this.contextMenuStrip1;
            this.Label210.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label210.Location = new System.Drawing.Point(92, 380);
            this.Label210.Name = "Label210";
            this.Label210.Size = new System.Drawing.Size(38, 20);
            this.Label210.TabIndex = 263;
            this.Label210.Text = "210";
            this.Label210.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label209
            // 
            this.Label209.BackColor = System.Drawing.Color.White;
            this.Label209.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label209.ContextMenuStrip = this.contextMenuStrip1;
            this.Label209.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label209.Location = new System.Drawing.Point(51, 380);
            this.Label209.Name = "Label209";
            this.Label209.Size = new System.Drawing.Size(38, 20);
            this.Label209.TabIndex = 262;
            this.Label209.Text = "209";
            this.Label209.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label208
            // 
            this.Label208.BackColor = System.Drawing.Color.White;
            this.Label208.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label208.ContextMenuStrip = this.contextMenuStrip1;
            this.Label208.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label208.Location = new System.Drawing.Point(10, 380);
            this.Label208.Name = "Label208";
            this.Label208.Size = new System.Drawing.Size(38, 20);
            this.Label208.TabIndex = 261;
            this.Label208.Text = "208";
            this.Label208.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label207
            // 
            this.Label207.BackColor = System.Drawing.Color.White;
            this.Label207.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label207.ContextMenuStrip = this.contextMenuStrip1;
            this.Label207.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label207.Location = new System.Drawing.Point(92, 359);
            this.Label207.Name = "Label207";
            this.Label207.Size = new System.Drawing.Size(38, 20);
            this.Label207.TabIndex = 260;
            this.Label207.Text = "207";
            this.Label207.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label206
            // 
            this.Label206.BackColor = System.Drawing.Color.White;
            this.Label206.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label206.ContextMenuStrip = this.contextMenuStrip1;
            this.Label206.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label206.Location = new System.Drawing.Point(51, 359);
            this.Label206.Name = "Label206";
            this.Label206.Size = new System.Drawing.Size(38, 20);
            this.Label206.TabIndex = 259;
            this.Label206.Text = "206";
            this.Label206.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label205
            // 
            this.Label205.BackColor = System.Drawing.Color.White;
            this.Label205.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label205.ContextMenuStrip = this.contextMenuStrip1;
            this.Label205.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label205.Location = new System.Drawing.Point(10, 359);
            this.Label205.Name = "Label205";
            this.Label205.Size = new System.Drawing.Size(38, 20);
            this.Label205.TabIndex = 258;
            this.Label205.Text = "205";
            this.Label205.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label204
            // 
            this.Label204.BackColor = System.Drawing.Color.White;
            this.Label204.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label204.ContextMenuStrip = this.contextMenuStrip1;
            this.Label204.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label204.Location = new System.Drawing.Point(92, 331);
            this.Label204.Name = "Label204";
            this.Label204.Size = new System.Drawing.Size(38, 20);
            this.Label204.TabIndex = 257;
            this.Label204.Text = "204";
            this.Label204.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label203
            // 
            this.Label203.BackColor = System.Drawing.Color.White;
            this.Label203.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label203.ContextMenuStrip = this.contextMenuStrip1;
            this.Label203.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label203.Location = new System.Drawing.Point(51, 331);
            this.Label203.Name = "Label203";
            this.Label203.Size = new System.Drawing.Size(38, 20);
            this.Label203.TabIndex = 256;
            this.Label203.Text = "203";
            this.Label203.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label202
            // 
            this.Label202.BackColor = System.Drawing.Color.White;
            this.Label202.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label202.ContextMenuStrip = this.contextMenuStrip1;
            this.Label202.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label202.Location = new System.Drawing.Point(10, 331);
            this.Label202.Name = "Label202";
            this.Label202.Size = new System.Drawing.Size(38, 20);
            this.Label202.TabIndex = 255;
            this.Label202.Text = "202";
            this.Label202.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label201
            // 
            this.Label201.BackColor = System.Drawing.Color.White;
            this.Label201.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label201.ContextMenuStrip = this.contextMenuStrip1;
            this.Label201.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label201.Location = new System.Drawing.Point(92, 310);
            this.Label201.Name = "Label201";
            this.Label201.Size = new System.Drawing.Size(38, 20);
            this.Label201.TabIndex = 254;
            this.Label201.Text = "201";
            this.Label201.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label200
            // 
            this.Label200.BackColor = System.Drawing.Color.White;
            this.Label200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label200.ContextMenuStrip = this.contextMenuStrip1;
            this.Label200.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label200.Location = new System.Drawing.Point(51, 310);
            this.Label200.Name = "Label200";
            this.Label200.Size = new System.Drawing.Size(38, 20);
            this.Label200.TabIndex = 253;
            this.Label200.Text = "200";
            this.Label200.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label199
            // 
            this.Label199.BackColor = System.Drawing.Color.White;
            this.Label199.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label199.ContextMenuStrip = this.contextMenuStrip1;
            this.Label199.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label199.Location = new System.Drawing.Point(10, 310);
            this.Label199.Name = "Label199";
            this.Label199.Size = new System.Drawing.Size(38, 20);
            this.Label199.TabIndex = 252;
            this.Label199.Text = "199";
            this.Label199.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label198
            // 
            this.Label198.BackColor = System.Drawing.Color.White;
            this.Label198.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label198.ContextMenuStrip = this.contextMenuStrip1;
            this.Label198.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label198.Location = new System.Drawing.Point(92, 282);
            this.Label198.Name = "Label198";
            this.Label198.Size = new System.Drawing.Size(38, 20);
            this.Label198.TabIndex = 251;
            this.Label198.Text = "198";
            this.Label198.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label197
            // 
            this.Label197.BackColor = System.Drawing.Color.White;
            this.Label197.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label197.ContextMenuStrip = this.contextMenuStrip1;
            this.Label197.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label197.Location = new System.Drawing.Point(51, 282);
            this.Label197.Name = "Label197";
            this.Label197.Size = new System.Drawing.Size(38, 20);
            this.Label197.TabIndex = 250;
            this.Label197.Text = "197";
            this.Label197.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label196
            // 
            this.Label196.BackColor = System.Drawing.Color.White;
            this.Label196.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label196.ContextMenuStrip = this.contextMenuStrip1;
            this.Label196.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label196.Location = new System.Drawing.Point(10, 282);
            this.Label196.Name = "Label196";
            this.Label196.Size = new System.Drawing.Size(38, 20);
            this.Label196.TabIndex = 249;
            this.Label196.Text = "196";
            this.Label196.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label195
            // 
            this.Label195.BackColor = System.Drawing.Color.White;
            this.Label195.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label195.ContextMenuStrip = this.contextMenuStrip1;
            this.Label195.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label195.Location = new System.Drawing.Point(92, 261);
            this.Label195.Name = "Label195";
            this.Label195.Size = new System.Drawing.Size(38, 20);
            this.Label195.TabIndex = 248;
            this.Label195.Text = "195";
            this.Label195.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label194
            // 
            this.Label194.BackColor = System.Drawing.Color.White;
            this.Label194.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label194.ContextMenuStrip = this.contextMenuStrip1;
            this.Label194.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label194.Location = new System.Drawing.Point(51, 261);
            this.Label194.Name = "Label194";
            this.Label194.Size = new System.Drawing.Size(38, 20);
            this.Label194.TabIndex = 247;
            this.Label194.Text = "194";
            this.Label194.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label193
            // 
            this.Label193.BackColor = System.Drawing.Color.White;
            this.Label193.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label193.ContextMenuStrip = this.contextMenuStrip1;
            this.Label193.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label193.Location = new System.Drawing.Point(10, 261);
            this.Label193.Name = "Label193";
            this.Label193.Size = new System.Drawing.Size(38, 20);
            this.Label193.TabIndex = 246;
            this.Label193.Text = "193";
            this.Label193.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label192
            // 
            this.Label192.BackColor = System.Drawing.Color.White;
            this.Label192.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label192.ContextMenuStrip = this.contextMenuStrip1;
            this.Label192.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label192.Location = new System.Drawing.Point(92, 233);
            this.Label192.Name = "Label192";
            this.Label192.Size = new System.Drawing.Size(38, 20);
            this.Label192.TabIndex = 245;
            this.Label192.Text = "192";
            this.Label192.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label191
            // 
            this.Label191.BackColor = System.Drawing.Color.White;
            this.Label191.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label191.ContextMenuStrip = this.contextMenuStrip1;
            this.Label191.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label191.Location = new System.Drawing.Point(51, 233);
            this.Label191.Name = "Label191";
            this.Label191.Size = new System.Drawing.Size(38, 20);
            this.Label191.TabIndex = 244;
            this.Label191.Text = "191";
            this.Label191.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label190
            // 
            this.Label190.BackColor = System.Drawing.Color.White;
            this.Label190.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label190.ContextMenuStrip = this.contextMenuStrip1;
            this.Label190.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label190.Location = new System.Drawing.Point(10, 233);
            this.Label190.Name = "Label190";
            this.Label190.Size = new System.Drawing.Size(38, 20);
            this.Label190.TabIndex = 243;
            this.Label190.Text = "190";
            this.Label190.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label189
            // 
            this.Label189.BackColor = System.Drawing.Color.White;
            this.Label189.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label189.ContextMenuStrip = this.contextMenuStrip1;
            this.Label189.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label189.Location = new System.Drawing.Point(92, 212);
            this.Label189.Name = "Label189";
            this.Label189.Size = new System.Drawing.Size(38, 20);
            this.Label189.TabIndex = 242;
            this.Label189.Text = "189";
            this.Label189.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label188
            // 
            this.Label188.BackColor = System.Drawing.Color.White;
            this.Label188.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label188.ContextMenuStrip = this.contextMenuStrip1;
            this.Label188.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label188.Location = new System.Drawing.Point(51, 212);
            this.Label188.Name = "Label188";
            this.Label188.Size = new System.Drawing.Size(38, 20);
            this.Label188.TabIndex = 241;
            this.Label188.Text = "188";
            this.Label188.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label187
            // 
            this.Label187.BackColor = System.Drawing.Color.White;
            this.Label187.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label187.ContextMenuStrip = this.contextMenuStrip1;
            this.Label187.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label187.Location = new System.Drawing.Point(10, 212);
            this.Label187.Name = "Label187";
            this.Label187.Size = new System.Drawing.Size(38, 20);
            this.Label187.TabIndex = 240;
            this.Label187.Text = "187";
            this.Label187.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label186
            // 
            this.Label186.BackColor = System.Drawing.Color.White;
            this.Label186.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label186.ContextMenuStrip = this.contextMenuStrip1;
            this.Label186.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label186.Location = new System.Drawing.Point(92, 184);
            this.Label186.Name = "Label186";
            this.Label186.Size = new System.Drawing.Size(38, 20);
            this.Label186.TabIndex = 239;
            this.Label186.Text = "186";
            this.Label186.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label185
            // 
            this.Label185.BackColor = System.Drawing.Color.White;
            this.Label185.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label185.ContextMenuStrip = this.contextMenuStrip1;
            this.Label185.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label185.Location = new System.Drawing.Point(51, 184);
            this.Label185.Name = "Label185";
            this.Label185.Size = new System.Drawing.Size(38, 20);
            this.Label185.TabIndex = 238;
            this.Label185.Text = "185";
            this.Label185.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label184
            // 
            this.Label184.BackColor = System.Drawing.Color.White;
            this.Label184.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label184.ContextMenuStrip = this.contextMenuStrip1;
            this.Label184.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label184.Location = new System.Drawing.Point(10, 184);
            this.Label184.Name = "Label184";
            this.Label184.Size = new System.Drawing.Size(38, 20);
            this.Label184.TabIndex = 237;
            this.Label184.Text = "184";
            this.Label184.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label183
            // 
            this.Label183.BackColor = System.Drawing.Color.White;
            this.Label183.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label183.ContextMenuStrip = this.contextMenuStrip1;
            this.Label183.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label183.Location = new System.Drawing.Point(92, 163);
            this.Label183.Name = "Label183";
            this.Label183.Size = new System.Drawing.Size(38, 20);
            this.Label183.TabIndex = 236;
            this.Label183.Text = "183";
            this.Label183.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label182
            // 
            this.Label182.BackColor = System.Drawing.Color.White;
            this.Label182.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label182.ContextMenuStrip = this.contextMenuStrip1;
            this.Label182.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label182.Location = new System.Drawing.Point(51, 163);
            this.Label182.Name = "Label182";
            this.Label182.Size = new System.Drawing.Size(38, 20);
            this.Label182.TabIndex = 235;
            this.Label182.Text = "182";
            this.Label182.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label181
            // 
            this.Label181.BackColor = System.Drawing.Color.White;
            this.Label181.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label181.ContextMenuStrip = this.contextMenuStrip1;
            this.Label181.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label181.Location = new System.Drawing.Point(10, 163);
            this.Label181.Name = "Label181";
            this.Label181.Size = new System.Drawing.Size(38, 20);
            this.Label181.TabIndex = 234;
            this.Label181.Text = "181";
            this.Label181.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label180
            // 
            this.Label180.BackColor = System.Drawing.Color.White;
            this.Label180.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label180.ContextMenuStrip = this.contextMenuStrip1;
            this.Label180.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label180.Location = new System.Drawing.Point(92, 135);
            this.Label180.Name = "Label180";
            this.Label180.Size = new System.Drawing.Size(38, 20);
            this.Label180.TabIndex = 233;
            this.Label180.Text = "180";
            this.Label180.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label179
            // 
            this.Label179.BackColor = System.Drawing.Color.White;
            this.Label179.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label179.ContextMenuStrip = this.contextMenuStrip1;
            this.Label179.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label179.Location = new System.Drawing.Point(51, 135);
            this.Label179.Name = "Label179";
            this.Label179.Size = new System.Drawing.Size(38, 20);
            this.Label179.TabIndex = 232;
            this.Label179.Text = "179";
            this.Label179.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label178
            // 
            this.Label178.BackColor = System.Drawing.Color.White;
            this.Label178.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label178.ContextMenuStrip = this.contextMenuStrip1;
            this.Label178.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label178.Location = new System.Drawing.Point(10, 135);
            this.Label178.Name = "Label178";
            this.Label178.Size = new System.Drawing.Size(38, 20);
            this.Label178.TabIndex = 231;
            this.Label178.Text = "178";
            this.Label178.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label177
            // 
            this.Label177.BackColor = System.Drawing.Color.White;
            this.Label177.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label177.ContextMenuStrip = this.contextMenuStrip1;
            this.Label177.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label177.Location = new System.Drawing.Point(92, 114);
            this.Label177.Name = "Label177";
            this.Label177.Size = new System.Drawing.Size(38, 20);
            this.Label177.TabIndex = 230;
            this.Label177.Text = "177";
            this.Label177.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label176
            // 
            this.Label176.BackColor = System.Drawing.Color.White;
            this.Label176.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label176.ContextMenuStrip = this.contextMenuStrip1;
            this.Label176.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label176.Location = new System.Drawing.Point(51, 114);
            this.Label176.Name = "Label176";
            this.Label176.Size = new System.Drawing.Size(38, 20);
            this.Label176.TabIndex = 229;
            this.Label176.Text = "176";
            this.Label176.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label175
            // 
            this.Label175.BackColor = System.Drawing.Color.White;
            this.Label175.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label175.ContextMenuStrip = this.contextMenuStrip1;
            this.Label175.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label175.Location = new System.Drawing.Point(10, 114);
            this.Label175.Name = "Label175";
            this.Label175.Size = new System.Drawing.Size(38, 20);
            this.Label175.TabIndex = 228;
            this.Label175.Text = "175";
            this.Label175.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label174
            // 
            this.Label174.BackColor = System.Drawing.Color.White;
            this.Label174.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label174.ContextMenuStrip = this.contextMenuStrip1;
            this.Label174.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label174.Location = new System.Drawing.Point(92, 86);
            this.Label174.Name = "Label174";
            this.Label174.Size = new System.Drawing.Size(38, 20);
            this.Label174.TabIndex = 227;
            this.Label174.Text = "174";
            this.Label174.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label173
            // 
            this.Label173.BackColor = System.Drawing.Color.White;
            this.Label173.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label173.ContextMenuStrip = this.contextMenuStrip1;
            this.Label173.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label173.Location = new System.Drawing.Point(51, 86);
            this.Label173.Name = "Label173";
            this.Label173.Size = new System.Drawing.Size(38, 20);
            this.Label173.TabIndex = 226;
            this.Label173.Text = "173";
            this.Label173.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label172
            // 
            this.Label172.BackColor = System.Drawing.Color.White;
            this.Label172.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label172.ContextMenuStrip = this.contextMenuStrip1;
            this.Label172.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label172.Location = new System.Drawing.Point(10, 86);
            this.Label172.Name = "Label172";
            this.Label172.Size = new System.Drawing.Size(38, 20);
            this.Label172.TabIndex = 225;
            this.Label172.Text = "172";
            this.Label172.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label171
            // 
            this.Label171.BackColor = System.Drawing.Color.White;
            this.Label171.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label171.ContextMenuStrip = this.contextMenuStrip1;
            this.Label171.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label171.Location = new System.Drawing.Point(92, 65);
            this.Label171.Name = "Label171";
            this.Label171.Size = new System.Drawing.Size(38, 20);
            this.Label171.TabIndex = 224;
            this.Label171.Text = "171";
            this.Label171.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label170
            // 
            this.Label170.BackColor = System.Drawing.Color.White;
            this.Label170.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label170.ContextMenuStrip = this.contextMenuStrip1;
            this.Label170.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label170.Location = new System.Drawing.Point(51, 65);
            this.Label170.Name = "Label170";
            this.Label170.Size = new System.Drawing.Size(38, 20);
            this.Label170.TabIndex = 223;
            this.Label170.Text = "170";
            this.Label170.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label169
            // 
            this.Label169.BackColor = System.Drawing.Color.White;
            this.Label169.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label169.ContextMenuStrip = this.contextMenuStrip1;
            this.Label169.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label169.Location = new System.Drawing.Point(10, 65);
            this.Label169.Name = "Label169";
            this.Label169.Size = new System.Drawing.Size(38, 20);
            this.Label169.TabIndex = 222;
            this.Label169.Text = "169";
            this.Label169.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label168
            // 
            this.Label168.BackColor = System.Drawing.Color.White;
            this.Label168.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label168.ContextMenuStrip = this.contextMenuStrip1;
            this.Label168.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label168.Location = new System.Drawing.Point(92, 37);
            this.Label168.Name = "Label168";
            this.Label168.Size = new System.Drawing.Size(38, 20);
            this.Label168.TabIndex = 221;
            this.Label168.Text = "168";
            this.Label168.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label167
            // 
            this.Label167.BackColor = System.Drawing.Color.White;
            this.Label167.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label167.ContextMenuStrip = this.contextMenuStrip1;
            this.Label167.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label167.Location = new System.Drawing.Point(51, 37);
            this.Label167.Name = "Label167";
            this.Label167.Size = new System.Drawing.Size(38, 20);
            this.Label167.TabIndex = 220;
            this.Label167.Text = "167";
            this.Label167.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label166
            // 
            this.Label166.BackColor = System.Drawing.Color.White;
            this.Label166.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label166.ContextMenuStrip = this.contextMenuStrip1;
            this.Label166.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label166.Location = new System.Drawing.Point(10, 37);
            this.Label166.Name = "Label166";
            this.Label166.Size = new System.Drawing.Size(38, 20);
            this.Label166.TabIndex = 219;
            this.Label166.Text = "166";
            this.Label166.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label165
            // 
            this.Label165.BackColor = System.Drawing.Color.White;
            this.Label165.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label165.ContextMenuStrip = this.contextMenuStrip1;
            this.Label165.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label165.Location = new System.Drawing.Point(92, 16);
            this.Label165.Name = "Label165";
            this.Label165.Size = new System.Drawing.Size(38, 20);
            this.Label165.TabIndex = 218;
            this.Label165.Text = "165";
            this.Label165.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label164
            // 
            this.Label164.BackColor = System.Drawing.Color.White;
            this.Label164.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label164.ContextMenuStrip = this.contextMenuStrip1;
            this.Label164.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label164.Location = new System.Drawing.Point(51, 16);
            this.Label164.Name = "Label164";
            this.Label164.Size = new System.Drawing.Size(38, 20);
            this.Label164.TabIndex = 217;
            this.Label164.Text = "164";
            this.Label164.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label163
            // 
            this.Label163.BackColor = System.Drawing.Color.White;
            this.Label163.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label163.ContextMenuStrip = this.contextMenuStrip1;
            this.Label163.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label163.Location = new System.Drawing.Point(10, 16);
            this.Label163.Name = "Label163";
            this.Label163.Size = new System.Drawing.Size(38, 20);
            this.Label163.TabIndex = 216;
            this.Label163.Text = "163";
            this.Label163.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label54);
            this.GroupBox1.Controls.Add(this.Label53);
            this.GroupBox1.Controls.Add(this.Label52);
            this.GroupBox1.Controls.Add(this.Label51);
            this.GroupBox1.Controls.Add(this.Label50);
            this.GroupBox1.Controls.Add(this.Label49);
            this.GroupBox1.Controls.Add(this.Label48);
            this.GroupBox1.Controls.Add(this.Label47);
            this.GroupBox1.Controls.Add(this.Label46);
            this.GroupBox1.Controls.Add(this.Label45);
            this.GroupBox1.Controls.Add(this.Label44);
            this.GroupBox1.Controls.Add(this.Label43);
            this.GroupBox1.Controls.Add(this.Label42);
            this.GroupBox1.Controls.Add(this.Label41);
            this.GroupBox1.Controls.Add(this.Label40);
            this.GroupBox1.Controls.Add(this.Label39);
            this.GroupBox1.Controls.Add(this.Label38);
            this.GroupBox1.Controls.Add(this.Label37);
            this.GroupBox1.Controls.Add(this.Label36);
            this.GroupBox1.Controls.Add(this.Label35);
            this.GroupBox1.Controls.Add(this.Label34);
            this.GroupBox1.Controls.Add(this.Label33);
            this.GroupBox1.Controls.Add(this.Label32);
            this.GroupBox1.Controls.Add(this.Label31);
            this.GroupBox1.Controls.Add(this.Label30);
            this.GroupBox1.Controls.Add(this.Label29);
            this.GroupBox1.Controls.Add(this.Label28);
            this.GroupBox1.Controls.Add(this.Label27);
            this.GroupBox1.Controls.Add(this.Label26);
            this.GroupBox1.Controls.Add(this.Label25);
            this.GroupBox1.Controls.Add(this.Label24);
            this.GroupBox1.Controls.Add(this.Label23);
            this.GroupBox1.Controls.Add(this.Label22);
            this.GroupBox1.Controls.Add(this.Label21);
            this.GroupBox1.Controls.Add(this.Label20);
            this.GroupBox1.Controls.Add(this.Label19);
            this.GroupBox1.Controls.Add(this.Label18);
            this.GroupBox1.Controls.Add(this.Label17);
            this.GroupBox1.Controls.Add(this.Label16);
            this.GroupBox1.Controls.Add(this.Label15);
            this.GroupBox1.Controls.Add(this.Label14);
            this.GroupBox1.Controls.Add(this.Label13);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(350, 157);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(142, 460);
            this.GroupBox1.TabIndex = 275;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = " Side 1 ";
            // 
            // Label54
            // 
            this.Label54.BackColor = System.Drawing.Color.White;
            this.Label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label54.ContextMenuStrip = this.contextMenuStrip1;
            this.Label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label54.Location = new System.Drawing.Point(94, 431);
            this.Label54.Name = "Label54";
            this.Label54.Size = new System.Drawing.Size(40, 20);
            this.Label54.TabIndex = 107;
            this.Label54.Text = "54";
            this.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label53
            // 
            this.Label53.BackColor = System.Drawing.Color.White;
            this.Label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label53.ContextMenuStrip = this.contextMenuStrip1;
            this.Label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label53.Location = new System.Drawing.Point(51, 431);
            this.Label53.Name = "Label53";
            this.Label53.Size = new System.Drawing.Size(40, 20);
            this.Label53.TabIndex = 106;
            this.Label53.Text = "53";
            this.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label52
            // 
            this.Label52.BackColor = System.Drawing.Color.White;
            this.Label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label52.ContextMenuStrip = this.contextMenuStrip1;
            this.Label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label52.Location = new System.Drawing.Point(8, 431);
            this.Label52.Name = "Label52";
            this.Label52.Size = new System.Drawing.Size(40, 20);
            this.Label52.TabIndex = 105;
            this.Label52.Text = "52";
            this.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label51
            // 
            this.Label51.BackColor = System.Drawing.Color.White;
            this.Label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label51.ContextMenuStrip = this.contextMenuStrip1;
            this.Label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label51.Location = new System.Drawing.Point(94, 410);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(40, 20);
            this.Label51.TabIndex = 104;
            this.Label51.Text = "51";
            this.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label50
            // 
            this.Label50.BackColor = System.Drawing.Color.White;
            this.Label50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label50.ContextMenuStrip = this.contextMenuStrip1;
            this.Label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label50.Location = new System.Drawing.Point(51, 410);
            this.Label50.Name = "Label50";
            this.Label50.Size = new System.Drawing.Size(40, 20);
            this.Label50.TabIndex = 103;
            this.Label50.Text = "50";
            this.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label49
            // 
            this.Label49.BackColor = System.Drawing.Color.White;
            this.Label49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label49.ContextMenuStrip = this.contextMenuStrip1;
            this.Label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label49.Location = new System.Drawing.Point(8, 410);
            this.Label49.Name = "Label49";
            this.Label49.Size = new System.Drawing.Size(40, 20);
            this.Label49.TabIndex = 102;
            this.Label49.Text = "49";
            this.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label48
            // 
            this.Label48.BackColor = System.Drawing.Color.White;
            this.Label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label48.ContextMenuStrip = this.contextMenuStrip1;
            this.Label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label48.Location = new System.Drawing.Point(94, 382);
            this.Label48.Name = "Label48";
            this.Label48.Size = new System.Drawing.Size(40, 20);
            this.Label48.TabIndex = 101;
            this.Label48.Text = "48";
            this.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label47
            // 
            this.Label47.BackColor = System.Drawing.Color.White;
            this.Label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label47.ContextMenuStrip = this.contextMenuStrip1;
            this.Label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label47.Location = new System.Drawing.Point(51, 382);
            this.Label47.Name = "Label47";
            this.Label47.Size = new System.Drawing.Size(40, 20);
            this.Label47.TabIndex = 100;
            this.Label47.Text = "47";
            this.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label46
            // 
            this.Label46.BackColor = System.Drawing.Color.White;
            this.Label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label46.ContextMenuStrip = this.contextMenuStrip1;
            this.Label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label46.Location = new System.Drawing.Point(8, 382);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(40, 20);
            this.Label46.TabIndex = 99;
            this.Label46.Text = "46";
            this.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label45
            // 
            this.Label45.BackColor = System.Drawing.Color.White;
            this.Label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label45.ContextMenuStrip = this.contextMenuStrip1;
            this.Label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label45.Location = new System.Drawing.Point(94, 361);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(40, 20);
            this.Label45.TabIndex = 98;
            this.Label45.Text = "45";
            this.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label44
            // 
            this.Label44.BackColor = System.Drawing.Color.White;
            this.Label44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label44.ContextMenuStrip = this.contextMenuStrip1;
            this.Label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label44.Location = new System.Drawing.Point(51, 361);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(40, 20);
            this.Label44.TabIndex = 97;
            this.Label44.Text = "44";
            this.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label43
            // 
            this.Label43.BackColor = System.Drawing.Color.White;
            this.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label43.ContextMenuStrip = this.contextMenuStrip1;
            this.Label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label43.Location = new System.Drawing.Point(8, 361);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(40, 20);
            this.Label43.TabIndex = 96;
            this.Label43.Text = "43";
            this.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label42
            // 
            this.Label42.BackColor = System.Drawing.Color.White;
            this.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label42.ContextMenuStrip = this.contextMenuStrip1;
            this.Label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label42.Location = new System.Drawing.Point(94, 333);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(40, 20);
            this.Label42.TabIndex = 95;
            this.Label42.Text = "42";
            this.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label41
            // 
            this.Label41.BackColor = System.Drawing.Color.White;
            this.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label41.ContextMenuStrip = this.contextMenuStrip1;
            this.Label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label41.Location = new System.Drawing.Point(51, 333);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(40, 20);
            this.Label41.TabIndex = 94;
            this.Label41.Text = "41";
            this.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label40
            // 
            this.Label40.BackColor = System.Drawing.Color.White;
            this.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label40.ContextMenuStrip = this.contextMenuStrip1;
            this.Label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label40.Location = new System.Drawing.Point(8, 333);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(40, 20);
            this.Label40.TabIndex = 93;
            this.Label40.Text = "40";
            this.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label39
            // 
            this.Label39.BackColor = System.Drawing.Color.White;
            this.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label39.ContextMenuStrip = this.contextMenuStrip1;
            this.Label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label39.Location = new System.Drawing.Point(94, 312);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(40, 20);
            this.Label39.TabIndex = 92;
            this.Label39.Text = "39";
            this.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label38
            // 
            this.Label38.BackColor = System.Drawing.Color.White;
            this.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label38.ContextMenuStrip = this.contextMenuStrip1;
            this.Label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label38.Location = new System.Drawing.Point(51, 312);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(40, 20);
            this.Label38.TabIndex = 91;
            this.Label38.Text = "38";
            this.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label37
            // 
            this.Label37.BackColor = System.Drawing.Color.White;
            this.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label37.ContextMenuStrip = this.contextMenuStrip1;
            this.Label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label37.Location = new System.Drawing.Point(8, 312);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(40, 20);
            this.Label37.TabIndex = 90;
            this.Label37.Text = "37";
            this.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label36
            // 
            this.Label36.BackColor = System.Drawing.Color.White;
            this.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label36.ContextMenuStrip = this.contextMenuStrip1;
            this.Label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label36.Location = new System.Drawing.Point(94, 284);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(40, 20);
            this.Label36.TabIndex = 89;
            this.Label36.Text = "36";
            this.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label35
            // 
            this.Label35.BackColor = System.Drawing.Color.White;
            this.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label35.ContextMenuStrip = this.contextMenuStrip1;
            this.Label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label35.Location = new System.Drawing.Point(51, 284);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(40, 20);
            this.Label35.TabIndex = 88;
            this.Label35.Text = "35";
            this.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label34
            // 
            this.Label34.BackColor = System.Drawing.Color.White;
            this.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label34.ContextMenuStrip = this.contextMenuStrip1;
            this.Label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label34.Location = new System.Drawing.Point(8, 284);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(40, 20);
            this.Label34.TabIndex = 87;
            this.Label34.Text = "34";
            this.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label33
            // 
            this.Label33.BackColor = System.Drawing.Color.White;
            this.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label33.ContextMenuStrip = this.contextMenuStrip1;
            this.Label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label33.Location = new System.Drawing.Point(94, 263);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(40, 20);
            this.Label33.TabIndex = 86;
            this.Label33.Text = "33";
            this.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label32
            // 
            this.Label32.BackColor = System.Drawing.Color.White;
            this.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label32.ContextMenuStrip = this.contextMenuStrip1;
            this.Label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label32.Location = new System.Drawing.Point(51, 263);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(40, 20);
            this.Label32.TabIndex = 85;
            this.Label32.Text = "32";
            this.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label31
            // 
            this.Label31.BackColor = System.Drawing.Color.White;
            this.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label31.ContextMenuStrip = this.contextMenuStrip1;
            this.Label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label31.Location = new System.Drawing.Point(8, 263);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(40, 20);
            this.Label31.TabIndex = 84;
            this.Label31.Text = "31";
            this.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label30
            // 
            this.Label30.BackColor = System.Drawing.Color.White;
            this.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label30.ContextMenuStrip = this.contextMenuStrip1;
            this.Label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label30.Location = new System.Drawing.Point(94, 235);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(40, 20);
            this.Label30.TabIndex = 83;
            this.Label30.Text = "30";
            this.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label29
            // 
            this.Label29.BackColor = System.Drawing.Color.White;
            this.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label29.ContextMenuStrip = this.contextMenuStrip1;
            this.Label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label29.Location = new System.Drawing.Point(51, 235);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(40, 20);
            this.Label29.TabIndex = 82;
            this.Label29.Text = "29";
            this.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label28
            // 
            this.Label28.BackColor = System.Drawing.Color.White;
            this.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label28.ContextMenuStrip = this.contextMenuStrip1;
            this.Label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label28.Location = new System.Drawing.Point(8, 235);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(40, 20);
            this.Label28.TabIndex = 81;
            this.Label28.Text = "28";
            this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label27
            // 
            this.Label27.BackColor = System.Drawing.Color.White;
            this.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label27.ContextMenuStrip = this.contextMenuStrip1;
            this.Label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label27.Location = new System.Drawing.Point(94, 214);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(40, 20);
            this.Label27.TabIndex = 80;
            this.Label27.Text = "27";
            this.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label26
            // 
            this.Label26.BackColor = System.Drawing.Color.White;
            this.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label26.ContextMenuStrip = this.contextMenuStrip1;
            this.Label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label26.Location = new System.Drawing.Point(51, 214);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(40, 20);
            this.Label26.TabIndex = 79;
            this.Label26.Text = "26";
            this.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label25
            // 
            this.Label25.BackColor = System.Drawing.Color.White;
            this.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label25.ContextMenuStrip = this.contextMenuStrip1;
            this.Label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label25.Location = new System.Drawing.Point(8, 214);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(40, 20);
            this.Label25.TabIndex = 78;
            this.Label25.Text = "25";
            this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label24
            // 
            this.Label24.BackColor = System.Drawing.Color.White;
            this.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label24.ContextMenuStrip = this.contextMenuStrip1;
            this.Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label24.Location = new System.Drawing.Point(94, 186);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(40, 20);
            this.Label24.TabIndex = 77;
            this.Label24.Text = "24";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label23
            // 
            this.Label23.BackColor = System.Drawing.Color.White;
            this.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label23.ContextMenuStrip = this.contextMenuStrip1;
            this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label23.Location = new System.Drawing.Point(51, 186);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(40, 20);
            this.Label23.TabIndex = 76;
            this.Label23.Text = "23";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label22
            // 
            this.Label22.BackColor = System.Drawing.Color.White;
            this.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label22.ContextMenuStrip = this.contextMenuStrip1;
            this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label22.Location = new System.Drawing.Point(8, 186);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(40, 20);
            this.Label22.TabIndex = 75;
            this.Label22.Text = "22";
            this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label21
            // 
            this.Label21.BackColor = System.Drawing.Color.White;
            this.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label21.ContextMenuStrip = this.contextMenuStrip1;
            this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label21.Location = new System.Drawing.Point(94, 165);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(40, 20);
            this.Label21.TabIndex = 74;
            this.Label21.Text = "21";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label20
            // 
            this.Label20.BackColor = System.Drawing.Color.White;
            this.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label20.ContextMenuStrip = this.contextMenuStrip1;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label20.Location = new System.Drawing.Point(51, 165);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(40, 20);
            this.Label20.TabIndex = 73;
            this.Label20.Text = "20";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label19
            // 
            this.Label19.BackColor = System.Drawing.Color.White;
            this.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label19.ContextMenuStrip = this.contextMenuStrip1;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label19.Location = new System.Drawing.Point(8, 165);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(40, 20);
            this.Label19.TabIndex = 72;
            this.Label19.Text = "19";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.White;
            this.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label18.ContextMenuStrip = this.contextMenuStrip1;
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label18.Location = new System.Drawing.Point(94, 137);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(40, 20);
            this.Label18.TabIndex = 71;
            this.Label18.Text = "18";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.Color.White;
            this.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label17.ContextMenuStrip = this.contextMenuStrip1;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label17.Location = new System.Drawing.Point(51, 137);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(40, 20);
            this.Label17.TabIndex = 70;
            this.Label17.Text = "17";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.White;
            this.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label16.ContextMenuStrip = this.contextMenuStrip1;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label16.Location = new System.Drawing.Point(8, 137);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(40, 20);
            this.Label16.TabIndex = 69;
            this.Label16.Text = "16";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.White;
            this.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label15.ContextMenuStrip = this.contextMenuStrip1;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label15.Location = new System.Drawing.Point(94, 116);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(40, 20);
            this.Label15.TabIndex = 68;
            this.Label15.Text = "15";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.White;
            this.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label14.ContextMenuStrip = this.contextMenuStrip1;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label14.Location = new System.Drawing.Point(51, 116);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(40, 20);
            this.Label14.TabIndex = 67;
            this.Label14.Text = "14";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.White;
            this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label13.ContextMenuStrip = this.contextMenuStrip1;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label13.Location = new System.Drawing.Point(8, 116);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(40, 20);
            this.Label13.TabIndex = 66;
            this.Label13.Text = "13";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.White;
            this.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label12.ContextMenuStrip = this.contextMenuStrip1;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label12.Location = new System.Drawing.Point(94, 88);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(40, 20);
            this.Label12.TabIndex = 65;
            this.Label12.Text = "12";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.White;
            this.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label11.ContextMenuStrip = this.contextMenuStrip1;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label11.Location = new System.Drawing.Point(51, 88);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(40, 20);
            this.Label11.TabIndex = 64;
            this.Label11.Text = "11";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.White;
            this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label10.ContextMenuStrip = this.contextMenuStrip1;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label10.Location = new System.Drawing.Point(8, 88);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(40, 20);
            this.Label10.TabIndex = 63;
            this.Label10.Text = "10";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label9.ContextMenuStrip = this.contextMenuStrip1;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label9.Location = new System.Drawing.Point(94, 67);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(40, 20);
            this.Label9.TabIndex = 62;
            this.Label9.Text = "9";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label8.ContextMenuStrip = this.contextMenuStrip1;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label8.Location = new System.Drawing.Point(51, 67);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(40, 20);
            this.Label8.TabIndex = 61;
            this.Label8.Text = "8";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label7.ContextMenuStrip = this.contextMenuStrip1;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label7.Location = new System.Drawing.Point(8, 67);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(40, 20);
            this.Label7.TabIndex = 60;
            this.Label7.Text = "7";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label6.ContextMenuStrip = this.contextMenuStrip1;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label6.Location = new System.Drawing.Point(94, 39);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(40, 20);
            this.Label6.TabIndex = 59;
            this.Label6.Text = "6";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.ContextMenuStrip = this.contextMenuStrip1;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label5.Location = new System.Drawing.Point(51, 39);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(40, 20);
            this.Label5.TabIndex = 58;
            this.Label5.Text = "5";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.ContextMenuStrip = this.contextMenuStrip1;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label4.Location = new System.Drawing.Point(8, 39);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 20);
            this.Label4.TabIndex = 57;
            this.Label4.Text = "4";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.ContextMenuStrip = this.contextMenuStrip1;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label3.Location = new System.Drawing.Point(94, 18);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 20);
            this.Label3.TabIndex = 56;
            this.Label3.Text = "3";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.ContextMenuStrip = this.contextMenuStrip1;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label2.Location = new System.Drawing.Point(51, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 20);
            this.Label2.TabIndex = 55;
            this.Label2.Text = "2";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.ContextMenuStrip = this.contextMenuStrip1;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(8, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(40, 20);
            this.Label1.TabIndex = 54;
            this.Label1.Text = "1";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.Location = new System.Drawing.Point(1005, 16);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(226, 114);
            this.Button1.TabIndex = 263;
            this.Button1.Text = "View Blocked Slots";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Label217
            // 
            this.Label217.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label217.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label217.Location = new System.Drawing.Point(350, 91);
            this.Label217.Name = "Label217";
            this.Label217.Size = new System.Drawing.Size(649, 34);
            this.Label217.TabIndex = 265;
            this.Label217.Text = "CART:";
            this.Label217.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RichTextBox2
            // 
            this.RichTextBox2.Location = new System.Drawing.Point(350, 630);
            this.RichTextBox2.Name = "RichTextBox2";
            this.RichTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBox2.Size = new System.Drawing.Size(649, 56);
            this.RichTextBox2.TabIndex = 274;
            this.RichTextBox2.Text = "";
            // 
            // Label218
            // 
            this.Label218.AutoSize = true;
            this.Label218.Location = new System.Drawing.Point(19, 157);
            this.Label218.Name = "Label218";
            this.Label218.Size = new System.Drawing.Size(80, 13);
            this.Label218.TabIndex = 266;
            this.Label218.Text = "Product Codes:";
            // 
            // Label224
            // 
            this.Label224.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label224.Location = new System.Drawing.Point(157, 369);
            this.Label224.Name = "Label224";
            this.Label224.Size = new System.Drawing.Size(120, 40);
            this.Label224.TabIndex = 273;
            this.Label224.Text = "Status_5";
            this.Label224.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label223
            // 
            this.Label223.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label223.Location = new System.Drawing.Point(157, 320);
            this.Label223.Name = "Label223";
            this.Label223.Size = new System.Drawing.Size(120, 40);
            this.Label223.TabIndex = 272;
            this.Label223.Text = "Status_4";
            this.Label223.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label219
            // 
            this.Label219.AutoSize = true;
            this.Label219.Location = new System.Drawing.Point(155, 157);
            this.Label219.Name = "Label219";
            this.Label219.Size = new System.Drawing.Size(55, 13);
            this.Label219.TabIndex = 267;
            this.Label219.Text = "Color Key:";
            // 
            // Label221
            // 
            this.Label221.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label221.Location = new System.Drawing.Point(157, 224);
            this.Label221.Name = "Label221";
            this.Label221.Size = new System.Drawing.Size(120, 40);
            this.Label221.TabIndex = 270;
            this.Label221.Text = "Status_2";
            this.Label221.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label220
            // 
            this.Label220.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label220.Location = new System.Drawing.Point(157, 175);
            this.Label220.Name = "Label220";
            this.Label220.Size = new System.Drawing.Size(120, 40);
            this.Label220.TabIndex = 269;
            this.Label220.Text = "Status_1";
            this.Label220.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(18, 176);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(133, 471);
            this.RichTextBox1.TabIndex = 268;
            this.RichTextBox1.Text = "";
            // 
            // Label222
            // 
            this.Label222.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label222.Location = new System.Drawing.Point(157, 272);
            this.Label222.Name = "Label222";
            this.Label222.Size = new System.Drawing.Size(120, 40);
            this.Label222.TabIndex = 271;
            this.Label222.Text = "Status_3";
            this.Label222.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label162);
            this.GroupBox3.Controls.Add(this.Label161);
            this.GroupBox3.Controls.Add(this.Label160);
            this.GroupBox3.Controls.Add(this.Label159);
            this.GroupBox3.Controls.Add(this.Label158);
            this.GroupBox3.Controls.Add(this.Label157);
            this.GroupBox3.Controls.Add(this.Label156);
            this.GroupBox3.Controls.Add(this.Label155);
            this.GroupBox3.Controls.Add(this.Label154);
            this.GroupBox3.Controls.Add(this.Label153);
            this.GroupBox3.Controls.Add(this.Label152);
            this.GroupBox3.Controls.Add(this.Label151);
            this.GroupBox3.Controls.Add(this.Label150);
            this.GroupBox3.Controls.Add(this.Label149);
            this.GroupBox3.Controls.Add(this.Label148);
            this.GroupBox3.Controls.Add(this.Label147);
            this.GroupBox3.Controls.Add(this.Label146);
            this.GroupBox3.Controls.Add(this.Label145);
            this.GroupBox3.Controls.Add(this.Label144);
            this.GroupBox3.Controls.Add(this.Label143);
            this.GroupBox3.Controls.Add(this.Label142);
            this.GroupBox3.Controls.Add(this.Label141);
            this.GroupBox3.Controls.Add(this.Label140);
            this.GroupBox3.Controls.Add(this.Label139);
            this.GroupBox3.Controls.Add(this.Label138);
            this.GroupBox3.Controls.Add(this.Label137);
            this.GroupBox3.Controls.Add(this.Label136);
            this.GroupBox3.Controls.Add(this.Label135);
            this.GroupBox3.Controls.Add(this.Label134);
            this.GroupBox3.Controls.Add(this.Label133);
            this.GroupBox3.Controls.Add(this.Label132);
            this.GroupBox3.Controls.Add(this.Label131);
            this.GroupBox3.Controls.Add(this.Label130);
            this.GroupBox3.Controls.Add(this.Label129);
            this.GroupBox3.Controls.Add(this.Label128);
            this.GroupBox3.Controls.Add(this.Label127);
            this.GroupBox3.Controls.Add(this.Label126);
            this.GroupBox3.Controls.Add(this.Label125);
            this.GroupBox3.Controls.Add(this.Label124);
            this.GroupBox3.Controls.Add(this.Label123);
            this.GroupBox3.Controls.Add(this.Label122);
            this.GroupBox3.Controls.Add(this.Label121);
            this.GroupBox3.Controls.Add(this.Label120);
            this.GroupBox3.Controls.Add(this.Label119);
            this.GroupBox3.Controls.Add(this.Label118);
            this.GroupBox3.Controls.Add(this.Label117);
            this.GroupBox3.Controls.Add(this.Label116);
            this.GroupBox3.Controls.Add(this.Label115);
            this.GroupBox3.Controls.Add(this.Label114);
            this.GroupBox3.Controls.Add(this.Label113);
            this.GroupBox3.Controls.Add(this.Label112);
            this.GroupBox3.Controls.Add(this.Label111);
            this.GroupBox3.Controls.Add(this.Label110);
            this.GroupBox3.Controls.Add(this.Label109);
            this.GroupBox3.Location = new System.Drawing.Point(687, 157);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(142, 460);
            this.GroupBox3.TabIndex = 277;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = " Side 3 ";
            // 
            // Label162
            // 
            this.Label162.BackColor = System.Drawing.Color.White;
            this.Label162.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label162.ContextMenuStrip = this.contextMenuStrip1;
            this.Label162.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label162.Location = new System.Drawing.Point(94, 429);
            this.Label162.Name = "Label162";
            this.Label162.Size = new System.Drawing.Size(40, 20);
            this.Label162.TabIndex = 215;
            this.Label162.Text = "162";
            this.Label162.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label161
            // 
            this.Label161.BackColor = System.Drawing.Color.White;
            this.Label161.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label161.ContextMenuStrip = this.contextMenuStrip1;
            this.Label161.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label161.Location = new System.Drawing.Point(51, 429);
            this.Label161.Name = "Label161";
            this.Label161.Size = new System.Drawing.Size(40, 20);
            this.Label161.TabIndex = 214;
            this.Label161.Text = "161";
            this.Label161.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label160
            // 
            this.Label160.BackColor = System.Drawing.Color.White;
            this.Label160.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label160.ContextMenuStrip = this.contextMenuStrip1;
            this.Label160.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label160.Location = new System.Drawing.Point(8, 429);
            this.Label160.Name = "Label160";
            this.Label160.Size = new System.Drawing.Size(40, 20);
            this.Label160.TabIndex = 213;
            this.Label160.Text = "160";
            this.Label160.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label159
            // 
            this.Label159.BackColor = System.Drawing.Color.White;
            this.Label159.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label159.ContextMenuStrip = this.contextMenuStrip1;
            this.Label159.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label159.Location = new System.Drawing.Point(94, 408);
            this.Label159.Name = "Label159";
            this.Label159.Size = new System.Drawing.Size(40, 20);
            this.Label159.TabIndex = 212;
            this.Label159.Text = "159";
            this.Label159.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label158
            // 
            this.Label158.BackColor = System.Drawing.Color.White;
            this.Label158.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label158.ContextMenuStrip = this.contextMenuStrip1;
            this.Label158.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label158.Location = new System.Drawing.Point(51, 408);
            this.Label158.Name = "Label158";
            this.Label158.Size = new System.Drawing.Size(40, 20);
            this.Label158.TabIndex = 211;
            this.Label158.Text = "158";
            this.Label158.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label157
            // 
            this.Label157.BackColor = System.Drawing.Color.White;
            this.Label157.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label157.ContextMenuStrip = this.contextMenuStrip1;
            this.Label157.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label157.Location = new System.Drawing.Point(8, 408);
            this.Label157.Name = "Label157";
            this.Label157.Size = new System.Drawing.Size(40, 20);
            this.Label157.TabIndex = 210;
            this.Label157.Text = "157";
            this.Label157.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label156
            // 
            this.Label156.BackColor = System.Drawing.Color.White;
            this.Label156.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label156.ContextMenuStrip = this.contextMenuStrip1;
            this.Label156.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label156.Location = new System.Drawing.Point(94, 380);
            this.Label156.Name = "Label156";
            this.Label156.Size = new System.Drawing.Size(40, 20);
            this.Label156.TabIndex = 209;
            this.Label156.Text = "156";
            this.Label156.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label155
            // 
            this.Label155.BackColor = System.Drawing.Color.White;
            this.Label155.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label155.ContextMenuStrip = this.contextMenuStrip1;
            this.Label155.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label155.Location = new System.Drawing.Point(51, 380);
            this.Label155.Name = "Label155";
            this.Label155.Size = new System.Drawing.Size(40, 20);
            this.Label155.TabIndex = 208;
            this.Label155.Text = "155";
            this.Label155.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label154
            // 
            this.Label154.BackColor = System.Drawing.Color.White;
            this.Label154.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label154.ContextMenuStrip = this.contextMenuStrip1;
            this.Label154.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label154.Location = new System.Drawing.Point(8, 380);
            this.Label154.Name = "Label154";
            this.Label154.Size = new System.Drawing.Size(40, 20);
            this.Label154.TabIndex = 207;
            this.Label154.Text = "154";
            this.Label154.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label153
            // 
            this.Label153.BackColor = System.Drawing.Color.White;
            this.Label153.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label153.ContextMenuStrip = this.contextMenuStrip1;
            this.Label153.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label153.Location = new System.Drawing.Point(94, 359);
            this.Label153.Name = "Label153";
            this.Label153.Size = new System.Drawing.Size(40, 20);
            this.Label153.TabIndex = 206;
            this.Label153.Text = "153";
            this.Label153.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label152
            // 
            this.Label152.BackColor = System.Drawing.Color.White;
            this.Label152.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label152.ContextMenuStrip = this.contextMenuStrip1;
            this.Label152.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label152.Location = new System.Drawing.Point(51, 359);
            this.Label152.Name = "Label152";
            this.Label152.Size = new System.Drawing.Size(40, 20);
            this.Label152.TabIndex = 205;
            this.Label152.Text = "152";
            this.Label152.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label151
            // 
            this.Label151.BackColor = System.Drawing.Color.White;
            this.Label151.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label151.ContextMenuStrip = this.contextMenuStrip1;
            this.Label151.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label151.Location = new System.Drawing.Point(8, 359);
            this.Label151.Name = "Label151";
            this.Label151.Size = new System.Drawing.Size(40, 20);
            this.Label151.TabIndex = 204;
            this.Label151.Text = "151";
            this.Label151.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label150
            // 
            this.Label150.BackColor = System.Drawing.Color.White;
            this.Label150.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label150.ContextMenuStrip = this.contextMenuStrip1;
            this.Label150.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label150.Location = new System.Drawing.Point(94, 331);
            this.Label150.Name = "Label150";
            this.Label150.Size = new System.Drawing.Size(40, 20);
            this.Label150.TabIndex = 203;
            this.Label150.Text = "150";
            this.Label150.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label149
            // 
            this.Label149.BackColor = System.Drawing.Color.White;
            this.Label149.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label149.ContextMenuStrip = this.contextMenuStrip1;
            this.Label149.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label149.Location = new System.Drawing.Point(51, 331);
            this.Label149.Name = "Label149";
            this.Label149.Size = new System.Drawing.Size(40, 20);
            this.Label149.TabIndex = 202;
            this.Label149.Text = "149";
            this.Label149.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label148
            // 
            this.Label148.BackColor = System.Drawing.Color.White;
            this.Label148.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label148.ContextMenuStrip = this.contextMenuStrip1;
            this.Label148.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label148.Location = new System.Drawing.Point(8, 331);
            this.Label148.Name = "Label148";
            this.Label148.Size = new System.Drawing.Size(40, 20);
            this.Label148.TabIndex = 201;
            this.Label148.Text = "148";
            this.Label148.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label147
            // 
            this.Label147.BackColor = System.Drawing.Color.White;
            this.Label147.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label147.ContextMenuStrip = this.contextMenuStrip1;
            this.Label147.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label147.Location = new System.Drawing.Point(94, 310);
            this.Label147.Name = "Label147";
            this.Label147.Size = new System.Drawing.Size(40, 20);
            this.Label147.TabIndex = 200;
            this.Label147.Text = "147";
            this.Label147.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label146
            // 
            this.Label146.BackColor = System.Drawing.Color.White;
            this.Label146.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label146.ContextMenuStrip = this.contextMenuStrip1;
            this.Label146.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label146.Location = new System.Drawing.Point(51, 310);
            this.Label146.Name = "Label146";
            this.Label146.Size = new System.Drawing.Size(40, 20);
            this.Label146.TabIndex = 199;
            this.Label146.Text = "146";
            this.Label146.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label145
            // 
            this.Label145.BackColor = System.Drawing.Color.White;
            this.Label145.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label145.ContextMenuStrip = this.contextMenuStrip1;
            this.Label145.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label145.Location = new System.Drawing.Point(8, 310);
            this.Label145.Name = "Label145";
            this.Label145.Size = new System.Drawing.Size(40, 20);
            this.Label145.TabIndex = 198;
            this.Label145.Text = "145";
            this.Label145.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label144
            // 
            this.Label144.BackColor = System.Drawing.Color.White;
            this.Label144.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label144.ContextMenuStrip = this.contextMenuStrip1;
            this.Label144.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label144.Location = new System.Drawing.Point(94, 282);
            this.Label144.Name = "Label144";
            this.Label144.Size = new System.Drawing.Size(40, 20);
            this.Label144.TabIndex = 197;
            this.Label144.Text = "144";
            this.Label144.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label143
            // 
            this.Label143.BackColor = System.Drawing.Color.White;
            this.Label143.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label143.ContextMenuStrip = this.contextMenuStrip1;
            this.Label143.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label143.Location = new System.Drawing.Point(51, 282);
            this.Label143.Name = "Label143";
            this.Label143.Size = new System.Drawing.Size(40, 20);
            this.Label143.TabIndex = 196;
            this.Label143.Text = "143";
            this.Label143.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label142
            // 
            this.Label142.BackColor = System.Drawing.Color.White;
            this.Label142.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label142.ContextMenuStrip = this.contextMenuStrip1;
            this.Label142.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label142.Location = new System.Drawing.Point(8, 282);
            this.Label142.Name = "Label142";
            this.Label142.Size = new System.Drawing.Size(40, 20);
            this.Label142.TabIndex = 195;
            this.Label142.Text = "142";
            this.Label142.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label141
            // 
            this.Label141.BackColor = System.Drawing.Color.White;
            this.Label141.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label141.ContextMenuStrip = this.contextMenuStrip1;
            this.Label141.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label141.Location = new System.Drawing.Point(94, 261);
            this.Label141.Name = "Label141";
            this.Label141.Size = new System.Drawing.Size(40, 20);
            this.Label141.TabIndex = 194;
            this.Label141.Text = "141";
            this.Label141.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label140
            // 
            this.Label140.BackColor = System.Drawing.Color.White;
            this.Label140.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label140.ContextMenuStrip = this.contextMenuStrip1;
            this.Label140.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label140.Location = new System.Drawing.Point(51, 261);
            this.Label140.Name = "Label140";
            this.Label140.Size = new System.Drawing.Size(40, 20);
            this.Label140.TabIndex = 193;
            this.Label140.Text = "140";
            this.Label140.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label139
            // 
            this.Label139.BackColor = System.Drawing.Color.White;
            this.Label139.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label139.ContextMenuStrip = this.contextMenuStrip1;
            this.Label139.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label139.Location = new System.Drawing.Point(8, 261);
            this.Label139.Name = "Label139";
            this.Label139.Size = new System.Drawing.Size(40, 20);
            this.Label139.TabIndex = 192;
            this.Label139.Text = "139";
            this.Label139.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label138
            // 
            this.Label138.BackColor = System.Drawing.Color.White;
            this.Label138.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label138.ContextMenuStrip = this.contextMenuStrip1;
            this.Label138.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label138.Location = new System.Drawing.Point(94, 233);
            this.Label138.Name = "Label138";
            this.Label138.Size = new System.Drawing.Size(40, 20);
            this.Label138.TabIndex = 191;
            this.Label138.Text = "138";
            this.Label138.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label137
            // 
            this.Label137.BackColor = System.Drawing.Color.White;
            this.Label137.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label137.ContextMenuStrip = this.contextMenuStrip1;
            this.Label137.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label137.Location = new System.Drawing.Point(51, 233);
            this.Label137.Name = "Label137";
            this.Label137.Size = new System.Drawing.Size(40, 20);
            this.Label137.TabIndex = 190;
            this.Label137.Text = "137";
            this.Label137.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label136
            // 
            this.Label136.BackColor = System.Drawing.Color.White;
            this.Label136.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label136.ContextMenuStrip = this.contextMenuStrip1;
            this.Label136.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label136.Location = new System.Drawing.Point(8, 233);
            this.Label136.Name = "Label136";
            this.Label136.Size = new System.Drawing.Size(40, 20);
            this.Label136.TabIndex = 189;
            this.Label136.Text = "136";
            this.Label136.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label135
            // 
            this.Label135.BackColor = System.Drawing.Color.White;
            this.Label135.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label135.ContextMenuStrip = this.contextMenuStrip1;
            this.Label135.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label135.Location = new System.Drawing.Point(94, 212);
            this.Label135.Name = "Label135";
            this.Label135.Size = new System.Drawing.Size(40, 20);
            this.Label135.TabIndex = 188;
            this.Label135.Text = "135";
            this.Label135.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label134
            // 
            this.Label134.BackColor = System.Drawing.Color.White;
            this.Label134.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label134.ContextMenuStrip = this.contextMenuStrip1;
            this.Label134.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label134.Location = new System.Drawing.Point(51, 212);
            this.Label134.Name = "Label134";
            this.Label134.Size = new System.Drawing.Size(40, 20);
            this.Label134.TabIndex = 187;
            this.Label134.Text = "134";
            this.Label134.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label133
            // 
            this.Label133.BackColor = System.Drawing.Color.White;
            this.Label133.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label133.ContextMenuStrip = this.contextMenuStrip1;
            this.Label133.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label133.Location = new System.Drawing.Point(8, 212);
            this.Label133.Name = "Label133";
            this.Label133.Size = new System.Drawing.Size(40, 20);
            this.Label133.TabIndex = 186;
            this.Label133.Text = "133";
            this.Label133.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label132
            // 
            this.Label132.BackColor = System.Drawing.Color.White;
            this.Label132.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label132.ContextMenuStrip = this.contextMenuStrip1;
            this.Label132.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label132.Location = new System.Drawing.Point(94, 184);
            this.Label132.Name = "Label132";
            this.Label132.Size = new System.Drawing.Size(40, 20);
            this.Label132.TabIndex = 185;
            this.Label132.Text = "132";
            this.Label132.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label131
            // 
            this.Label131.BackColor = System.Drawing.Color.White;
            this.Label131.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label131.ContextMenuStrip = this.contextMenuStrip1;
            this.Label131.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label131.Location = new System.Drawing.Point(51, 184);
            this.Label131.Name = "Label131";
            this.Label131.Size = new System.Drawing.Size(40, 20);
            this.Label131.TabIndex = 184;
            this.Label131.Text = "131";
            this.Label131.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label130
            // 
            this.Label130.BackColor = System.Drawing.Color.White;
            this.Label130.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label130.ContextMenuStrip = this.contextMenuStrip1;
            this.Label130.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label130.Location = new System.Drawing.Point(8, 184);
            this.Label130.Name = "Label130";
            this.Label130.Size = new System.Drawing.Size(40, 20);
            this.Label130.TabIndex = 183;
            this.Label130.Text = "130";
            this.Label130.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label129
            // 
            this.Label129.BackColor = System.Drawing.Color.White;
            this.Label129.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label129.ContextMenuStrip = this.contextMenuStrip1;
            this.Label129.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label129.Location = new System.Drawing.Point(94, 163);
            this.Label129.Name = "Label129";
            this.Label129.Size = new System.Drawing.Size(40, 20);
            this.Label129.TabIndex = 182;
            this.Label129.Text = "129";
            this.Label129.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label128
            // 
            this.Label128.BackColor = System.Drawing.Color.White;
            this.Label128.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label128.ContextMenuStrip = this.contextMenuStrip1;
            this.Label128.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label128.Location = new System.Drawing.Point(51, 163);
            this.Label128.Name = "Label128";
            this.Label128.Size = new System.Drawing.Size(40, 20);
            this.Label128.TabIndex = 181;
            this.Label128.Text = "128";
            this.Label128.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label127
            // 
            this.Label127.BackColor = System.Drawing.Color.White;
            this.Label127.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label127.ContextMenuStrip = this.contextMenuStrip1;
            this.Label127.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label127.Location = new System.Drawing.Point(8, 163);
            this.Label127.Name = "Label127";
            this.Label127.Size = new System.Drawing.Size(40, 20);
            this.Label127.TabIndex = 180;
            this.Label127.Text = "127";
            this.Label127.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label126
            // 
            this.Label126.BackColor = System.Drawing.Color.White;
            this.Label126.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label126.ContextMenuStrip = this.contextMenuStrip1;
            this.Label126.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label126.Location = new System.Drawing.Point(94, 135);
            this.Label126.Name = "Label126";
            this.Label126.Size = new System.Drawing.Size(40, 20);
            this.Label126.TabIndex = 179;
            this.Label126.Text = "126";
            this.Label126.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label125
            // 
            this.Label125.BackColor = System.Drawing.Color.White;
            this.Label125.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label125.ContextMenuStrip = this.contextMenuStrip1;
            this.Label125.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label125.Location = new System.Drawing.Point(51, 135);
            this.Label125.Name = "Label125";
            this.Label125.Size = new System.Drawing.Size(40, 20);
            this.Label125.TabIndex = 178;
            this.Label125.Text = "125";
            this.Label125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label124
            // 
            this.Label124.BackColor = System.Drawing.Color.White;
            this.Label124.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label124.ContextMenuStrip = this.contextMenuStrip1;
            this.Label124.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label124.Location = new System.Drawing.Point(8, 135);
            this.Label124.Name = "Label124";
            this.Label124.Size = new System.Drawing.Size(40, 20);
            this.Label124.TabIndex = 177;
            this.Label124.Text = "124";
            this.Label124.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label123
            // 
            this.Label123.BackColor = System.Drawing.Color.White;
            this.Label123.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label123.ContextMenuStrip = this.contextMenuStrip1;
            this.Label123.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label123.Location = new System.Drawing.Point(94, 114);
            this.Label123.Name = "Label123";
            this.Label123.Size = new System.Drawing.Size(40, 20);
            this.Label123.TabIndex = 176;
            this.Label123.Text = "123";
            this.Label123.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label122
            // 
            this.Label122.BackColor = System.Drawing.Color.White;
            this.Label122.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label122.ContextMenuStrip = this.contextMenuStrip1;
            this.Label122.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label122.Location = new System.Drawing.Point(51, 114);
            this.Label122.Name = "Label122";
            this.Label122.Size = new System.Drawing.Size(40, 20);
            this.Label122.TabIndex = 175;
            this.Label122.Text = "122";
            this.Label122.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label121
            // 
            this.Label121.BackColor = System.Drawing.Color.White;
            this.Label121.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label121.ContextMenuStrip = this.contextMenuStrip1;
            this.Label121.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label121.Location = new System.Drawing.Point(8, 114);
            this.Label121.Name = "Label121";
            this.Label121.Size = new System.Drawing.Size(40, 20);
            this.Label121.TabIndex = 174;
            this.Label121.Text = "121";
            this.Label121.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label120
            // 
            this.Label120.BackColor = System.Drawing.Color.White;
            this.Label120.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label120.ContextMenuStrip = this.contextMenuStrip1;
            this.Label120.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label120.Location = new System.Drawing.Point(94, 86);
            this.Label120.Name = "Label120";
            this.Label120.Size = new System.Drawing.Size(40, 20);
            this.Label120.TabIndex = 173;
            this.Label120.Text = "120";
            this.Label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label119
            // 
            this.Label119.BackColor = System.Drawing.Color.White;
            this.Label119.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label119.ContextMenuStrip = this.contextMenuStrip1;
            this.Label119.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label119.Location = new System.Drawing.Point(51, 86);
            this.Label119.Name = "Label119";
            this.Label119.Size = new System.Drawing.Size(40, 20);
            this.Label119.TabIndex = 172;
            this.Label119.Text = "119";
            this.Label119.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label118
            // 
            this.Label118.BackColor = System.Drawing.Color.White;
            this.Label118.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label118.ContextMenuStrip = this.contextMenuStrip1;
            this.Label118.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label118.Location = new System.Drawing.Point(8, 86);
            this.Label118.Name = "Label118";
            this.Label118.Size = new System.Drawing.Size(40, 20);
            this.Label118.TabIndex = 171;
            this.Label118.Text = "118";
            this.Label118.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label117
            // 
            this.Label117.BackColor = System.Drawing.Color.White;
            this.Label117.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label117.ContextMenuStrip = this.contextMenuStrip1;
            this.Label117.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label117.Location = new System.Drawing.Point(94, 65);
            this.Label117.Name = "Label117";
            this.Label117.Size = new System.Drawing.Size(40, 20);
            this.Label117.TabIndex = 170;
            this.Label117.Text = "117";
            this.Label117.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label116
            // 
            this.Label116.BackColor = System.Drawing.Color.White;
            this.Label116.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label116.ContextMenuStrip = this.contextMenuStrip1;
            this.Label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label116.Location = new System.Drawing.Point(51, 65);
            this.Label116.Name = "Label116";
            this.Label116.Size = new System.Drawing.Size(40, 20);
            this.Label116.TabIndex = 169;
            this.Label116.Text = "116";
            this.Label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label115
            // 
            this.Label115.BackColor = System.Drawing.Color.White;
            this.Label115.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label115.ContextMenuStrip = this.contextMenuStrip1;
            this.Label115.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label115.Location = new System.Drawing.Point(8, 65);
            this.Label115.Name = "Label115";
            this.Label115.Size = new System.Drawing.Size(40, 20);
            this.Label115.TabIndex = 168;
            this.Label115.Text = "115";
            this.Label115.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label114
            // 
            this.Label114.BackColor = System.Drawing.Color.White;
            this.Label114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label114.ContextMenuStrip = this.contextMenuStrip1;
            this.Label114.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label114.Location = new System.Drawing.Point(94, 37);
            this.Label114.Name = "Label114";
            this.Label114.Size = new System.Drawing.Size(40, 20);
            this.Label114.TabIndex = 167;
            this.Label114.Text = "114";
            this.Label114.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label113
            // 
            this.Label113.BackColor = System.Drawing.Color.White;
            this.Label113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label113.ContextMenuStrip = this.contextMenuStrip1;
            this.Label113.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label113.Location = new System.Drawing.Point(51, 37);
            this.Label113.Name = "Label113";
            this.Label113.Size = new System.Drawing.Size(40, 20);
            this.Label113.TabIndex = 166;
            this.Label113.Text = "113";
            this.Label113.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label112
            // 
            this.Label112.BackColor = System.Drawing.Color.White;
            this.Label112.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label112.ContextMenuStrip = this.contextMenuStrip1;
            this.Label112.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label112.Location = new System.Drawing.Point(8, 37);
            this.Label112.Name = "Label112";
            this.Label112.Size = new System.Drawing.Size(40, 20);
            this.Label112.TabIndex = 165;
            this.Label112.Text = "112";
            this.Label112.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label111
            // 
            this.Label111.BackColor = System.Drawing.Color.White;
            this.Label111.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label111.ContextMenuStrip = this.contextMenuStrip1;
            this.Label111.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label111.Location = new System.Drawing.Point(94, 16);
            this.Label111.Name = "Label111";
            this.Label111.Size = new System.Drawing.Size(40, 20);
            this.Label111.TabIndex = 164;
            this.Label111.Text = "111";
            this.Label111.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label110
            // 
            this.Label110.BackColor = System.Drawing.Color.White;
            this.Label110.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label110.ContextMenuStrip = this.contextMenuStrip1;
            this.Label110.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label110.Location = new System.Drawing.Point(51, 16);
            this.Label110.Name = "Label110";
            this.Label110.Size = new System.Drawing.Size(40, 20);
            this.Label110.TabIndex = 163;
            this.Label110.Text = "110";
            this.Label110.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label109
            // 
            this.Label109.BackColor = System.Drawing.Color.White;
            this.Label109.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label109.ContextMenuStrip = this.contextMenuStrip1;
            this.Label109.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label109.Location = new System.Drawing.Point(8, 16);
            this.Label109.Name = "Label109";
            this.Label109.Size = new System.Drawing.Size(40, 20);
            this.Label109.TabIndex = 162;
            this.Label109.Text = "109";
            this.Label109.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label108);
            this.GroupBox2.Controls.Add(this.Label107);
            this.GroupBox2.Controls.Add(this.Label106);
            this.GroupBox2.Controls.Add(this.Label105);
            this.GroupBox2.Controls.Add(this.Label104);
            this.GroupBox2.Controls.Add(this.Label103);
            this.GroupBox2.Controls.Add(this.Label102);
            this.GroupBox2.Controls.Add(this.Label101);
            this.GroupBox2.Controls.Add(this.Label100);
            this.GroupBox2.Controls.Add(this.Label99);
            this.GroupBox2.Controls.Add(this.Label98);
            this.GroupBox2.Controls.Add(this.Label97);
            this.GroupBox2.Controls.Add(this.Label96);
            this.GroupBox2.Controls.Add(this.Label95);
            this.GroupBox2.Controls.Add(this.Label94);
            this.GroupBox2.Controls.Add(this.Label93);
            this.GroupBox2.Controls.Add(this.Label92);
            this.GroupBox2.Controls.Add(this.Label91);
            this.GroupBox2.Controls.Add(this.Label90);
            this.GroupBox2.Controls.Add(this.Label89);
            this.GroupBox2.Controls.Add(this.Label88);
            this.GroupBox2.Controls.Add(this.Label87);
            this.GroupBox2.Controls.Add(this.Label86);
            this.GroupBox2.Controls.Add(this.Label85);
            this.GroupBox2.Controls.Add(this.Label84);
            this.GroupBox2.Controls.Add(this.Label83);
            this.GroupBox2.Controls.Add(this.Label82);
            this.GroupBox2.Controls.Add(this.Label81);
            this.GroupBox2.Controls.Add(this.Label80);
            this.GroupBox2.Controls.Add(this.Label79);
            this.GroupBox2.Controls.Add(this.Label78);
            this.GroupBox2.Controls.Add(this.Label77);
            this.GroupBox2.Controls.Add(this.Label76);
            this.GroupBox2.Controls.Add(this.Label75);
            this.GroupBox2.Controls.Add(this.Label74);
            this.GroupBox2.Controls.Add(this.Label73);
            this.GroupBox2.Controls.Add(this.Label72);
            this.GroupBox2.Controls.Add(this.Label71);
            this.GroupBox2.Controls.Add(this.Label70);
            this.GroupBox2.Controls.Add(this.Label69);
            this.GroupBox2.Controls.Add(this.Label68);
            this.GroupBox2.Controls.Add(this.Label67);
            this.GroupBox2.Controls.Add(this.Label66);
            this.GroupBox2.Controls.Add(this.Label65);
            this.GroupBox2.Controls.Add(this.Label64);
            this.GroupBox2.Controls.Add(this.Label63);
            this.GroupBox2.Controls.Add(this.Label62);
            this.GroupBox2.Controls.Add(this.Label61);
            this.GroupBox2.Controls.Add(this.Label60);
            this.GroupBox2.Controls.Add(this.Label59);
            this.GroupBox2.Controls.Add(this.Label58);
            this.GroupBox2.Controls.Add(this.Label57);
            this.GroupBox2.Controls.Add(this.Label56);
            this.GroupBox2.Controls.Add(this.Label55);
            this.GroupBox2.Location = new System.Drawing.Point(519, 157);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(142, 460);
            this.GroupBox2.TabIndex = 276;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = " Side 2 ";
            // 
            // Label108
            // 
            this.Label108.BackColor = System.Drawing.Color.White;
            this.Label108.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label108.ContextMenuStrip = this.contextMenuStrip1;
            this.Label108.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label108.Location = new System.Drawing.Point(93, 429);
            this.Label108.Name = "Label108";
            this.Label108.Size = new System.Drawing.Size(39, 20);
            this.Label108.TabIndex = 161;
            this.Label108.Text = "108";
            this.Label108.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label107
            // 
            this.Label107.BackColor = System.Drawing.Color.White;
            this.Label107.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label107.ContextMenuStrip = this.contextMenuStrip1;
            this.Label107.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label107.Location = new System.Drawing.Point(51, 429);
            this.Label107.Name = "Label107";
            this.Label107.Size = new System.Drawing.Size(39, 20);
            this.Label107.TabIndex = 160;
            this.Label107.Text = "107";
            this.Label107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label106
            // 
            this.Label106.BackColor = System.Drawing.Color.White;
            this.Label106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label106.ContextMenuStrip = this.contextMenuStrip1;
            this.Label106.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label106.Location = new System.Drawing.Point(9, 429);
            this.Label106.Name = "Label106";
            this.Label106.Size = new System.Drawing.Size(39, 20);
            this.Label106.TabIndex = 159;
            this.Label106.Text = "106";
            this.Label106.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label105
            // 
            this.Label105.BackColor = System.Drawing.Color.White;
            this.Label105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label105.ContextMenuStrip = this.contextMenuStrip1;
            this.Label105.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label105.Location = new System.Drawing.Point(93, 408);
            this.Label105.Name = "Label105";
            this.Label105.Size = new System.Drawing.Size(39, 20);
            this.Label105.TabIndex = 158;
            this.Label105.Text = "105";
            this.Label105.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label104
            // 
            this.Label104.BackColor = System.Drawing.Color.White;
            this.Label104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label104.ContextMenuStrip = this.contextMenuStrip1;
            this.Label104.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label104.Location = new System.Drawing.Point(51, 408);
            this.Label104.Name = "Label104";
            this.Label104.Size = new System.Drawing.Size(39, 20);
            this.Label104.TabIndex = 157;
            this.Label104.Text = "104";
            this.Label104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label103
            // 
            this.Label103.BackColor = System.Drawing.Color.White;
            this.Label103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label103.ContextMenuStrip = this.contextMenuStrip1;
            this.Label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label103.Location = new System.Drawing.Point(9, 408);
            this.Label103.Name = "Label103";
            this.Label103.Size = new System.Drawing.Size(39, 20);
            this.Label103.TabIndex = 156;
            this.Label103.Text = "103";
            this.Label103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label102
            // 
            this.Label102.BackColor = System.Drawing.Color.White;
            this.Label102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label102.ContextMenuStrip = this.contextMenuStrip1;
            this.Label102.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label102.Location = new System.Drawing.Point(93, 380);
            this.Label102.Name = "Label102";
            this.Label102.Size = new System.Drawing.Size(39, 20);
            this.Label102.TabIndex = 155;
            this.Label102.Text = "102";
            this.Label102.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label101
            // 
            this.Label101.BackColor = System.Drawing.Color.White;
            this.Label101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label101.ContextMenuStrip = this.contextMenuStrip1;
            this.Label101.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label101.Location = new System.Drawing.Point(51, 380);
            this.Label101.Name = "Label101";
            this.Label101.Size = new System.Drawing.Size(39, 20);
            this.Label101.TabIndex = 154;
            this.Label101.Text = "101";
            this.Label101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label100
            // 
            this.Label100.BackColor = System.Drawing.Color.White;
            this.Label100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label100.ContextMenuStrip = this.contextMenuStrip1;
            this.Label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label100.Location = new System.Drawing.Point(9, 380);
            this.Label100.Name = "Label100";
            this.Label100.Size = new System.Drawing.Size(39, 20);
            this.Label100.TabIndex = 153;
            this.Label100.Text = "100";
            this.Label100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label99
            // 
            this.Label99.BackColor = System.Drawing.Color.White;
            this.Label99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label99.ContextMenuStrip = this.contextMenuStrip1;
            this.Label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label99.Location = new System.Drawing.Point(93, 359);
            this.Label99.Name = "Label99";
            this.Label99.Size = new System.Drawing.Size(39, 20);
            this.Label99.TabIndex = 152;
            this.Label99.Text = "99";
            this.Label99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label98
            // 
            this.Label98.BackColor = System.Drawing.Color.White;
            this.Label98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label98.ContextMenuStrip = this.contextMenuStrip1;
            this.Label98.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label98.Location = new System.Drawing.Point(51, 359);
            this.Label98.Name = "Label98";
            this.Label98.Size = new System.Drawing.Size(39, 20);
            this.Label98.TabIndex = 151;
            this.Label98.Text = "98";
            this.Label98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label97
            // 
            this.Label97.BackColor = System.Drawing.Color.White;
            this.Label97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label97.ContextMenuStrip = this.contextMenuStrip1;
            this.Label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label97.Location = new System.Drawing.Point(9, 359);
            this.Label97.Name = "Label97";
            this.Label97.Size = new System.Drawing.Size(39, 20);
            this.Label97.TabIndex = 150;
            this.Label97.Text = "97";
            this.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label96
            // 
            this.Label96.BackColor = System.Drawing.Color.White;
            this.Label96.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label96.ContextMenuStrip = this.contextMenuStrip1;
            this.Label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label96.Location = new System.Drawing.Point(93, 331);
            this.Label96.Name = "Label96";
            this.Label96.Size = new System.Drawing.Size(39, 20);
            this.Label96.TabIndex = 149;
            this.Label96.Text = "96";
            this.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label95
            // 
            this.Label95.BackColor = System.Drawing.Color.White;
            this.Label95.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label95.ContextMenuStrip = this.contextMenuStrip1;
            this.Label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label95.Location = new System.Drawing.Point(51, 331);
            this.Label95.Name = "Label95";
            this.Label95.Size = new System.Drawing.Size(39, 20);
            this.Label95.TabIndex = 148;
            this.Label95.Text = "95";
            this.Label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label94
            // 
            this.Label94.BackColor = System.Drawing.Color.White;
            this.Label94.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label94.ContextMenuStrip = this.contextMenuStrip1;
            this.Label94.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label94.Location = new System.Drawing.Point(9, 331);
            this.Label94.Name = "Label94";
            this.Label94.Size = new System.Drawing.Size(39, 20);
            this.Label94.TabIndex = 147;
            this.Label94.Text = "94";
            this.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label93
            // 
            this.Label93.BackColor = System.Drawing.Color.White;
            this.Label93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label93.ContextMenuStrip = this.contextMenuStrip1;
            this.Label93.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label93.Location = new System.Drawing.Point(93, 310);
            this.Label93.Name = "Label93";
            this.Label93.Size = new System.Drawing.Size(39, 20);
            this.Label93.TabIndex = 146;
            this.Label93.Text = "93";
            this.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label92
            // 
            this.Label92.BackColor = System.Drawing.Color.White;
            this.Label92.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label92.ContextMenuStrip = this.contextMenuStrip1;
            this.Label92.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label92.Location = new System.Drawing.Point(51, 310);
            this.Label92.Name = "Label92";
            this.Label92.Size = new System.Drawing.Size(39, 20);
            this.Label92.TabIndex = 145;
            this.Label92.Text = "92";
            this.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label91
            // 
            this.Label91.BackColor = System.Drawing.Color.White;
            this.Label91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label91.ContextMenuStrip = this.contextMenuStrip1;
            this.Label91.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label91.Location = new System.Drawing.Point(9, 310);
            this.Label91.Name = "Label91";
            this.Label91.Size = new System.Drawing.Size(39, 20);
            this.Label91.TabIndex = 144;
            this.Label91.Text = "91";
            this.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label90
            // 
            this.Label90.BackColor = System.Drawing.Color.White;
            this.Label90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label90.ContextMenuStrip = this.contextMenuStrip1;
            this.Label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label90.Location = new System.Drawing.Point(93, 282);
            this.Label90.Name = "Label90";
            this.Label90.Size = new System.Drawing.Size(39, 20);
            this.Label90.TabIndex = 143;
            this.Label90.Text = "90";
            this.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label89
            // 
            this.Label89.BackColor = System.Drawing.Color.White;
            this.Label89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label89.ContextMenuStrip = this.contextMenuStrip1;
            this.Label89.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label89.Location = new System.Drawing.Point(51, 282);
            this.Label89.Name = "Label89";
            this.Label89.Size = new System.Drawing.Size(39, 20);
            this.Label89.TabIndex = 142;
            this.Label89.Text = "89";
            this.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label88
            // 
            this.Label88.BackColor = System.Drawing.Color.White;
            this.Label88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label88.ContextMenuStrip = this.contextMenuStrip1;
            this.Label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label88.Location = new System.Drawing.Point(9, 282);
            this.Label88.Name = "Label88";
            this.Label88.Size = new System.Drawing.Size(39, 20);
            this.Label88.TabIndex = 141;
            this.Label88.Text = "88";
            this.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label87
            // 
            this.Label87.BackColor = System.Drawing.Color.White;
            this.Label87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label87.ContextMenuStrip = this.contextMenuStrip1;
            this.Label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label87.Location = new System.Drawing.Point(93, 261);
            this.Label87.Name = "Label87";
            this.Label87.Size = new System.Drawing.Size(39, 20);
            this.Label87.TabIndex = 140;
            this.Label87.Text = "87";
            this.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label86
            // 
            this.Label86.BackColor = System.Drawing.Color.White;
            this.Label86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label86.ContextMenuStrip = this.contextMenuStrip1;
            this.Label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label86.Location = new System.Drawing.Point(51, 261);
            this.Label86.Name = "Label86";
            this.Label86.Size = new System.Drawing.Size(39, 20);
            this.Label86.TabIndex = 139;
            this.Label86.Text = "86";
            this.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label85
            // 
            this.Label85.BackColor = System.Drawing.Color.White;
            this.Label85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label85.ContextMenuStrip = this.contextMenuStrip1;
            this.Label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label85.Location = new System.Drawing.Point(9, 261);
            this.Label85.Name = "Label85";
            this.Label85.Size = new System.Drawing.Size(39, 20);
            this.Label85.TabIndex = 138;
            this.Label85.Text = "85";
            this.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label84
            // 
            this.Label84.BackColor = System.Drawing.Color.White;
            this.Label84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label84.ContextMenuStrip = this.contextMenuStrip1;
            this.Label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label84.Location = new System.Drawing.Point(93, 233);
            this.Label84.Name = "Label84";
            this.Label84.Size = new System.Drawing.Size(39, 20);
            this.Label84.TabIndex = 137;
            this.Label84.Text = "84";
            this.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label83
            // 
            this.Label83.BackColor = System.Drawing.Color.White;
            this.Label83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label83.ContextMenuStrip = this.contextMenuStrip1;
            this.Label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label83.Location = new System.Drawing.Point(51, 233);
            this.Label83.Name = "Label83";
            this.Label83.Size = new System.Drawing.Size(39, 20);
            this.Label83.TabIndex = 136;
            this.Label83.Text = "83";
            this.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label82
            // 
            this.Label82.BackColor = System.Drawing.Color.White;
            this.Label82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label82.ContextMenuStrip = this.contextMenuStrip1;
            this.Label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label82.Location = new System.Drawing.Point(9, 233);
            this.Label82.Name = "Label82";
            this.Label82.Size = new System.Drawing.Size(39, 20);
            this.Label82.TabIndex = 135;
            this.Label82.Text = "82";
            this.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label81
            // 
            this.Label81.BackColor = System.Drawing.Color.White;
            this.Label81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label81.ContextMenuStrip = this.contextMenuStrip1;
            this.Label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label81.Location = new System.Drawing.Point(93, 212);
            this.Label81.Name = "Label81";
            this.Label81.Size = new System.Drawing.Size(39, 20);
            this.Label81.TabIndex = 134;
            this.Label81.Text = "81";
            this.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label80
            // 
            this.Label80.BackColor = System.Drawing.Color.White;
            this.Label80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label80.ContextMenuStrip = this.contextMenuStrip1;
            this.Label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label80.Location = new System.Drawing.Point(51, 212);
            this.Label80.Name = "Label80";
            this.Label80.Size = new System.Drawing.Size(39, 20);
            this.Label80.TabIndex = 133;
            this.Label80.Text = "80";
            this.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label79
            // 
            this.Label79.BackColor = System.Drawing.Color.White;
            this.Label79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label79.ContextMenuStrip = this.contextMenuStrip1;
            this.Label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label79.Location = new System.Drawing.Point(9, 212);
            this.Label79.Name = "Label79";
            this.Label79.Size = new System.Drawing.Size(39, 20);
            this.Label79.TabIndex = 132;
            this.Label79.Text = "79";
            this.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label78
            // 
            this.Label78.BackColor = System.Drawing.Color.White;
            this.Label78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label78.ContextMenuStrip = this.contextMenuStrip1;
            this.Label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label78.Location = new System.Drawing.Point(93, 184);
            this.Label78.Name = "Label78";
            this.Label78.Size = new System.Drawing.Size(39, 20);
            this.Label78.TabIndex = 131;
            this.Label78.Text = "78";
            this.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label77
            // 
            this.Label77.BackColor = System.Drawing.Color.White;
            this.Label77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label77.ContextMenuStrip = this.contextMenuStrip1;
            this.Label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label77.Location = new System.Drawing.Point(51, 184);
            this.Label77.Name = "Label77";
            this.Label77.Size = new System.Drawing.Size(39, 20);
            this.Label77.TabIndex = 130;
            this.Label77.Text = "77";
            this.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label76
            // 
            this.Label76.BackColor = System.Drawing.Color.White;
            this.Label76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label76.ContextMenuStrip = this.contextMenuStrip1;
            this.Label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label76.Location = new System.Drawing.Point(9, 184);
            this.Label76.Name = "Label76";
            this.Label76.Size = new System.Drawing.Size(39, 20);
            this.Label76.TabIndex = 129;
            this.Label76.Text = "76";
            this.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label75
            // 
            this.Label75.BackColor = System.Drawing.Color.White;
            this.Label75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label75.ContextMenuStrip = this.contextMenuStrip1;
            this.Label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label75.Location = new System.Drawing.Point(93, 163);
            this.Label75.Name = "Label75";
            this.Label75.Size = new System.Drawing.Size(39, 20);
            this.Label75.TabIndex = 128;
            this.Label75.Text = "75";
            this.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label74
            // 
            this.Label74.BackColor = System.Drawing.Color.White;
            this.Label74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label74.ContextMenuStrip = this.contextMenuStrip1;
            this.Label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label74.Location = new System.Drawing.Point(51, 163);
            this.Label74.Name = "Label74";
            this.Label74.Size = new System.Drawing.Size(39, 20);
            this.Label74.TabIndex = 127;
            this.Label74.Text = "74";
            this.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label73
            // 
            this.Label73.BackColor = System.Drawing.Color.White;
            this.Label73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label73.ContextMenuStrip = this.contextMenuStrip1;
            this.Label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label73.Location = new System.Drawing.Point(9, 163);
            this.Label73.Name = "Label73";
            this.Label73.Size = new System.Drawing.Size(39, 20);
            this.Label73.TabIndex = 126;
            this.Label73.Text = "73";
            this.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label72
            // 
            this.Label72.BackColor = System.Drawing.Color.White;
            this.Label72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label72.ContextMenuStrip = this.contextMenuStrip1;
            this.Label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label72.Location = new System.Drawing.Point(93, 135);
            this.Label72.Name = "Label72";
            this.Label72.Size = new System.Drawing.Size(39, 20);
            this.Label72.TabIndex = 125;
            this.Label72.Text = "72";
            this.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label71
            // 
            this.Label71.BackColor = System.Drawing.Color.White;
            this.Label71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label71.ContextMenuStrip = this.contextMenuStrip1;
            this.Label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label71.Location = new System.Drawing.Point(51, 135);
            this.Label71.Name = "Label71";
            this.Label71.Size = new System.Drawing.Size(39, 20);
            this.Label71.TabIndex = 124;
            this.Label71.Text = "71";
            this.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label70
            // 
            this.Label70.BackColor = System.Drawing.Color.White;
            this.Label70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label70.ContextMenuStrip = this.contextMenuStrip1;
            this.Label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label70.Location = new System.Drawing.Point(9, 135);
            this.Label70.Name = "Label70";
            this.Label70.Size = new System.Drawing.Size(39, 20);
            this.Label70.TabIndex = 123;
            this.Label70.Text = "70";
            this.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label69
            // 
            this.Label69.BackColor = System.Drawing.Color.White;
            this.Label69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label69.ContextMenuStrip = this.contextMenuStrip1;
            this.Label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label69.Location = new System.Drawing.Point(93, 114);
            this.Label69.Name = "Label69";
            this.Label69.Size = new System.Drawing.Size(39, 20);
            this.Label69.TabIndex = 122;
            this.Label69.Text = "69";
            this.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label68
            // 
            this.Label68.BackColor = System.Drawing.Color.White;
            this.Label68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label68.ContextMenuStrip = this.contextMenuStrip1;
            this.Label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label68.Location = new System.Drawing.Point(51, 114);
            this.Label68.Name = "Label68";
            this.Label68.Size = new System.Drawing.Size(39, 20);
            this.Label68.TabIndex = 121;
            this.Label68.Text = "68";
            this.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label67
            // 
            this.Label67.BackColor = System.Drawing.Color.White;
            this.Label67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label67.ContextMenuStrip = this.contextMenuStrip1;
            this.Label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label67.Location = new System.Drawing.Point(9, 114);
            this.Label67.Name = "Label67";
            this.Label67.Size = new System.Drawing.Size(39, 20);
            this.Label67.TabIndex = 120;
            this.Label67.Text = "67";
            this.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label66
            // 
            this.Label66.BackColor = System.Drawing.Color.White;
            this.Label66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label66.ContextMenuStrip = this.contextMenuStrip1;
            this.Label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label66.Location = new System.Drawing.Point(93, 86);
            this.Label66.Name = "Label66";
            this.Label66.Size = new System.Drawing.Size(39, 20);
            this.Label66.TabIndex = 119;
            this.Label66.Text = "66";
            this.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label65
            // 
            this.Label65.BackColor = System.Drawing.Color.White;
            this.Label65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label65.ContextMenuStrip = this.contextMenuStrip1;
            this.Label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label65.Location = new System.Drawing.Point(51, 86);
            this.Label65.Name = "Label65";
            this.Label65.Size = new System.Drawing.Size(39, 20);
            this.Label65.TabIndex = 118;
            this.Label65.Text = "65";
            this.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label64
            // 
            this.Label64.BackColor = System.Drawing.Color.White;
            this.Label64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label64.ContextMenuStrip = this.contextMenuStrip1;
            this.Label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label64.Location = new System.Drawing.Point(9, 86);
            this.Label64.Name = "Label64";
            this.Label64.Size = new System.Drawing.Size(39, 20);
            this.Label64.TabIndex = 117;
            this.Label64.Text = "64";
            this.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label63
            // 
            this.Label63.BackColor = System.Drawing.Color.White;
            this.Label63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label63.ContextMenuStrip = this.contextMenuStrip1;
            this.Label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label63.Location = new System.Drawing.Point(93, 65);
            this.Label63.Name = "Label63";
            this.Label63.Size = new System.Drawing.Size(39, 20);
            this.Label63.TabIndex = 116;
            this.Label63.Text = "63";
            this.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label62
            // 
            this.Label62.BackColor = System.Drawing.Color.White;
            this.Label62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label62.ContextMenuStrip = this.contextMenuStrip1;
            this.Label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label62.Location = new System.Drawing.Point(51, 65);
            this.Label62.Name = "Label62";
            this.Label62.Size = new System.Drawing.Size(39, 20);
            this.Label62.TabIndex = 115;
            this.Label62.Text = "62";
            this.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label61
            // 
            this.Label61.BackColor = System.Drawing.Color.White;
            this.Label61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label61.ContextMenuStrip = this.contextMenuStrip1;
            this.Label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label61.Location = new System.Drawing.Point(9, 65);
            this.Label61.Name = "Label61";
            this.Label61.Size = new System.Drawing.Size(39, 20);
            this.Label61.TabIndex = 114;
            this.Label61.Text = "61";
            this.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label60
            // 
            this.Label60.BackColor = System.Drawing.Color.White;
            this.Label60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label60.ContextMenuStrip = this.contextMenuStrip1;
            this.Label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label60.Location = new System.Drawing.Point(93, 37);
            this.Label60.Name = "Label60";
            this.Label60.Size = new System.Drawing.Size(39, 20);
            this.Label60.TabIndex = 113;
            this.Label60.Text = "60";
            this.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label59
            // 
            this.Label59.BackColor = System.Drawing.Color.White;
            this.Label59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label59.ContextMenuStrip = this.contextMenuStrip1;
            this.Label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label59.Location = new System.Drawing.Point(51, 37);
            this.Label59.Name = "Label59";
            this.Label59.Size = new System.Drawing.Size(39, 20);
            this.Label59.TabIndex = 112;
            this.Label59.Text = "59";
            this.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label58
            // 
            this.Label58.BackColor = System.Drawing.Color.White;
            this.Label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label58.ContextMenuStrip = this.contextMenuStrip1;
            this.Label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label58.Location = new System.Drawing.Point(9, 37);
            this.Label58.Name = "Label58";
            this.Label58.Size = new System.Drawing.Size(39, 20);
            this.Label58.TabIndex = 111;
            this.Label58.Text = "58";
            this.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label57
            // 
            this.Label57.BackColor = System.Drawing.Color.White;
            this.Label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label57.ContextMenuStrip = this.contextMenuStrip1;
            this.Label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label57.Location = new System.Drawing.Point(93, 16);
            this.Label57.Name = "Label57";
            this.Label57.Size = new System.Drawing.Size(39, 20);
            this.Label57.TabIndex = 110;
            this.Label57.Text = "57";
            this.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label56
            // 
            this.Label56.BackColor = System.Drawing.Color.White;
            this.Label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label56.ContextMenuStrip = this.contextMenuStrip1;
            this.Label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label56.Location = new System.Drawing.Point(51, 16);
            this.Label56.Name = "Label56";
            this.Label56.Size = new System.Drawing.Size(39, 20);
            this.Label56.TabIndex = 109;
            this.Label56.Text = "56";
            this.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label55
            // 
            this.Label55.BackColor = System.Drawing.Color.White;
            this.Label55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label55.ContextMenuStrip = this.contextMenuStrip1;
            this.Label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label55.Location = new System.Drawing.Point(9, 16);
            this.Label55.Name = "Label55";
            this.Label55.Size = new System.Drawing.Size(39, 20);
            this.Label55.TabIndex = 108;
            this.Label55.Text = "55";
            this.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 43);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1479, 775);
            this.metroTabControl1.TabIndex = 264;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived_1);
            // 
            // serialPort3
            // 
            this.serialPort3.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort3_DataReceived);
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(42, 70);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(136, 108);
            this.button12.TabIndex = 288;
            this.button12.Text = "RANDOM";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // label234
            // 
            this.label234.AutoSize = true;
            this.label234.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label234.Location = new System.Drawing.Point(52, 24);
            this.label234.Name = "label234";
            this.label234.Size = new System.Drawing.Size(109, 25);
            this.label234.TabIndex = 0;
            this.label234.Text = "TestPanel";
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(42, 186);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 34);
            this.button8.TabIndex = 289;
            this.button8.Text = "1. Generuj Def. Data";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(42, 226);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(136, 34);
            this.button10.TabIndex = 290;
            this.button10.Text = "2. Iteracja kolorów";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(42, 266);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(136, 34);
            this.button11.TabIndex = 291;
            this.button11.Text = "3. Koloruj pola";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(42, 307);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(136, 34);
            this.button9.TabIndex = 292;
            this.button9.Text = "Kolor dla Nest #1";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(42, 347);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(136, 20);
            this.textBox6.TabIndex = 293;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.label234);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Location = new System.Drawing.Point(1237, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 670);
            this.panel3.TabIndex = 290;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 817);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Burn-In Pit Stop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ComBoxCart.ResumeLayout(false);
            this.ComBoxCart.PerformLayout();
            this.grpboxComPort.ResumeLayout(false);
            this.grpboxComPort.PerformLayout();
            this.grpboxCanFrameTransmit.ResumeLayout(false);
            this.grpboxCanFrameTransmit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDlc)).EndInit();
            this.grpboxCanCommands.ResumeLayout(false);
            this.grpboxCanCommands.PerformLayout();
            this.grpboxCanFrameReceive.ResumeLayout(false);
            this.ComBoxTester.ResumeLayout(false);
            this.ComBoxTester.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ComBoxChamber.ResumeLayout(false);
            this.ComBoxChamber.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label233;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        internal System.Windows.Forms.GroupBox ComBoxChamber;
        private System.Windows.Forms.ProgressBar ComprogressChaber;
        private System.Windows.Forms.Button ComSend;
        private System.Windows.Forms.Button ComClose;
        private System.Windows.Forms.Button ComOpen;
        internal System.Windows.Forms.Label label231;
        internal System.Windows.Forms.Label label230;
        private System.Windows.Forms.RichTextBox richTextBoxTX;
        private System.Windows.Forms.RichTextBox richTextBoxRX;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxParity;
        private System.Windows.Forms.ComboBox CBoxDataBits;
        private System.Windows.Forms.ComboBox CBoxBaundRate;
        private System.Windows.Forms.ComboBox cBoxCOMPort;
        internal System.Windows.Forms.Button ComOk;
        internal System.Windows.Forms.Label Label229;
        internal System.Windows.Forms.Label Label228;
        internal System.Windows.Forms.Label Label227;
        internal System.Windows.Forms.Label Label226;
        internal System.Windows.Forms.Label Label225;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label232;
        private System.Windows.Forms.Button button4;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label Label216;
        internal System.Windows.Forms.Label Label215;
        internal System.Windows.Forms.Label Label214;
        internal System.Windows.Forms.Label Label213;
        internal System.Windows.Forms.Label Label212;
        internal System.Windows.Forms.Label Label211;
        internal System.Windows.Forms.Label Label210;
        internal System.Windows.Forms.Label Label209;
        internal System.Windows.Forms.Label Label208;
        internal System.Windows.Forms.Label Label207;
        internal System.Windows.Forms.Label Label206;
        internal System.Windows.Forms.Label Label205;
        internal System.Windows.Forms.Label Label204;
        internal System.Windows.Forms.Label Label203;
        internal System.Windows.Forms.Label Label202;
        internal System.Windows.Forms.Label Label201;
        internal System.Windows.Forms.Label Label200;
        internal System.Windows.Forms.Label Label199;
        internal System.Windows.Forms.Label Label198;
        internal System.Windows.Forms.Label Label197;
        internal System.Windows.Forms.Label Label196;
        internal System.Windows.Forms.Label Label195;
        internal System.Windows.Forms.Label Label194;
        internal System.Windows.Forms.Label Label193;
        internal System.Windows.Forms.Label Label192;
        internal System.Windows.Forms.Label Label191;
        internal System.Windows.Forms.Label Label190;
        internal System.Windows.Forms.Label Label189;
        internal System.Windows.Forms.Label Label188;
        internal System.Windows.Forms.Label Label187;
        internal System.Windows.Forms.Label Label186;
        internal System.Windows.Forms.Label Label185;
        internal System.Windows.Forms.Label Label184;
        internal System.Windows.Forms.Label Label183;
        internal System.Windows.Forms.Label Label182;
        internal System.Windows.Forms.Label Label181;
        internal System.Windows.Forms.Label Label180;
        internal System.Windows.Forms.Label Label179;
        internal System.Windows.Forms.Label Label178;
        internal System.Windows.Forms.Label Label177;
        internal System.Windows.Forms.Label Label176;
        internal System.Windows.Forms.Label Label175;
        internal System.Windows.Forms.Label Label174;
        internal System.Windows.Forms.Label Label173;
        internal System.Windows.Forms.Label Label172;
        internal System.Windows.Forms.Label Label171;
        internal System.Windows.Forms.Label Label170;
        internal System.Windows.Forms.Label Label169;
        internal System.Windows.Forms.Label Label168;
        internal System.Windows.Forms.Label Label167;
        internal System.Windows.Forms.Label Label166;
        internal System.Windows.Forms.Label Label165;
        internal System.Windows.Forms.Label Label164;
        internal System.Windows.Forms.Label Label163;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label54;
        internal System.Windows.Forms.Label Label53;
        internal System.Windows.Forms.Label Label52;
        internal System.Windows.Forms.Label Label51;
        internal System.Windows.Forms.Label Label50;
        internal System.Windows.Forms.Label Label49;
        internal System.Windows.Forms.Label Label48;
        internal System.Windows.Forms.Label Label47;
        internal System.Windows.Forms.Label Label46;
        internal System.Windows.Forms.Label Label45;
        internal System.Windows.Forms.Label Label44;
        internal System.Windows.Forms.Label Label43;
        internal System.Windows.Forms.Label Label42;
        internal System.Windows.Forms.Label Label41;
        internal System.Windows.Forms.Label Label40;
        internal System.Windows.Forms.Label Label39;
        internal System.Windows.Forms.Label Label38;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.Label Label32;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label217;
        internal System.Windows.Forms.RichTextBox RichTextBox2;
        internal System.Windows.Forms.Label Label218;
        internal System.Windows.Forms.Label Label224;
        internal System.Windows.Forms.Label Label223;
        internal System.Windows.Forms.Label Label219;
        internal System.Windows.Forms.Label Label221;
        internal System.Windows.Forms.Label Label220;
        internal System.Windows.Forms.RichTextBox RichTextBox1;
        internal System.Windows.Forms.Label Label222;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label162;
        internal System.Windows.Forms.Label Label161;
        internal System.Windows.Forms.Label Label160;
        internal System.Windows.Forms.Label Label159;
        internal System.Windows.Forms.Label Label158;
        internal System.Windows.Forms.Label Label157;
        internal System.Windows.Forms.Label Label156;
        internal System.Windows.Forms.Label Label155;
        internal System.Windows.Forms.Label Label154;
        internal System.Windows.Forms.Label Label153;
        internal System.Windows.Forms.Label Label152;
        internal System.Windows.Forms.Label Label151;
        internal System.Windows.Forms.Label Label150;
        internal System.Windows.Forms.Label Label149;
        internal System.Windows.Forms.Label Label148;
        internal System.Windows.Forms.Label Label147;
        internal System.Windows.Forms.Label Label146;
        internal System.Windows.Forms.Label Label145;
        internal System.Windows.Forms.Label Label144;
        internal System.Windows.Forms.Label Label143;
        internal System.Windows.Forms.Label Label142;
        internal System.Windows.Forms.Label Label141;
        internal System.Windows.Forms.Label Label140;
        internal System.Windows.Forms.Label Label139;
        internal System.Windows.Forms.Label Label138;
        internal System.Windows.Forms.Label Label137;
        internal System.Windows.Forms.Label Label136;
        internal System.Windows.Forms.Label Label135;
        internal System.Windows.Forms.Label Label134;
        internal System.Windows.Forms.Label Label133;
        internal System.Windows.Forms.Label Label132;
        internal System.Windows.Forms.Label Label131;
        internal System.Windows.Forms.Label Label130;
        internal System.Windows.Forms.Label Label129;
        internal System.Windows.Forms.Label Label128;
        internal System.Windows.Forms.Label Label127;
        internal System.Windows.Forms.Label Label126;
        internal System.Windows.Forms.Label Label125;
        internal System.Windows.Forms.Label Label124;
        internal System.Windows.Forms.Label Label123;
        internal System.Windows.Forms.Label Label122;
        internal System.Windows.Forms.Label Label121;
        internal System.Windows.Forms.Label Label120;
        internal System.Windows.Forms.Label Label119;
        internal System.Windows.Forms.Label Label118;
        internal System.Windows.Forms.Label Label117;
        internal System.Windows.Forms.Label Label116;
        internal System.Windows.Forms.Label Label115;
        internal System.Windows.Forms.Label Label114;
        internal System.Windows.Forms.Label Label113;
        internal System.Windows.Forms.Label Label112;
        internal System.Windows.Forms.Label Label111;
        internal System.Windows.Forms.Label Label110;
        internal System.Windows.Forms.Label Label109;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label108;
        internal System.Windows.Forms.Label Label107;
        internal System.Windows.Forms.Label Label106;
        internal System.Windows.Forms.Label Label105;
        internal System.Windows.Forms.Label Label104;
        internal System.Windows.Forms.Label Label103;
        internal System.Windows.Forms.Label Label102;
        internal System.Windows.Forms.Label Label101;
        internal System.Windows.Forms.Label Label100;
        internal System.Windows.Forms.Label Label99;
        internal System.Windows.Forms.Label Label98;
        internal System.Windows.Forms.Label Label97;
        internal System.Windows.Forms.Label Label96;
        internal System.Windows.Forms.Label Label95;
        internal System.Windows.Forms.Label Label94;
        internal System.Windows.Forms.Label Label93;
        internal System.Windows.Forms.Label Label92;
        internal System.Windows.Forms.Label Label91;
        internal System.Windows.Forms.Label Label90;
        internal System.Windows.Forms.Label Label89;
        internal System.Windows.Forms.Label Label88;
        internal System.Windows.Forms.Label Label87;
        internal System.Windows.Forms.Label Label86;
        internal System.Windows.Forms.Label Label85;
        internal System.Windows.Forms.Label Label84;
        internal System.Windows.Forms.Label Label83;
        internal System.Windows.Forms.Label Label82;
        internal System.Windows.Forms.Label Label81;
        internal System.Windows.Forms.Label Label80;
        internal System.Windows.Forms.Label Label79;
        internal System.Windows.Forms.Label Label78;
        internal System.Windows.Forms.Label Label77;
        internal System.Windows.Forms.Label Label76;
        internal System.Windows.Forms.Label Label75;
        internal System.Windows.Forms.Label Label74;
        internal System.Windows.Forms.Label Label73;
        internal System.Windows.Forms.Label Label72;
        internal System.Windows.Forms.Label Label71;
        internal System.Windows.Forms.Label Label70;
        internal System.Windows.Forms.Label Label69;
        internal System.Windows.Forms.Label Label68;
        internal System.Windows.Forms.Label Label67;
        internal System.Windows.Forms.Label Label66;
        internal System.Windows.Forms.Label Label65;
        internal System.Windows.Forms.Label Label64;
        internal System.Windows.Forms.Label Label63;
        internal System.Windows.Forms.Label Label62;
        internal System.Windows.Forms.Label Label61;
        internal System.Windows.Forms.Label Label60;
        internal System.Windows.Forms.Label Label59;
        internal System.Windows.Forms.Label Label58;
        internal System.Windows.Forms.Label Label57;
        internal System.Windows.Forms.Label Label56;
        internal System.Windows.Forms.Label Label55;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        internal System.Windows.Forms.GroupBox ComBoxCart;
        internal System.Windows.Forms.GroupBox ComBoxTester;
        private System.Windows.Forms.ProgressBar ComProgresTester;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        internal System.Windows.Forms.Label label235;
        internal System.Windows.Forms.Label label236;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        internal System.Windows.Forms.Button button18;
        internal System.Windows.Forms.Label label237;
        internal System.Windows.Forms.Label label238;
        internal System.Windows.Forms.Label label239;
        internal System.Windows.Forms.Label label240;
        internal System.Windows.Forms.Label label241;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Label label249;
        private System.Windows.Forms.Label label252;
        private System.Windows.Forms.Label label251;
        private System.Windows.Forms.Label label250;
        private System.Windows.Forms.ProgressBar ComProgresshomecard;
        private System.Windows.Forms.ProgressBar ComProgressHomeTester;
        private System.Windows.Forms.ProgressBar ComProgresHomeChamber;
        internal System.IO.Ports.SerialPort serialPort2;
        internal System.IO.Ports.SerialPort serialPort3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.Label label253;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem blockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unblockToolStripMenuItem;
        internal System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.GroupBox grpboxCanFrameTransmit;
        private System.Windows.Forms.Label lblDataBytes;
        private System.Windows.Forms.Label lblDlc;
        private System.Windows.Forms.Label lblCanId;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Button btnSendFrame;
        private System.Windows.Forms.TextBox tbxHex1;
        private System.Windows.Forms.CheckBox cboxRtr;
        private System.Windows.Forms.TextBox tbxHex2;
        private System.Windows.Forms.CheckBox cboxExt;
        private System.Windows.Forms.NumericUpDown numDlc;
        private System.Windows.Forms.TextBox tbxHex3;
        private System.Windows.Forms.TextBox tbxHex8;
        private System.Windows.Forms.TextBox tbxHex4;
        private System.Windows.Forms.TextBox tbxHex7;
        private System.Windows.Forms.TextBox tbxHex5;
        private System.Windows.Forms.TextBox tbxHex6;
        private System.Windows.Forms.GroupBox grpboxCanCommands;
        private System.Windows.Forms.Button btnAutoOff;
        private System.Windows.Forms.Button btnAutoOn;
        private System.Windows.Forms.Button btnTimeStampOff;
        private System.Windows.Forms.Button btnTimeStampOn;
        private System.Windows.Forms.Button btnPollAll;
        private System.Windows.Forms.Button btnPollOne;
        private System.Windows.Forms.Button btnSerNo;
        private System.Windows.Forms.Button btnCanVersion;
        private System.Windows.Forms.Button btnCanFlags;
        private System.Windows.Forms.Button btnCanClose;
        private System.Windows.Forms.Button btnCanOpen;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Label label254;
        private System.Windows.Forms.ComboBox cmbCanBitrate;
        private System.Windows.Forms.GroupBox grpboxCanFrameReceive;
        private System.Windows.Forms.RichTextBox rtboxReceive;
        private System.Windows.Forms.GroupBox grpboxComPort;
        private System.Windows.Forms.Button btnComClose;
        private System.Windows.Forms.Button btnComOpen;
        private System.Windows.Forms.Label lblComSpeed;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.ComboBox cmbComSpeed;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label234;
        private System.Windows.Forms.Button button12;
    }
}

