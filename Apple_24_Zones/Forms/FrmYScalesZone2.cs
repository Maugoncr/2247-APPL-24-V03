using Apple_24_Zones.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apple_24_Zones.Forms
{
    public partial class FrmYScalesZone2 : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FrmYScalesZone2()
        {
            InitializeComponent();
        }

        private void txtYUpperZ2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only numbers are allowed to be entered", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtYLowerZ2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only numbers are allowed to be entered", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void IconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveYUZ2_Click(object sender, EventArgs e)
        {
            int validation = Convert.ToInt32(txtYUpperZ2.Text);

            if (validation <= 100 && validation >= 0)
            {
                Settings.Default.YZone2Upper = validation;
                Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Warning: The scale range for the Y-axis is within 0 - 100.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveYLZ2_Click(object sender, EventArgs e)
        {
            int validation = Convert.ToInt32(txtYLowerZ2.Text);

            if (validation <= 100 && validation >= 0)
            {
                Settings.Default.YZone2Lower = validation;
                Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Warning: The scale range for the Y-axis is within 0 - 100.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmYScalesZone2_Load(object sender, EventArgs e)
        {
            txtYUpperZ2.Text = Settings.Default.YZone2Upper.ToString();
            txtYLowerZ2.Text = Settings.Default.YZone2Lower.ToString();
        }
    }
}
