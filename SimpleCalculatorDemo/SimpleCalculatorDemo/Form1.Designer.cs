namespace SimpleCalculatorDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Label();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.txtsecond = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtndivide = new System.Windows.Forms.RadioButton();
            this.rbtnminus = new System.Windows.Forms.RadioButton();
            this.rbtnmultiply = new System.Windows.Forms.RadioButton();
            this.rbtnplus = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(193, 50);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(13, 13);
            this.equal.TabIndex = 3;
            this.equal.Text = "=";
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(16, 50);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(40, 20);
            this.txtfirst.TabIndex = 4;
            this.txtfirst.Text = "15";
            // 
            // txtsecond
            // 
            this.txtsecond.Location = new System.Drawing.Point(78, 50);
            this.txtsecond.Name = "txtsecond";
            this.txtsecond.Size = new System.Drawing.Size(41, 20);
            this.txtsecond.TabIndex = 5;
            this.txtsecond.Text = "7";
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(224, 50);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(34, 20);
            this.txtresult.TabIndex = 6;
            this.txtresult.Text = "N/A";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(10, 179);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(262, 71);
            this.btncalculate.TabIndex = 7;
            this.btncalculate.Text = "Perform Operation";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtndivide);
            this.groupBox1.Controls.Add(this.rbtnminus);
            this.groupBox1.Controls.Add(this.rbtnmultiply);
            this.groupBox1.Controls.Add(this.rbtnplus);
            this.groupBox1.Location = new System.Drawing.Point(135, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(48, 116);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // rbtndivide
            // 
            this.rbtndivide.AutoSize = true;
            this.rbtndivide.Location = new System.Drawing.Point(6, 91);
            this.rbtndivide.Name = "rbtndivide";
            this.rbtndivide.Size = new System.Drawing.Size(30, 17);
            this.rbtndivide.TabIndex = 3;
            this.rbtndivide.TabStop = true;
            this.rbtndivide.Text = "/";
            this.rbtndivide.UseVisualStyleBackColor = true;
            this.rbtndivide.CheckedChanged += new System.EventHandler(this.ChangedOperation);
            // 
            // rbtnminus
            // 
            this.rbtnminus.AutoSize = true;
            this.rbtnminus.Location = new System.Drawing.Point(6, 42);
            this.rbtnminus.Name = "rbtnminus";
            this.rbtnminus.Size = new System.Drawing.Size(28, 17);
            this.rbtnminus.TabIndex = 2;
            this.rbtnminus.TabStop = true;
            this.rbtnminus.Text = "-";
            this.rbtnminus.UseVisualStyleBackColor = true;
            this.rbtnminus.CheckedChanged += new System.EventHandler(this.ChangedOperation);
            // 
            // rbtnmultiply
            // 
            this.rbtnmultiply.AutoSize = true;
            this.rbtnmultiply.Location = new System.Drawing.Point(6, 68);
            this.rbtnmultiply.Name = "rbtnmultiply";
            this.rbtnmultiply.Size = new System.Drawing.Size(29, 17);
            this.rbtnmultiply.TabIndex = 1;
            this.rbtnmultiply.TabStop = true;
            this.rbtnmultiply.Text = "*";
            this.rbtnmultiply.UseVisualStyleBackColor = true;
            this.rbtnmultiply.CheckedChanged += new System.EventHandler(this.ChangedOperation);
            // 
            // rbtnplus
            // 
            this.rbtnplus.AutoSize = true;
            this.rbtnplus.Checked = true;
            this.rbtnplus.Location = new System.Drawing.Point(6, 17);
            this.rbtnplus.Name = "rbtnplus";
            this.rbtnplus.Size = new System.Drawing.Size(31, 17);
            this.rbtnplus.TabIndex = 0;
            this.rbtnplus.TabStop = true;
            this.rbtnplus.Text = "+";
            this.rbtnplus.UseVisualStyleBackColor = true;
            this.rbtnplus.CheckedChanged += new System.EventHandler(this.ChangedOperation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtsecond);
            this.Controls.Add(this.txtfirst);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtsecond;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtndivide;
        private System.Windows.Forms.RadioButton rbtnminus;
        private System.Windows.Forms.RadioButton rbtnmultiply;
        private System.Windows.Forms.RadioButton rbtnplus;
    }
}

