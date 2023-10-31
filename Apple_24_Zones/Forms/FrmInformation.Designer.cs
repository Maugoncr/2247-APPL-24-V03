namespace Apple_24_Zones.Forms
{
    partial class FrmInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformation));
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCountHeat1 = new System.Windows.Forms.Label();
            this.lbCountCool1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.IconClose = new FontAwesome.Sharp.IconButton();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveNotes = new FontAwesome.Sharp.IconButton();
            this.btnDeleteNotes = new FontAwesome.Sharp.IconButton();
            this.lbCountCool2 = new System.Windows.Forms.Label();
            this.lbCountHeat2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(13, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Heating cycle counter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cooling cycle counter:";
            // 
            // lbCountHeat1
            // 
            this.lbCountHeat1.AutoSize = true;
            this.lbCountHeat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCountHeat1.ForeColor = System.Drawing.Color.White;
            this.lbCountHeat1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCountHeat1.Location = new System.Drawing.Point(170, 53);
            this.lbCountHeat1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountHeat1.Name = "lbCountHeat1";
            this.lbCountHeat1.Size = new System.Drawing.Size(15, 16);
            this.lbCountHeat1.TabIndex = 29;
            this.lbCountHeat1.Text = "0";
            // 
            // lbCountCool1
            // 
            this.lbCountCool1.AutoSize = true;
            this.lbCountCool1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCountCool1.ForeColor = System.Drawing.Color.White;
            this.lbCountCool1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCountCool1.Location = new System.Drawing.Point(170, 78);
            this.lbCountCool1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountCool1.Name = "lbCountCool1";
            this.lbCountCool1.Size = new System.Drawing.Size(15, 16);
            this.lbCountCool1.TabIndex = 30;
            this.lbCountCool1.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IconClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 36);
            this.panel1.TabIndex = 31;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 232;
            this.label3.Text = "ELEN II SOFTWARE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.IconClose.Location = new System.Drawing.Point(752, 0);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(35, 36);
            this.IconClose.TabIndex = 41;
            this.IconClose.UseVisualStyleBackColor = true;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 175);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(763, 346);
            this.txtNotes.TabIndex = 32;
            this.txtNotes.Text = "";
            this.txtNotes.Enter += new System.EventHandler(this.txtNotes_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(37, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "NOTES";
            // 
            // btnSaveNotes
            // 
            this.btnSaveNotes.BackColor = System.Drawing.Color.Gray;
            this.btnSaveNotes.FlatAppearance.BorderSize = 0;
            this.btnSaveNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNotes.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSaveNotes.IconColor = System.Drawing.Color.White;
            this.btnSaveNotes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveNotes.IconSize = 30;
            this.btnSaveNotes.Location = new System.Drawing.Point(740, 527);
            this.btnSaveNotes.Name = "btnSaveNotes";
            this.btnSaveNotes.Size = new System.Drawing.Size(35, 36);
            this.btnSaveNotes.TabIndex = 42;
            this.btnSaveNotes.UseVisualStyleBackColor = false;
            this.btnSaveNotes.Click += new System.EventHandler(this.btnSaveNotes_Click);
            // 
            // btnDeleteNotes
            // 
            this.btnDeleteNotes.BackColor = System.Drawing.Color.Gray;
            this.btnDeleteNotes.FlatAppearance.BorderSize = 0;
            this.btnDeleteNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNotes.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDeleteNotes.IconColor = System.Drawing.Color.White;
            this.btnDeleteNotes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteNotes.IconSize = 25;
            this.btnDeleteNotes.Location = new System.Drawing.Point(12, 527);
            this.btnDeleteNotes.Name = "btnDeleteNotes";
            this.btnDeleteNotes.Size = new System.Drawing.Size(35, 36);
            this.btnDeleteNotes.TabIndex = 43;
            this.btnDeleteNotes.UseVisualStyleBackColor = false;
            this.btnDeleteNotes.Click += new System.EventHandler(this.btnDeleteNotes_Click);
            // 
            // lbCountCool2
            // 
            this.lbCountCool2.AutoSize = true;
            this.lbCountCool2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCountCool2.ForeColor = System.Drawing.Color.White;
            this.lbCountCool2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCountCool2.Location = new System.Drawing.Point(374, 78);
            this.lbCountCool2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountCool2.Name = "lbCountCool2";
            this.lbCountCool2.Size = new System.Drawing.Size(15, 16);
            this.lbCountCool2.TabIndex = 51;
            this.lbCountCool2.Text = "0";
            // 
            // lbCountHeat2
            // 
            this.lbCountHeat2.AutoSize = true;
            this.lbCountHeat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCountHeat2.ForeColor = System.Drawing.Color.White;
            this.lbCountHeat2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCountHeat2.Location = new System.Drawing.Point(374, 53);
            this.lbCountHeat2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountHeat2.Name = "lbCountHeat2";
            this.lbCountHeat2.Size = new System.Drawing.Size(15, 16);
            this.lbCountHeat2.TabIndex = 50;
            this.lbCountHeat2.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(217, 78);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Cooling cycle counter:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(217, 53);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 16);
            this.label12.TabIndex = 48;
            this.label12.Text = "Heating cycle counter:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(217, 36);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 16);
            this.label13.TabIndex = 52;
            this.label13.Text = "Zone 2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(13, 39);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 16);
            this.label14.TabIndex = 53;
            this.label14.Text = "Zone 1";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(787, 582);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbCountCool2);
            this.Controls.Add(this.lbCountHeat2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDeleteNotes);
            this.Controls.Add(this.btnSaveNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbCountCool1);
            this.Controls.Add(this.lbCountHeat1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInformation";
            this.Load += new System.EventHandler(this.FrmInformation_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCountHeat1;
        private System.Windows.Forms.Label lbCountCool1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IconClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnSaveNotes;
        private FontAwesome.Sharp.IconButton btnDeleteNotes;
        private System.Windows.Forms.Label lbCountCool2;
        private System.Windows.Forms.Label lbCountHeat2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}