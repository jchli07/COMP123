namespace PremierDemo
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
            this.picPremier = new System.Windows.Forms.PictureBox();
            this.lstPremier = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPremier)).BeginInit();
            this.SuspendLayout();
            // 
            // picPremier
            // 
            this.picPremier.Location = new System.Drawing.Point(12, 37);
            this.picPremier.Name = "picPremier";
            this.picPremier.Size = new System.Drawing.Size(159, 189);
            this.picPremier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPremier.TabIndex = 0;
            this.picPremier.TabStop = false;
            // 
            // lstPremier
            // 
            this.lstPremier.FormattingEnabled = true;
            this.lstPremier.Location = new System.Drawing.Point(217, 13);
            this.lstPremier.Name = "lstPremier";
            this.lstPremier.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPremier.Size = new System.Drawing.Size(120, 316);
            this.lstPremier.TabIndex = 1;
            this.lstPremier.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label1";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(12, 268);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(35, 13);
            this.lblBirth.TabIndex = 3;
            this.lblBirth.Text = "label2";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(12, 285);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(35, 13);
            this.lblRange.TabIndex = 4;
            this.lblRange.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 361);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstPremier);
            this.Controls.Add(this.picPremier);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPremier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPremier;
        private System.Windows.Forms.ListBox lstPremier;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblRange;
    }
}

