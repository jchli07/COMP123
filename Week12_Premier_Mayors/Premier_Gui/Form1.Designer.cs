namespace Premier_Gui
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.picPremier = new System.Windows.Forms.PictureBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblOffice = new System.Windows.Forms.Label();
            this.lstPremier = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPremier)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // picPremier
            // 
            this.picPremier.Location = new System.Drawing.Point(15, 25);
            this.picPremier.Name = "picPremier";
            this.picPremier.Size = new System.Drawing.Size(100, 118);
            this.picPremier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPremier.TabIndex = 1;
            this.picPremier.TabStop = false;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(19, 194);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(35, 13);
            this.lblBirth.TabIndex = 2;
            this.lblBirth.Text = "label2";
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Location = new System.Drawing.Point(19, 207);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(35, 13);
            this.lblOffice.TabIndex = 3;
            this.lblOffice.Text = "label3";
            // 
            // lstPremier
            // 
            this.lstPremier.FormattingEnabled = true;
            this.lstPremier.Location = new System.Drawing.Point(296, 12);
            this.lstPremier.Name = "lstPremier";
            this.lstPremier.Size = new System.Drawing.Size(120, 238);
            this.lstPremier.TabIndex = 4;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 262);
            this.Controls.Add(this.lstPremier);
            this.Controls.Add(this.lblOffice);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.picPremier);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPremier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picPremier;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.ListBox lstPremier;
    }
}

