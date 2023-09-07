namespace Apple_24_Zones.Forms
{
    partial class FrmPID
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
            this.panelConexion = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseConexionPanel = new FontAwesome.Sharp.IconButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.panelConexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConexion
            // 
            this.panelConexion.BackColor = System.Drawing.Color.SteelBlue;
            this.panelConexion.Controls.Add(this.numericUpDown3);
            this.panelConexion.Controls.Add(this.numericUpDown1);
            this.panelConexion.Controls.Add(this.numericUpDown2);
            this.panelConexion.Controls.Add(this.label3);
            this.panelConexion.Controls.Add(this.label2);
            this.panelConexion.Controls.Add(this.label1);
            this.panelConexion.Controls.Add(this.btnCloseConexionPanel);
            this.panelConexion.Controls.Add(this.label32);
            this.panelConexion.Location = new System.Drawing.Point(142, 49);
            this.panelConexion.Name = "panelConexion";
            this.panelConexion.Size = new System.Drawing.Size(518, 263);
            this.panelConexion.TabIndex = 276;
            this.panelConexion.Visible = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(3, 14);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(111, 20);
            this.label32.TabIndex = 1;
            this.label32.Text = "PID Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 291;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 29);
            this.label2.TabIndex = 292;
            this.label2.Text = "I";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 29);
            this.label3.TabIndex = 293;
            this.label3.Text = "D";
            // 
            // btnCloseConexionPanel
            // 
            this.btnCloseConexionPanel.FlatAppearance.BorderSize = 0;
            this.btnCloseConexionPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseConexionPanel.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnCloseConexionPanel.IconColor = System.Drawing.Color.White;
            this.btnCloseConexionPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseConexionPanel.IconSize = 30;
            this.btnCloseConexionPanel.Location = new System.Drawing.Point(483, 3);
            this.btnCloseConexionPanel.Name = "btnCloseConexionPanel";
            this.btnCloseConexionPanel.Size = new System.Drawing.Size(35, 31);
            this.btnCloseConexionPanel.TabIndex = 290;
            this.btnCloseConexionPanel.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.White;
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.DimGray;
            this.numericUpDown2.Location = new System.Drawing.Point(122, 116);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(239, 31);
            this.numericUpDown2.TabIndex = 294;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.DimGray;
            this.numericUpDown1.Location = new System.Drawing.Point(122, 74);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(239, 31);
            this.numericUpDown1.TabIndex = 295;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.White;
            this.numericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.ForeColor = System.Drawing.Color.DimGray;
            this.numericUpDown3.Location = new System.Drawing.Point(122, 161);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(239, 31);
            this.numericUpDown3.TabIndex = 296;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmPID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelConexion);
            this.Name = "FrmPID";
            this.Text = " ";
            this.panelConexion.ResumeLayout(false);
            this.panelConexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConexion;
        private FontAwesome.Sharp.IconButton btnCloseConexionPanel;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}