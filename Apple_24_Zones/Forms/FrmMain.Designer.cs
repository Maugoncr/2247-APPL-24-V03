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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series217 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series218 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series219 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series220 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series221 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series222 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series223 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series224 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series225 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series226 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series227 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series228 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series229 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series230 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series231 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series232 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series233 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series234 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series235 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series236 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series237 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series238 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series239 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series240 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series241 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series242 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series243 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series244 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series245 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series246 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series247 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series248 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series249 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series250 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series251 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series252 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.chartZone2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TimerHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerRequestData = new System.Windows.Forms.Timer(this.components);
            this.timerForChartTC = new System.Windows.Forms.Timer(this.components);
            this.panelZone1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.chartZone1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label73 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
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
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
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
            this.panelZone2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IconMinima = new FontAwesome.Sharp.IconButton();
            this.IconMaxin = new FontAwesome.Sharp.IconButton();
            this.IconClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBoth = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label87 = new System.Windows.Forms.Label();
            this.checkT24 = new System.Windows.Forms.CheckBox();
            this.label88 = new System.Windows.Forms.Label();
            this.checkT23 = new System.Windows.Forms.CheckBox();
            this.label89 = new System.Windows.Forms.Label();
            this.checkT22 = new System.Windows.Forms.CheckBox();
            this.label90 = new System.Windows.Forms.Label();
            this.checkT21 = new System.Windows.Forms.CheckBox();
            this.label91 = new System.Windows.Forms.Label();
            this.checkT20 = new System.Windows.Forms.CheckBox();
            this.label92 = new System.Windows.Forms.Label();
            this.checkT19 = new System.Windows.Forms.CheckBox();
            this.label93 = new System.Windows.Forms.Label();
            this.checkT18 = new System.Windows.Forms.CheckBox();
            this.label94 = new System.Windows.Forms.Label();
            this.checkT17 = new System.Windows.Forms.CheckBox();
            this.label95 = new System.Windows.Forms.Label();
            this.checkT16 = new System.Windows.Forms.CheckBox();
            this.label96 = new System.Windows.Forms.Label();
            this.checkT15 = new System.Windows.Forms.CheckBox();
            this.label97 = new System.Windows.Forms.Label();
            this.checkT14 = new System.Windows.Forms.CheckBox();
            this.label98 = new System.Windows.Forms.Label();
            this.checkT13 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label84 = new System.Windows.Forms.Label();
            this.checkT12 = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.checkT11 = new System.Windows.Forms.CheckBox();
            this.label38 = new System.Windows.Forms.Label();
            this.checkT10 = new System.Windows.Forms.CheckBox();
            this.label66 = new System.Windows.Forms.Label();
            this.checkT9 = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.checkT8 = new System.Windows.Forms.CheckBox();
            this.label83 = new System.Windows.Forms.Label();
            this.checkT7 = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.checkT6 = new System.Windows.Forms.CheckBox();
            this.label34 = new System.Windows.Forms.Label();
            this.checkT5 = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.checkT4 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkT3 = new System.Windows.Forms.CheckBox();
            this.label85 = new System.Windows.Forms.Label();
            this.checkT2 = new System.Windows.Forms.CheckBox();
            this.label86 = new System.Windows.Forms.Label();
            this.checkT1 = new System.Windows.Forms.CheckBox();
            this.panelGhost = new System.Windows.Forms.Panel();
            this.panelCheckView = new System.Windows.Forms.Panel();
            this.lbRed = new System.Windows.Forms.Label();
            this.checkView12 = new System.Windows.Forms.CheckBox();
            this.lbPurple = new System.Windows.Forms.Label();
            this.checkView11 = new System.Windows.Forms.CheckBox();
            this.lbGreen = new System.Windows.Forms.Label();
            this.checkView10 = new System.Windows.Forms.CheckBox();
            this.lbYellow = new System.Windows.Forms.Label();
            this.checkView9 = new System.Windows.Forms.CheckBox();
            this.lbSky = new System.Windows.Forms.Label();
            this.checkView8 = new System.Windows.Forms.CheckBox();
            this.lbBlue = new System.Windows.Forms.Label();
            this.checkView7 = new System.Windows.Forms.CheckBox();
            this.lbOrange = new System.Windows.Forms.Label();
            this.checkView6 = new System.Windows.Forms.CheckBox();
            this.lbLightGreen = new System.Windows.Forms.Label();
            this.checkView5 = new System.Windows.Forms.CheckBox();
            this.lbMaroon = new System.Windows.Forms.Label();
            this.checkView4 = new System.Windows.Forms.CheckBox();
            this.lbMag = new System.Windows.Forms.Label();
            this.checkView3 = new System.Windows.Forms.CheckBox();
            this.lbBlack = new System.Windows.Forms.Label();
            this.checkView2 = new System.Windows.Forms.CheckBox();
            this.lbOlive = new System.Windows.Forms.Label();
            this.checkView1 = new System.Windows.Forms.CheckBox();
            this.panelViewZone = new System.Windows.Forms.Panel();
            this.lbZoneView = new System.Windows.Forms.Label();
            this.txtView12 = new System.Windows.Forms.TextBox();
            this.txtView11 = new System.Windows.Forms.TextBox();
            this.txtView10 = new System.Windows.Forms.TextBox();
            this.txtView9 = new System.Windows.Forms.TextBox();
            this.txtView8 = new System.Windows.Forms.TextBox();
            this.txtView7 = new System.Windows.Forms.TextBox();
            this.txtView6 = new System.Windows.Forms.TextBox();
            this.txtView5 = new System.Windows.Forms.TextBox();
            this.txtView4 = new System.Windows.Forms.TextBox();
            this.txtView3 = new System.Windows.Forms.TextBox();
            this.txtView2 = new System.Windows.Forms.TextBox();
            this.txtView1 = new System.Windows.Forms.TextBox();
            this.lbView1 = new System.Windows.Forms.Label();
            this.lbView2 = new System.Windows.Forms.Label();
            this.lbView3 = new System.Windows.Forms.Label();
            this.lbView4 = new System.Windows.Forms.Label();
            this.lbView5 = new System.Windows.Forms.Label();
            this.lbView6 = new System.Windows.Forms.Label();
            this.lbView7 = new System.Windows.Forms.Label();
            this.lbView8 = new System.Windows.Forms.Label();
            this.lbView9 = new System.Windows.Forms.Label();
            this.lbView10 = new System.Windows.Forms.Label();
            this.lbView11 = new System.Windows.Forms.Label();
            this.lbView12 = new System.Windows.Forms.Label();
            this.chartView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerGhost = new System.Windows.Forms.Timer(this.components);
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.btnCSVFileFilter = new FontAwesome.Sharp.IconButton();
            this.btnEMO = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label110 = new System.Windows.Forms.Label();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnOnOff = new FontAwesome.Sharp.IconButton();
            this.label109 = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.txtSetTemp = new System.Windows.Forms.NumericUpDown();
            this.label108 = new System.Windows.Forms.Label();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.label107 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.label105 = new System.Windows.Forms.Label();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label104 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.cbZonesMode = new System.Windows.Forms.ComboBox();
            this.label100 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRefreshCOM = new FontAwesome.Sharp.IconButton();
            this.btnConnectCOM = new FontAwesome.Sharp.IconButton();
            this.cbCOMSelect = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtTempTest = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.viewOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothZonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zone1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zone2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainBar = new System.Windows.Forms.MenuStrip();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.chartZone2)).BeginInit();
            this.panelZone1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledZ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZone1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelZone2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBoth.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelGhost.SuspendLayout();
            this.panelCheckView.SuspendLayout();
            this.panelViewZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEMO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSetTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuMainBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFecha
            // 
            this.lbFecha.BackColor = System.Drawing.Color.Transparent;
            this.lbFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.Black;
            this.lbFecha.Location = new System.Drawing.Point(1429, 1093);
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
            this.lbHora.Location = new System.Drawing.Point(1699, 1094);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(209, 24);
            this.lbHora.TabIndex = 210;
            this.lbHora.Text = "hora";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chartZone2
            // 
            this.chartZone2.BorderlineColor = System.Drawing.Color.Gray;
            this.chartZone2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartZone2.BorderlineWidth = 2;
            chartArea19.Name = "ChartArea1";
            this.chartZone2.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.chartZone2.Legends.Add(legend19);
            this.chartZone2.Location = new System.Drawing.Point(5, 3);
            this.chartZone2.Name = "chartZone2";
            series217.ChartArea = "ChartArea1";
            series217.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series217.Legend = "Legend1";
            series217.Name = "T-13";
            series218.ChartArea = "ChartArea1";
            series218.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series218.Legend = "Legend1";
            series218.Name = "T-14";
            series219.ChartArea = "ChartArea1";
            series219.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series219.Legend = "Legend1";
            series219.Name = "T-15";
            series220.ChartArea = "ChartArea1";
            series220.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series220.Legend = "Legend1";
            series220.Name = "T-16";
            series221.ChartArea = "ChartArea1";
            series221.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series221.Legend = "Legend1";
            series221.Name = "T-17";
            series222.ChartArea = "ChartArea1";
            series222.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series222.Legend = "Legend1";
            series222.Name = "T-18";
            series223.ChartArea = "ChartArea1";
            series223.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series223.Legend = "Legend1";
            series223.Name = "T-19";
            series224.ChartArea = "ChartArea1";
            series224.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series224.Legend = "Legend1";
            series224.Name = "T-20";
            series225.ChartArea = "ChartArea1";
            series225.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series225.Legend = "Legend1";
            series225.Name = "T-21";
            series226.ChartArea = "ChartArea1";
            series226.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series226.Legend = "Legend1";
            series226.Name = "T-22";
            series227.ChartArea = "ChartArea1";
            series227.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series227.Legend = "Legend1";
            series227.Name = "T-23";
            series228.ChartArea = "ChartArea1";
            series228.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series228.Legend = "Legend1";
            series228.Name = "T-24";
            this.chartZone2.Series.Add(series217);
            this.chartZone2.Series.Add(series218);
            this.chartZone2.Series.Add(series219);
            this.chartZone2.Series.Add(series220);
            this.chartZone2.Series.Add(series221);
            this.chartZone2.Series.Add(series222);
            this.chartZone2.Series.Add(series223);
            this.chartZone2.Series.Add(series224);
            this.chartZone2.Series.Add(series225);
            this.chartZone2.Series.Add(series226);
            this.chartZone2.Series.Add(series227);
            this.chartZone2.Series.Add(series228);
            this.chartZone2.Size = new System.Drawing.Size(1212, 395);
            this.chartZone2.TabIndex = 212;
            this.chartZone2.Text = "chart1";
            this.chartZone2.CustomizeLegend += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CustomizeLegendEventArgs>(this.ChartMain_CustomizeLegend);
            this.chartZone2.Click += new System.EventHandler(this.ChartMain_Click);
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
            this.timerForChartTC.Interval = 1000;
            this.timerForChartTC.Tick += new System.EventHandler(this.timerForChartTC_Tick);
            // 
            // panelZone1
            // 
            this.panelZone1.BackColor = System.Drawing.Color.Gray;
            this.panelZone1.Controls.Add(this.label2);
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
            this.panelZone1.Location = new System.Drawing.Point(5, 871);
            this.panelZone1.Name = "panelZone1";
            this.panelZone1.Size = new System.Drawing.Size(1212, 82);
            this.panelZone1.TabIndex = 225;
            this.panelZone1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelZone1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(539, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 259;
            this.label2.Text = "ZONE #1";
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
            this.label17.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label17.Location = new System.Drawing.Point(1139, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "T-12";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label16.Location = new System.Drawing.Point(1032, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "T-11";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label15.Location = new System.Drawing.Point(921, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "T-10";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label14.Location = new System.Drawing.Point(821, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "T-9";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(716, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "T-8";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(612, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "T-7";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(508, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "T-6";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(407, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "T-5";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(312, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "T-4";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(218, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "T-3";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(122, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "T-2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(29, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "T-1";
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
            this.txtTC12.Location = new System.Drawing.Point(1124, 47);
            this.txtTC12.Name = "txtTC12";
            this.txtTC12.ReadOnly = true;
            this.txtTC12.Size = new System.Drawing.Size(79, 29);
            this.txtTC12.TabIndex = 12;
            this.txtTC12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTC12.TextChanged += new System.EventHandler(this.txtTC12_TextChanged);
            // 
            // txtTC11
            // 
            this.txtTC11.Location = new System.Drawing.Point(1018, 47);
            this.txtTC11.Name = "txtTC11";
            this.txtTC11.ReadOnly = true;
            this.txtTC11.Size = new System.Drawing.Size(79, 29);
            this.txtTC11.TabIndex = 11;
            this.txtTC11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC10
            // 
            this.txtTC10.Location = new System.Drawing.Point(909, 47);
            this.txtTC10.Name = "txtTC10";
            this.txtTC10.ReadOnly = true;
            this.txtTC10.Size = new System.Drawing.Size(79, 29);
            this.txtTC10.TabIndex = 10;
            this.txtTC10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC9
            // 
            this.txtTC9.Location = new System.Drawing.Point(803, 47);
            this.txtTC9.Name = "txtTC9";
            this.txtTC9.ReadOnly = true;
            this.txtTC9.Size = new System.Drawing.Size(79, 29);
            this.txtTC9.TabIndex = 9;
            this.txtTC9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC8
            // 
            this.txtTC8.Location = new System.Drawing.Point(696, 47);
            this.txtTC8.Name = "txtTC8";
            this.txtTC8.ReadOnly = true;
            this.txtTC8.Size = new System.Drawing.Size(79, 29);
            this.txtTC8.TabIndex = 8;
            this.txtTC8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC7
            // 
            this.txtTC7.Location = new System.Drawing.Point(592, 47);
            this.txtTC7.Name = "txtTC7";
            this.txtTC7.ReadOnly = true;
            this.txtTC7.Size = new System.Drawing.Size(79, 29);
            this.txtTC7.TabIndex = 7;
            this.txtTC7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC6
            // 
            this.txtTC6.Location = new System.Drawing.Point(488, 47);
            this.txtTC6.Name = "txtTC6";
            this.txtTC6.ReadOnly = true;
            this.txtTC6.Size = new System.Drawing.Size(79, 29);
            this.txtTC6.TabIndex = 6;
            this.txtTC6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC5
            // 
            this.txtTC5.Location = new System.Drawing.Point(387, 47);
            this.txtTC5.Name = "txtTC5";
            this.txtTC5.ReadOnly = true;
            this.txtTC5.Size = new System.Drawing.Size(79, 29);
            this.txtTC5.TabIndex = 5;
            this.txtTC5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC4
            // 
            this.txtTC4.Location = new System.Drawing.Point(293, 47);
            this.txtTC4.Name = "txtTC4";
            this.txtTC4.ReadOnly = true;
            this.txtTC4.Size = new System.Drawing.Size(79, 29);
            this.txtTC4.TabIndex = 4;
            this.txtTC4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC3
            // 
            this.txtTC3.Location = new System.Drawing.Point(198, 47);
            this.txtTC3.Name = "txtTC3";
            this.txtTC3.ReadOnly = true;
            this.txtTC3.Size = new System.Drawing.Size(79, 29);
            this.txtTC3.TabIndex = 3;
            this.txtTC3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC2
            // 
            this.txtTC2.Location = new System.Drawing.Point(99, 47);
            this.txtTC2.Name = "txtTC2";
            this.txtTC2.ReadOnly = true;
            this.txtTC2.Size = new System.Drawing.Size(79, 29);
            this.txtTC2.TabIndex = 2;
            this.txtTC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTC1
            // 
            this.txtTC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTC1.Location = new System.Drawing.Point(7, 47);
            this.txtTC1.Name = "txtTC1";
            this.txtTC1.ReadOnly = true;
            this.txtTC1.Size = new System.Drawing.Size(79, 29);
            this.txtTC1.TabIndex = 1;
            this.txtTC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chartZone1
            // 
            this.chartZone1.BorderlineColor = System.Drawing.Color.Gray;
            this.chartZone1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartZone1.BorderlineWidth = 2;
            chartArea20.InnerPlotPosition.Auto = false;
            chartArea20.InnerPlotPosition.Height = 88.4641F;
            chartArea20.InnerPlotPosition.Width = 93.2662F;
            chartArea20.InnerPlotPosition.X = 6.11536F;
            chartArea20.InnerPlotPosition.Y = 2.79255F;
            chartArea20.Name = "ChartArea1";
            this.chartZone1.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.chartZone1.Legends.Add(legend20);
            this.chartZone1.Location = new System.Drawing.Point(5, 479);
            this.chartZone1.Name = "chartZone1";
            series229.ChartArea = "ChartArea1";
            series229.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series229.Legend = "Legend1";
            series229.Name = "T-1";
            series230.ChartArea = "ChartArea1";
            series230.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series230.Legend = "Legend1";
            series230.Name = "T-2";
            series231.ChartArea = "ChartArea1";
            series231.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series231.Legend = "Legend1";
            series231.Name = "T-3";
            series232.ChartArea = "ChartArea1";
            series232.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series232.Legend = "Legend1";
            series232.Name = "T-4";
            series233.ChartArea = "ChartArea1";
            series233.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series233.Legend = "Legend1";
            series233.Name = "T-5";
            series234.ChartArea = "ChartArea1";
            series234.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series234.Legend = "Legend1";
            series234.Name = "T-6";
            series235.ChartArea = "ChartArea1";
            series235.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series235.Legend = "Legend1";
            series235.Name = "T-7";
            series236.ChartArea = "ChartArea1";
            series236.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series236.Legend = "Legend1";
            series236.Name = "T-8";
            series237.ChartArea = "ChartArea1";
            series237.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series237.Legend = "Legend1";
            series237.Name = "T-9";
            series238.ChartArea = "ChartArea1";
            series238.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series238.Legend = "Legend1";
            series238.Name = "T-10";
            series239.ChartArea = "ChartArea1";
            series239.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series239.Legend = "Legend1";
            series239.Name = "T-11";
            series240.ChartArea = "ChartArea1";
            series240.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series240.Legend = "Legend1";
            series240.Name = "T-12";
            this.chartZone1.Series.Add(series229);
            this.chartZone1.Series.Add(series230);
            this.chartZone1.Series.Add(series231);
            this.chartZone1.Series.Add(series232);
            this.chartZone1.Series.Add(series233);
            this.chartZone1.Series.Add(series234);
            this.chartZone1.Series.Add(series235);
            this.chartZone1.Series.Add(series236);
            this.chartZone1.Series.Add(series237);
            this.chartZone1.Series.Add(series238);
            this.chartZone1.Series.Add(series239);
            this.chartZone1.Series.Add(series240);
            this.chartZone1.Size = new System.Drawing.Size(1212, 395);
            this.chartZone1.TabIndex = 238;
            this.chartZone1.Text = "chart1";
            this.chartZone1.CustomizeLegend += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CustomizeLegendEventArgs>(this.chart1_CustomizeLegend);
            this.chartZone1.Click += new System.EventHandler(this.chart1_Click);
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Controls.Add(this.menuStrip1);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Location = new System.Drawing.Point(539, 1043);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(511, 395);
            this.panel8.TabIndex = 240;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.pictureBox19);
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
            this.panel10.Size = new System.Drawing.Size(461, 323);
            this.panel10.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel11.Controls.Add(this.pictureBox15);
            this.panel11.Controls.Add(this.pictureBox14);
            this.panel11.Controls.Add(this.pictureBox10);
            this.panel11.Controls.Add(this.pictureBox11);
            this.panel11.Controls.Add(this.button1);
            this.panel11.Controls.Add(this.label73);
            this.panel11.Controls.Add(this.label77);
            this.panel11.Controls.Add(this.textBox46);
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(461, 323);
            this.panel11.TabIndex = 242;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Image = global::Apple_24_Zones.Properties.Resources.tc1on;
            this.pictureBox15.Location = new System.Drawing.Point(251, 67);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(30, 30);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 233;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Image = global::Apple_24_Zones.Properties.Resources.tc8on;
            this.pictureBox14.Location = new System.Drawing.Point(252, 115);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(30, 30);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 232;
            this.pictureBox14.TabStop = false;
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
            this.button1.Location = new System.Drawing.Point(362, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Apply changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label77.ForeColor = System.Drawing.Color.Black;
            this.label77.Location = new System.Drawing.Point(5, 93);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(69, 20);
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
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox19.Image = global::Apple_24_Zones.Properties.Resources.tc8on;
            this.pictureBox19.Location = new System.Drawing.Point(378, 154);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(30, 30);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 233;
            this.pictureBox19.TabStop = false;
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
            this.label70.ForeColor = System.Drawing.Color.Black;
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
            this.label69.ForeColor = System.Drawing.Color.Black;
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
            this.label68.ForeColor = System.Drawing.Color.Black;
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
            this.label67.ForeColor = System.Drawing.Color.Black;
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
            this.textBox40.ReadOnly = true;
            this.textBox40.Size = new System.Drawing.Size(100, 26);
            this.textBox40.TabIndex = 0;
            this.textBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox40.TextChanged += new System.EventHandler(this.textBox40_TextChanged);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.LightGray;
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.menuStrip2);
            this.panel12.Location = new System.Drawing.Point(554, 1037);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(511, 395);
            this.panel12.TabIndex = 241;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel14.Controls.Add(this.pictureBox17);
            this.panel14.Controls.Add(this.pictureBox16);
            this.panel14.Controls.Add(this.pictureBox12);
            this.panel14.Controls.Add(this.pictureBox13);
            this.panel14.Controls.Add(this.button2);
            this.panel14.Controls.Add(this.label81);
            this.panel14.Controls.Add(this.label82);
            this.panel14.Controls.Add(this.textBox49);
            this.panel14.Location = new System.Drawing.Point(23, 45);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(461, 323);
            this.panel14.TabIndex = 242;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Image = global::Apple_24_Zones.Properties.Resources.tc1on;
            this.pictureBox17.Location = new System.Drawing.Point(235, 67);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(30, 30);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 235;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.Image = global::Apple_24_Zones.Properties.Resources.tc8on;
            this.pictureBox16.Location = new System.Drawing.Point(235, 115);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(30, 30);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 234;
            this.pictureBox16.TabStop = false;
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
            this.button2.Location = new System.Drawing.Point(362, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Apply changes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.label82.ForeColor = System.Drawing.Color.Black;
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
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel13.Controls.Add(this.pictureBox18);
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
            this.panel13.Size = new System.Drawing.Size(461, 323);
            this.panel13.TabIndex = 1;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.Image = global::Apple_24_Zones.Properties.Resources.tc8on;
            this.pictureBox18.Location = new System.Drawing.Point(391, 153);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(30, 30);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 233;
            this.pictureBox18.TabStop = false;
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
            this.label76.ForeColor = System.Drawing.Color.Black;
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
            this.label78.ForeColor = System.Drawing.Color.Black;
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
            this.label79.ForeColor = System.Drawing.Color.Black;
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
            this.label80.ForeColor = System.Drawing.Color.Black;
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
            this.textBox48.ReadOnly = true;
            this.textBox48.Size = new System.Drawing.Size(100, 26);
            this.textBox48.TabIndex = 0;
            this.textBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zone2label12
            // 
            this.zone2label12.AutoSize = true;
            this.zone2label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zone2label12.Location = new System.Drawing.Point(1139, 23);
            this.zone2label12.Name = "zone2label12";
            this.zone2label12.Size = new System.Drawing.Size(47, 20);
            this.zone2label12.TabIndex = 25;
            this.zone2label12.Text = "T-24";
            // 
            // zone2label11
            // 
            this.zone2label11.AutoSize = true;
            this.zone2label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zone2label11.Location = new System.Drawing.Point(1031, 23);
            this.zone2label11.Name = "zone2label11";
            this.zone2label11.Size = new System.Drawing.Size(47, 20);
            this.zone2label11.TabIndex = 25;
            this.zone2label11.Text = "T-23";
            // 
            // zone2label10
            // 
            this.zone2label10.AutoSize = true;
            this.zone2label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zone2label10.Location = new System.Drawing.Point(921, 22);
            this.zone2label10.Name = "zone2label10";
            this.zone2label10.Size = new System.Drawing.Size(47, 20);
            this.zone2label10.TabIndex = 25;
            this.zone2label10.Text = "T-22";
            // 
            // zone2label9
            // 
            this.zone2label9.AutoSize = true;
            this.zone2label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zone2label9.Location = new System.Drawing.Point(818, 22);
            this.zone2label9.Name = "zone2label9";
            this.zone2label9.Size = new System.Drawing.Size(47, 20);
            this.zone2label9.TabIndex = 25;
            this.zone2label9.Text = "T-21";
            // 
            // zone2label8
            // 
            this.zone2label8.AutoSize = true;
            this.zone2label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zone2label8.Location = new System.Drawing.Point(702, 22);
            this.zone2label8.Name = "zone2label8";
            this.zone2label8.Size = new System.Drawing.Size(47, 20);
            this.zone2label8.TabIndex = 25;
            this.zone2label8.Text = "T-20";
            // 
            // zone2label7
            // 
            this.zone2label7.AutoSize = true;
            this.zone2label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zone2label7.Location = new System.Drawing.Point(602, 22);
            this.zone2label7.Name = "zone2label7";
            this.zone2label7.Size = new System.Drawing.Size(47, 20);
            this.zone2label7.TabIndex = 25;
            this.zone2label7.Text = "T-19";
            // 
            // zone2label6
            // 
            this.zone2label6.AutoSize = true;
            this.zone2label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zone2label6.Location = new System.Drawing.Point(500, 23);
            this.zone2label6.Name = "zone2label6";
            this.zone2label6.Size = new System.Drawing.Size(47, 20);
            this.zone2label6.TabIndex = 25;
            this.zone2label6.Text = "T-18";
            this.zone2label6.Click += new System.EventHandler(this.zone2label6_Click);
            // 
            // zone2label5
            // 
            this.zone2label5.AutoSize = true;
            this.zone2label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zone2label5.Location = new System.Drawing.Point(402, 23);
            this.zone2label5.Name = "zone2label5";
            this.zone2label5.Size = new System.Drawing.Size(47, 20);
            this.zone2label5.TabIndex = 25;
            this.zone2label5.Text = "T-17";
            // 
            // zone2label4
            // 
            this.zone2label4.AutoSize = true;
            this.zone2label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zone2label4.Location = new System.Drawing.Point(301, 22);
            this.zone2label4.Name = "zone2label4";
            this.zone2label4.Size = new System.Drawing.Size(47, 20);
            this.zone2label4.TabIndex = 25;
            this.zone2label4.Text = "T-16";
            this.zone2label4.Click += new System.EventHandler(this.zone2label4_Click);
            // 
            // zone2label3
            // 
            this.zone2label3.AutoSize = true;
            this.zone2label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zone2label3.Location = new System.Drawing.Point(208, 22);
            this.zone2label3.Name = "zone2label3";
            this.zone2label3.Size = new System.Drawing.Size(47, 20);
            this.zone2label3.TabIndex = 25;
            this.zone2label3.Text = "T-15";
            this.zone2label3.Click += new System.EventHandler(this.zone2label3_Click);
            // 
            // zone2label2
            // 
            this.zone2label2.AutoSize = true;
            this.zone2label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zone2label2.Location = new System.Drawing.Point(117, 22);
            this.zone2label2.Name = "zone2label2";
            this.zone2label2.Size = new System.Drawing.Size(47, 20);
            this.zone2label2.TabIndex = 25;
            this.zone2label2.Text = "T-14";
            // 
            // zone2label1
            // 
            this.zone2label1.AutoSize = true;
            this.zone2label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zone2label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.zone2label1.Location = new System.Drawing.Point(25, 22);
            this.zone2label1.Name = "zone2label1";
            this.zone2label1.Size = new System.Drawing.Size(47, 20);
            this.zone2label1.TabIndex = 25;
            this.zone2label1.Text = "T-13";
            // 
            // textBox28
            // 
            this.textBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox28.Location = new System.Drawing.Point(8, 43);
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            this.textBox28.Size = new System.Drawing.Size(79, 29);
            this.textBox28.TabIndex = 184;
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox29
            // 
            this.textBox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox29.Location = new System.Drawing.Point(100, 43);
            this.textBox29.Name = "textBox29";
            this.textBox29.ReadOnly = true;
            this.textBox29.Size = new System.Drawing.Size(79, 29);
            this.textBox29.TabIndex = 185;
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox29.TextChanged += new System.EventHandler(this.textBox29_TextChanged);
            // 
            // textBox30
            // 
            this.textBox30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox30.Location = new System.Drawing.Point(193, 43);
            this.textBox30.Name = "textBox30";
            this.textBox30.ReadOnly = true;
            this.textBox30.Size = new System.Drawing.Size(79, 29);
            this.textBox30.TabIndex = 186;
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox31
            // 
            this.textBox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox31.Location = new System.Drawing.Point(287, 43);
            this.textBox31.Name = "textBox31";
            this.textBox31.ReadOnly = true;
            this.textBox31.Size = new System.Drawing.Size(79, 29);
            this.textBox31.TabIndex = 187;
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox32
            // 
            this.textBox32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox32.Location = new System.Drawing.Point(388, 44);
            this.textBox32.Name = "textBox32";
            this.textBox32.ReadOnly = true;
            this.textBox32.Size = new System.Drawing.Size(79, 29);
            this.textBox32.TabIndex = 188;
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox33
            // 
            this.textBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox33.Location = new System.Drawing.Point(486, 43);
            this.textBox33.Name = "textBox33";
            this.textBox33.ReadOnly = true;
            this.textBox33.Size = new System.Drawing.Size(79, 29);
            this.textBox33.TabIndex = 189;
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox34
            // 
            this.textBox34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox34.Location = new System.Drawing.Point(590, 43);
            this.textBox34.Name = "textBox34";
            this.textBox34.ReadOnly = true;
            this.textBox34.Size = new System.Drawing.Size(79, 29);
            this.textBox34.TabIndex = 190;
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox35
            // 
            this.textBox35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox35.Location = new System.Drawing.Point(691, 43);
            this.textBox35.Name = "textBox35";
            this.textBox35.ReadOnly = true;
            this.textBox35.Size = new System.Drawing.Size(79, 29);
            this.textBox35.TabIndex = 191;
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox36
            // 
            this.textBox36.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox36.Location = new System.Drawing.Point(801, 43);
            this.textBox36.Name = "textBox36";
            this.textBox36.ReadOnly = true;
            this.textBox36.Size = new System.Drawing.Size(79, 29);
            this.textBox36.TabIndex = 192;
            this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox37
            // 
            this.textBox37.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox37.Location = new System.Drawing.Point(910, 43);
            this.textBox37.Name = "textBox37";
            this.textBox37.ReadOnly = true;
            this.textBox37.Size = new System.Drawing.Size(79, 29);
            this.textBox37.TabIndex = 193;
            this.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox38
            // 
            this.textBox38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox38.Location = new System.Drawing.Point(1019, 43);
            this.textBox38.Name = "textBox38";
            this.textBox38.ReadOnly = true;
            this.textBox38.Size = new System.Drawing.Size(79, 29);
            this.textBox38.TabIndex = 194;
            this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox39
            // 
            this.textBox39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox39.Location = new System.Drawing.Point(1125, 43);
            this.textBox39.Name = "textBox39";
            this.textBox39.ReadOnly = true;
            this.textBox39.Size = new System.Drawing.Size(79, 29);
            this.textBox39.TabIndex = 195;
            this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelZone2
            // 
            this.panelZone2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelZone2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelZone2.Controls.Add(this.label4);
            this.panelZone2.Controls.Add(this.textBox39);
            this.panelZone2.Controls.Add(this.textBox38);
            this.panelZone2.Controls.Add(this.textBox37);
            this.panelZone2.Controls.Add(this.textBox36);
            this.panelZone2.Controls.Add(this.textBox35);
            this.panelZone2.Controls.Add(this.textBox34);
            this.panelZone2.Controls.Add(this.textBox33);
            this.panelZone2.Controls.Add(this.textBox32);
            this.panelZone2.Controls.Add(this.textBox31);
            this.panelZone2.Controls.Add(this.textBox30);
            this.panelZone2.Controls.Add(this.textBox29);
            this.panelZone2.Controls.Add(this.textBox28);
            this.panelZone2.Controls.Add(this.zone2label1);
            this.panelZone2.Controls.Add(this.zone2label2);
            this.panelZone2.Controls.Add(this.zone2label3);
            this.panelZone2.Controls.Add(this.zone2label4);
            this.panelZone2.Controls.Add(this.zone2label5);
            this.panelZone2.Controls.Add(this.zone2label6);
            this.panelZone2.Controls.Add(this.zone2label7);
            this.panelZone2.Controls.Add(this.zone2label8);
            this.panelZone2.Controls.Add(this.zone2label9);
            this.panelZone2.Controls.Add(this.zone2label10);
            this.panelZone2.Controls.Add(this.zone2label11);
            this.panelZone2.Controls.Add(this.zone2label12);
            this.panelZone2.Location = new System.Drawing.Point(5, 391);
            this.panelZone2.Name = "panelZone2";
            this.panelZone2.Size = new System.Drawing.Size(1212, 82);
            this.panelZone2.TabIndex = 239;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(539, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 260;
            this.label4.Text = "ZONE #2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.IconMinima);
            this.panel1.Controls.Add(this.IconMaxin);
            this.panel1.Controls.Add(this.IconClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 39);
            this.panel1.TabIndex = 242;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // IconMinima
            // 
            this.IconMinima.Dock = System.Windows.Forms.DockStyle.Right;
            this.IconMinima.FlatAppearance.BorderSize = 0;
            this.IconMinima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconMinima.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.IconMinima.IconColor = System.Drawing.Color.White;
            this.IconMinima.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconMinima.IconSize = 30;
            this.IconMinima.Location = new System.Drawing.Point(1815, 0);
            this.IconMinima.Name = "IconMinima";
            this.IconMinima.Size = new System.Drawing.Size(35, 39);
            this.IconMinima.TabIndex = 275;
            this.IconMinima.UseVisualStyleBackColor = true;
            this.IconMinima.Click += new System.EventHandler(this.IconMinima_Click);
            // 
            // IconMaxin
            // 
            this.IconMaxin.Dock = System.Windows.Forms.DockStyle.Right;
            this.IconMaxin.FlatAppearance.BorderSize = 0;
            this.IconMaxin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconMaxin.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.IconMaxin.IconColor = System.Drawing.Color.White;
            this.IconMaxin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconMaxin.IconSize = 30;
            this.IconMaxin.Location = new System.Drawing.Point(1850, 0);
            this.IconMaxin.Name = "IconMaxin";
            this.IconMaxin.Size = new System.Drawing.Size(35, 39);
            this.IconMaxin.TabIndex = 274;
            this.IconMaxin.UseVisualStyleBackColor = true;
            this.IconMaxin.Click += new System.EventHandler(this.IconMaxin_Click);
            // 
            // IconClose
            // 
            this.IconClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.IconClose.FlatAppearance.BorderSize = 0;
            this.IconClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.IconClose.IconColor = System.Drawing.Color.White;
            this.IconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconClose.IconSize = 30;
            this.IconClose.Location = new System.Drawing.Point(1885, 0);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(35, 39);
            this.IconClose.TabIndex = 40;
            this.IconClose.UseVisualStyleBackColor = true;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 268;
            this.label1.Text = "200-32271";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-7, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 41);
            this.label3.TabIndex = 231;
            this.label3.Text = "ELEN II SOFTWARE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBoth
            // 
            this.panelBoth.BackColor = System.Drawing.Color.SteelBlue;
            this.panelBoth.Controls.Add(this.panel3);
            this.panelBoth.Controls.Add(this.panel2);
            this.panelBoth.Controls.Add(this.panelZone2);
            this.panelBoth.Controls.Add(this.chartZone2);
            this.panelBoth.Controls.Add(this.chartZone1);
            this.panelBoth.Controls.Add(this.panelZone1);
            this.panelBoth.Location = new System.Drawing.Point(579, 45);
            this.panelBoth.Name = "panelBoth";
            this.panelBoth.Size = new System.Drawing.Size(1320, 958);
            this.panelBoth.TabIndex = 271;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
            this.panel3.Controls.Add(this.label87);
            this.panel3.Controls.Add(this.checkT24);
            this.panel3.Controls.Add(this.label88);
            this.panel3.Controls.Add(this.checkT23);
            this.panel3.Controls.Add(this.label89);
            this.panel3.Controls.Add(this.checkT22);
            this.panel3.Controls.Add(this.label90);
            this.panel3.Controls.Add(this.checkT21);
            this.panel3.Controls.Add(this.label91);
            this.panel3.Controls.Add(this.checkT20);
            this.panel3.Controls.Add(this.label92);
            this.panel3.Controls.Add(this.checkT19);
            this.panel3.Controls.Add(this.label93);
            this.panel3.Controls.Add(this.checkT18);
            this.panel3.Controls.Add(this.label94);
            this.panel3.Controls.Add(this.checkT17);
            this.panel3.Controls.Add(this.label95);
            this.panel3.Controls.Add(this.checkT16);
            this.panel3.Controls.Add(this.label96);
            this.panel3.Controls.Add(this.checkT15);
            this.panel3.Controls.Add(this.label97);
            this.panel3.Controls.Add(this.checkT14);
            this.panel3.Controls.Add(this.label98);
            this.panel3.Controls.Add(this.checkT13);
            this.panel3.Location = new System.Drawing.Point(1223, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 360);
            this.panel3.TabIndex = 266;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.BackColor = System.Drawing.Color.Red;
            this.label87.Location = new System.Drawing.Point(7, 5);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(19, 13);
            this.label87.TabIndex = 241;
            this.label87.Text = "    ";
            // 
            // checkT24
            // 
            this.checkT24.AutoSize = true;
            this.checkT24.Checked = true;
            this.checkT24.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT24.Location = new System.Drawing.Point(30, 330);
            this.checkT24.Name = "checkT24";
            this.checkT24.Size = new System.Drawing.Size(48, 17);
            this.checkT24.TabIndex = 264;
            this.checkT24.Text = "T-24";
            this.checkT24.UseVisualStyleBackColor = true;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.BackColor = System.Drawing.Color.Purple;
            this.label88.Location = new System.Drawing.Point(7, 119);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(19, 13);
            this.label88.TabIndex = 245;
            this.label88.Text = "    ";
            // 
            // checkT23
            // 
            this.checkT23.AutoSize = true;
            this.checkT23.Checked = true;
            this.checkT23.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT23.Location = new System.Drawing.Point(30, 299);
            this.checkT23.Name = "checkT23";
            this.checkT23.Size = new System.Drawing.Size(48, 17);
            this.checkT23.TabIndex = 263;
            this.checkT23.Text = "T-23";
            this.checkT23.UseVisualStyleBackColor = true;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.BackColor = System.Drawing.Color.Green;
            this.label89.Location = new System.Drawing.Point(7, 92);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(19, 13);
            this.label89.TabIndex = 244;
            this.label89.Text = "    ";
            // 
            // checkT22
            // 
            this.checkT22.AutoSize = true;
            this.checkT22.Checked = true;
            this.checkT22.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT22.Location = new System.Drawing.Point(30, 272);
            this.checkT22.Name = "checkT22";
            this.checkT22.Size = new System.Drawing.Size(48, 17);
            this.checkT22.TabIndex = 262;
            this.checkT22.Text = "T-22";
            this.checkT22.UseVisualStyleBackColor = true;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.BackColor = System.Drawing.Color.Yellow;
            this.label90.Location = new System.Drawing.Point(7, 62);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(19, 13);
            this.label90.TabIndex = 243;
            this.label90.Text = "    ";
            // 
            // checkT21
            // 
            this.checkT21.AutoSize = true;
            this.checkT21.Checked = true;
            this.checkT21.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT21.Location = new System.Drawing.Point(30, 241);
            this.checkT21.Name = "checkT21";
            this.checkT21.Size = new System.Drawing.Size(48, 17);
            this.checkT21.TabIndex = 261;
            this.checkT21.Text = "T-21";
            this.checkT21.UseVisualStyleBackColor = true;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.BackColor = System.Drawing.Color.Cyan;
            this.label91.Location = new System.Drawing.Point(7, 148);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(19, 13);
            this.label91.TabIndex = 246;
            this.label91.Text = "    ";
            // 
            // checkT20
            // 
            this.checkT20.AutoSize = true;
            this.checkT20.Checked = true;
            this.checkT20.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT20.Location = new System.Drawing.Point(30, 210);
            this.checkT20.Name = "checkT20";
            this.checkT20.Size = new System.Drawing.Size(48, 17);
            this.checkT20.TabIndex = 260;
            this.checkT20.Text = "T-20";
            this.checkT20.UseVisualStyleBackColor = true;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.BackColor = System.Drawing.Color.Blue;
            this.label92.Location = new System.Drawing.Point(7, 32);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(19, 13);
            this.label92.TabIndex = 242;
            this.label92.Text = "    ";
            // 
            // checkT19
            // 
            this.checkT19.AutoSize = true;
            this.checkT19.Checked = true;
            this.checkT19.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT19.Location = new System.Drawing.Point(30, 178);
            this.checkT19.Name = "checkT19";
            this.checkT19.Size = new System.Drawing.Size(48, 17);
            this.checkT19.TabIndex = 259;
            this.checkT19.Text = "T-19";
            this.checkT19.UseVisualStyleBackColor = true;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.BackColor = System.Drawing.Color.Orange;
            this.label93.Location = new System.Drawing.Point(7, 179);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(19, 13);
            this.label93.TabIndex = 247;
            this.label93.Text = "    ";
            // 
            // checkT18
            // 
            this.checkT18.AutoSize = true;
            this.checkT18.Checked = true;
            this.checkT18.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT18.Location = new System.Drawing.Point(30, 147);
            this.checkT18.Name = "checkT18";
            this.checkT18.Size = new System.Drawing.Size(48, 17);
            this.checkT18.TabIndex = 258;
            this.checkT18.Text = "T-18";
            this.checkT18.UseVisualStyleBackColor = true;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.BackColor = System.Drawing.Color.Lime;
            this.label94.Location = new System.Drawing.Point(7, 242);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(19, 13);
            this.label94.TabIndex = 248;
            this.label94.Text = "    ";
            // 
            // checkT17
            // 
            this.checkT17.AutoSize = true;
            this.checkT17.Checked = true;
            this.checkT17.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT17.Location = new System.Drawing.Point(30, 118);
            this.checkT17.Name = "checkT17";
            this.checkT17.Size = new System.Drawing.Size(48, 17);
            this.checkT17.TabIndex = 257;
            this.checkT17.Text = "T-17";
            this.checkT17.UseVisualStyleBackColor = true;
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.BackColor = System.Drawing.Color.Maroon;
            this.label95.Location = new System.Drawing.Point(7, 211);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(19, 13);
            this.label95.TabIndex = 249;
            this.label95.Text = "    ";
            // 
            // checkT16
            // 
            this.checkT16.AutoSize = true;
            this.checkT16.Checked = true;
            this.checkT16.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT16.Location = new System.Drawing.Point(30, 91);
            this.checkT16.Name = "checkT16";
            this.checkT16.Size = new System.Drawing.Size(48, 17);
            this.checkT16.TabIndex = 256;
            this.checkT16.Text = "T-16";
            this.checkT16.UseVisualStyleBackColor = true;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.BackColor = System.Drawing.Color.Magenta;
            this.label96.Location = new System.Drawing.Point(7, 272);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(19, 13);
            this.label96.TabIndex = 250;
            this.label96.Text = "    ";
            // 
            // checkT15
            // 
            this.checkT15.AutoSize = true;
            this.checkT15.Checked = true;
            this.checkT15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT15.Location = new System.Drawing.Point(30, 61);
            this.checkT15.Name = "checkT15";
            this.checkT15.Size = new System.Drawing.Size(48, 17);
            this.checkT15.TabIndex = 255;
            this.checkT15.Text = "T-15";
            this.checkT15.UseVisualStyleBackColor = true;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.BackColor = System.Drawing.Color.Black;
            this.label97.Location = new System.Drawing.Point(7, 331);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(19, 13);
            this.label97.TabIndex = 251;
            this.label97.Text = "    ";
            // 
            // checkT14
            // 
            this.checkT14.AutoSize = true;
            this.checkT14.Checked = true;
            this.checkT14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT14.Location = new System.Drawing.Point(30, 32);
            this.checkT14.Name = "checkT14";
            this.checkT14.Size = new System.Drawing.Size(48, 17);
            this.checkT14.TabIndex = 254;
            this.checkT14.Text = "T-14";
            this.checkT14.UseVisualStyleBackColor = true;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.BackColor = System.Drawing.Color.Olive;
            this.label98.Location = new System.Drawing.Point(7, 300);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(19, 13);
            this.label98.TabIndex = 252;
            this.label98.Text = "    ";
            // 
            // checkT13
            // 
            this.checkT13.AutoSize = true;
            this.checkT13.Checked = true;
            this.checkT13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT13.Location = new System.Drawing.Point(30, 4);
            this.checkT13.Name = "checkT13";
            this.checkT13.Size = new System.Drawing.Size(48, 17);
            this.checkT13.TabIndex = 253;
            this.checkT13.Text = "T-13";
            this.checkT13.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.label84);
            this.panel2.Controls.Add(this.checkT12);
            this.panel2.Controls.Add(this.label37);
            this.panel2.Controls.Add(this.checkT11);
            this.panel2.Controls.Add(this.label38);
            this.panel2.Controls.Add(this.checkT10);
            this.panel2.Controls.Add(this.label66);
            this.panel2.Controls.Add(this.checkT9);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Controls.Add(this.checkT8);
            this.panel2.Controls.Add(this.label83);
            this.panel2.Controls.Add(this.checkT7);
            this.panel2.Controls.Add(this.label35);
            this.panel2.Controls.Add(this.checkT6);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.checkT5);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.checkT4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.checkT3);
            this.panel2.Controls.Add(this.label85);
            this.panel2.Controls.Add(this.checkT2);
            this.panel2.Controls.Add(this.label86);
            this.panel2.Controls.Add(this.checkT1);
            this.panel2.Location = new System.Drawing.Point(1223, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 360);
            this.panel2.TabIndex = 265;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.BackColor = System.Drawing.Color.Red;
            this.label84.Location = new System.Drawing.Point(7, 5);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(19, 13);
            this.label84.TabIndex = 241;
            this.label84.Text = "    ";
            // 
            // checkT12
            // 
            this.checkT12.AutoSize = true;
            this.checkT12.Checked = true;
            this.checkT12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT12.Location = new System.Drawing.Point(30, 330);
            this.checkT12.Name = "checkT12";
            this.checkT12.Size = new System.Drawing.Size(48, 17);
            this.checkT12.TabIndex = 264;
            this.checkT12.Text = "T-12";
            this.checkT12.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Purple;
            this.label37.Location = new System.Drawing.Point(7, 119);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(19, 13);
            this.label37.TabIndex = 245;
            this.label37.Text = "    ";
            // 
            // checkT11
            // 
            this.checkT11.AutoSize = true;
            this.checkT11.Checked = true;
            this.checkT11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT11.Location = new System.Drawing.Point(30, 299);
            this.checkT11.Name = "checkT11";
            this.checkT11.Size = new System.Drawing.Size(48, 17);
            this.checkT11.TabIndex = 263;
            this.checkT11.Text = "T-11";
            this.checkT11.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Green;
            this.label38.Location = new System.Drawing.Point(7, 92);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(19, 13);
            this.label38.TabIndex = 244;
            this.label38.Text = "    ";
            // 
            // checkT10
            // 
            this.checkT10.AutoSize = true;
            this.checkT10.Checked = true;
            this.checkT10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT10.Location = new System.Drawing.Point(30, 272);
            this.checkT10.Name = "checkT10";
            this.checkT10.Size = new System.Drawing.Size(48, 17);
            this.checkT10.TabIndex = 262;
            this.checkT10.Text = "T-10";
            this.checkT10.UseVisualStyleBackColor = true;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.Color.Yellow;
            this.label66.Location = new System.Drawing.Point(7, 62);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(19, 13);
            this.label66.TabIndex = 243;
            this.label66.Text = "    ";
            // 
            // checkT9
            // 
            this.checkT9.AutoSize = true;
            this.checkT9.Checked = true;
            this.checkT9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT9.Location = new System.Drawing.Point(30, 241);
            this.checkT9.Name = "checkT9";
            this.checkT9.Size = new System.Drawing.Size(42, 17);
            this.checkT9.TabIndex = 261;
            this.checkT9.Text = "T-9";
            this.checkT9.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Cyan;
            this.label36.Location = new System.Drawing.Point(7, 148);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(19, 13);
            this.label36.TabIndex = 246;
            this.label36.Text = "    ";
            // 
            // checkT8
            // 
            this.checkT8.AutoSize = true;
            this.checkT8.Checked = true;
            this.checkT8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT8.Location = new System.Drawing.Point(30, 210);
            this.checkT8.Name = "checkT8";
            this.checkT8.Size = new System.Drawing.Size(42, 17);
            this.checkT8.TabIndex = 260;
            this.checkT8.Text = "T-8";
            this.checkT8.UseVisualStyleBackColor = true;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.BackColor = System.Drawing.Color.Blue;
            this.label83.Location = new System.Drawing.Point(7, 32);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(19, 13);
            this.label83.TabIndex = 242;
            this.label83.Text = "    ";
            // 
            // checkT7
            // 
            this.checkT7.AutoSize = true;
            this.checkT7.Checked = true;
            this.checkT7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT7.Location = new System.Drawing.Point(30, 178);
            this.checkT7.Name = "checkT7";
            this.checkT7.Size = new System.Drawing.Size(42, 17);
            this.checkT7.TabIndex = 259;
            this.checkT7.Text = "T-7";
            this.checkT7.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Orange;
            this.label35.Location = new System.Drawing.Point(7, 179);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(19, 13);
            this.label35.TabIndex = 247;
            this.label35.Text = "    ";
            // 
            // checkT6
            // 
            this.checkT6.AutoSize = true;
            this.checkT6.Checked = true;
            this.checkT6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT6.Location = new System.Drawing.Point(30, 147);
            this.checkT6.Name = "checkT6";
            this.checkT6.Size = new System.Drawing.Size(42, 17);
            this.checkT6.TabIndex = 258;
            this.checkT6.Text = "T-6";
            this.checkT6.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Lime;
            this.label34.Location = new System.Drawing.Point(7, 242);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(19, 13);
            this.label34.TabIndex = 248;
            this.label34.Text = "    ";
            // 
            // checkT5
            // 
            this.checkT5.AutoSize = true;
            this.checkT5.Checked = true;
            this.checkT5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT5.Location = new System.Drawing.Point(30, 118);
            this.checkT5.Name = "checkT5";
            this.checkT5.Size = new System.Drawing.Size(42, 17);
            this.checkT5.TabIndex = 257;
            this.checkT5.Text = "T-5";
            this.checkT5.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Maroon;
            this.label31.Location = new System.Drawing.Point(7, 211);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(19, 13);
            this.label31.TabIndex = 249;
            this.label31.Text = "    ";
            // 
            // checkT4
            // 
            this.checkT4.AutoSize = true;
            this.checkT4.Checked = true;
            this.checkT4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT4.Location = new System.Drawing.Point(30, 91);
            this.checkT4.Name = "checkT4";
            this.checkT4.Size = new System.Drawing.Size(42, 17);
            this.checkT4.TabIndex = 256;
            this.checkT4.Text = "T-4";
            this.checkT4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Magenta;
            this.label5.Location = new System.Drawing.Point(7, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 250;
            this.label5.Text = "    ";
            // 
            // checkT3
            // 
            this.checkT3.AutoSize = true;
            this.checkT3.Checked = true;
            this.checkT3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT3.Location = new System.Drawing.Point(30, 61);
            this.checkT3.Name = "checkT3";
            this.checkT3.Size = new System.Drawing.Size(42, 17);
            this.checkT3.TabIndex = 255;
            this.checkT3.Text = "T-3";
            this.checkT3.UseVisualStyleBackColor = true;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.BackColor = System.Drawing.Color.Black;
            this.label85.Location = new System.Drawing.Point(7, 331);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(19, 13);
            this.label85.TabIndex = 251;
            this.label85.Text = "    ";
            // 
            // checkT2
            // 
            this.checkT2.AutoSize = true;
            this.checkT2.Checked = true;
            this.checkT2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT2.Location = new System.Drawing.Point(30, 32);
            this.checkT2.Name = "checkT2";
            this.checkT2.Size = new System.Drawing.Size(42, 17);
            this.checkT2.TabIndex = 254;
            this.checkT2.Text = "T-2";
            this.checkT2.UseVisualStyleBackColor = true;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.BackColor = System.Drawing.Color.Olive;
            this.label86.Location = new System.Drawing.Point(7, 300);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(19, 13);
            this.label86.TabIndex = 252;
            this.label86.Text = "    ";
            // 
            // checkT1
            // 
            this.checkT1.AutoSize = true;
            this.checkT1.Checked = true;
            this.checkT1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkT1.Location = new System.Drawing.Point(30, 4);
            this.checkT1.Name = "checkT1";
            this.checkT1.Size = new System.Drawing.Size(42, 17);
            this.checkT1.TabIndex = 253;
            this.checkT1.Text = "T-1";
            this.checkT1.UseVisualStyleBackColor = true;
            // 
            // panelGhost
            // 
            this.panelGhost.BackColor = System.Drawing.Color.SteelBlue;
            this.panelGhost.Controls.Add(this.panelCheckView);
            this.panelGhost.Controls.Add(this.panelViewZone);
            this.panelGhost.Controls.Add(this.chartView);
            this.panelGhost.Location = new System.Drawing.Point(577, 1025);
            this.panelGhost.Name = "panelGhost";
            this.panelGhost.Size = new System.Drawing.Size(1320, 491);
            this.panelGhost.TabIndex = 273;
            this.panelGhost.Visible = false;
            // 
            // panelCheckView
            // 
            this.panelCheckView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
            this.panelCheckView.Controls.Add(this.lbRed);
            this.panelCheckView.Controls.Add(this.checkView12);
            this.panelCheckView.Controls.Add(this.lbPurple);
            this.panelCheckView.Controls.Add(this.checkView11);
            this.panelCheckView.Controls.Add(this.lbGreen);
            this.panelCheckView.Controls.Add(this.checkView10);
            this.panelCheckView.Controls.Add(this.lbYellow);
            this.panelCheckView.Controls.Add(this.checkView9);
            this.panelCheckView.Controls.Add(this.lbSky);
            this.panelCheckView.Controls.Add(this.checkView8);
            this.panelCheckView.Controls.Add(this.lbBlue);
            this.panelCheckView.Controls.Add(this.checkView7);
            this.panelCheckView.Controls.Add(this.lbOrange);
            this.panelCheckView.Controls.Add(this.checkView6);
            this.panelCheckView.Controls.Add(this.lbLightGreen);
            this.panelCheckView.Controls.Add(this.checkView5);
            this.panelCheckView.Controls.Add(this.lbMaroon);
            this.panelCheckView.Controls.Add(this.checkView4);
            this.panelCheckView.Controls.Add(this.lbMag);
            this.panelCheckView.Controls.Add(this.checkView3);
            this.panelCheckView.Controls.Add(this.lbBlack);
            this.panelCheckView.Controls.Add(this.checkView2);
            this.panelCheckView.Controls.Add(this.lbOlive);
            this.panelCheckView.Controls.Add(this.checkView1);
            this.panelCheckView.Location = new System.Drawing.Point(1223, 17);
            this.panelCheckView.Name = "panelCheckView";
            this.panelCheckView.Size = new System.Drawing.Size(90, 360);
            this.panelCheckView.TabIndex = 267;
            // 
            // lbRed
            // 
            this.lbRed.AutoSize = true;
            this.lbRed.BackColor = System.Drawing.Color.Red;
            this.lbRed.Location = new System.Drawing.Point(7, 5);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(19, 13);
            this.lbRed.TabIndex = 241;
            this.lbRed.Text = "    ";
            // 
            // checkView12
            // 
            this.checkView12.AutoSize = true;
            this.checkView12.Checked = true;
            this.checkView12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkView12.Location = new System.Drawing.Point(30, 330);
            this.checkView12.Name = "checkView12";
            this.checkView12.Size = new System.Drawing.Size(48, 17);
            this.checkView12.TabIndex = 264;
            this.checkView12.Text = "T-24";
            this.checkView12.UseVisualStyleBackColor = true;
            // 
            // lbPurple
            // 
            this.lbPurple.AutoSize = true;
            this.lbPurple.BackColor = System.Drawing.Color.Purple;
            this.lbPurple.Location = new System.Drawing.Point(7, 119);
            this.lbPurple.Name = "lbPurple";
            this.lbPurple.Size = new System.Drawing.Size(19, 13);
            this.lbPurple.TabIndex = 245;
            this.lbPurple.Text = "    ";
            // 
            // checkView11
            // 
            this.checkView11.AutoSize = true;
            this.checkView11.Checked = true;
            this.checkView11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkView11.Location = new System.Drawing.Point(30, 299);
            this.checkView11.Name = "checkView11";
            this.checkView11.Size = new System.Drawing.Size(48, 17);
            this.checkView11.TabIndex = 263;
            this.checkView11.Text = "T-23";
            this.checkView11.UseVisualStyleBackColor = true;
            // 
            // lbGreen
            // 
            this.lbGreen.AutoSize = true;
            this.lbGreen.BackColor = System.Drawing.Color.Green;
            this.lbGreen.Location = new System.Drawing.Point(7, 92);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(19, 13);
            this.lbGreen.TabIndex = 244;
            this.lbGreen.Text = "    ";
            // 
            // checkView10
            // 
            this.checkView10.AutoSize = true;
            this.checkView10.Checked = true;
            this.checkView10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkView10.Location = new System.Drawing.Point(30, 272);
            this.checkView10.Name = "checkView10";
            this.checkView10.Size = new System.Drawing.Size(48, 17);
            this.checkView10.TabIndex = 262;
            this.checkView10.Text = "T-22";
            this.checkView10.UseVisualStyleBackColor = true;
            // 
            // lbYellow
            // 
            this.lbYellow.AutoSize = true;
            this.lbYellow.BackColor = System.Drawing.Color.Yellow;
            this.lbYellow.Location = new System.Drawing.Point(7, 62);
            this.lbYellow.Name = "lbYellow";
            this.lbYellow.Size = new System.Drawing.Size(19, 13);
            this.lbYellow.TabIndex = 243;
            this.lbYellow.Text = "    ";
            // 
            // checkView9
            // 
            this.checkView9.AutoSize = true;
            this.checkView9.Checked = true;
            this.checkView9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkView9.Location = new System.Drawing.Point(30, 241);
            this.checkView9.Name = "checkView9";
            this.checkView9.Size = new System.Drawing.Size(48, 17);
            this.checkView9.TabIndex = 261;
            this.checkView9.Text = "T-21";
            this.checkView9.UseVisualStyleBackColor = true;
            // 
            // lbSky
            // 
            this.lbSky.AutoSize = true;
            this.lbSky.BackColor = System.Drawing.Color.Cyan;
            this.lbSky.Location = new System.Drawing.Point(7, 148);
            this.lbSky.Name = "lbSky";
            this.lbSky.Size = new System.Drawing.Size(19, 13);
            this.lbSky.TabIndex = 246;
            this.lbSky.Text = "    ";
            // 
            // checkView8
            // 
            this.checkView8.AutoSize = true;
            this.checkView8.Checked = true;
            this.checkView8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkView8.Location = new System.Drawing.Point(30, 210);
            this.checkView8.Name = "checkView8";
            this.checkView8.Size = new System.Drawing.Size(48, 17);
            this.checkView8.TabIndex = 260;
            this.checkView8.Text = "T-20";
            this.checkView8.UseVisualStyleBackColor = true;
            // 
            // lbBlue
            // 
            this.lbBlue.AutoSize = true;
            this.lbBlue.BackColor = System.Drawing.Color.Blue;
            this.lbBlue.Location = new System.Drawing.Point(7, 32);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(19, 13);
            this.lbBlue.TabIndex = 242;
            this.lbBlue.Text = "    ";
            // 
            // checkView7
            // 
            this.checkView7.AutoSize = true;
            this.checkView7.Checked = true;
            this.checkView7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkView7.Location = new System.Drawing.Point(30, 178);
            this.checkView7.Name = "checkView7";
            this.checkView7.Size = new System.Drawing.Size(48, 17);
            this.checkView7.TabIndex = 259;
            this.checkView7.Text = "T-19";
            this.checkView7.UseVisualStyleBackColor = true;
            // 
            // lbOrange
            // 
            this.lbOrange.AutoSize = true;
            this.lbOrange.BackColor = System.Drawing.Color.Orange;
            this.lbOrange.Location = new System.Drawing.Point(7, 179);
            this.lbOrange.Name = "lbOrange";
            this.lbOrange.Size = new System.Drawing.Size(19, 13);
            this.lbOrange.TabIndex = 247;
            this.lbOrange.Text = "    ";
            // 
            // checkView6
            // 
            this.checkView6.AutoSize = true;
            this.checkView6.Checked = true;
            this.checkView6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkView6.Location = new System.Drawing.Point(30, 147);
            this.checkView6.Name = "checkView6";
            this.checkView6.Size = new System.Drawing.Size(48, 17);
            this.checkView6.TabIndex = 258;
            this.checkView6.Text = "T-18";
            this.checkView6.UseVisualStyleBackColor = true;
            // 
            // lbLightGreen
            // 
            this.lbLightGreen.AutoSize = true;
            this.lbLightGreen.BackColor = System.Drawing.Color.Lime;
            this.lbLightGreen.Location = new System.Drawing.Point(7, 242);
            this.lbLightGreen.Name = "lbLightGreen";
            this.lbLightGreen.Size = new System.Drawing.Size(19, 13);
            this.lbLightGreen.TabIndex = 248;
            this.lbLightGreen.Text = "    ";
            // 
            // checkView5
            // 
            this.checkView5.AutoSize = true;
            this.checkView5.Checked = true;
            this.checkView5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkView5.Location = new System.Drawing.Point(30, 118);
            this.checkView5.Name = "checkView5";
            this.checkView5.Size = new System.Drawing.Size(48, 17);
            this.checkView5.TabIndex = 257;
            this.checkView5.Text = "T-17";
            this.checkView5.UseVisualStyleBackColor = true;
            // 
            // lbMaroon
            // 
            this.lbMaroon.AutoSize = true;
            this.lbMaroon.BackColor = System.Drawing.Color.Maroon;
            this.lbMaroon.Location = new System.Drawing.Point(7, 211);
            this.lbMaroon.Name = "lbMaroon";
            this.lbMaroon.Size = new System.Drawing.Size(19, 13);
            this.lbMaroon.TabIndex = 249;
            this.lbMaroon.Text = "    ";
            // 
            // checkView4
            // 
            this.checkView4.AutoSize = true;
            this.checkView4.Checked = true;
            this.checkView4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkView4.Location = new System.Drawing.Point(30, 91);
            this.checkView4.Name = "checkView4";
            this.checkView4.Size = new System.Drawing.Size(48, 17);
            this.checkView4.TabIndex = 256;
            this.checkView4.Text = "T-16";
            this.checkView4.UseVisualStyleBackColor = true;
            // 
            // lbMag
            // 
            this.lbMag.AutoSize = true;
            this.lbMag.BackColor = System.Drawing.Color.Magenta;
            this.lbMag.Location = new System.Drawing.Point(7, 272);
            this.lbMag.Name = "lbMag";
            this.lbMag.Size = new System.Drawing.Size(19, 13);
            this.lbMag.TabIndex = 250;
            this.lbMag.Text = "    ";
            // 
            // checkView3
            // 
            this.checkView3.AutoSize = true;
            this.checkView3.Checked = true;
            this.checkView3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkView3.Location = new System.Drawing.Point(30, 61);
            this.checkView3.Name = "checkView3";
            this.checkView3.Size = new System.Drawing.Size(48, 17);
            this.checkView3.TabIndex = 255;
            this.checkView3.Text = "T-15";
            this.checkView3.UseVisualStyleBackColor = true;
            // 
            // lbBlack
            // 
            this.lbBlack.AutoSize = true;
            this.lbBlack.BackColor = System.Drawing.Color.Black;
            this.lbBlack.Location = new System.Drawing.Point(7, 331);
            this.lbBlack.Name = "lbBlack";
            this.lbBlack.Size = new System.Drawing.Size(19, 13);
            this.lbBlack.TabIndex = 251;
            this.lbBlack.Text = "    ";
            // 
            // checkView2
            // 
            this.checkView2.AutoSize = true;
            this.checkView2.Checked = true;
            this.checkView2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkView2.Location = new System.Drawing.Point(30, 32);
            this.checkView2.Name = "checkView2";
            this.checkView2.Size = new System.Drawing.Size(48, 17);
            this.checkView2.TabIndex = 254;
            this.checkView2.Text = "T-14";
            this.checkView2.UseVisualStyleBackColor = true;
            // 
            // lbOlive
            // 
            this.lbOlive.AutoSize = true;
            this.lbOlive.BackColor = System.Drawing.Color.Olive;
            this.lbOlive.Location = new System.Drawing.Point(7, 300);
            this.lbOlive.Name = "lbOlive";
            this.lbOlive.Size = new System.Drawing.Size(19, 13);
            this.lbOlive.TabIndex = 252;
            this.lbOlive.Text = "    ";
            // 
            // checkView1
            // 
            this.checkView1.AutoSize = true;
            this.checkView1.Checked = true;
            this.checkView1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkView1.Location = new System.Drawing.Point(30, 4);
            this.checkView1.Name = "checkView1";
            this.checkView1.Size = new System.Drawing.Size(48, 17);
            this.checkView1.TabIndex = 253;
            this.checkView1.Text = "T-13";
            this.checkView1.UseVisualStyleBackColor = true;
            // 
            // panelViewZone
            // 
            this.panelViewZone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelViewZone.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelViewZone.Controls.Add(this.lbZoneView);
            this.panelViewZone.Controls.Add(this.txtView12);
            this.panelViewZone.Controls.Add(this.txtView11);
            this.panelViewZone.Controls.Add(this.txtView10);
            this.panelViewZone.Controls.Add(this.txtView9);
            this.panelViewZone.Controls.Add(this.txtView8);
            this.panelViewZone.Controls.Add(this.txtView7);
            this.panelViewZone.Controls.Add(this.txtView6);
            this.panelViewZone.Controls.Add(this.txtView5);
            this.panelViewZone.Controls.Add(this.txtView4);
            this.panelViewZone.Controls.Add(this.txtView3);
            this.panelViewZone.Controls.Add(this.txtView2);
            this.panelViewZone.Controls.Add(this.txtView1);
            this.panelViewZone.Controls.Add(this.lbView1);
            this.panelViewZone.Controls.Add(this.lbView2);
            this.panelViewZone.Controls.Add(this.lbView3);
            this.panelViewZone.Controls.Add(this.lbView4);
            this.panelViewZone.Controls.Add(this.lbView5);
            this.panelViewZone.Controls.Add(this.lbView6);
            this.panelViewZone.Controls.Add(this.lbView7);
            this.panelViewZone.Controls.Add(this.lbView8);
            this.panelViewZone.Controls.Add(this.lbView9);
            this.panelViewZone.Controls.Add(this.lbView10);
            this.panelViewZone.Controls.Add(this.lbView11);
            this.panelViewZone.Controls.Add(this.lbView12);
            this.panelViewZone.Location = new System.Drawing.Point(5, 395);
            this.panelViewZone.Name = "panelViewZone";
            this.panelViewZone.Size = new System.Drawing.Size(1212, 87);
            this.panelViewZone.TabIndex = 239;
            // 
            // lbZoneView
            // 
            this.lbZoneView.AutoSize = true;
            this.lbZoneView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZoneView.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbZoneView.Location = new System.Drawing.Point(539, 3);
            this.lbZoneView.Name = "lbZoneView";
            this.lbZoneView.Size = new System.Drawing.Size(84, 20);
            this.lbZoneView.TabIndex = 260;
            this.lbZoneView.Text = "ZONE #2";
            // 
            // txtView12
            // 
            this.txtView12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView12.Location = new System.Drawing.Point(1125, 43);
            this.txtView12.Name = "txtView12";
            this.txtView12.ReadOnly = true;
            this.txtView12.Size = new System.Drawing.Size(79, 29);
            this.txtView12.TabIndex = 195;
            this.txtView12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtView11
            // 
            this.txtView11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView11.Location = new System.Drawing.Point(1019, 43);
            this.txtView11.Name = "txtView11";
            this.txtView11.ReadOnly = true;
            this.txtView11.Size = new System.Drawing.Size(79, 29);
            this.txtView11.TabIndex = 194;
            this.txtView11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtView10
            // 
            this.txtView10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView10.Location = new System.Drawing.Point(910, 43);
            this.txtView10.Name = "txtView10";
            this.txtView10.ReadOnly = true;
            this.txtView10.Size = new System.Drawing.Size(79, 29);
            this.txtView10.TabIndex = 193;
            this.txtView10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtView9
            // 
            this.txtView9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView9.Location = new System.Drawing.Point(801, 43);
            this.txtView9.Name = "txtView9";
            this.txtView9.ReadOnly = true;
            this.txtView9.Size = new System.Drawing.Size(79, 29);
            this.txtView9.TabIndex = 192;
            this.txtView9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtView8
            // 
            this.txtView8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView8.Location = new System.Drawing.Point(691, 43);
            this.txtView8.Name = "txtView8";
            this.txtView8.ReadOnly = true;
            this.txtView8.Size = new System.Drawing.Size(79, 29);
            this.txtView8.TabIndex = 191;
            this.txtView8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtView7
            // 
            this.txtView7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView7.Location = new System.Drawing.Point(590, 43);
            this.txtView7.Name = "txtView7";
            this.txtView7.ReadOnly = true;
            this.txtView7.Size = new System.Drawing.Size(79, 29);
            this.txtView7.TabIndex = 190;
            this.txtView7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtView6
            // 
            this.txtView6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView6.Location = new System.Drawing.Point(486, 43);
            this.txtView6.Name = "txtView6";
            this.txtView6.ReadOnly = true;
            this.txtView6.Size = new System.Drawing.Size(79, 29);
            this.txtView6.TabIndex = 189;
            this.txtView6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtView5
            // 
            this.txtView5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView5.Location = new System.Drawing.Point(388, 44);
            this.txtView5.Name = "txtView5";
            this.txtView5.ReadOnly = true;
            this.txtView5.Size = new System.Drawing.Size(79, 29);
            this.txtView5.TabIndex = 188;
            this.txtView5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtView4
            // 
            this.txtView4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView4.Location = new System.Drawing.Point(287, 43);
            this.txtView4.Name = "txtView4";
            this.txtView4.ReadOnly = true;
            this.txtView4.Size = new System.Drawing.Size(79, 29);
            this.txtView4.TabIndex = 187;
            this.txtView4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtView3
            // 
            this.txtView3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView3.Location = new System.Drawing.Point(193, 43);
            this.txtView3.Name = "txtView3";
            this.txtView3.ReadOnly = true;
            this.txtView3.Size = new System.Drawing.Size(79, 29);
            this.txtView3.TabIndex = 186;
            this.txtView3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtView2
            // 
            this.txtView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView2.Location = new System.Drawing.Point(100, 43);
            this.txtView2.Name = "txtView2";
            this.txtView2.ReadOnly = true;
            this.txtView2.Size = new System.Drawing.Size(79, 29);
            this.txtView2.TabIndex = 185;
            this.txtView2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtView1
            // 
            this.txtView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView1.Location = new System.Drawing.Point(8, 43);
            this.txtView1.Name = "txtView1";
            this.txtView1.ReadOnly = true;
            this.txtView1.Size = new System.Drawing.Size(79, 29);
            this.txtView1.TabIndex = 184;
            this.txtView1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbView1
            // 
            this.lbView1.AutoSize = true;
            this.lbView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbView1.Location = new System.Drawing.Point(25, 22);
            this.lbView1.Name = "lbView1";
            this.lbView1.Size = new System.Drawing.Size(47, 20);
            this.lbView1.TabIndex = 25;
            this.lbView1.Text = "T-13";
            // 
            // lbView2
            // 
            this.lbView2.AutoSize = true;
            this.lbView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbView2.Location = new System.Drawing.Point(117, 22);
            this.lbView2.Name = "lbView2";
            this.lbView2.Size = new System.Drawing.Size(47, 20);
            this.lbView2.TabIndex = 25;
            this.lbView2.Text = "T-14";
            // 
            // lbView3
            // 
            this.lbView3.AutoSize = true;
            this.lbView3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbView3.Location = new System.Drawing.Point(208, 22);
            this.lbView3.Name = "lbView3";
            this.lbView3.Size = new System.Drawing.Size(47, 20);
            this.lbView3.TabIndex = 25;
            this.lbView3.Text = "T-15";
            // 
            // lbView4
            // 
            this.lbView4.AutoSize = true;
            this.lbView4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbView4.Location = new System.Drawing.Point(301, 22);
            this.lbView4.Name = "lbView4";
            this.lbView4.Size = new System.Drawing.Size(47, 20);
            this.lbView4.TabIndex = 25;
            this.lbView4.Text = "T-16";
            // 
            // lbView5
            // 
            this.lbView5.AutoSize = true;
            this.lbView5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbView5.Location = new System.Drawing.Point(402, 23);
            this.lbView5.Name = "lbView5";
            this.lbView5.Size = new System.Drawing.Size(47, 20);
            this.lbView5.TabIndex = 25;
            this.lbView5.Text = "T-17";
            // 
            // lbView6
            // 
            this.lbView6.AutoSize = true;
            this.lbView6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbView6.Location = new System.Drawing.Point(500, 23);
            this.lbView6.Name = "lbView6";
            this.lbView6.Size = new System.Drawing.Size(47, 20);
            this.lbView6.TabIndex = 25;
            this.lbView6.Text = "T-18";
            // 
            // lbView7
            // 
            this.lbView7.AutoSize = true;
            this.lbView7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbView7.Location = new System.Drawing.Point(602, 22);
            this.lbView7.Name = "lbView7";
            this.lbView7.Size = new System.Drawing.Size(47, 20);
            this.lbView7.TabIndex = 25;
            this.lbView7.Text = "T-19";
            // 
            // lbView8
            // 
            this.lbView8.AutoSize = true;
            this.lbView8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbView8.Location = new System.Drawing.Point(702, 22);
            this.lbView8.Name = "lbView8";
            this.lbView8.Size = new System.Drawing.Size(47, 20);
            this.lbView8.TabIndex = 25;
            this.lbView8.Text = "T-20";
            // 
            // lbView9
            // 
            this.lbView9.AutoSize = true;
            this.lbView9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbView9.Location = new System.Drawing.Point(818, 22);
            this.lbView9.Name = "lbView9";
            this.lbView9.Size = new System.Drawing.Size(47, 20);
            this.lbView9.TabIndex = 25;
            this.lbView9.Text = "T-21";
            // 
            // lbView10
            // 
            this.lbView10.AutoSize = true;
            this.lbView10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbView10.Location = new System.Drawing.Point(921, 22);
            this.lbView10.Name = "lbView10";
            this.lbView10.Size = new System.Drawing.Size(47, 20);
            this.lbView10.TabIndex = 25;
            this.lbView10.Text = "T-22";
            // 
            // lbView11
            // 
            this.lbView11.AutoSize = true;
            this.lbView11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbView11.Location = new System.Drawing.Point(1031, 23);
            this.lbView11.Name = "lbView11";
            this.lbView11.Size = new System.Drawing.Size(47, 20);
            this.lbView11.TabIndex = 25;
            this.lbView11.Text = "T-23";
            // 
            // lbView12
            // 
            this.lbView12.AutoSize = true;
            this.lbView12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbView12.Location = new System.Drawing.Point(1139, 23);
            this.lbView12.Name = "lbView12";
            this.lbView12.Size = new System.Drawing.Size(47, 20);
            this.lbView12.TabIndex = 25;
            this.lbView12.Text = "T-24";
            // 
            // chartView
            // 
            this.chartView.BorderlineColor = System.Drawing.Color.Gray;
            this.chartView.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartView.BorderlineWidth = 2;
            chartArea21.Name = "ChartArea1";
            this.chartView.ChartAreas.Add(chartArea21);
            legend21.Name = "Legend1";
            this.chartView.Legends.Add(legend21);
            this.chartView.Location = new System.Drawing.Point(5, 3);
            this.chartView.Name = "chartView";
            series241.ChartArea = "ChartArea1";
            series241.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series241.Legend = "Legend1";
            series241.Name = "T-13";
            series242.ChartArea = "ChartArea1";
            series242.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series242.Legend = "Legend1";
            series242.Name = "T-14";
            series243.ChartArea = "ChartArea1";
            series243.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series243.Legend = "Legend1";
            series243.Name = "T-15";
            series244.ChartArea = "ChartArea1";
            series244.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series244.Legend = "Legend1";
            series244.Name = "T-16";
            series245.ChartArea = "ChartArea1";
            series245.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series245.Legend = "Legend1";
            series245.Name = "T-17";
            series246.ChartArea = "ChartArea1";
            series246.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series246.Legend = "Legend1";
            series246.Name = "T-18";
            series247.ChartArea = "ChartArea1";
            series247.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series247.Legend = "Legend1";
            series247.Name = "T-19";
            series248.ChartArea = "ChartArea1";
            series248.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series248.Legend = "Legend1";
            series248.Name = "TC-20";
            series249.ChartArea = "ChartArea1";
            series249.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series249.Legend = "Legend1";
            series249.Name = "TC-21";
            series250.ChartArea = "ChartArea1";
            series250.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series250.Legend = "Legend1";
            series250.Name = "TC-22";
            series251.ChartArea = "ChartArea1";
            series251.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series251.Legend = "Legend1";
            series251.Name = "TC-23";
            series252.ChartArea = "ChartArea1";
            series252.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series252.Legend = "Legend1";
            series252.Name = "TC-24";
            this.chartView.Series.Add(series241);
            this.chartView.Series.Add(series242);
            this.chartView.Series.Add(series243);
            this.chartView.Series.Add(series244);
            this.chartView.Series.Add(series245);
            this.chartView.Series.Add(series246);
            this.chartView.Series.Add(series247);
            this.chartView.Series.Add(series248);
            this.chartView.Series.Add(series249);
            this.chartView.Series.Add(series250);
            this.chartView.Series.Add(series251);
            this.chartView.Series.Add(series252);
            this.chartView.Size = new System.Drawing.Size(1212, 395);
            this.chartView.TabIndex = 212;
            this.chartView.Text = "chart1";
            // 
            // timerGhost
            // 
            this.timerGhost.Tick += new System.EventHandler(this.timerGhost_Tick);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnInfo.IconColor = System.Drawing.Color.White;
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.IconSize = 25;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(7, 759);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(155, 36);
            this.btnInfo.TabIndex = 274;
            this.btnInfo.Text = "Information";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnCSVFileFilter
            // 
            this.btnCSVFileFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCSVFileFilter.FlatAppearance.BorderSize = 0;
            this.btnCSVFileFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSVFileFilter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSVFileFilter.ForeColor = System.Drawing.Color.White;
            this.btnCSVFileFilter.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            this.btnCSVFileFilter.IconColor = System.Drawing.Color.White;
            this.btnCSVFileFilter.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCSVFileFilter.IconSize = 25;
            this.btnCSVFileFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCSVFileFilter.Location = new System.Drawing.Point(7, 799);
            this.btnCSVFileFilter.Name = "btnCSVFileFilter";
            this.btnCSVFileFilter.Size = new System.Drawing.Size(137, 36);
            this.btnCSVFileFilter.TabIndex = 229;
            this.btnCSVFileFilter.Text = "CSV Files";
            this.btnCSVFileFilter.UseVisualStyleBackColor = false;
            this.btnCSVFileFilter.Click += new System.EventHandler(this.btnCSVFileFilter_Click);
            // 
            // btnEMO
            // 
            this.btnEMO.BackColor = System.Drawing.Color.Transparent;
            this.btnEMO.Image = ((System.Drawing.Image)(resources.GetObject("btnEMO.Image")));
            this.btnEMO.Location = new System.Drawing.Point(455, 635);
            this.btnEMO.Name = "btnEMO";
            this.btnEMO.Size = new System.Drawing.Size(48, 50);
            this.btnEMO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEMO.TabIndex = 221;
            this.btnEMO.TabStop = false;
            this.btnEMO.Click += new System.EventHandler(this.btnEMO_Click);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label110);
            this.panel4.Controls.Add(this.pictureBox26);
            this.panel4.Controls.Add(this.pictureBox25);
            this.panel4.Controls.Add(this.pictureBox24);
            this.panel4.Controls.Add(this.iconButton4);
            this.panel4.Controls.Add(this.btnOnOff);
            this.panel4.Controls.Add(this.label109);
            this.panel4.Controls.Add(this.iconButton3);
            this.panel4.Controls.Add(this.txtSetTemp);
            this.panel4.Controls.Add(this.label108);
            this.panel4.Controls.Add(this.pictureBox23);
            this.panel4.Controls.Add(this.pictureBox22);
            this.panel4.Controls.Add(this.btnInfo);
            this.panel4.Controls.Add(this.label107);
            this.panel4.Controls.Add(this.label106);
            this.panel4.Controls.Add(this.cbSelect);
            this.panel4.Controls.Add(this.btnCSVFileFilter);
            this.panel4.Controls.Add(this.label105);
            this.panel4.Controls.Add(this.pictureBox21);
            this.panel4.Controls.Add(this.pictureBox20);
            this.panel4.Controls.Add(this.btnEMO);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label104);
            this.panel4.Controls.Add(this.label103);
            this.panel4.Controls.Add(this.label101);
            this.panel4.Controls.Add(this.label102);
            this.panel4.Controls.Add(this.cbZonesMode);
            this.panel4.Controls.Add(this.label100);
            this.panel4.Controls.Add(this.label99);
            this.panel4.Controls.Add(this.label33);
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Controls.Add(this.iconButton2);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.btnRefreshCOM);
            this.panel4.Controls.Add(this.btnConnectCOM);
            this.panel4.Controls.Add(this.cbCOMSelect);
            this.panel4.Controls.Add(this.label32);
            this.panel4.Controls.Add(this.menuMainBar);
            this.panel4.Location = new System.Drawing.Point(21, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(518, 879);
            this.panel4.TabIndex = 275;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(0, 407);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(518, 5);
            this.panel7.TabIndex = 286;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 504);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(518, 5);
            this.panel6.TabIndex = 286;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 712);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(518, 5);
            this.panel5.TabIndex = 285;
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label110.ForeColor = System.Drawing.Color.White;
            this.label110.Location = new System.Drawing.Point(8, 727);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(157, 19);
            this.label110.TabIndex = 284;
            this.label110.Text = "Information Section";
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = global::Apple_24_Zones.Properties.Resources.tc3off;
            this.pictureBox26.Location = new System.Drawing.Point(59, 655);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(30, 30);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox26.TabIndex = 283;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Image = global::Apple_24_Zones.Properties.Resources.tc8off;
            this.pictureBox25.Location = new System.Drawing.Point(23, 655);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(30, 30);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox25.TabIndex = 282;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = global::Apple_24_Zones.Properties.Resources.tc1off;
            this.pictureBox24.Location = new System.Drawing.Point(98, 655);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(30, 30);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox24.TabIndex = 281;
            this.pictureBox24.TabStop = false;
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(12, 607);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.iconButton4.Size = new System.Drawing.Size(116, 41);
            this.iconButton4.TabIndex = 280;
            this.iconButton4.Text = "         Turn Off";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // btnOnOff
            // 
            this.btnOnOff.FlatAppearance.BorderSize = 0;
            this.btnOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnOff.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnOff.ForeColor = System.Drawing.Color.White;
            this.btnOnOff.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnOnOff.IconColor = System.Drawing.Color.White;
            this.btnOnOff.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnOnOff.IconSize = 30;
            this.btnOnOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnOff.Location = new System.Drawing.Point(12, 560);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnOnOff.Size = new System.Drawing.Size(116, 41);
            this.btnOnOff.TabIndex = 279;
            this.btnOnOff.Text = "         Turn On";
            this.btnOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnOff.UseVisualStyleBackColor = true;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label109.ForeColor = System.Drawing.Color.White;
            this.label109.Location = new System.Drawing.Point(8, 526);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(112, 19);
            this.label109.TabIndex = 278;
            this.label109.Text = "Status Section";
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.SteelBlue;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(276, 466);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(73, 28);
            this.iconButton3.TabIndex = 277;
            this.iconButton3.Text = "    SET";
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // txtSetTemp
            // 
            this.txtSetTemp.BackColor = System.Drawing.Color.SteelBlue;
            this.txtSetTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSetTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetTemp.ForeColor = System.Drawing.Color.White;
            this.txtSetTemp.Location = new System.Drawing.Point(12, 469);
            this.txtSetTemp.Name = "txtSetTemp";
            this.txtSetTemp.Size = new System.Drawing.Size(250, 22);
            this.txtSetTemp.TabIndex = 276;
            this.txtSetTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label108.ForeColor = System.Drawing.Color.White;
            this.label108.Location = new System.Drawing.Point(8, 430);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(194, 19);
            this.label108.TabIndex = 275;
            this.label108.Text = "Set Temperature Section";
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = global::Apple_24_Zones.Properties.Resources.led_off;
            this.pictureBox23.Location = new System.Drawing.Point(245, 376);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(25, 25);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox23.TabIndex = 133;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = global::Apple_24_Zones.Properties.Resources.led_off;
            this.pictureBox22.Location = new System.Drawing.Point(91, 376);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(25, 25);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox22.TabIndex = 132;
            this.pictureBox22.TabStop = false;
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label107.ForeColor = System.Drawing.Color.White;
            this.label107.Location = new System.Drawing.Point(20, 376);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(65, 18);
            this.label107.TabIndex = 131;
            this.label107.Text = "Heating";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label106.ForeColor = System.Drawing.Color.White;
            this.label106.Location = new System.Drawing.Point(172, 376);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(67, 18);
            this.label106.TabIndex = 130;
            this.label106.Text = "Cooling";
            // 
            // cbSelect
            // 
            this.cbSelect.BackColor = System.Drawing.Color.SteelBlue;
            this.cbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelect.ForeColor = System.Drawing.Color.White;
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            " • Cooling",
            " • Heating"});
            this.cbSelect.Location = new System.Drawing.Point(23, 335);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(265, 26);
            this.cbSelect.TabIndex = 129;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label105.ForeColor = System.Drawing.Color.White;
            this.label105.Location = new System.Drawing.Point(8, 300);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(168, 19);
            this.label105.TabIndex = 128;
            this.label105.Text = "Action Mode Section";
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::Apple_24_Zones.Properties.Resources.tc8off;
            this.pictureBox21.Location = new System.Drawing.Point(405, 217);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(25, 25);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox21.TabIndex = 127;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::Apple_24_Zones.Properties.Resources.tc8off;
            this.pictureBox20.Location = new System.Drawing.Point(405, 245);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(25, 25);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox20.TabIndex = 126;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Apple_24_Zones.Properties.Resources.tc8off;
            this.pictureBox3.Location = new System.Drawing.Point(405, 189);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 125;
            this.pictureBox3.TabStop = false;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label104.ForeColor = System.Drawing.Color.White;
            this.label104.Location = new System.Drawing.Point(312, 252);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(66, 18);
            this.label104.TabIndex = 124;
            this.label104.Text = "Zone #1";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.ForeColor = System.Drawing.Color.White;
            this.label103.Location = new System.Drawing.Point(312, 224);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(66, 18);
            this.label103.TabIndex = 123;
            this.label103.Text = "Zone #2";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.ForeColor = System.Drawing.Color.White;
            this.label101.Location = new System.Drawing.Point(312, 196);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(87, 18);
            this.label101.TabIndex = 122;
            this.label101.Text = "Both Zones";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.ForeColor = System.Drawing.Color.White;
            this.label102.Location = new System.Drawing.Point(20, 205);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(268, 18);
            this.label102.TabIndex = 121;
            this.label102.Text = "Select the area in which you\'ll work";
            // 
            // cbZonesMode
            // 
            this.cbZonesMode.BackColor = System.Drawing.Color.SteelBlue;
            this.cbZonesMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZonesMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZonesMode.ForeColor = System.Drawing.Color.White;
            this.cbZonesMode.FormattingEnabled = true;
            this.cbZonesMode.Items.AddRange(new object[] {
            " • Both Zones",
            " • Zone # 1",
            " • Zone # 2"});
            this.cbZonesMode.Location = new System.Drawing.Point(23, 235);
            this.cbZonesMode.Name = "cbZonesMode";
            this.cbZonesMode.Size = new System.Drawing.Size(265, 26);
            this.cbZonesMode.TabIndex = 119;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.ForeColor = System.Drawing.Color.White;
            this.label100.Location = new System.Drawing.Point(3, 172);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(162, 19);
            this.label100.TabIndex = 118;
            this.label100.Text = "Zones Mode Section";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.ForeColor = System.Drawing.Color.White;
            this.label99.Location = new System.Drawing.Point(273, 62);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(116, 18);
            this.label99.TabIndex = 117;
            this.label99.Text = "Connection #2";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(20, 62);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(116, 18);
            this.label33.TabIndex = 116;
            this.label33.Text = "Connection #1";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(377, 116);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(117, 36);
            this.iconButton1.TabIndex = 115;
            this.iconButton1.Text = "          Refresh";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(267, 116);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(116, 36);
            this.iconButton2.TabIndex = 114;
            this.iconButton2.Text = "           Connect";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(276, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 26);
            this.comboBox1.TabIndex = 113;
            // 
            // btnRefreshCOM
            // 
            this.btnRefreshCOM.FlatAppearance.BorderSize = 0;
            this.btnRefreshCOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCOM.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCOM.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnRefreshCOM.IconColor = System.Drawing.Color.White;
            this.btnRefreshCOM.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRefreshCOM.IconSize = 30;
            this.btnRefreshCOM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshCOM.Location = new System.Drawing.Point(122, 114);
            this.btnRefreshCOM.Name = "btnRefreshCOM";
            this.btnRefreshCOM.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnRefreshCOM.Size = new System.Drawing.Size(117, 36);
            this.btnRefreshCOM.TabIndex = 112;
            this.btnRefreshCOM.Text = "          Refresh";
            this.btnRefreshCOM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshCOM.UseVisualStyleBackColor = true;
            // 
            // btnConnectCOM
            // 
            this.btnConnectCOM.FlatAppearance.BorderSize = 0;
            this.btnConnectCOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectCOM.ForeColor = System.Drawing.Color.White;
            this.btnConnectCOM.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.btnConnectCOM.IconColor = System.Drawing.Color.White;
            this.btnConnectCOM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConnectCOM.IconSize = 40;
            this.btnConnectCOM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnectCOM.Location = new System.Drawing.Point(12, 114);
            this.btnConnectCOM.Name = "btnConnectCOM";
            this.btnConnectCOM.Size = new System.Drawing.Size(116, 36);
            this.btnConnectCOM.TabIndex = 111;
            this.btnConnectCOM.Text = "           Connect";
            this.btnConnectCOM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnectCOM.UseVisualStyleBackColor = true;
            // 
            // cbCOMSelect
            // 
            this.cbCOMSelect.BackColor = System.Drawing.Color.SteelBlue;
            this.cbCOMSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCOMSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCOMSelect.ForeColor = System.Drawing.Color.White;
            this.cbCOMSelect.FormattingEnabled = true;
            this.cbCOMSelect.Location = new System.Drawing.Point(23, 83);
            this.cbCOMSelect.Name = "cbCOMSelect";
            this.cbCOMSelect.Size = new System.Drawing.Size(206, 26);
            this.cbCOMSelect.TabIndex = 110;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(3, 28);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(159, 19);
            this.label32.TabIndex = 1;
            this.label32.Text = "Connection Section";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(21, 415);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(518, 5);
            this.panel9.TabIndex = 286;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Location = new System.Drawing.Point(21, 280);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(518, 5);
            this.panel15.TabIndex = 286;
            // 
            // txtTempTest
            // 
            this.txtTempTest.Location = new System.Drawing.Point(28, 48);
            this.txtTempTest.Name = "txtTempTest";
            this.txtTempTest.Size = new System.Drawing.Size(100, 20);
            this.txtTempTest.TabIndex = 287;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 288;
            this.button3.Text = "convert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(233, 90);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 289;
            // 
            // viewOptionToolStripMenuItem
            // 
            this.viewOptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bothZonesToolStripMenuItem,
            this.zone1ToolStripMenuItem,
            this.zone2ToolStripMenuItem});
            this.viewOptionToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOptionToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.viewOptionToolStripMenuItem.Name = "viewOptionToolStripMenuItem";
            this.viewOptionToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.viewOptionToolStripMenuItem.Text = "View Option";
            // 
            // bothZonesToolStripMenuItem
            // 
            this.bothZonesToolStripMenuItem.Name = "bothZonesToolStripMenuItem";
            this.bothZonesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.bothZonesToolStripMenuItem.Text = "Both Zones";
            this.bothZonesToolStripMenuItem.Click += new System.EventHandler(this.bothZonesToolStripMenuItem_Click);
            // 
            // zone1ToolStripMenuItem
            // 
            this.zone1ToolStripMenuItem.Name = "zone1ToolStripMenuItem";
            this.zone1ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.zone1ToolStripMenuItem.Text = "Zone #1";
            this.zone1ToolStripMenuItem.Click += new System.EventHandler(this.zone1ToolStripMenuItem_Click);
            // 
            // zone2ToolStripMenuItem
            // 
            this.zone2ToolStripMenuItem.Name = "zone2ToolStripMenuItem";
            this.zone2ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.zone2ToolStripMenuItem.Text = "Zone #2";
            this.zone2ToolStripMenuItem.Click += new System.EventHandler(this.zone2ToolStripMenuItem_Click);
            // 
            // menuMainBar
            // 
            this.menuMainBar.BackColor = System.Drawing.Color.White;
            this.menuMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOptionToolStripMenuItem});
            this.menuMainBar.Location = new System.Drawing.Point(0, 0);
            this.menuMainBar.Name = "menuMainBar";
            this.menuMainBar.Size = new System.Drawing.Size(518, 24);
            this.menuMainBar.TabIndex = 0;
            this.menuMainBar.Text = "menuStrip3";
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(226)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtTempTest);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelGhost);
            this.Controls.Add(this.panelBoth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELEN II Software Rev 1.000.0";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartZone2)).EndInit();
            this.panelZone1.ResumeLayout(false);
            this.panelZone1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledZ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZone1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelZone2.ResumeLayout(false);
            this.panelZone2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBoth.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelGhost.ResumeLayout(false);
            this.panelCheckView.ResumeLayout(false);
            this.panelCheckView.PerformLayout();
            this.panelViewZone.ResumeLayout(false);
            this.panelViewZone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEMO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSetTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuMainBar.ResumeLayout(false);
            this.menuMainBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHora;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZone1;
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
        private Panel panel8;
        private Panel panel10;
        private TextBox textBox40;
        private TextBox textBox41;
        private TextBox textBox43;
        private TextBox textBox42;
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
        private Panel panelZone2;
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
        private Label label3;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox17;
        private PictureBox pictureBox16;
        private Label label1;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartZone2;
        private Panel panelBoth;
        private Label label2;
        private Label label4;
        private Panel panel3;
        private Label label87;
        private CheckBox checkT24;
        private Label label88;
        private CheckBox checkT23;
        private Label label89;
        private CheckBox checkT22;
        private Label label90;
        private CheckBox checkT21;
        private Label label91;
        private CheckBox checkT20;
        private Label label92;
        private CheckBox checkT19;
        private Label label93;
        private CheckBox checkT18;
        private Label label94;
        private CheckBox checkT17;
        private Label label95;
        private CheckBox checkT16;
        private Label label96;
        private CheckBox checkT15;
        private Label label97;
        private CheckBox checkT14;
        private Label label98;
        private CheckBox checkT13;
        private Panel panel2;
        private Label label84;
        private CheckBox checkT12;
        private Label label37;
        private CheckBox checkT11;
        private Label label38;
        private CheckBox checkT10;
        private Label label66;
        private CheckBox checkT9;
        private Label label36;
        private CheckBox checkT8;
        private Label label83;
        private CheckBox checkT7;
        private Label label35;
        private CheckBox checkT6;
        private Label label34;
        private CheckBox checkT5;
        private Label label31;
        private CheckBox checkT4;
        private Label label5;
        private CheckBox checkT3;
        private Label label85;
        private CheckBox checkT2;
        private Label label86;
        private CheckBox checkT1;
        private FontAwesome.Sharp.IconButton IconMinima;
        private FontAwesome.Sharp.IconButton IconMaxin;
        private FontAwesome.Sharp.IconButton IconClose;
        private Panel panelGhost;
        private Panel panelCheckView;
        private Label lbRed;
        private CheckBox checkView12;
        private Label lbPurple;
        private CheckBox checkView11;
        private Label lbGreen;
        private CheckBox checkView10;
        private Label lbYellow;
        private CheckBox checkView9;
        private Label lbSky;
        private CheckBox checkView8;
        private Label lbBlue;
        private CheckBox checkView7;
        private Label lbOrange;
        private CheckBox checkView6;
        private Label lbLightGreen;
        private CheckBox checkView5;
        private Label lbMaroon;
        private CheckBox checkView4;
        private Label lbMag;
        private CheckBox checkView3;
        private Label lbBlack;
        private CheckBox checkView2;
        private Label lbOlive;
        private CheckBox checkView1;
        private Panel panelViewZone;
        private Label lbZoneView;
        private TextBox txtView12;
        private TextBox txtView11;
        private TextBox txtView10;
        private TextBox txtView9;
        private TextBox txtView8;
        private TextBox txtView7;
        private TextBox txtView6;
        private TextBox txtView5;
        private TextBox txtView4;
        private TextBox txtView3;
        private TextBox txtView2;
        private TextBox txtView1;
        private Label lbView1;
        private Label lbView2;
        private Label lbView3;
        private Label lbView4;
        private Label lbView5;
        private Label lbView6;
        private Label lbView7;
        private Label lbView8;
        private Label lbView9;
        private Label lbView10;
        private Label lbView11;
        private Label lbView12;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartView;
        private Timer timerGhost;
        private FontAwesome.Sharp.IconButton btnInfo;
        private Panel panel4;
        private Label label100;
        private Label label99;
        private Label label33;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton btnRefreshCOM;
        private FontAwesome.Sharp.IconButton btnConnectCOM;
        private ComboBox cbCOMSelect;
        private Label label32;
        private ComboBox cbZonesMode;
        private Label label102;
        private Label label104;
        private Label label103;
        private Label label101;
        private PictureBox pictureBox21;
        private PictureBox pictureBox20;
        private PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private NumericUpDown txtSetTemp;
        private Label label108;
        private PictureBox pictureBox23;
        private PictureBox pictureBox22;
        private Label label107;
        private Label label106;
        private ComboBox cbSelect;
        private Label label105;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnOnOff;
        private Label label109;
        private PictureBox pictureBox26;
        private PictureBox pictureBox25;
        private PictureBox pictureBox24;
        private Label label110;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel9;
        private Panel panel15;
        private TextBox txtTempTest;
        private Button button3;
        private TextBox txtResult;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem statusToolStripMenuItem;
        private ToolStripMenuItem manualControlToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private MenuStrip menuMainBar;
        private ToolStripMenuItem viewOptionToolStripMenuItem;
        private ToolStripMenuItem bothZonesToolStripMenuItem;
        private ToolStripMenuItem zone1ToolStripMenuItem;
        private ToolStripMenuItem zone2ToolStripMenuItem;
    }
}