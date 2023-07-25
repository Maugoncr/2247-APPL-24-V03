using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media.Media3D;

namespace Apple_24_Zones.Forms
{
    public partial class FrmMain : Form
         
    {
        
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
         private MainMenu mainMenu;

        //
        //Panel swap status
        //
        List<Panel> listPanel = new List<Panel>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //TODO
            //if (serialPort1.IsOpen)
            //{
            //    serialPort1.DiscardInBuffer();
            //    serialPort1.DiscardOutBuffer();
            //    serialPort1.Write("#020000" + "\r");
            //    BanderaRespuestaParaTCS = false;
            //    serialPort1.Close();
            //}
            Application.Exit();
        }


        /*
        private void MenuItemExport_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmFilterCSVFile);

            if (frm == null)
            {
                FrmFilterCSVFile nt = new FrmFilterCSVFile();

                nt.Show();
            }
            else
            {
                frm.BringToFront();
                return;
            }
        }
        */
        /*
        private void MenuItemConnect_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmConnect);

            if(frm==null)
            {
                FrmConnect nt = new FrmConnect();
                nt.Show();
            }
            else
            {
                frm.BringToFront();
                return;
            }


        }
        */

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        



        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
               // btnDownUpMenu.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleUp;
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void hideSubMenu()
        {
           // if (panelSubMenuGestion.Visible == true)
           // {
           //     panelSubMenuGestion.Visible = false;
           // }
           /*
            if (panelSubMenu2.Visible == true)
            {
                panelSubMenu2.Visible = false;
            }
            if (panelSubMenu3.Visible == true)
            {
                panelSubMenu3.Visible = false;
            }
            if (panelSubMenu4.Visible == true)
            {
                panelSubMenu4.Visible = false;
            }
            if (panelSubMenu5.Visible == true)
            {
                panelSubMenu5.Visible = false;
            }
            if (panelSubMenu6.Visible == true)
            {
                panelSubMenu6.Visible = false;
            }
           */
        }

        private void ResetAllDefault()
        {
            // Reset Seccion Conection
           // cbSelect.SelectedIndex = -1;
            //btnRefreshCOM1.Enabled = true;
            //btnConnectCOM1.Enabled = false;
           // cbCOMSelect1.Enabled = true;
            string[] ports = SerialPort.GetPortNames();
            //cbCOMSelect1.Items.Clear();
            //cbCOMSelect1.Items.AddRange(ports);
            //btnConnectCOM1.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

            // Comunicacion
            //SetConfigSerialPortForTCS();
            //BanderaRespuestaParaTCS = false;

            //Reset View Options
           // panelGhost.Visible = false;
           // cbSelectViewZone.SelectedIndex = -1;
           // cbSelectViewChartZone.SelectedIndex = -1;
            //cbZonesMode.SelectedIndex = -1;

            //ledZ1.Image.Dispose();
            //ledZ2.Image.Dispose();

            //ledZ1.Image = Properties.Resources.led_off;
            //ledZ2.Image = Properties.Resources.led_off;

            // Disable All buttoms
            /*
            cbZonesMode.Enabled = false;
            cbSelect.Enabled = false;
            txtSetTemp.Enabled = false;
            btnSetTemperature.Enabled = false;
            btnOnOff.Enabled = false;
            btnStartStopChart.Enabled = false;
            btnChartMode.Enabled = false;
            btnRecordDataChart.Enabled = false;
            btnClearChart.Enabled = false;
            btnTypeTime.Enabled = false;
            

            btnReportes.Text = "Status: OFF";
            btnOnOff.Text = "         Turn On";
            */

            //Chart things

            ChartArea CA = ChartMain.ChartAreas[0];
            CA.CursorX.AutoScroll = true;

            ChartMain.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            ChartMain.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            ChartMain.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid;

            CA.AxisY.MinorTickMark.Enabled = true;
            CA.AxisY.MinorGrid.Enabled = true;

      

            //Record things
            DATETIMES.Clear();
            TIMES.Clear();
            TC1A.Clear(); TC2A.Clear(); TC3A.Clear(); TC4A.Clear(); TC5A.Clear(); TC6A.Clear(); TC7A.Clear(); TC8A.Clear(); TC9A.Clear(); TC10A.Clear(); TC11A.Clear(); TC12A.Clear(); TC13A.Clear(); TC14A.Clear(); TC15A.Clear(); TC16A.Clear(); TC17A.Clear(); TC18A.Clear(); TC19A.Clear(); TC20A.Clear(); TC21A.Clear(); TC22A.Clear(); TC23A.Clear(); TC24A.Clear();

            btnRecordDataChart.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            Record = false;
            end_record = DateTime.Now;
            lbRecord.Text = "Record Data";
            lbRecord.ForeColor = Color.Black;

            ChartMain.Series.Clear();
            chart1.Series.Clear();
            GenerarChart12();
            GenerarChart24();


            ChartMain.Series["T-1"].Points.Clear(); ChartMain.Series["T-2"].Points.Clear(); ChartMain.Series["T-3"].Points.Clear(); ChartMain.Series["T-4"].Points.Clear(); ChartMain.Series["T-5"].Points.Clear(); ChartMain.Series["T-6"].Points.Clear(); ChartMain.Series["T-7"].Points.Clear(); ChartMain.Series["T-8"].Points.Clear(); ChartMain.Series["T-9"].Points.Clear(); ChartMain.Series["T-10"].Points.Clear(); ChartMain.Series["T-11"].Points.Clear(); ChartMain.Series["T-12"].Points.Clear();
            chart1.Series["T-13"].Points.Clear(); chart1.Series["T-14"].Points.Clear(); chart1.Series["T-15"].Points.Clear(); chart1.Series["T-16"].Points.Clear(); chart1.Series["T-17"].Points.Clear(); chart1.Series["T-18"].Points.Clear(); chart1.Series["T-19"].Points.Clear(); chart1.Series["T-20"].Points.Clear(); chart1.Series["T-21"].Points.Clear(); chart1.Series["T-22"].Points.Clear(); chart1.Series["T-23"].Points.Clear(); chart1.Series["T-24"].Points.Clear();

            timerForChartTC.Stop();


            tiempo = 0;

            FuncModeAntiguo();
            ModeChartTimeSS();

            // Limpiar todos txt's

            //txtSetTemp.ResetText();
            //txtTCView1.Clear(); txtTCView2.Clear(); txtTCView3.Clear(); txtTCView4.Clear(); txtTCView5.Clear(); txtTCView6.Clear(); txtTCView7.Clear(); txtTCView8.Clear(); txtTCView9.Clear(); txtTCView10.Clear(); txtTCView11.Clear(); txtTCView12.Clear(); txtTCView13.Clear(); txtTCView14.Clear(); txtTCView15.Clear(); txtTCView16.Clear(); txtTCView17.Clear(); txtTCView18.Clear(); txtTCView19.Clear(); txtTCView20.Clear(); txtTCView21.Clear(); txtTCView22.Clear(); txtTCView23.Clear(); txtTCView24.Clear();
            txtTC1.Clear(); txtTC2.Clear(); txtTC3.Clear(); txtTC4.Clear(); txtTC5.Clear(); txtTC6.Clear(); txtTC7.Clear(); txtTC8.Clear(); txtTC9.Clear(); txtTC10.Clear(); txtTC11.Clear(); txtTC12.Clear(); txtTC13.Clear(); txtTC14.Clear(); txtTC15.Clear(); txtTC16.Clear(); txtTC17.Clear(); txtTC18.Clear(); txtTC19.Clear(); txtTC20.Clear(); txtTC21.Clear(); txtTC22.Clear(); txtTC23.Clear(); txtTC24.Clear();
            txtSetPointZone2.Clear();


            // Reset variables

            TC1S = ""; TC2S = ""; TC3S = ""; TC4S = ""; TC5S = ""; TC6S = ""; TC7S = ""; TC8S = ""; TC9S = ""; TC10S = ""; TC11S = ""; TC12S = ""; TC13S = ""; TC14S = ""; TC15S = ""; TC16S = ""; TC17S = ""; TC18S = ""; TC19S = ""; TC20S = ""; TC21S = ""; TC22S = ""; TC23S = ""; TC24S = "";
            TC1Num = 0; TC2Num = 0; TC3Num = 0; TC4Num = 0; TC5Num = 0; TC6Num = 0; TC7Num = 0; TC8Num = 0; TC9Num = 0; TC10Num = 0; TC11Num = 0; TC12Num = 0; TC13Num = 0; TC14Num = 0; TC15Num = 0; TC16Num = 0; TC17Num = 0; TC18Num = 0; TC19Num = 0; TC20Num = 0; TC21Num = 0; TC22Num = 0; TC23Num = 0; TC24Num = 0;


            ZonasSelecionadasChart = 0;
            ZonasSelecionadasTXT = 0;
            ZonasSelecionadasSendTCSETPOINT = 0;
            i = false;

           // led1.Image.Dispose();
           // led2.Image.Dispose();
           // led1.Image = Properties.Resources.led_off;
           // led2.Image = Properties.Resources.led_off;

        }


        private void CiclosEnOtroHilo()
        {
            Thread.Sleep(2000);
            serialPort1.Write("P");
            Console.WriteLine("Hablando desde otro hilo :)");

        }

        private void FuncModeAntiguo()
        {
            lbCharMode.Text = "Chart Dinamic";
            //lbMinChartMode.Visible = false;
            //NumMinChart.Visible = false;
            //NumMinChart.Value = 2;
            ModoAntiguo = true;
            btnChartMode.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            TimerHoraFecha.Start();
            ResetAllDefault();

            listPanel.Add(panel10);
            listPanel.Add(panel11);
            listPanel.Add(panel13);
            listPanel.Add(panel14);
            listPanel[2].BringToFront();


        }


        /*
        private void btnInformacion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu2);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu3);
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu4);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu5);
        }

        private void btnGestionArchivos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu6);
        }
        */

        /*
        private void AbrirMenu()
        {
            //panelSubMenuGestion.Visible = true;
            panelSubMenu2.Visible = true;
            panelSubMenu3.Visible = true;
            panelSubMenu4.Visible = true;
            panelSubMenu5.Visible = true;
           // panelSubMenu6.Visible = true;
            btnDownUpMenu.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleUp;
        }

        private void CerrarMenu()
        {
            //panelSubMenuGestion.Visible = false;
            panelSubMenu2.Visible = false;
            panelSubMenu3.Visible = false;
            panelSubMenu4.Visible = false;
            panelSubMenu5.Visible = false;
           // panelSubMenu6.Visible = false;
            btnDownUpMenu.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleDown;
        }

        private void btnDownUpMenu_Click(object sender, EventArgs e)
        {
            if (btnDownUpMenu.IconChar == FontAwesome.Sharp.IconChar.ChevronCircleDown)
            {
                AbrirMenu();
            }
            else if (btnDownUpMenu.IconChar == FontAwesome.Sharp.IconChar.ChevronCircleUp)
            {
                CerrarMenu();
            }
        }

        private void cbSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbSelect.SelectedIndex >= 0)
            {
                btnSetTemperature.Enabled = true;
                txtSetTemp.Enabled = true;
                btnOnOff.Enabled = true;
            }
            if (cbSelect.SelectedIndex == 0)
            {
                led1.Image.Dispose();
                led2.Image.Dispose();
                led1.Image = Properties.Resources.led_on_green;
                led2.Image = Properties.Resources.led_off;
            }
            else if (cbSelect.SelectedIndex == 1)
            {
                led1.Image.Dispose();
                led2.Image.Dispose();
                led2.Image = Properties.Resources.led_on_green;
                led1.Image = Properties.Resources.led_off;
            }
        }
        */

        private void TimerHoraFecha_Tick(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("dddd, MM/dd/yyyy");
            lbHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbFecha.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fecha);
        }

        private void cbCOMSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // if (cbCOMSelect1.SelectedIndex >= 0)
            {
               // btnConnectCOM1.Enabled = true;
            }
        }


        private void GenerarChart12()
        {

            ChartMain.Series.Add("T-1");
            ChartMain.Series.Add("T-2");
            ChartMain.Series.Add("T-3");
            ChartMain.Series.Add("T-4");
            ChartMain.Series.Add("T-5");
            ChartMain.Series.Add("T-6");
            ChartMain.Series.Add("T-7");
            ChartMain.Series.Add("T-8");
            ChartMain.Series.Add("T-9");
            ChartMain.Series.Add("T-10");
            ChartMain.Series.Add("T-11");
            ChartMain.Series.Add("T-12");
           

            ChartMain.Series["T-1"].ChartType = SeriesChartType.Spline;
            ChartMain.Series["T-2"].ChartType = SeriesChartType.Spline;
            ChartMain.Series["T-3"].ChartType = SeriesChartType.Spline;
            ChartMain.Series["T-4"].ChartType = SeriesChartType.Spline;
            ChartMain.Series["T-5"].ChartType = SeriesChartType.Spline;
            ChartMain.Series["T-6"].ChartType = SeriesChartType.Spline;
            ChartMain.Series["T-7"].ChartType = SeriesChartType.Spline;
            ChartMain.Series["T-8"].ChartType = SeriesChartType.Spline;
            ChartMain.Series["T-9"].ChartType = SeriesChartType.Spline;
            ChartMain.Series["T-10"].ChartType = SeriesChartType.Spline;
            ChartMain.Series["T-11"].ChartType = SeriesChartType.Spline;
            ChartMain.Series["T-12"].ChartType = SeriesChartType.Spline;
           

        }

        private void GenerarChart24()
        {
            chart1.Series.Add("T-13");
            chart1.Series.Add("T-14");
            chart1.Series.Add("T-15");
            chart1.Series.Add("T-16");
            chart1.Series.Add("T-17");
            chart1.Series.Add("T-18");
            chart1.Series.Add("T-19");
            chart1.Series.Add("T-20");
            chart1.Series.Add("T-21");
            chart1.Series.Add("T-22");
            chart1.Series.Add("T-23");
            chart1.Series.Add("T-24");

            chart1.Series["T-13"].ChartType = SeriesChartType.Spline;
            chart1.Series["T-14"].ChartType = SeriesChartType.Spline;
            chart1.Series["T-15"].ChartType = SeriesChartType.Spline;
            chart1.Series["T-16"].ChartType = SeriesChartType.Spline;
            chart1.Series["T-17"].ChartType = SeriesChartType.Spline;
            chart1.Series["T-18"].ChartType = SeriesChartType.Spline;
            chart1.Series["T-19"].ChartType = SeriesChartType.Spline;
            chart1.Series["T-20"].ChartType = SeriesChartType.Spline;
            chart1.Series["T-21"].ChartType = SeriesChartType.Spline;
            chart1.Series["T-22"].ChartType = SeriesChartType.Spline;
            chart1.Series["T-23"].ChartType = SeriesChartType.Spline;
            chart1.Series["T-24"].ChartType = SeriesChartType.Spline;
        }



        private bool reconocerCOM(string COM)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    return false;
                }
                // Remember Baud Rate
                serialPort1.PortName = COM;
                serialPort1.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private void btnConnectCOM_Click(object sender, EventArgs e)
        {
           // if (btnConnectCOM1.IconChar == FontAwesome.Sharp.IconChar.ToggleOff)
            {
               // if (reconocerCOM(cbCOMSelect1.SelectedItem.ToString()))
                {
                   // btnConnectCOM1.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
                   // cbCOMSelect1.Enabled = false;
                    //btnRefreshCOM1.Enabled = false;

                    // Se debe elegir Zona para trabajar / la pongo por defecto en todas
                   // cbSelect.Enabled = true;
                   // cbZonesMode.Enabled = true;
                   // cbZonesMode.SelectedIndex = 0;
                    ZonasSelecionadasSendTCSETPOINT = 0;

                   // ledZ1.Image.Dispose();
                   // ledZ1.Image = Properties.Resources.led_on_green;
                    ledZ2.Image.Dispose();
                    ledZ2.Image = Properties.Resources.led_on_green;


                    btnTypeTime.Enabled = true;
                    btnClearChart.Enabled = true;
                    btnStartStopChart.Enabled = true;
                    btnChartMode.Enabled = true;
                    btnRecordDataChart.Enabled = true;


                    //ChartMain.ChartAreas.Clear();

                    btnTypeTime.Visible = false;
                    btnClearChart.Visible = false;
                    btnStartStopChart.Visible = false;
                    btnChartMode.Visible = false;
                    btnRecordDataChart.Visible = false;

                    //picGREEN.Dispose();
                    //picYELLOW.Dispose();
                    //picRED.Dispose();

                    lbRecord.Visible = false;
                    lbCharMode.Visible = false;
                    label32.Visible = false;

                    //SIMULATION...
                    ChartMain.ChartAreas[0].AxisX.Minimum = 0;
                    ChartMain.Series["T-1"].Points.AddXY(0, 20);
                    ChartMain.Series["T-1"].Points.AddXY(1, 21);
                    ChartMain.Series["T-1"].Points.AddXY(2, 23);
                    ChartMain.Series["T-1"].Points.AddXY(3, 23);
                    ChartMain.Series["T-1"].Points.AddXY(4, 21);
                    ChartMain.Series["T-1"].Points.AddXY(5, 24);
                    ChartMain.Series["T-1"].Points.AddXY(6, 20);


                }
            }
           // else if (btnConnectCOM1.IconChar == FontAwesome.Sharp.IconChar.ToggleOn)
            {
               // btnConnectCOM1.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            }
        }
        string TC1S = "";
        string TC2S = "";
        string TC3S = "";
        string TC4S = "";
        string TC5S = "";
        string TC6S = "";
        string TC7S = "";
        string TC8S = "";
        string TC9S = "";
        string TC10S = "";
        string TC11S = "";
        string TC12S = "";
        string TC13S = "";
        string TC14S = "";
        string TC15S = "";
        string TC16S = "";
        string TC17S = "";
        string TC18S = "";
        string TC19S = "";
        string TC20S = "";
        string TC21S = "";
        string TC22S = "";
        string TC23S = "";
        string TC24S = "";
        double TC1Num = 0;
        double TC2Num = 0;
        double TC3Num = 0;
        double TC4Num = 0;
        double TC5Num = 0;
        double TC6Num = 0;
        double TC7Num = 0;
        double TC8Num = 0;
        double TC9Num = 0;
        double TC10Num = 0;
        double TC11Num = 0;
        double TC12Num = 0;
        double TC13Num = 0;
        double TC14Num = 0;
        double TC15Num = 0;
        double TC16Num = 0;
        double TC17Num = 0;
        double TC18Num = 0;
        double TC19Num = 0;
        double TC20Num = 0;
        double TC21Num = 0;
        double TC22Num = 0;
        double TC23Num = 0;
        double TC24Num = 0;

        bool ModoAntiguo = true;

        private void timerForChartTC_Tick(object sender, EventArgs e)
        {
            if (ModoAntiguo)
            {
                ChartModeAutoScrollLosingInfo();
            }
            else
            {
                //ChartModeNewZoomWithLimits();
            }
        }

        private void ChartModeAutoScrollLosingInfo()
        {
            GraficarChart();

            ChartMain.ChartAreas[0].AxisX.Minimum = double.NaN;
            ChartMain.ChartAreas[0].AxisX.Maximum = double.NaN;
            ChartMain.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            ChartMain.ChartAreas[0].CursorX.AutoScroll = true;
            ChartMain.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            ChartMain.ChartAreas[0].RecalculateAxesScale();

            if (ZonasSelecionadasChart == 0)
            {
                if (ChartMain.Series["T-1"].Points.Count >= 100)
                {
                    ChartMain.Series["T-1"].Points.RemoveAt(0); ChartMain.Series["T-2"].Points.RemoveAt(0); ChartMain.Series["T-3"].Points.RemoveAt(0); ChartMain.Series["T-4"].Points.RemoveAt(0); ChartMain.Series["T-5"].Points.RemoveAt(0); ChartMain.Series["T-6"].Points.RemoveAt(0); ChartMain.Series["T-7"].Points.RemoveAt(0); ChartMain.Series["T-8"].Points.RemoveAt(0); ChartMain.Series["T-9"].Points.RemoveAt(0); ChartMain.Series["T-10"].Points.RemoveAt(0); ChartMain.Series["T-11"].Points.RemoveAt(0); ChartMain.Series["T-12"].Points.RemoveAt(0); ChartMain.Series["T-13"].Points.RemoveAt(0); ChartMain.Series["T-14"].Points.RemoveAt(0); ChartMain.Series["T-15"].Points.RemoveAt(0); ChartMain.Series["T-16"].Points.RemoveAt(0); ChartMain.Series["T-17"].Points.RemoveAt(0); ChartMain.Series["T-18"].Points.RemoveAt(0); ChartMain.Series["T-19"].Points.RemoveAt(0); ChartMain.Series["T-20"].Points.RemoveAt(0); ChartMain.Series["T-21"].Points.RemoveAt(0); ChartMain.Series["T-22"].Points.RemoveAt(0); ChartMain.Series["T-23"].Points.RemoveAt(0); ChartMain.Series["T-24"].Points.RemoveAt(0);
                }
            }
            else if (ZonasSelecionadasChart == 1)
            {
                if (ChartMain.Series["T-1"].Points.Count >= 100)
                {
                    ChartMain.Series["T-1"].Points.RemoveAt(0); ChartMain.Series["T-2"].Points.RemoveAt(0); ChartMain.Series["T-3"].Points.RemoveAt(0); ChartMain.Series["T-4"].Points.RemoveAt(0); ChartMain.Series["T-5"].Points.RemoveAt(0); ChartMain.Series["T-6"].Points.RemoveAt(0); ChartMain.Series["T-7"].Points.RemoveAt(0); ChartMain.Series["T-8"].Points.RemoveAt(0); ChartMain.Series["T-9"].Points.RemoveAt(0); ChartMain.Series["T-10"].Points.RemoveAt(0); ChartMain.Series["T-11"].Points.RemoveAt(0); ChartMain.Series["T-12"].Points.RemoveAt(0);
                } 
            }
            else if (ZonasSelecionadasChart == 2)
            {
                if (ChartMain.Series["T-13"].Points.Count >= 100)
                {
                    ChartMain.Series["T-13"].Points.RemoveAt(0); ChartMain.Series["T-14"].Points.RemoveAt(0); ChartMain.Series["T-15"].Points.RemoveAt(0); ChartMain.Series["T-16"].Points.RemoveAt(0); ChartMain.Series["T-17"].Points.RemoveAt(0); ChartMain.Series["T-18"].Points.RemoveAt(0); ChartMain.Series["T-19"].Points.RemoveAt(0); ChartMain.Series["T-20"].Points.RemoveAt(0); ChartMain.Series["T-21"].Points.RemoveAt(0); ChartMain.Series["T-22"].Points.RemoveAt(0); ChartMain.Series["T-23"].Points.RemoveAt(0); ChartMain.Series["T-24"].Points.RemoveAt(0);
                }
            }

        }

        double tiempo = 0;
        //ZonasSeleccionadas 0 = Todas 1 = Zona 1 2 = Zona 2 3 = Zona 3 4 = Zona 4
        int ZonasSelecionadasChart = 0;
        int ZonasSelecionadasTXT = 0;
        int ZonasSelecionadasSendTCSETPOINT = 0;

        private void GraficarChart()
        {
            tiempo = tiempo + 100;

            if (TimeEnSegundosChart)
            {
                double temp = tiempo / 1000;
                if (ZonasSelecionadasChart == 0)
                {
                    ChartMain.Series["TC-1"].Points.AddXY(temp.ToString(), TC1Num.ToString()); ChartMain.Series["TC-2"].Points.AddXY(temp.ToString(), TC2Num.ToString()); ChartMain.Series["TC-3"].Points.AddXY(temp.ToString(), TC3Num.ToString()); ChartMain.Series["TC-4"].Points.AddXY(temp.ToString(), TC4Num.ToString()); ChartMain.Series["TC-5"].Points.AddXY(temp.ToString(), TC5Num.ToString()); ChartMain.Series["TC-6"].Points.AddXY(temp.ToString(), TC6Num.ToString()); ChartMain.Series["TC-7"].Points.AddXY(temp.ToString(), TC7Num.ToString()); ChartMain.Series["TC-8"].Points.AddXY(temp.ToString(), TC8Num.ToString()); ChartMain.Series["TC-9"].Points.AddXY(temp.ToString(), TC9Num.ToString()); ChartMain.Series["TC-10"].Points.AddXY(temp.ToString(), TC10Num.ToString()); ChartMain.Series["TC-11"].Points.AddXY(temp.ToString(), TC11Num.ToString()); ChartMain.Series["TC-12"].Points.AddXY(temp.ToString(), TC12Num.ToString()); ChartMain.Series["TC-13"].Points.AddXY(temp.ToString(), TC13Num.ToString()); ChartMain.Series["TC-14"].Points.AddXY(temp.ToString(), TC14Num.ToString()); ChartMain.Series["TC-15"].Points.AddXY(temp.ToString(), TC15Num.ToString()); ChartMain.Series["TC-16"].Points.AddXY(temp.ToString(), TC16Num.ToString()); ChartMain.Series["TC-17"].Points.AddXY(temp.ToString(), TC17Num.ToString()); ChartMain.Series["TC-18"].Points.AddXY(temp.ToString(), TC18Num.ToString()); ChartMain.Series["TC-19"].Points.AddXY(temp.ToString(), TC19Num.ToString()); ChartMain.Series["TC-20"].Points.AddXY(temp.ToString(), TC20Num.ToString()); ChartMain.Series["TC-21"].Points.AddXY(temp.ToString(), TC21Num.ToString()); ChartMain.Series["TC-22"].Points.AddXY(temp.ToString(), TC22Num.ToString()); ChartMain.Series["TC-23"].Points.AddXY(temp.ToString(), TC23Num.ToString()); ChartMain.Series["TC-24"].Points.AddXY(temp.ToString(), TC24Num.ToString());
                }
                else if (ZonasSelecionadasChart == 1)
                {
                    ChartMain.Series["TC-1"].Points.AddXY(temp.ToString(), TC1Num.ToString()); ChartMain.Series["TC-2"].Points.AddXY(temp.ToString(), TC2Num.ToString()); ChartMain.Series["TC-3"].Points.AddXY(temp.ToString(), TC3Num.ToString()); ChartMain.Series["TC-4"].Points.AddXY(temp.ToString(), TC4Num.ToString()); ChartMain.Series["TC-5"].Points.AddXY(temp.ToString(), TC5Num.ToString()); ChartMain.Series["TC-6"].Points.AddXY(temp.ToString(), TC6Num.ToString()); ChartMain.Series["TC-7"].Points.AddXY(temp.ToString(), TC7Num.ToString()); ChartMain.Series["TC-8"].Points.AddXY(temp.ToString(), TC8Num.ToString()); ChartMain.Series["TC-9"].Points.AddXY(temp.ToString(), TC9Num.ToString()); ChartMain.Series["TC-10"].Points.AddXY(temp.ToString(), TC10Num.ToString()); ChartMain.Series["TC-11"].Points.AddXY(temp.ToString(), TC11Num.ToString()); ChartMain.Series["TC-12"].Points.AddXY(temp.ToString(), TC12Num.ToString());
                }
                else if (ZonasSelecionadasChart == 2)
                {
                    ChartMain.Series["TC-13"].Points.AddXY(temp.ToString(), TC13Num.ToString()); ChartMain.Series["TC-14"].Points.AddXY(temp.ToString(), TC14Num.ToString()); ChartMain.Series["TC-15"].Points.AddXY(temp.ToString(), TC15Num.ToString()); ChartMain.Series["TC-16"].Points.AddXY(temp.ToString(), TC16Num.ToString()); ChartMain.Series["TC-17"].Points.AddXY(temp.ToString(), TC17Num.ToString()); ChartMain.Series["TC-18"].Points.AddXY(temp.ToString(), TC18Num.ToString()); ChartMain.Series["TC-19"].Points.AddXY(temp.ToString(), TC19Num.ToString()); ChartMain.Series["TC-20"].Points.AddXY(temp.ToString(), TC20Num.ToString()); ChartMain.Series["TC-21"].Points.AddXY(temp.ToString(), TC21Num.ToString()); ChartMain.Series["TC-22"].Points.AddXY(temp.ToString(), TC22Num.ToString()); ChartMain.Series["TC-23"].Points.AddXY(temp.ToString(), TC23Num.ToString()); ChartMain.Series["TC-24"].Points.AddXY(temp.ToString(), TC24Num.ToString());
                }
            }
            else
            {
                string HoraMinSeg = DateTime.Now.ToString("hh:mm:ss");
                if (ZonasSelecionadasChart == 0)
                {
                    ChartMain.Series["TC-1"].Points.AddXY(HoraMinSeg.ToString(), TC1Num.ToString()); ChartMain.Series["TC-2"].Points.AddXY(HoraMinSeg.ToString(), TC2Num.ToString()); ChartMain.Series["TC-3"].Points.AddXY(HoraMinSeg.ToString(), TC3Num.ToString()); ChartMain.Series["TC-4"].Points.AddXY(HoraMinSeg.ToString(), TC4Num.ToString()); ChartMain.Series["TC-5"].Points.AddXY(HoraMinSeg.ToString(), TC5Num.ToString()); ChartMain.Series["TC-6"].Points.AddXY(HoraMinSeg.ToString(), TC6Num.ToString()); ChartMain.Series["TC-7"].Points.AddXY(HoraMinSeg.ToString(), TC7Num.ToString()); ChartMain.Series["TC-8"].Points.AddXY(HoraMinSeg.ToString(), TC8Num.ToString()); ChartMain.Series["TC-9"].Points.AddXY(HoraMinSeg.ToString(), TC9Num.ToString()); ChartMain.Series["TC-10"].Points.AddXY(HoraMinSeg.ToString(), TC10Num.ToString()); ChartMain.Series["TC-11"].Points.AddXY(HoraMinSeg.ToString(), TC11Num.ToString()); ChartMain.Series["TC-12"].Points.AddXY(HoraMinSeg.ToString(), TC12Num.ToString()); ChartMain.Series["TC-13"].Points.AddXY(HoraMinSeg.ToString(), TC13Num.ToString()); ChartMain.Series["TC-14"].Points.AddXY(HoraMinSeg.ToString(), TC14Num.ToString()); ChartMain.Series["TC-15"].Points.AddXY(HoraMinSeg.ToString(), TC15Num.ToString()); ChartMain.Series["TC-16"].Points.AddXY(HoraMinSeg.ToString(), TC16Num.ToString()); ChartMain.Series["TC-17"].Points.AddXY(HoraMinSeg.ToString(), TC17Num.ToString()); ChartMain.Series["TC-18"].Points.AddXY(HoraMinSeg.ToString(), TC18Num.ToString()); ChartMain.Series["TC-19"].Points.AddXY(HoraMinSeg.ToString(), TC19Num.ToString()); ChartMain.Series["TC-20"].Points.AddXY(HoraMinSeg.ToString(), TC20Num.ToString()); ChartMain.Series["TC-21"].Points.AddXY(HoraMinSeg.ToString(), TC21Num.ToString()); ChartMain.Series["TC-22"].Points.AddXY(HoraMinSeg.ToString(), TC22Num.ToString()); ChartMain.Series["TC-23"].Points.AddXY(HoraMinSeg.ToString(), TC23Num.ToString()); ChartMain.Series["TC-24"].Points.AddXY(HoraMinSeg.ToString(), TC24Num.ToString());
                }
                else if (ZonasSelecionadasChart == 1)
                {
                    ChartMain.Series["TC-1"].Points.AddXY(HoraMinSeg.ToString(), TC1Num.ToString()); ChartMain.Series["TC-2"].Points.AddXY(HoraMinSeg.ToString(), TC2Num.ToString()); ChartMain.Series["TC-3"].Points.AddXY(HoraMinSeg.ToString(), TC3Num.ToString()); ChartMain.Series["TC-4"].Points.AddXY(HoraMinSeg.ToString(), TC4Num.ToString()); ChartMain.Series["TC-5"].Points.AddXY(HoraMinSeg.ToString(), TC5Num.ToString()); ChartMain.Series["TC-6"].Points.AddXY(HoraMinSeg.ToString(), TC6Num.ToString()); ChartMain.Series["TC-7"].Points.AddXY(HoraMinSeg.ToString(), TC7Num.ToString()); ChartMain.Series["TC-8"].Points.AddXY(HoraMinSeg.ToString(), TC8Num.ToString()); ChartMain.Series["TC-9"].Points.AddXY(HoraMinSeg.ToString(), TC9Num.ToString()); ChartMain.Series["TC-10"].Points.AddXY(HoraMinSeg.ToString(), TC10Num.ToString()); ChartMain.Series["TC-11"].Points.AddXY(HoraMinSeg.ToString(), TC11Num.ToString()); ChartMain.Series["TC-12"].Points.AddXY(HoraMinSeg.ToString(), TC12Num.ToString());
                }
                else if (ZonasSelecionadasChart == 2)
                {
                    ChartMain.Series["TC-13"].Points.AddXY(HoraMinSeg.ToString(), TC13Num.ToString()); ChartMain.Series["TC-14"].Points.AddXY(HoraMinSeg.ToString(), TC14Num.ToString()); ChartMain.Series["TC-15"].Points.AddXY(HoraMinSeg.ToString(), TC15Num.ToString()); ChartMain.Series["TC-16"].Points.AddXY(HoraMinSeg.ToString(), TC16Num.ToString()); ChartMain.Series["TC-17"].Points.AddXY(HoraMinSeg.ToString(), TC17Num.ToString()); ChartMain.Series["TC-18"].Points.AddXY(HoraMinSeg.ToString(), TC18Num.ToString()); ChartMain.Series["TC-19"].Points.AddXY(HoraMinSeg.ToString(), TC19Num.ToString()); ChartMain.Series["TC-20"].Points.AddXY(HoraMinSeg.ToString(), TC20Num.ToString()); ChartMain.Series["TC-21"].Points.AddXY(HoraMinSeg.ToString(), TC21Num.ToString()); ChartMain.Series["TC-22"].Points.AddXY(HoraMinSeg.ToString(), TC22Num.ToString()); ChartMain.Series["TC-23"].Points.AddXY(HoraMinSeg.ToString(), TC23Num.ToString()); ChartMain.Series["TC-24"].Points.AddXY(HoraMinSeg.ToString(), TC24Num.ToString());
                }
            }
        }

        bool TimeEnSegundosChart = true;

        private void btnTypeTime_Click(object sender, EventArgs e)
        {
            if (btnTypeTime.IconChar == FontAwesome.Sharp.IconChar.Stopwatch)
            {
                ModeChartTimeHHmmss();
            }
            else if (btnTypeTime.IconChar == FontAwesome.Sharp.IconChar.Clock)
            {
                ModeChartTimeSS();
            }
        }

        private void ModeChartTimeHHmmss()
        {
            btnTypeTime.IconChar = FontAwesome.Sharp.IconChar.Clock;
            btnTypeTime.IconFont = FontAwesome.Sharp.IconFont.Regular;
            TimeEnSegundosChart = false;
        }
        private void ModeChartTimeSS()
        {
            btnTypeTime.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            btnTypeTime.IconFont = FontAwesome.Sharp.IconFont.Solid;
            TimeEnSegundosChart = true;
        }

        bool Record;
        DateTime star_record = new DateTime();
        DateTime end_record = new DateTime();

        private List<string> TC1A = new List<string>();
        private List<string> TC2A = new List<string>();
        private List<string> TC3A = new List<string>();
        private List<string> TC4A = new List<string>();
        private List<string> TC5A = new List<string>();
        private List<string> TC6A = new List<string>();
        private List<string> TC7A = new List<string>();
        private List<string> TC8A = new List<string>();
        private List<string> TC9A = new List<string>();
        private List<string> TC10A = new List<string>();
        private List<string> TC11A = new List<string>();
        private List<string> TC12A = new List<string>();
        private List<string> TC13A = new List<string>();
        private List<string> TC14A = new List<string>();
        private List<string> TC15A = new List<string>();
        private List<string> TC16A = new List<string>();
        private List<string> TC17A = new List<string>();
        private List<string> TC18A = new List<string>();
        private List<string> TC19A = new List<string>();
        private List<string> TC20A = new List<string>();
        private List<string> TC21A = new List<string>();
        private List<string> TC22A = new List<string>();
        private List<string> TC23A = new List<string>();
        private List<string> TC24A = new List<string>();
        private List<string> DATETIMES = new List<string>();
        private List<string> TIMES = new List<string>();

        private void btnRecordDataChart_Click(object sender, EventArgs e)
        {

        }

        private void btnSetTemperature_Click(object sender, EventArgs e)
        {
            if (ZonasSelecionadasSendTCSETPOINT == 0)
            {
               // txtSetPointZone1.Text = txtSetTemp.Value.ToString();
               // txtSetPointZone2.Text = txtSetTemp.Value.ToString();
            }
            else if (ZonasSelecionadasSendTCSETPOINT == 1)
            {
               // txtSetPointZone1.Text = txtSetTemp.Value.ToString();
            }
            else if (ZonasSelecionadasSendTCSETPOINT == 2)
            {
               // txtSetPointZone2.Text = txtSetTemp.Value.ToString();
            }
            
        }

        private void btnStartStopChart_Click(object sender, EventArgs e)
        {
            if (btnStartStopChart.IconChar == FontAwesome.Sharp.IconChar.ToggleOff)
            {
                EncenderChart();
            }
            else if (btnStartStopChart.IconChar == FontAwesome.Sharp.IconChar.ToggleOn)
            {
                ApagarChartSinBorrar();
            }
        }
        private void ApagarChartSinBorrar()
        {
            timerForChartTC.Stop();
            btnStartStopChart.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
        }

        private void EncenderChart()
        {
            ResetearChart();
            timerForChartTC.Start();
            btnStartStopChart.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
        }

        bool BanderaRespuestaParaTCS = false;
        Boolean i = false;

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (i == false)
                {
                    tiempo = 0;
                    i = true;
                }

                if (BanderaRespuestaParaTCS)
                {
                    try
                    {
                        Thread.Sleep(2000);
                        string DataIn = serialPort1.ReadExisting();
                        if (DataIn != null && DataIn != String.Empty)
                        {
                            ReadData(DataIn);
                            serialPort1.DiscardInBuffer();
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
        private void ReadData(string data)
        {
            if (data != null && data != string.Empty)
            {
                // Paso 1 Quitar cualquier espacio
                string tcs = data.Trim();
                if (tcs.Length == 71)
                {
                    tcs = tcs.Replace("\r", string.Empty);
                    //Paso 2 quitar el >+ inicial
                    tcs = tcs.Substring(2);
                    //Paso 3 separar por +
                    string[] TC = tcs.Split('+');

                    //Paso 4 asignar cada TC
                    if (TC.Length == 10)
                    {
                        TC1S = TC[0];
                        TC2S = TC[1];
                        TC3S = TC[2];
                        TC4S = TC[3];
                        TC5S = TC[4];
                        TC6S = TC[5];
                        TC7S = TC[6];
                        TC8S = TC[7];
                        TC9S = TC[8];
                        TC10S = TC[9];
                    }

                    // Paso 5 reasignar valores

                    TC1S = TC1S.Substring(2);
                    TC2S = TC2S.Substring(2);
                    TC3S = TC3S.Substring(2);
                    TC4S = TC4S.Substring(2);
                    TC5S = TC5S.Substring(2);
                    TC6S = TC6S.Substring(2);
                    TC7S = TC7S.Substring(2);
                    TC8S = TC8S.Substring(2);
                    TC9S = TC9S.Substring(2);
                    TC10S = TC10S.Substring(2);

                    // Paso 6 Separar a las con numeros a las con C°

                    TC1Num = Convert.ToDouble(TC1S);
                    TC2Num = Convert.ToDouble(TC2S);
                    TC3Num = Convert.ToDouble(TC3S);
                    TC4Num = Convert.ToDouble(TC4S);
                    TC5Num = Convert.ToDouble(TC5S);
                    TC6Num = Convert.ToDouble(TC6S);
                    TC7Num = Convert.ToDouble(TC7S);
                    TC8Num = Convert.ToDouble(TC8S);
                    TC9Num = Convert.ToDouble(TC9S);
                    TC10Num = Convert.ToDouble(TC10S);

                    // Paso Final
                    TC1S = TC1S + " C°";
                    TC2S = TC2S + " C°";
                    TC3S = TC3S + " C°";
                    TC4S = TC4S + " C°";
                    TC5S = TC5S + " C°";
                    TC6S = TC6S + " C°";
                    TC7S = TC7S + " C°";
                    TC8S = TC8S + " C°";
                    TC9S = TC9S + " C°";
                    TC10S = TC10S + " C°";

                    //TODO GRAFICAR.
                    GraficarDatosTxt();
                }
            }
        }

        private void GraficarDatosTxt()
        {

            if (ZonasSelecionadasTXT == 1)
            {
               // txtTCView1.Text = TC1S; txtTCView2.Text = TC2S; txtTCView3.Text = TC3S; txtTCView4.Text = TC4S; txtTCView5.Text = TC5S; txtTCView6.Text = TC6S; txtTCView7.Text = TC7S; txtTCView8.Text = TC8S; txtTCView9.Text = TC9S; txtTCView10.Text = TC10S; txtTCView11.Text = TC11S; txtTCView12.Text = TC12S; txtTCView13.Text = TC13S; txtTCView14.Text = TC14S; txtTCView15.Text = TC15S; txtTCView16.Text = TC16S; txtTCView17.Text = TC17S; txtTCView18.Text = TC18S; txtTCView19.Text = TC19S; txtTCView20.Text = TC20S; txtTCView21.Text = TC21S; txtTCView22.Text = TC22S; txtTCView23.Text = TC23S; txtTCView24.Text = TC24S;
            }
        }

        private void btnClearChart_Click(object sender, EventArgs e)
        {
            ApagarChart();
        }
        private void ApagarChart()
        {
            ResetearChart();
            timerForChartTC.Stop();
            btnStartStopChart.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
        }

        private void ResetearChart()
        {
            if (ZonasSelecionadasChart == 0)
            {
                ChartMain.Series["TC-1"].Points.Clear(); ChartMain.Series["TC-2"].Points.Clear(); ChartMain.Series["TC-3"].Points.Clear(); ChartMain.Series["TC-4"].Points.Clear(); ChartMain.Series["TC-5"].Points.Clear(); ChartMain.Series["TC-6"].Points.Clear(); ChartMain.Series["TC-7"].Points.Clear(); ChartMain.Series["TC-8"].Points.Clear(); ChartMain.Series["TC-9"].Points.Clear(); ChartMain.Series["TC-10"].Points.Clear(); ChartMain.Series["TC-11"].Points.Clear(); ChartMain.Series["TC-12"].Points.Clear(); ChartMain.Series["TC-13"].Points.Clear(); ChartMain.Series["TC-14"].Points.Clear(); ChartMain.Series["TC-15"].Points.Clear(); ChartMain.Series["TC-16"].Points.Clear(); ChartMain.Series["TC-17"].Points.Clear(); ChartMain.Series["TC-18"].Points.Clear(); ChartMain.Series["TC-19"].Points.Clear(); ChartMain.Series["TC-20"].Points.Clear(); ChartMain.Series["TC-21"].Points.Clear(); ChartMain.Series["TC-22"].Points.Clear(); ChartMain.Series["TC-23"].Points.Clear(); ChartMain.Series["TC-24"].Points.Clear();
            }

            ChartArea CA = ChartMain.ChartAreas[0];
            CA.CursorX.AutoScroll = true;
            i = false;
            tiempo = 0;
        }

        private void btnChartMode_Click(object sender, EventArgs e)
        {

        }

        private void timerRequestData_Tick(object sender, EventArgs e)
        {

        }

        /*
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (btnOnOff.Text.Trim() == "Turn On")
            {
                btnOnOff.Text = "         Turn Off";
                btnReportes.Text = "Status: " + "ON";
                btnOnOff.IconColor = Color.White;
            }
            else if (btnOnOff.Text.Trim() == "Turn Off")
            {
                btnOnOff.Text = "         Turn On";
                btnReportes.Text = "Status: OFF";
                btnOnOff.IconColor = Color.White;
            }
        }
        */



        private void btnEMO_Click(object sender, EventArgs e)
        {
            ResetAllDefault();
            //Thread t = new Thread(new ThreadStart(CiclosEnOtroHilo));
            //t.Start();
        }

        /*
        private void cbZonesMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbZonesMode.SelectedIndex == 0)
            {
               // ledZ1.Image.Dispose();
               // ledZ2.Image.Dispose();
               // ledZ1.Image = Properties.Resources.led_on_green;
               // ledZ2.Image = Properties.Resources.led_on_green;
                ZonasSelecionadasSendTCSETPOINT = 0;

            }
            else if (cbZonesMode.SelectedIndex == 1)
            {
              //  ledZ1.Image.Dispose();
                ledZ2.Image.Dispose();
               // ledZ1.Image = Properties.Resources.led_on_green;
                ledZ2.Image = Properties.Resources.led_off;
                ZonasSelecionadasSendTCSETPOINT = 1;

            }
            else if (cbZonesMode.SelectedIndex == 2)
            {
              //  ledZ1.Image.Dispose();
                ledZ2.Image.Dispose();
                //ledZ1.Image = Properties.Resources.led_off;
                ledZ2.Image = Properties.Resources.led_on_green;
                ZonasSelecionadasSendTCSETPOINT = 2;

            }
        }
        */

        private void btnRefreshCOM_Click(object sender, EventArgs e)
        {
           // cbSelect.SelectedIndex = -1;
           // btnConnectCOM1.Enabled = false;
           // cbCOMSelect1.Enabled = true;
            string[] ports = SerialPort.GetPortNames();
           // cbCOMSelect1.Items.Clear();
           // cbCOMSelect1.Items.AddRange(ports);
        }

        private void lbCharMode_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void lbRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnCSVFileFilter_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmFilterCSVFile);

            if (frm == null)
            {
                FrmFilterCSVFile nt = new FrmFilterCSVFile();

                nt.Show();
            }
            else
            {
                frm.BringToFront();
                return;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lbZone1_Click(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void zone2label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void zone2label3_Click(object sender, EventArgs e)
        {

        }

        private void zone2label6_Click(object sender, EventArgs e)
        {

        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPanel[0].BringToFront();

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

       

        private void manualControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPanel[1].BringToFront();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            listPanel[2].BringToFront();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listPanel[3].BringToFront();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelZone1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtTC12_TextChanged(object sender, EventArgs e)
        {

        }

        private void led1_Click(object sender, EventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmConnect);

            if (frm == null)
            {
                FrmConnect nt = new FrmConnect();
                nt.Show();
            }
            else
            {
                frm.BringToFront();
                return;
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmFilterCSVFile);

            if (frm == null)
            {
                FrmFilterCSVFile nt = new FrmFilterCSVFile();

                nt.Show();
            }
            else
            {
                frm.BringToFront();
                return;
            }

        }

        private void textBox46_TextChanged(object sender, EventArgs e) { }

        private void textBox46_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
                
            

         
        }

        private void textBox49_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void ChartMain_Click(object sender, EventArgs e)
        {

        }

        private void lbTCView7_Click(object sender, EventArgs e)
        {

        }
    }
}
