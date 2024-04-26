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
    public partial class FrmYScalesZone1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FrmYScalesZone1()
        {
            InitializeComponent();
        }

        private void txtYUpperZ1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only numbers are allowed to be entered", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtYLowerZ1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSaveYUZ1_Click(object sender, EventArgs e)
        {
            int validation = Convert.ToInt32(txtYUpperZ1.Text);

            if (validation <= 100 && validation >= 0)
            {
                Settings.Default.YZone1Upper = validation;
                Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Warning: The scale range for the Y-axis is within 0 - 100.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveYLZ1_Click(object sender, EventArgs e)
        {
            int validation = Convert.ToInt32(txtYLowerZ1.Text);

            if (validation <= 100 && validation >= 0)
            {
                Settings.Default.YZone1Lower = validation;
                Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Warning: The scale range for the Y-axis is within 0 - 100.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmYScalesZone1_Load(object sender, EventArgs e)
        {
            txtYUpperZ1.Text = Settings.Default.YZone1Upper.ToString();
            txtYLowerZ1.Text = Settings.Default.YZone1Lower.ToString();
        }
    }
}
