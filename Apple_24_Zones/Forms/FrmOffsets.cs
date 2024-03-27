using Apple_24_Zones.Properties;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Apple_24_Zones.Forms
{
    public partial class FrmOffsets : Form
    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FrmOffsets()
        {
            InitializeComponent();
        }

        private string Offset = "MIDRCRMGM";
        private string entrada = "";
        private int indice = 0;

        private void FrmOffsets_Load(object sender, EventArgs e)
        {
            txt1.Text = Settings.Default.Offset0_5.ToString();
            txt2.Text = Settings.Default.Offset5_10.ToString();
            txt3.Text = Settings.Default.Offset10_15.ToString();
            txt4.Text = Settings.Default.Offset15_20.ToString();
            txt5.Text = Settings.Default.Offset20_25.ToString();
            txt6.Text = Settings.Default.Offset25_30.ToString();
            txt7.Text = Settings.Default.Offset30_35.ToString();
            txt8.Text = Settings.Default.Offset35_40.ToString();
            txt9.Text = Settings.Default.Offset40_45.ToString();
            txt10.Text = Settings.Default.Offset45_50.ToString();
            txt11.Text = Settings.Default.Offset50_55.ToString();
            txt12.Text = Settings.Default.Offset55_60.ToString();
            txt13.Text = Settings.Default.Offset60_65.ToString();
            txt14.Text = Settings.Default.Offset65_70.ToString();
            txt15.Text = Settings.Default.Offset70_75.ToString();
            txt16.Text = Settings.Default.Offset75_80.ToString();
            txt17.Text = Settings.Default.Offset80_85.ToString();
            txt18.Text = Settings.Default.Offset85_90.ToString();
            txt19.Text = Settings.Default.Offset90_95.ToString();
            txt20.Text = Settings.Default.Offset95_100.ToString();
            txt21.Text = Settings.Default.Offset100_105.ToString();
            txt22.Text = Settings.Default.Offset105_110.ToString();
            txt23.Text = Settings.Default.Offset110_115.ToString();
            txt24.Text = Settings.Default.Offset115_120.ToString();
            txt25.Text = Settings.Default.Offset120_125.ToString();
            txt26.Text = Settings.Default.Offset125_130.ToString();
            txt27.Text = Settings.Default.Offset130_135.ToString();
            txt28.Text = Settings.Default.Offset135_140.ToString();

            txt_1.Text = Settings.Default.Off2set0_5.ToString();
            txt_2.Text = Settings.Default.Off2set5_10.ToString();
            txt_3.Text = Settings.Default.Off2set10_15.ToString();
            txt_4.Text = Settings.Default.Off2set15_20.ToString();
            txt_5.Text = Settings.Default.Off2set20_25.ToString();
            txt_6.Text = Settings.Default.Off2set25_30.ToString();
            txt_7.Text = Settings.Default.Off2set30_35.ToString();
            txt_8.Text = Settings.Default.Off2set35_40.ToString();
            txt_9.Text = Settings.Default.Off2set40_45.ToString();
            txt_10.Text = Settings.Default.Off2set45_50.ToString();
            txt_11.Text = Settings.Default.Off2set50_55.ToString();
            txt_12.Text = Settings.Default.Off2set55_60.ToString();
            txt_13.Text = Settings.Default.Off2set60_65.ToString();
            txt_14.Text = Settings.Default.Off2set65_70.ToString();
            txt_15.Text = Settings.Default.Off2set70_75.ToString();
            txt_16.Text = Settings.Default.Off2set75_80.ToString();
            txt_17.Text = Settings.Default.Off2set80_85.ToString();
            txt_18.Text = Settings.Default.Off2set85_90.ToString();
            txt_19.Text = Settings.Default.Off2set90_95.ToString();
            txt_20.Text = Settings.Default.Off2set95_100.ToString();
            txt_21.Text = Settings.Default.Off2set100_105.ToString();
            txt_22.Text = Settings.Default.Off2set105_110.ToString();
            txt_23.Text = Settings.Default.Off2set110_115.ToString();
            txt_24.Text = Settings.Default.Off2set115_120.ToString();
            txt_25.Text = Settings.Default.Off2set120_125.ToString();
            txt_26.Text = Settings.Default.Off2set125_130.ToString();
            txt_27.Text = Settings.Default.Off2set130_135.ToString();
            txt_28.Text = Settings.Default.Off2set135_140.ToString();

         
        }

        private void IconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset0_5 = Convert.ToDouble(txt1.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset5_10 = Convert.ToDouble(txt2.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset10_15 = Convert.ToDouble(txt3.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset15_20 = Convert.ToDouble(txt4.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset20_25 = Convert.ToDouble(txt5.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset25_30 = Convert.ToDouble(txt6.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset30_35 = Convert.ToDouble(txt7.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset35_40 = Convert.ToDouble(txt8.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset40_45 = Convert.ToDouble(txt9.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset45_50 = Convert.ToDouble(txt10.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset50_55 = Convert.ToDouble(txt11.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset55_60 = Convert.ToDouble(txt12.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset60_65 = Convert.ToDouble(txt13.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset65_70 = Convert.ToDouble(txt14.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset70_75 = Convert.ToDouble(txt15.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset75_80 = Convert.ToDouble(txt16.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset80_85 = Convert.ToDouble(txt17.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset85_90 = Convert.ToDouble(txt18.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset90_95 = Convert.ToDouble(txt19.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset95_100 = Convert.ToDouble(txt20.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset100_105 = Convert.ToDouble(txt21.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset105_110 = Convert.ToDouble(txt22.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset110_115 = Convert.ToDouble(txt23.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset115_120 = Convert.ToDouble(txt24.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset120_125 = Convert.ToDouble(txt25.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset125_130 = Convert.ToDouble(txt26.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset130_135 = Convert.ToDouble(txt27.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Offset135_140 = Convert.ToDouble(txt28.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set0_5 = Convert.ToDouble(txt_1.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set5_10 = Convert.ToDouble(txt_2.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set10_15 = Convert.ToDouble(txt_3.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set15_20 = Convert.ToDouble(txt_4.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set20_25 = Convert.ToDouble(txt_5.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set25_30 = Convert.ToDouble(txt_6.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set30_35 = Convert.ToDouble(txt_7.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set35_40 = Convert.ToDouble(txt_8.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set40_45 = Convert.ToDouble(txt_9.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set45_50 = Convert.ToDouble(txt_10.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set50_55 = Convert.ToDouble(txt_11.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set55_60 = Convert.ToDouble(txt_12.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set60_65 = Convert.ToDouble(txt_13.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_14_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set65_70 = Convert.ToDouble(txt_14.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_15_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set70_75 = Convert.ToDouble(txt_15.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_16_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set75_80 = Convert.ToDouble(txt_16.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_17_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set80_85 = Convert.ToDouble(txt_17.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_18_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set85_90 = Convert.ToDouble(txt_18.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_19_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set90_95 = Convert.ToDouble(txt_19.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set95_100 = Convert.ToDouble(txt_20.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set100_105 = Convert.ToDouble(txt_21.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set105_110 = Convert.ToDouble(txt_22.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_23_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set110_115 = Convert.ToDouble(txt_23.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_24_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set115_120 = Convert.ToDouble(txt_24.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_25_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set120_125 = Convert.ToDouble(txt_25.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_26_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set125_130 = Convert.ToDouble(txt_26.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_27_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set130_135 = Convert.ToDouble(txt_27.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_28_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.Off2set135_140 = Convert.ToDouble(txt_28.Text);
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void FrmOffsets_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                if (e.KeyChar == Offset[indice])
                {
                    entrada += e.KeyChar;
                    indice++;
                    if (indice == Offset.Length)
                    {
                        btnLock.Visible = true;
                        entrada = "";
                        indice = 0;
                    }
                }
                else
                {
                    entrada = "";
                    indice = 0;
                }
            }
        }

       

        private void btnLock_Click(object sender, EventArgs e)
        {
            pSecurity.Visible = false;
            txtTimesLogCreated.Text = Settings.Default.LogCreateTimes.ToString();

            string logFilePath = Path.Combine(Application.StartupPath, "log.txt");
            string logEntry = $"{DateTime.Now.ToString("MM/dd/yyyy HH:mm")}: Restricted form entry\r\n";

            try
            {
                // Verificar si el archivo existe
                if (!File.Exists(logFilePath))
                {
                    // Si no existe, crear el archivo y guardar la información
                    Settings.Default.LogCreateTimes++;
                    Settings.Default.Save();
                    File.WriteAllText(logFilePath, logEntry);
                }
                else
                {
                    // Si ya existe, agregar la información al archivo
                    File.AppendAllText(logFilePath, logEntry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
