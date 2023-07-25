using System.Windows.Forms;

namespace Apple_24_Zones.Forms
{
    partial class FrmMain
    {
        private MainMenu panelMenu;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series145 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series146 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series147 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series148 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series149 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series150 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series151 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series152 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series153 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series154 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series155 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series156 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series157 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series158 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series159 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series160 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series161 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series162 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series163 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series164 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series165 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series166 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series167 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series168 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.ChartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbRecord = new System.Windows.Forms.Label();
            this.lbCharMode = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.TimerHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerRequestData = new System.Windows.Forms.Timer(this.components);
            this.timerForChartTC = new System.Windows.Forms.Timer(this.components);
            this.panelZone1 = new System.Windows.Forms.Panel();
            this.lbDivisor = new System.Windows.Forms.Label();
            this.txtSetPointZone2 = new System.Windows.Forms.TextBox();
            this.ledZ2 = new System.Windows.Forms.PictureBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTC24 = new System.Windows.Forms.TextBox();
            this.txtTC23 = new System.Windows.Forms.TextBox();
            this.txtTC22 = new System.Windows.Forms.TextBox();
            this.txtTC21 = new System.Windows.Forms.TextBox();
            this.txtTC20 = new System.Windows.Forms.TextBox();
            this.txtTC19 = new System.Windows.Forms.TextBox();
            this.txtTC18 = new System.Windows.Forms.TextBox();
            this.txtTC17 = new System.Windows.Forms.TextBox();
            this.txtTC16 = new System.Windows.Forms.TextBox();
            this.txtTC15 = new System.Windows.Forms.TextBox();
            this.txtTC14 = new System.Windows.Forms.TextBox();
            this.txtTC13 = new System.Windows.Forms.TextBox();
            this.txtTC12 = new System.Windows.Forms.TextBox();
            this.txtTC11 = new System.Windows.Forms.TextBox();
            this.txtTC10 = new System.Windows.Forms.TextBox();
            this.txtTC9 = new System.Windows.Forms.TextBox();
            this.txtTC8 = new System.Windows.Forms.TextBox();
            this.txtTC7 = new System.Windows.Forms.TextBox();
            this.txtTC6 = new System.Windows.Forms.TextBox();
            this.txtTC5 = new System.Windows.Forms.TextBox();
            this.txtTC4 = new System.Windows.Forms.TextBox();
            this.txtTC3 = new System.Windows.Forms.TextBox();
            this.txtTC2 = new System.Windows.Forms.TextBox();
            this.txtTC1 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.btnEMO = new System.Windows.Forms.PictureBox();
            this.btnTypeTime = new FontAwesome.Sharp.IconButton();
            this.btnClearChart = new FontAwesome.Sharp.IconButton();
            this.btnRecordDataChart = new FontAwesome.Sharp.IconButton();
            this.btnChartMode = new FontAwesome.Sharp.IconButton();
            this.btnStartStopChart = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label72 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label73 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.zone2label12 = new System.Windows.Forms.Label();
            this.zone2label11 = new System.Windows.Forms.Label();
            this.zone2label10 = new System.Windows.Forms.Label();
            this.zone2label9 = new System.Windows.Forms.Label();
            this.zone2label8 = new System.Windows.Forms.Label();
            this.zone2label7 = new System.Windows.Forms.Label();
            this.zone2label6 = new System.Windows.Forms.Label();
            this.zone2label5 = new System.Windows.Forms.Label();
            this.zone2label4 = new System.Windows.Forms.Label();
            this.zone2label3 = new System.Windows.Forms.Label();
            this.zone2label2 = new System.Windows.Forms.Label();
            this.zone2label1 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCSVFileFilter = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMain)).BeginInit();
            this.panelZone1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledZ2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEMO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFecha
            // 
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.Black;
            this.lbFecha.Location = new System.Drawing.Point(1429, 1068);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(353, 24);
            this.lbFecha.TabIndex = 211;
            this.lbFecha.Text = "fecha";
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHora
            // 
            this.lbHora.BackColor = System.Drawing.Color.Transparent;
            this.lbHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.Black;
            this.lbHora.Location = new System.Drawing.Point(1699, 1068);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(209, 24);
            this.lbHora.TabIndex = 210;
            this.lbHora.Text = "hora";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChartMain
            // 
            this.ChartMain.BorderlineColor = System.Drawing.Color.SteelBlue;
            this.ChartMain.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.ChartMain.BorderlineWidth = 2;
            chartArea13.Name = "ChartArea1";
            this.ChartMain.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.ChartMain.Legends.Add(legend13);
            this.ChartMain.Location = new System.Drawing.Point(792, 127);
            this.ChartMain.Name = "ChartMain";
            series145.ChartArea = "ChartArea1";
            series145.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series145.Legend = "Legend1";
            series145.Name = "T-1";
            series146.ChartArea = "ChartArea1";
            series146.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series146.Legend = "Legend1";
            series146.Name = "T-2";
            series147.ChartArea = "ChartArea1";
            series147.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series147.Legend = "Legend1";
            series147.Name = "T-3";
            series148.ChartArea = "ChartArea1";
            series148.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series148.Legend = "Legend1";
            series148.Name = "T-4";
            series149.ChartArea = "ChartArea1";
            series149.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series149.Legend = "Legend1";
            series149.Name = "T-5";
            series150.ChartArea = "ChartArea1";
            series150.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series150.Legend = "Legend1";
            series150.Name = "T-6";
            series151.ChartArea = "ChartArea1";
            series151.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series151.Legend = "Legend1";
            series151.Name = "T-7";
            series152.ChartArea = "ChartArea1";
            series152.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series152.Legend = "Legend1";
            series152.Name = "TC-8";
            series153.ChartArea = "ChartArea1";
            series153.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series153.Legend = "Legend1";
            series153.Name = "TC-9";
            series154.ChartArea = "ChartArea1";
            series154.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series154.Legend = "Legend1";
            series154.Name = "TC-10";
            series155.ChartArea = "ChartArea1";
            series155.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series155.Legend = "Legend1";
            series155.Name = "TC-11";
            series156.ChartArea = "ChartArea1";
            series156.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series156.Legend = "Legend1";
            series156.Name = "TC-12";
            this.ChartMain.Series.Add(series145);
            this.ChartMain.Series.Add(series146);
            this.ChartMain.Series.Add(series147);
            this.ChartMain.Series.Add(series148);
            this.ChartMain.Series.Add(series149);
            this.ChartMain.Series.Add(series150);
            this.ChartMain.Series.Add(series151);
            this.ChartMain.Series.Add(series152);
            this.ChartMain.Series.Add(series153);
            this.ChartMain.Series.Add(series154);
            this.ChartMain.Series.Add(series155);
            this.ChartMain.Series.Add(series156);
            this.ChartMain.Size = new System.Drawing.Size(1110, 350);
            this.ChartMain.TabIndex = 212;
            this.ChartMain.Text = "chart1";
            this.ChartMain.Click += new System.EventHandler(this.ChartMain_Click);
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.BackColor = System.Drawing.Color.White;
            this.lbRecord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.ForeColor = System.Drawing.Color.Black;
            this.lbRecord.Location = new System.Drawing.Point(40, 631);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(104, 19);
            this.lbRecord.TabIndex = 218;
            this.lbRecord.Text = "Record Data";
            this.lbRecord.Visible = false;
            this.lbRecord.Click += new System.EventHandler(this.lbRecord_Click);
            // 
            // lbCharMode
            // 
            this.lbCharMode.BackColor = System.Drawing.Color.White;
            this.lbCharMode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharMode.ForeColor = System.Drawing.Color.Black;
            this.lbCharMode.Location = new System.Drawing.Point(79, 474);
            this.lbCharMode.Name = "lbCharMode";
            this.lbCharMode.Size = new System.Drawing.Size(117, 19);
            this.lbCharMode.TabIndex = 216;
            this.lbCharMode.Text = "Chart Dinamic";
            this.lbCharMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCharMode.Visible = false;
            this.lbCharMode.Click += new System.EventHandler(this.lbCharMode_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.White;
            this.label32.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(86, 454);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(93, 19);
            this.label32.TabIndex = 214;
            this.label32.Text = "Start / Stop";
            this.label32.Visible = false;
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // TimerHoraFecha
            // 
            this.TimerHoraFecha.Tick += new System.EventHandler(this.TimerHoraFecha_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timerRequestData
            // 
            this.timerRequestData.Interval = 5000;
            this.timerRequestData.Tick += new System.EventHandler(this.timerRequestData_Tick);
            // 
            // timerForChartTC
            // 
            this.timerForChartTC.Tick += new System.EventHandler(this.timerForChartTC_Tick);
            // 
            // panelZone1
            // 
            this.panelZone1.BackColor = System.Drawing.Color.SteelBlue;
            this.panelZone1.Controls.Add(this.lbDivisor);
            this.panelZone1.Controls.Add(this.txtSetPointZone2);
            this.panelZone1.Controls.Add(this.ledZ2);
            this.panelZone1.Controls.Add(this.label30);
            this.panelZone1.Controls.Add(this.label29);
            this.panelZone1.Controls.Add(this.label28);
            this.panelZone1.Controls.Add(this.label27);
            this.panelZone1.Controls.Add(this.label26);
            this.panelZone1.Controls.Add(this.label25);
            this.panelZone1.Controls.Add(this.label24);
            this.panelZone1.Controls.Add(this.label23);
            this.panelZone1.Controls.Add(this.label22);
            this.panelZone1.Controls.Add(this.label21);
            this.panelZone1.Controls.Add(this.label20);
            this.panelZone1.Controls.Add(this.label19);
            this.panelZone1.Controls.Add(this.label18);
            this.panelZone1.Controls.Add(this.label17);
            this.panelZone1.Controls.Add(this.label16);
            this.panelZone1.Controls.Add(this.label15);
            this.panelZone1.Controls.Add(this.label14);
            this.panelZone1.Controls.Add(this.label13);
            this.panelZone1.Controls.Add(this.label12);
            this.panelZone1.Controls.Add(this.label11);
            this.panelZone1.Controls.Add(this.label10);
            this.panelZone1.Controls.Add(this.label9);
            this.panelZone1.Controls.Add(this.label8);
            this.panelZone1.Controls.Add(this.label7);
            this.panelZone1.Controls.Add(this.label6);
            this.panelZone1.Controls.Add(this.txtTC24);
            this.panelZone1.Controls.Add(this.txtTC23);
            this.panelZone1.Controls.Add(this.txtTC22);
            this.panelZone1.Controls.Add(this.txtTC21);
            this.panelZone1.Controls.Add(this.txtTC20);
            this.panelZone1.Controls.Add(this.txtTC19);
            this.panelZone1.Controls.Add(this.txtTC18);
            this.panelZone1.Controls.Add(this.txtTC17);
            this.panelZone1.Controls.Add(this.txtTC16);
            this.panelZone1.Controls.Add(this.txtTC15);
            this.panelZone1.Controls.Add(this.txtTC14);
            this.panelZone1.Controls.Add(this.txtTC13);
            this.panelZone1.Controls.Add(this.txtTC12);
            this.panelZone1.Controls.Add(this.txtTC11);
            this.panelZone1.Controls.Add(this.txtTC10);
            this.panelZone1.Controls.Add(this.txtTC9);
            this.panelZone1.Controls.Add(this.txtTC8);
            this.panelZone1.Controls.Add(this.txtTC7);
            this.panelZone1.Controls.Add(this.txtTC6);
            this.panelZone1.Controls.Add(this.txtTC5);
            this.panelZone1.Controls.Add(this.txtTC4);
            this.panelZone1.Controls.Add(this.txtTC3);
            this.panelZone1.Controls.Add(this.txtTC2);
            this.panelZone1.Controls.Add(this.txtTC1);
            this.panelZone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelZone1.Location = new System.Drawing.Point(792, 964);
            this.panelZone1.Name = "panelZone1";
            this.panelZone1.Size = new System.Drawing.Size(1110, 70);
            this.panelZone1.TabIndex = 225;
            this.panelZone1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelZone1_Paint);
            // 
            // lbDivisor
            // 
            this.lbDivisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(220)))));
            this.lbDivisor.Location = new System.Drawing.Point(-7, 158);
            this.lbDivisor.Name = "lbDivisor";
            this.lbDivisor.Size = new System.Drawing.Size(1650, 5);
            this.lbDivisor.TabIndex = 186;
            // 
            // txtSetPointZone2
            // 
            this.txtSetPointZone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetPointZone2.Location = new System.Drawing.Point(773, 171);
            this.txtSetPointZone2.Name = "txtSetPointZone2";
            this.txtSetPointZone2.ReadOnly = true;
            this.txtSetPointZone2.Size = new System.Drawing.Size(109, 44);
            this.txtSetPointZone2.TabIndex = 185;
            this.txtSetPointZone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ledZ2
            // 
            this.ledZ2.BackColor = System.Drawing.Color.Transparent;
            this.ledZ2.Image = ((System.Drawing.Image)(resources.GetObject("ledZ2.Image")));
            this.ledZ2.Location = new System.Drawing.Point(888, 171);
            this.ledZ2.Name = "ledZ2";
            this.ledZ2.Size = new System.Drawing.Size(43, 39);
            this.ledZ2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ledZ2.TabIndex = 184;
            this.ledZ2.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(635, 180);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(119, 29);
            this.label30.TabIndex = 183;
            this.label30.Text = "ZONE #2";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(1544, 225);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 25);
            this.label29.TabIndex = 48;
            this.label29.Text = "T-24";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(1410, 225);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(60, 25);
            this.label28.TabIndex = 47;
            this.label28.Text = "T-23";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(1281, 225);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 25);
            this.label27.TabIndex = 46;
            this.label27.Text = "T-22";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(1152, 225);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 25);
            this.label26.TabIndex = 45;
            this.label26.Text = "T-21";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(1005, 225);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 25);
            this.label25.TabIndex = 44;
            this.label25.Text = "T-20";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(855, 225);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 25);
            this.label24.TabIndex = 43;
            this.label24.Text = "T-19";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(716, 225);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 25);
            this.label23.TabIndex = 42;
            this.label23.Text = "T-18";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(585, 225);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 25);
            this.label22.TabIndex = 41;
            this.label22.Text = "T-17";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(450, 225);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 25);
            this.label21.TabIndex = 40;
            this.label21.Text = "T-16";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(315, 226);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 25);
            this.label20.TabIndex = 39;
            this.label20.Text = "T-15";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(185, 227);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 25);
            this.label19.TabIndex = 38;
            this.label19.Text = "T-14";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(55, 225);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 25);
            this.label18.TabIndex = 37;
            this.label18.Text = "T-13";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(993, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "T-24";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(898, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "T-23";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(811, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "T-22";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(717, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "T-21";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(633, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "T-20";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(557, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "T-19";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(469, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "T-18";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(381, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "T-17";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(288, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "T-16";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(205, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "T-15";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(125, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "T-14";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "T-13";
            // 
            // txtTC24
            // 
            this.txtTC24.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC24.Location = new System.Drawing.Point(1526, 254);
            this.txtTC24.Name = "txtTC24";
            this.txtTC24.ReadOnly = true;
            this.txtTC24.Size = new System.Drawing.Size(100, 44);
            this.txtTC24.TabIndex = 24;
            this.txtTC24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC23
            // 
            this.txtTC23.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC23.Location = new System.Drawing.Point(1389, 254);
            this.txtTC23.Name = "txtTC23";
            this.txtTC23.ReadOnly = true;
            this.txtTC23.Size = new System.Drawing.Size(100, 44);
            this.txtTC23.TabIndex = 23;
            this.txtTC23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC22
            // 
            this.txtTC22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC22.Location = new System.Drawing.Point(1260, 253);
            this.txtTC22.Name = "txtTC22";
            this.txtTC22.ReadOnly = true;
            this.txtTC22.Size = new System.Drawing.Size(100, 44);
            this.txtTC22.TabIndex = 22;
            this.txtTC22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC21
            // 
            this.txtTC21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC21.Location = new System.Drawing.Point(1129, 254);
            this.txtTC21.Name = "txtTC21";
            this.txtTC21.ReadOnly = true;
            this.txtTC21.Size = new System.Drawing.Size(100, 44);
            this.txtTC21.TabIndex = 21;
            this.txtTC21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC20
            // 
            this.txtTC20.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC20.Location = new System.Drawing.Point(981, 253);
            this.txtTC20.Name = "txtTC20";
            this.txtTC20.ReadOnly = true;
            this.txtTC20.Size = new System.Drawing.Size(100, 44);
            this.txtTC20.TabIndex = 20;
            this.txtTC20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC19
            // 
            this.txtTC19.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC19.Location = new System.Drawing.Point(830, 254);
            this.txtTC19.Name = "txtTC19";
            this.txtTC19.ReadOnly = true;
            this.txtTC19.Size = new System.Drawing.Size(100, 44);
            this.txtTC19.TabIndex = 19;
            this.txtTC19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC18
            // 
            this.txtTC18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC18.Location = new System.Drawing.Point(695, 254);
            this.txtTC18.Name = "txtTC18";
            this.txtTC18.ReadOnly = true;
            this.txtTC18.Size = new System.Drawing.Size(100, 44);
            this.txtTC18.TabIndex = 18;
            this.txtTC18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC17
            // 
            this.txtTC17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC17.Location = new System.Drawing.Point(561, 256);
            this.txtTC17.Name = "txtTC17";
            this.txtTC17.ReadOnly = true;
            this.txtTC17.Size = new System.Drawing.Size(100, 44);
            this.txtTC17.TabIndex = 17;
            this.txtTC17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC16
            // 
            this.txtTC16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC16.Location = new System.Drawing.Point(426, 256);
            this.txtTC16.Name = "txtTC16";
            this.txtTC16.ReadOnly = true;
            this.txtTC16.Size = new System.Drawing.Size(100, 44);
            this.txtTC16.TabIndex = 16;
            this.txtTC16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC15
            // 
            this.txtTC15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC15.Location = new System.Drawing.Point(292, 256);
            this.txtTC15.Name = "txtTC15";
            this.txtTC15.ReadOnly = true;
            this.txtTC15.Size = new System.Drawing.Size(100, 44);
            this.txtTC15.TabIndex = 15;
            this.txtTC15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC14
            // 
            this.txtTC14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC14.Location = new System.Drawing.Point(165, 256);
            this.txtTC14.Name = "txtTC14";
            this.txtTC14.ReadOnly = true;
            this.txtTC14.Size = new System.Drawing.Size(100, 44);
            this.txtTC14.TabIndex = 14;
            this.txtTC14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC13
            // 
            this.txtTC13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC13.Location = new System.Drawing.Point(32, 256);
            this.txtTC13.Name = "txtTC13";
            this.txtTC13.ReadOnly = true;
            this.txtTC13.Size = new System.Drawing.Size(100, 44);
            this.txtTC13.TabIndex = 13;
            this.txtTC13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC12
            // 
            this.txtTC12.Location = new System.Drawing.Point(988, 34);
            this.txtTC12.Name = "txtTC12";
            this.txtTC12.ReadOnly = true;
            this.txtTC12.Size = new System.Drawing.Size(60, 29);
            this.txtTC12.TabIndex = 12;
            this.txtTC12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTC12.TextChanged += new System.EventHandler(this.txtTC12_TextChanged);
            // 
            // txtTC11
            // 
            this.txtTC11.Location = new System.Drawing.Point(894, 35);
            this.txtTC11.Name = "txtTC11";
            this.txtTC11.ReadOnly = true;
            this.txtTC11.Size = new System.Drawing.Size(58, 29);
            this.txtTC11.TabIndex = 11;
            this.txtTC11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC10
            // 
            this.txtTC10.Location = new System.Drawing.Point(808, 34);
            this.txtTC10.Name = "txtTC10";
            this.txtTC10.ReadOnly = true;
            this.txtTC10.Size = new System.Drawing.Size(58, 29);
            this.txtTC10.TabIndex = 10;
            this.txtTC10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC9
            // 
            this.txtTC9.Location = new System.Drawing.Point(711, 35);
            this.txtTC9.Name = "txtTC9";
            this.txtTC9.ReadOnly = true;
            this.txtTC9.Size = new System.Drawing.Size(58, 29);
            this.txtTC9.TabIndex = 9;
            this.txtTC9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC8
            // 
            this.txtTC8.Location = new System.Drawing.Point(630, 35);
            this.txtTC8.Name = "txtTC8";
            this.txtTC8.ReadOnly = true;
            this.txtTC8.Size = new System.Drawing.Size(58, 29);
            this.txtTC8.TabIndex = 8;
            this.txtTC8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC7
            // 
            this.txtTC7.Location = new System.Drawing.Point(552, 35);
            this.txtTC7.Name = "txtTC7";
            this.txtTC7.ReadOnly = true;
            this.txtTC7.Size = new System.Drawing.Size(58, 29);
            this.txtTC7.TabIndex = 7;
            this.txtTC7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC6
            // 
            this.txtTC6.Location = new System.Drawing.Point(466, 35);
            this.txtTC6.Name = "txtTC6";
            this.txtTC6.ReadOnly = true;
            this.txtTC6.Size = new System.Drawing.Size(58, 29);
            this.txtTC6.TabIndex = 6;
            this.txtTC6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC5
            // 
            this.txtTC5.Location = new System.Drawing.Point(370, 33);
            this.txtTC5.Name = "txtTC5";
            this.txtTC5.ReadOnly = true;
            this.txtTC5.Size = new System.Drawing.Size(58, 29);
            this.txtTC5.TabIndex = 5;
            this.txtTC5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC4
            // 
            this.txtTC4.Location = new System.Drawing.Point(283, 34);
            this.txtTC4.Name = "txtTC4";
            this.txtTC4.ReadOnly = true;
            this.txtTC4.Size = new System.Drawing.Size(58, 29);
            this.txtTC4.TabIndex = 4;
            this.txtTC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC3
            // 
            this.txtTC3.Location = new System.Drawing.Point(200, 33);
            this.txtTC3.Name = "txtTC3";
            this.txtTC3.ReadOnly = true;
            this.txtTC3.Size = new System.Drawing.Size(58, 29);
            this.txtTC3.TabIndex = 3;
            this.txtTC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC2
            // 
            this.txtTC2.Location = new System.Drawing.Point(118, 33);
            this.txtTC2.Name = "txtTC2";
            this.txtTC2.ReadOnly = true;
            this.txtTC2.Size = new System.Drawing.Size(58, 29);
            this.txtTC2.TabIndex = 2;
            this.txtTC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC1
            // 
            this.txtTC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC1.Location = new System.Drawing.Point(30, 33);
            this.txtTC1.Name = "txtTC1";
            this.txtTC1.ReadOnly = true;
            this.txtTC1.Size = new System.Drawing.Size(58, 29);
            this.txtTC1.TabIndex = 1;
            this.txtTC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.White;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(449, 832);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(63, 20);
            this.label33.TabIndex = 227;
            this.label33.Text = "Time [s]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(792, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 72);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Zone #1:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Red;
            this.label36.Location = new System.Drawing.Point(74, 30);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(63, 29);
            this.label36.TabIndex = 56;
            this.label36.Text = " 0 °C";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(792, 543);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 71);
            this.groupBox3.TabIndex = 233;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Zone #2:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Red;
            this.label38.Location = new System.Drawing.Point(75, 30);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(63, 29);
            this.label38.TabIndex = 56;
            this.label38.Text = " 0 °C";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.SteelBlue;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            chartArea14.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart1.Legends.Add(legend14);
            this.chart1.Location = new System.Drawing.Point(792, 614);
            this.chart1.Name = "chart1";
            series157.ChartArea = "ChartArea1";
            series157.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series157.Legend = "Legend1";
            series157.Name = "T-13";
            series158.ChartArea = "ChartArea1";
            series158.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series158.Legend = "Legend1";
            series158.Name = "T-14";
            series159.ChartArea = "ChartArea1";
            series159.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series159.Legend = "Legend1";
            series159.Name = "T-15";
            series160.ChartArea = "ChartArea1";
            series160.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series160.Legend = "Legend1";
            series160.Name = "T-16";
            series161.ChartArea = "ChartArea1";
            series161.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series161.Legend = "Legend1";
            series161.Name = "T-17";
            series162.ChartArea = "ChartArea1";
            series162.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series162.Legend = "Legend1";
            series162.Name = "T-18";
            series163.ChartArea = "ChartArea1";
            series163.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series163.Legend = "Legend1";
            series163.Name = "T-19";
            series164.ChartArea = "ChartArea1";
            series164.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series164.Legend = "Legend1";
            series164.Name = "T-20";
            series165.ChartArea = "ChartArea1";
            series165.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series165.Legend = "Legend1";
            series165.Name = "T-21";
            series166.ChartArea = "ChartArea1";
            series166.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series166.Legend = "Legend1";
            series166.Name = "T-22";
            series167.ChartArea = "ChartArea1";
            series167.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series167.Legend = "Legend1";
            series167.Name = "T-23";
            series168.ChartArea = "ChartArea1";
            series168.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series168.Legend = "Legend1";
            series168.Name = "T-24";
            this.chart1.Series.Add(series157);
            this.chart1.Series.Add(series158);
            this.chart1.Series.Add(series159);
            this.chart1.Series.Add(series160);
            this.chart1.Series.Add(series161);
            this.chart1.Series.Add(series162);
            this.chart1.Series.Add(series163);
            this.chart1.Series.Add(series164);
            this.chart1.Series.Add(series165);
            this.chart1.Series.Add(series166);
            this.chart1.Series.Add(series167);
            this.chart1.Series.Add(series168);
            this.chart1.Size = new System.Drawing.Size(1110, 350);
            this.chart1.TabIndex = 238;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(91, 495);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 182;
            this.pictureBox3.TabStop = false;
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(220)))));
            this.label39.Location = new System.Drawing.Point(-7, 158);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(1650, 5);
            this.label39.TabIndex = 186;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(773, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(109, 44);
            this.textBox1.TabIndex = 185;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(773, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(109, 44);
            this.textBox2.TabIndex = 182;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(1544, 225);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(60, 25);
            this.label41.TabIndex = 48;
            this.label41.Text = "T-24";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(1410, 225);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(60, 25);
            this.label42.TabIndex = 47;
            this.label42.Text = "T-23";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(1281, 225);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(60, 25);
            this.label43.TabIndex = 46;
            this.label43.Text = "T-22";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(1152, 225);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(60, 25);
            this.label44.TabIndex = 45;
            this.label44.Text = "T-21";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(1005, 225);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(60, 25);
            this.label45.TabIndex = 44;
            this.label45.Text = "T-20";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(855, 225);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(60, 25);
            this.label46.TabIndex = 43;
            this.label46.Text = "T-19";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(716, 225);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(60, 25);
            this.label47.TabIndex = 42;
            this.label47.Text = "T-18";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(585, 225);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(60, 25);
            this.label48.TabIndex = 41;
            this.label48.Text = "T-17";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(450, 225);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(60, 25);
            this.label49.TabIndex = 40;
            this.label49.Text = "T-16";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(315, 226);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(60, 25);
            this.label50.TabIndex = 39;
            this.label50.Text = "T-15";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(185, 227);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(60, 25);
            this.label51.TabIndex = 38;
            this.label51.Text = "T-14";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(55, 225);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(60, 25);
            this.label52.TabIndex = 37;
            this.label52.Text = "T-13";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(1544, 67);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(60, 25);
            this.label53.TabIndex = 36;
            this.label53.Text = "T-12";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(1410, 67);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(60, 25);
            this.label54.TabIndex = 35;
            this.label54.Text = "T-11";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(1281, 67);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(60, 25);
            this.label55.TabIndex = 34;
            this.label55.Text = "T-10";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Location = new System.Drawing.Point(1155, 67);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(47, 25);
            this.label56.TabIndex = 33;
            this.label56.Text = "T-9";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.White;
            this.label57.Location = new System.Drawing.Point(1008, 67);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(47, 25);
            this.label57.TabIndex = 32;
            this.label57.Text = "T-8";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Location = new System.Drawing.Point(859, 67);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(47, 25);
            this.label58.TabIndex = 31;
            this.label58.Text = "T-7";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Location = new System.Drawing.Point(720, 67);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(47, 25);
            this.label59.TabIndex = 30;
            this.label59.Text = "T-6";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(589, 67);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(47, 25);
            this.label60.TabIndex = 29;
            this.label60.Text = "T-5";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.White;
            this.label61.Location = new System.Drawing.Point(453, 67);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(47, 25);
            this.label61.TabIndex = 28;
            this.label61.Text = "T-4";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(319, 67);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(47, 25);
            this.label62.TabIndex = 27;
            this.label62.Text = "T-3";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(191, 67);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(47, 25);
            this.label63.TabIndex = 26;
            this.label63.Text = "T-2";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(55, 67);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(47, 25);
            this.label64.TabIndex = 25;
            this.label64.Text = "T-1";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(1526, 254);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 44);
            this.textBox3.TabIndex = 24;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(1389, 254);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 44);
            this.textBox4.TabIndex = 23;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(1260, 253);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 44);
            this.textBox5.TabIndex = 22;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(1129, 254);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 44);
            this.textBox6.TabIndex = 21;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(981, 253);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 44);
            this.textBox7.TabIndex = 20;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(830, 254);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 44);
            this.textBox8.TabIndex = 19;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(695, 254);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 44);
            this.textBox9.TabIndex = 18;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(561, 256);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 44);
            this.textBox10.TabIndex = 17;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(426, 256);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 44);
            this.textBox11.TabIndex = 16;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(292, 256);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 44);
            this.textBox12.TabIndex = 15;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(165, 256);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 44);
            this.textBox13.TabIndex = 14;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(32, 256);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(100, 44);
            this.textBox14.TabIndex = 13;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(1526, 96);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(100, 44);
            this.textBox15.TabIndex = 12;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(1389, 96);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(100, 44);
            this.textBox16.TabIndex = 11;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(1260, 96);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(100, 44);
            this.textBox17.TabIndex = 10;
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(1129, 96);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(100, 44);
            this.textBox18.TabIndex = 9;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox19
            // 
            this.textBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.Location = new System.Drawing.Point(981, 96);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(100, 44);
            this.textBox19.TabIndex = 8;
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            this.textBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.Location = new System.Drawing.Point(830, 96);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(100, 44);
            this.textBox20.TabIndex = 7;
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox21
            // 
            this.textBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.Location = new System.Drawing.Point(695, 96);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(100, 44);
            this.textBox21.TabIndex = 6;
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox22
            // 
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.Location = new System.Drawing.Point(561, 96);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(100, 44);
            this.textBox22.TabIndex = 5;
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(426, 96);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(100, 44);
            this.textBox23.TabIndex = 4;
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox24.Location = new System.Drawing.Point(292, 96);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(100, 44);
            this.textBox24.TabIndex = 3;
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox25.Location = new System.Drawing.Point(165, 96);
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new System.Drawing.Size(100, 44);
            this.textBox25.TabIndex = 2;
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox26
            // 
            this.textBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox26.Location = new System.Drawing.Point(32, 96);
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new System.Drawing.Size(100, 44);
            this.textBox26.TabIndex = 1;
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(635, 180);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(119, 29);
            this.label40.TabIndex = 183;
            this.label40.Text = "ZONE #2";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.White;
            this.label65.Location = new System.Drawing.Point(635, 15);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(119, 29);
            this.label65.TabIndex = 0;
            this.label65.Text = "ZONE #1";
            // 
            // btnEMO
            // 
            this.btnEMO.BackColor = System.Drawing.Color.White;
            this.btnEMO.Image = ((System.Drawing.Image)(resources.GetObject("btnEMO.Image")));
            this.btnEMO.Location = new System.Drawing.Point(283, 987);
            this.btnEMO.Name = "btnEMO";
            this.btnEMO.Size = new System.Drawing.Size(95, 90);
            this.btnEMO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEMO.TabIndex = 221;
            this.btnEMO.TabStop = false;
            this.btnEMO.Click += new System.EventHandler(this.btnEMO_Click);
            // 
            // btnTypeTime
            // 
            this.btnTypeTime.BackColor = System.Drawing.Color.White;
            this.btnTypeTime.FlatAppearance.BorderSize = 0;
            this.btnTypeTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeTime.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            this.btnTypeTime.IconColor = System.Drawing.Color.Black;
            this.btnTypeTime.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTypeTime.IconSize = 30;
            this.btnTypeTime.Location = new System.Drawing.Point(91, 578);
            this.btnTypeTime.Name = "btnTypeTime";
            this.btnTypeTime.Size = new System.Drawing.Size(38, 33);
            this.btnTypeTime.TabIndex = 220;
            this.btnTypeTime.UseVisualStyleBackColor = false;
            this.btnTypeTime.Visible = false;
            this.btnTypeTime.Click += new System.EventHandler(this.btnTypeTime_Click);
            // 
            // btnClearChart
            // 
            this.btnClearChart.BackColor = System.Drawing.Color.White;
            this.btnClearChart.FlatAppearance.BorderSize = 0;
            this.btnClearChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearChart.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnClearChart.IconColor = System.Drawing.Color.Black;
            this.btnClearChart.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClearChart.IconSize = 30;
            this.btnClearChart.Location = new System.Drawing.Point(169, 553);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(38, 33);
            this.btnClearChart.TabIndex = 219;
            this.btnClearChart.UseVisualStyleBackColor = false;
            this.btnClearChart.Visible = false;
            this.btnClearChart.Click += new System.EventHandler(this.btnClearChart_Click);
            // 
            // btnRecordDataChart
            // 
            this.btnRecordDataChart.BackColor = System.Drawing.Color.White;
            this.btnRecordDataChart.FlatAppearance.BorderSize = 0;
            this.btnRecordDataChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordDataChart.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.btnRecordDataChart.IconColor = System.Drawing.Color.Black;
            this.btnRecordDataChart.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRecordDataChart.Location = new System.Drawing.Point(159, 614);
            this.btnRecordDataChart.Name = "btnRecordDataChart";
            this.btnRecordDataChart.Size = new System.Drawing.Size(48, 33);
            this.btnRecordDataChart.TabIndex = 217;
            this.btnRecordDataChart.UseVisualStyleBackColor = false;
            this.btnRecordDataChart.Visible = false;
            this.btnRecordDataChart.Click += new System.EventHandler(this.btnRecordDataChart_Click);
            // 
            // btnChartMode
            // 
            this.btnChartMode.BackColor = System.Drawing.Color.White;
            this.btnChartMode.FlatAppearance.BorderSize = 0;
            this.btnChartMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChartMode.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.btnChartMode.IconColor = System.Drawing.Color.Black;
            this.btnChartMode.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnChartMode.Location = new System.Drawing.Point(153, 712);
            this.btnChartMode.Name = "btnChartMode";
            this.btnChartMode.Size = new System.Drawing.Size(48, 33);
            this.btnChartMode.TabIndex = 215;
            this.btnChartMode.UseVisualStyleBackColor = false;
            this.btnChartMode.Visible = false;
            this.btnChartMode.Click += new System.EventHandler(this.btnChartMode_Click);
            // 
            // btnStartStopChart
            // 
            this.btnStartStopChart.BackColor = System.Drawing.Color.White;
            this.btnStartStopChart.FlatAppearance.BorderSize = 0;
            this.btnStartStopChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStopChart.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.btnStartStopChart.IconColor = System.Drawing.Color.Black;
            this.btnStartStopChart.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnStartStopChart.Location = new System.Drawing.Point(159, 668);
            this.btnStartStopChart.Name = "btnStartStopChart";
            this.btnStartStopChart.Size = new System.Drawing.Size(48, 33);
            this.btnStartStopChart.TabIndex = 213;
            this.btnStartStopChart.UseVisualStyleBackColor = false;
            this.btnStartStopChart.Visible = false;
            this.btnStartStopChart.Click += new System.EventHandler(this.btnStartStopChart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(888, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 184;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(888, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 181;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripMenuItem,
            this.manualControlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // manualControlToolStripMenuItem
            // 
            this.manualControlToolStripMenuItem.Name = "manualControlToolStripMenuItem";
            this.manualControlToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.manualControlToolStripMenuItem.Text = "Manual Control";
            this.manualControlToolStripMenuItem.Click += new System.EventHandler(this.manualControlToolStripMenuItem_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.menuStrip1);
            this.panel8.Location = new System.Drawing.Point(267, 124);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(511, 366);
            this.panel8.TabIndex = 240;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel10.Controls.Add(this.pictureBox7);
            this.panel10.Controls.Add(this.pictureBox8);
            this.panel10.Controls.Add(this.pictureBox9);
            this.panel10.Controls.Add(this.label72);
            this.panel10.Controls.Add(this.label71);
            this.panel10.Controls.Add(this.label70);
            this.panel10.Controls.Add(this.label69);
            this.panel10.Controls.Add(this.label68);
            this.panel10.Controls.Add(this.label67);
            this.panel10.Controls.Add(this.textBox43);
            this.panel10.Controls.Add(this.textBox42);
            this.panel10.Controls.Add(this.textBox41);
            this.panel10.Controls.Add(this.textBox40);
            this.panel10.Location = new System.Drawing.Point(23, 45);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(461, 303);
            this.panel10.TabIndex = 1;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(378, 103);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 230;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(378, 155);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 229;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(378, 56);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 228;
            this.pictureBox9.TabStop = false;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(287, 95);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(38, 20);
            this.label72.TabIndex = 9;
            this.label72.Text = "[°C]";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(287, 63);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(38, 20);
            this.label71.TabIndex = 8;
            this.label71.Text = "[°C]";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.Color.White;
            this.label70.Location = new System.Drawing.Point(124, 159);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(51, 20);
            this.label70.TabIndex = 7;
            this.label70.Text = "Cycle\r\n";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.White;
            this.label69.Location = new System.Drawing.Point(130, 123);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(45, 20);
            this.label69.TabIndex = 6;
            this.label69.Text = "Type";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Location = new System.Drawing.Point(105, 93);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(70, 20);
            this.label68.TabIndex = 5;
            this.label68.Text = "Setpoint";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.White;
            this.label67.Location = new System.Drawing.Point(5, 60);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(175, 20);
            this.label67.TabIndex = 4;
            this.label67.Text = "Average Temperature ";
            this.label67.Click += new System.EventHandler(this.label67_Click);
            // 
            // textBox43
            // 
            this.textBox43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox43.Location = new System.Drawing.Point(181, 158);
            this.textBox43.Name = "textBox43";
            this.textBox43.ReadOnly = true;
            this.textBox43.Size = new System.Drawing.Size(100, 26);
            this.textBox43.TabIndex = 3;
            this.textBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox42
            // 
            this.textBox42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox42.Location = new System.Drawing.Point(181, 124);
            this.textBox42.Name = "textBox42";
            this.textBox42.ReadOnly = true;
            this.textBox42.Size = new System.Drawing.Size(100, 26);
            this.textBox42.TabIndex = 2;
            this.textBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox41
            // 
            this.textBox41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox41.Location = new System.Drawing.Point(181, 93);
            this.textBox41.Name = "textBox41";
            this.textBox41.ReadOnly = true;
            this.textBox41.Size = new System.Drawing.Size(100, 26);
            this.textBox41.TabIndex = 1;
            this.textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox41.TextChanged += new System.EventHandler(this.textBox41_TextChanged);
            // 
            // textBox40
            // 
            this.textBox40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox40.Location = new System.Drawing.Point(181, 60);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(100, 26);
            this.textBox40.TabIndex = 0;
            this.textBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox40.TextChanged += new System.EventHandler(this.textBox40_TextChanged);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel11.Controls.Add(this.pictureBox10);
            this.panel11.Controls.Add(this.pictureBox11);
            this.panel11.Controls.Add(this.button1);
            this.panel11.Controls.Add(this.label73);
            this.panel11.Controls.Add(this.label77);
            this.panel11.Controls.Add(this.textBox46);
            this.panel11.Location = new System.Drawing.Point(23, 45);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(461, 303);
            this.panel11.TabIndex = 242;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(252, 115);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 231;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(252, 67);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 230;
            this.pictureBox11.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(352, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "apply changes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(191, 96);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(38, 20);
            this.label73.TabIndex = 6;
            this.label73.Text = "[°C]";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.ForeColor = System.Drawing.Color.White;
            this.label77.Location = new System.Drawing.Point(5, 93);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(70, 20);
            this.label77.TabIndex = 5;
            this.label77.Text = "Setpoint";
            // 
            // textBox46
            // 
            this.textBox46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox46.Location = new System.Drawing.Point(85, 93);
            this.textBox46.MaxLength = 2;
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(100, 26);
            this.textBox46.TabIndex = 1;
            this.textBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox46.TextChanged += new System.EventHandler(this.textBox46_TextChanged);
            this.textBox46.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox46_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.menuStrip2);
            this.panel12.Location = new System.Drawing.Point(267, 614);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(511, 366);
            this.panel12.TabIndex = 241;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel14.Controls.Add(this.pictureBox12);
            this.panel14.Controls.Add(this.pictureBox13);
            this.panel14.Controls.Add(this.button2);
            this.panel14.Controls.Add(this.label81);
            this.panel14.Controls.Add(this.label82);
            this.panel14.Controls.Add(this.textBox49);
            this.panel14.Location = new System.Drawing.Point(23, 45);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(461, 303);
            this.panel14.TabIndex = 242;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(235, 115);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(30, 30);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 233;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(235, 67);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(30, 30);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 232;
            this.pictureBox13.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(352, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "apply changes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(191, 96);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(38, 20);
            this.label81.TabIndex = 6;
            this.label81.Text = "[°C]";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.ForeColor = System.Drawing.Color.White;
            this.label82.Location = new System.Drawing.Point(5, 93);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(70, 20);
            this.label82.TabIndex = 5;
            this.label82.Text = "Setpoint";
            // 
            // textBox49
            // 
            this.textBox49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox49.Location = new System.Drawing.Point(85, 93);
            this.textBox49.MaxLength = 2;
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(100, 26);
            this.textBox49.TabIndex = 1;
            this.textBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox49.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox49_KeyPress);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel13.Controls.Add(this.pictureBox6);
            this.panel13.Controls.Add(this.pictureBox5);
            this.panel13.Controls.Add(this.pictureBox4);
            this.panel13.Controls.Add(this.label74);
            this.panel13.Controls.Add(this.label75);
            this.panel13.Controls.Add(this.label76);
            this.panel13.Controls.Add(this.label78);
            this.panel13.Controls.Add(this.label79);
            this.panel13.Controls.Add(this.label80);
            this.panel13.Controls.Add(this.textBox44);
            this.panel13.Controls.Add(this.textBox45);
            this.panel13.Controls.Add(this.textBox47);
            this.panel13.Controls.Add(this.textBox48);
            this.panel13.Location = new System.Drawing.Point(23, 45);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(461, 303);
            this.panel13.TabIndex = 1;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(391, 103);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 227;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(391, 155);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 226;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(391, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 225;
            this.pictureBox4.TabStop = false;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(287, 96);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(38, 20);
            this.label74.TabIndex = 9;
            this.label74.Text = "[°C]";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(287, 63);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(38, 20);
            this.label75.TabIndex = 8;
            this.label75.Text = "[°C]";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.ForeColor = System.Drawing.Color.White;
            this.label76.Location = new System.Drawing.Point(121, 162);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(51, 20);
            this.label76.TabIndex = 7;
            this.label76.Text = "Cycle\r\n";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.ForeColor = System.Drawing.Color.White;
            this.label78.Location = new System.Drawing.Point(127, 130);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(45, 20);
            this.label78.TabIndex = 6;
            this.label78.Text = "Type";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.White;
            this.label79.Location = new System.Drawing.Point(102, 99);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(70, 20);
            this.label79.TabIndex = 5;
            this.label79.Text = "Setpoint";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.ForeColor = System.Drawing.Color.White;
            this.label80.Location = new System.Drawing.Point(5, 60);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(175, 20);
            this.label80.TabIndex = 4;
            this.label80.Text = "Average Temperature ";
            // 
            // textBox44
            // 
            this.textBox44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox44.Location = new System.Drawing.Point(182, 159);
            this.textBox44.Name = "textBox44";
            this.textBox44.ReadOnly = true;
            this.textBox44.Size = new System.Drawing.Size(100, 26);
            this.textBox44.TabIndex = 3;
            this.textBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox45
            // 
            this.textBox45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox45.Location = new System.Drawing.Point(182, 127);
            this.textBox45.Name = "textBox45";
            this.textBox45.ReadOnly = true;
            this.textBox45.Size = new System.Drawing.Size(100, 26);
            this.textBox45.TabIndex = 2;
            this.textBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox47
            // 
            this.textBox47.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox47.Location = new System.Drawing.Point(181, 93);
            this.textBox47.Name = "textBox47";
            this.textBox47.ReadOnly = true;
            this.textBox47.Size = new System.Drawing.Size(100, 26);
            this.textBox47.TabIndex = 1;
            this.textBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox48
            // 
            this.textBox48.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox48.Location = new System.Drawing.Point(181, 60);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(100, 26);
            this.textBox48.TabIndex = 0;
            this.textBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(511, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem1.Text = "Status";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 20);
            this.toolStripMenuItem2.Text = "Manual Control";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // zone2label12
            // 
            this.zone2label12.AutoSize = true;
            this.zone2label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label12.ForeColor = System.Drawing.Color.White;
            this.zone2label12.Location = new System.Drawing.Point(985, 11);
            this.zone2label12.Name = "zone2label12";
            this.zone2label12.Size = new System.Drawing.Size(47, 20);
            this.zone2label12.TabIndex = 25;
            this.zone2label12.Text = "T-12";
            // 
            // zone2label11
            // 
            this.zone2label11.AutoSize = true;
            this.zone2label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label11.ForeColor = System.Drawing.Color.White;
            this.zone2label11.Location = new System.Drawing.Point(904, 11);
            this.zone2label11.Name = "zone2label11";
            this.zone2label11.Size = new System.Drawing.Size(47, 20);
            this.zone2label11.TabIndex = 25;
            this.zone2label11.Text = "T-11";
            // 
            // zone2label10
            // 
            this.zone2label10.AutoSize = true;
            this.zone2label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label10.ForeColor = System.Drawing.Color.White;
            this.zone2label10.Location = new System.Drawing.Point(811, 10);
            this.zone2label10.Name = "zone2label10";
            this.zone2label10.Size = new System.Drawing.Size(47, 20);
            this.zone2label10.TabIndex = 25;
            this.zone2label10.Text = "T-10";
            // 
            // zone2label9
            // 
            this.zone2label9.AutoSize = true;
            this.zone2label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label9.ForeColor = System.Drawing.Color.White;
            this.zone2label9.Location = new System.Drawing.Point(732, 10);
            this.zone2label9.Name = "zone2label9";
            this.zone2label9.Size = new System.Drawing.Size(37, 20);
            this.zone2label9.TabIndex = 25;
            this.zone2label9.Text = "T-9";
            // 
            // zone2label8
            // 
            this.zone2label8.AutoSize = true;
            this.zone2label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label8.ForeColor = System.Drawing.Color.White;
            this.zone2label8.Location = new System.Drawing.Point(639, 10);
            this.zone2label8.Name = "zone2label8";
            this.zone2label8.Size = new System.Drawing.Size(37, 20);
            this.zone2label8.TabIndex = 25;
            this.zone2label8.Text = "T-8";
            // 
            // zone2label7
            // 
            this.zone2label7.AutoSize = true;
            this.zone2label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label7.ForeColor = System.Drawing.Color.White;
            this.zone2label7.Location = new System.Drawing.Point(550, 10);
            this.zone2label7.Name = "zone2label7";
            this.zone2label7.Size = new System.Drawing.Size(37, 20);
            this.zone2label7.TabIndex = 25;
            this.zone2label7.Text = "T-7";
            // 
            // zone2label6
            // 
            this.zone2label6.AutoSize = true;
            this.zone2label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label6.ForeColor = System.Drawing.Color.White;
            this.zone2label6.Location = new System.Drawing.Point(468, 10);
            this.zone2label6.Name = "zone2label6";
            this.zone2label6.Size = new System.Drawing.Size(37, 20);
            this.zone2label6.TabIndex = 25;
            this.zone2label6.Text = "T-6";
            this.zone2label6.Click += new System.EventHandler(this.zone2label6_Click);
            // 
            // zone2label5
            // 
            this.zone2label5.AutoSize = true;
            this.zone2label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label5.ForeColor = System.Drawing.Color.White;
            this.zone2label5.Location = new System.Drawing.Point(378, 10);
            this.zone2label5.Name = "zone2label5";
            this.zone2label5.Size = new System.Drawing.Size(37, 20);
            this.zone2label5.TabIndex = 25;
            this.zone2label5.Text = "T-5";
            // 
            // zone2label4
            // 
            this.zone2label4.AutoSize = true;
            this.zone2label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label4.ForeColor = System.Drawing.Color.White;
            this.zone2label4.Location = new System.Drawing.Point(292, 10);
            this.zone2label4.Name = "zone2label4";
            this.zone2label4.Size = new System.Drawing.Size(37, 20);
            this.zone2label4.TabIndex = 25;
            this.zone2label4.Text = "T-4";
            this.zone2label4.Click += new System.EventHandler(this.zone2label4_Click);
            // 
            // zone2label3
            // 
            this.zone2label3.AutoSize = true;
            this.zone2label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label3.ForeColor = System.Drawing.Color.White;
            this.zone2label3.Location = new System.Drawing.Point(202, 10);
            this.zone2label3.Name = "zone2label3";
            this.zone2label3.Size = new System.Drawing.Size(37, 20);
            this.zone2label3.TabIndex = 25;
            this.zone2label3.Text = "T-3";
            this.zone2label3.Click += new System.EventHandler(this.zone2label3_Click);
            // 
            // zone2label2
            // 
            this.zone2label2.AutoSize = true;
            this.zone2label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label2.ForeColor = System.Drawing.Color.White;
            this.zone2label2.Location = new System.Drawing.Point(121, 10);
            this.zone2label2.Name = "zone2label2";
            this.zone2label2.Size = new System.Drawing.Size(37, 20);
            this.zone2label2.TabIndex = 25;
            this.zone2label2.Text = "T-2";
            // 
            // zone2label1
            // 
            this.zone2label1.AutoSize = true;
            this.zone2label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label1.ForeColor = System.Drawing.Color.White;
            this.zone2label1.Location = new System.Drawing.Point(34, 10);
            this.zone2label1.Name = "zone2label1";
            this.zone2label1.Size = new System.Drawing.Size(37, 20);
            this.zone2label1.TabIndex = 25;
            this.zone2label1.Text = "T-1\r\n";
            // 
            // textBox28
            // 
            this.textBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox28.Location = new System.Drawing.Point(25, 31);
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            this.textBox28.Size = new System.Drawing.Size(58, 29);
            this.textBox28.TabIndex = 184;
            this.textBox28.Text = "122.3";
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox29
            // 
            this.textBox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox29.Location = new System.Drawing.Point(110, 31);
            this.textBox29.Name = "textBox29";
            this.textBox29.ReadOnly = true;
            this.textBox29.Size = new System.Drawing.Size(58, 29);
            this.textBox29.TabIndex = 185;
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox29.TextChanged += new System.EventHandler(this.textBox29_TextChanged);
            // 
            // textBox30
            // 
            this.textBox30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox30.Location = new System.Drawing.Point(192, 31);
            this.textBox30.Name = "textBox30";
            this.textBox30.ReadOnly = true;
            this.textBox30.Size = new System.Drawing.Size(58, 29);
            this.textBox30.TabIndex = 186;
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox31
            // 
            this.textBox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox31.Location = new System.Drawing.Point(282, 31);
            this.textBox31.Name = "textBox31";
            this.textBox31.ReadOnly = true;
            this.textBox31.Size = new System.Drawing.Size(58, 29);
            this.textBox31.TabIndex = 187;
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox32
            // 
            this.textBox32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox32.Location = new System.Drawing.Point(366, 31);
            this.textBox32.Name = "textBox32";
            this.textBox32.ReadOnly = true;
            this.textBox32.Size = new System.Drawing.Size(58, 29);
            this.textBox32.TabIndex = 188;
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox33
            // 
            this.textBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox33.Location = new System.Drawing.Point(455, 31);
            this.textBox33.Name = "textBox33";
            this.textBox33.ReadOnly = true;
            this.textBox33.Size = new System.Drawing.Size(58, 29);
            this.textBox33.TabIndex = 189;
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox34
            // 
            this.textBox34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox34.Location = new System.Drawing.Point(538, 31);
            this.textBox34.Name = "textBox34";
            this.textBox34.ReadOnly = true;
            this.textBox34.Size = new System.Drawing.Size(58, 29);
            this.textBox34.TabIndex = 190;
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox35
            // 
            this.textBox35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox35.Location = new System.Drawing.Point(631, 31);
            this.textBox35.Name = "textBox35";
            this.textBox35.ReadOnly = true;
            this.textBox35.Size = new System.Drawing.Size(58, 29);
            this.textBox35.TabIndex = 191;
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox36
            // 
            this.textBox36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox36.Location = new System.Drawing.Point(719, 31);
            this.textBox36.Name = "textBox36";
            this.textBox36.ReadOnly = true;
            this.textBox36.Size = new System.Drawing.Size(58, 29);
            this.textBox36.TabIndex = 192;
            this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox37
            // 
            this.textBox37.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox37.Location = new System.Drawing.Point(808, 31);
            this.textBox37.Name = "textBox37";
            this.textBox37.ReadOnly = true;
            this.textBox37.Size = new System.Drawing.Size(58, 29);
            this.textBox37.TabIndex = 193;
            this.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox38
            // 
            this.textBox38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox38.Location = new System.Drawing.Point(899, 31);
            this.textBox38.Name = "textBox38";
            this.textBox38.ReadOnly = true;
            this.textBox38.Size = new System.Drawing.Size(58, 29);
            this.textBox38.TabIndex = 194;
            this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox39
            // 
            this.textBox39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox39.Location = new System.Drawing.Point(980, 31);
            this.textBox39.Name = "textBox39";
            this.textBox39.ReadOnly = true;
            this.textBox39.Size = new System.Drawing.Size(58, 29);
            this.textBox39.TabIndex = 195;
            this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.SteelBlue;
            this.panel9.Controls.Add(this.textBox39);
            this.panel9.Controls.Add(this.textBox38);
            this.panel9.Controls.Add(this.textBox37);
            this.panel9.Controls.Add(this.textBox36);
            this.panel9.Controls.Add(this.textBox35);
            this.panel9.Controls.Add(this.textBox34);
            this.panel9.Controls.Add(this.textBox33);
            this.panel9.Controls.Add(this.textBox32);
            this.panel9.Controls.Add(this.textBox31);
            this.panel9.Controls.Add(this.textBox30);
            this.panel9.Controls.Add(this.textBox29);
            this.panel9.Controls.Add(this.textBox28);
            this.panel9.Controls.Add(this.zone2label1);
            this.panel9.Controls.Add(this.zone2label2);
            this.panel9.Controls.Add(this.zone2label3);
            this.panel9.Controls.Add(this.zone2label4);
            this.panel9.Controls.Add(this.zone2label5);
            this.panel9.Controls.Add(this.zone2label6);
            this.panel9.Controls.Add(this.zone2label7);
            this.panel9.Controls.Add(this.zone2label8);
            this.panel9.Controls.Add(this.zone2label9);
            this.panel9.Controls.Add(this.zone2label10);
            this.panel9.Controls.Add(this.zone2label11);
            this.panel9.Controls.Add(this.zone2label12);
            this.panel9.Location = new System.Drawing.Point(792, 435);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1110, 70);
            this.panel9.TabIndex = 239;
            // 
            // btnCSVFileFilter
            // 
            this.btnCSVFileFilter.BackColor = System.Drawing.Color.White;
            this.btnCSVFileFilter.FlatAppearance.BorderSize = 0;
            this.btnCSVFileFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSVFileFilter.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            this.btnCSVFileFilter.IconColor = System.Drawing.Color.SteelBlue;
            this.btnCSVFileFilter.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCSVFileFilter.IconSize = 35;
            this.btnCSVFileFilter.Location = new System.Drawing.Point(153, 495);
            this.btnCSVFileFilter.Name = "btnCSVFileFilter";
            this.btnCSVFileFilter.Size = new System.Drawing.Size(26, 36);
            this.btnCSVFileFilter.TabIndex = 229;
            this.btnCSVFileFilter.UseVisualStyleBackColor = false;
            this.btnCSVFileFilter.Click += new System.EventHandler(this.btnCSVFileFilter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.menuStrip3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1942, 28);
            this.panel1.TabIndex = 242;
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1942, 24);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 48);
            this.label3.TabIndex = 231;
            this.label3.Text = "ELEN II SOFTWARE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1924, 1088);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.lbRecord);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panelZone1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.ChartMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnCSVFileFilter);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.btnEMO);
            this.Controls.Add(this.btnTypeTime);
            this.Controls.Add(this.btnClearChart);
            this.Controls.Add(this.btnRecordDataChart);
            this.Controls.Add(this.lbCharMode);
            this.Controls.Add(this.btnChartMode);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btnStartStopChart);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbHora);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELEN II Software Rev 1.000.0";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartMain)).EndInit();
            this.panelZone1.ResumeLayout(false);
            this.panelZone1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledZ2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEMO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartMain;
        private FontAwesome.Sharp.IconButton btnTypeTime;
        private FontAwesome.Sharp.IconButton btnClearChart;
        private System.Windows.Forms.Label lbRecord;
        private FontAwesome.Sharp.IconButton btnRecordDataChart;
        private System.Windows.Forms.Label lbCharMode;
        private FontAwesome.Sharp.IconButton btnChartMode;
        private System.Windows.Forms.Label label32;
        private FontAwesome.Sharp.IconButton btnStartStopChart;
        private System.Windows.Forms.PictureBox btnEMO;
        private System.Windows.Forms.Timer TimerHoraFecha;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerRequestData;
        private System.Windows.Forms.Timer timerForChartTC;
        private System.Windows.Forms.Panel panelZone1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTC24;
        private System.Windows.Forms.TextBox txtTC23;
        private System.Windows.Forms.TextBox txtTC22;
        private System.Windows.Forms.TextBox txtTC21;
        private System.Windows.Forms.TextBox txtTC20;
        private System.Windows.Forms.TextBox txtTC19;
        private System.Windows.Forms.TextBox txtTC18;
        private System.Windows.Forms.TextBox txtTC17;
        private System.Windows.Forms.TextBox txtTC16;
        private System.Windows.Forms.TextBox txtTC15;
        private System.Windows.Forms.TextBox txtTC14;
        private System.Windows.Forms.TextBox txtTC13;
        private System.Windows.Forms.TextBox txtTC12;
        private System.Windows.Forms.TextBox txtTC11;
        private System.Windows.Forms.TextBox txtTC10;
        private System.Windows.Forms.TextBox txtTC9;
        private System.Windows.Forms.TextBox txtTC8;
        private System.Windows.Forms.TextBox txtTC7;
        private System.Windows.Forms.TextBox txtTC6;
        private System.Windows.Forms.TextBox txtTC5;
        private System.Windows.Forms.TextBox txtTC4;
        private System.Windows.Forms.TextBox txtTC3;
        private System.Windows.Forms.TextBox txtTC2;
        private System.Windows.Forms.TextBox txtTC1;
        private System.Windows.Forms.TextBox txtSetPointZone2;
        private System.Windows.Forms.PictureBox ledZ2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lbDivisor;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem statusToolStripMenuItem;
        private ToolStripMenuItem manualControlToolStripMenuItem;
        private Panel panel8;
        private Panel panel10;
        private TextBox textBox40;
        private TextBox textBox41;
        private TextBox textBox43;
        private TextBox textBox42;
        private ContextMenuStrip contextMenuStrip1;
        private Label label67;
        private Label label70;
        private Label label69;
        private Label label68;
        private Label label72;
        private Label label71;
        private Panel panel11;
        private Label label77;
        private TextBox textBox46;
        private Label label73;
        private Button button1;
        private Panel panel12;
        private Panel panel14;
        private Panel panel13;
        private Label label74;
        private Label label75;
        private Label label76;
        private Label label78;
        private Label label79;
        private Label label80;
        private TextBox textBox44;
        private TextBox textBox45;
        private TextBox textBox47;
        private TextBox textBox48;
        private Button button2;
        private Label label81;
        private Label label82;
        private TextBox textBox49;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private Label zone2label12;
        private Label zone2label11;
        private Label zone2label10;
        private Label zone2label9;
        private Label zone2label8;
        private Label zone2label7;
        private Label zone2label6;
        private Label zone2label5;
        private Label zone2label4;
        private Label zone2label3;
        private Label zone2label2;
        private Label zone2label1;
        private TextBox textBox28;
        private TextBox textBox29;
        private TextBox textBox30;
        private TextBox textBox31;
        private TextBox textBox32;
        private TextBox textBox33;
        private TextBox textBox34;
        private TextBox textBox35;
        private TextBox textBox36;
        private TextBox textBox37;
        private TextBox textBox38;
        private TextBox textBox39;
        private Panel panel9;
        private FontAwesome.Sharp.IconButton btnCSVFileFilter;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private Panel panel1;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private Label label3;
    }
}