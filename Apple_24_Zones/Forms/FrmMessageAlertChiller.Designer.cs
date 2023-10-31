namespace Apple_24_Zones.Forms
{
    partial class FrmMessageAlertChiller
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMessageAlertChiller));
            this.panelTitleZone2 = new System.Windows.Forms.Panel();
            this.lbTitleZone2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelTitleZone2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleZone2
            // 
            this.panelTitleZone2.BackColor = System.Drawing.Color.Gold;
            this.panelTitleZone2.Controls.Add(this.lbTitleZone2);
            this.panelTitleZone2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleZone2.Location = new System.Drawing.Point(0, 0);
            this.panelTitleZone2.Name = "panelTitleZone2";
            this.panelTitleZone2.Size = new System.Drawing.Size(601, 45);
            this.panelTitleZone2.TabIndex = 312;
            // 
            // lbTitleZone2
            // 
            this.lbTitleZone2.BackColor = System.Drawing.Color.Transparent;
            this.lbTitleZone2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleZone2.ForeColor = System.Drawing.Color.Black;
            this.lbTitleZone2.Location = new System.Drawing.Point(12, 6);
            this.lbTitleZone2.Name = "lbTitleZone2";
            this.lbTitleZone2.Size = new System.Drawing.Size(577, 33);
            this.lbTitleZone2.TabIndex = 309;
            this.lbTitleZone2.Text = "CONFIRMATION";
            this.lbTitleZone2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitleZone2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitleZone2_MouseDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 20);
            this.label1.TabIndex = 314;
            this.label1.Text = "This function utilizes the chiller";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Apple_24_Zones.Properties.Resources.Alert1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 313;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 20);
            this.label2.TabIndex = 316;
            this.label2.Text = "Please manually inspect the chiller display";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(533, 20);
            this.label4.TabIndex = 318;
            this.label4.Text = "Remove any error mesages before proceeding.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Apple_24_Zones.Properties.Resources.Alert1;
            this.pictureBox2.Location = new System.Drawing.Point(500, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 319;
            this.pictureBox2.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Gold;
            this.iconButton1.FlatAppearance.BorderSize = 2;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(249, 127);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(102, 37);
            this.iconButton1.TabIndex = 320;
            this.iconButton1.Text = "Proceed";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FrmMessageAlertChiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 173);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitleZone2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMessageAlertChiller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation";
            this.panelTitleZone2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleZone2;
        private System.Windows.Forms.Label lbTitleZone2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}