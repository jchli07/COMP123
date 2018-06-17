namespace ElementsDemo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblNeutron = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblProton = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtNeutron = new System.Windows.Forms.TextBox();
            this.txtProton = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvElements = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElements)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 245);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblWeight);
            this.tabPage1.Controls.Add(this.lblNeutron);
            this.tabPage1.Controls.Add(this.lblSymbol);
            this.tabPage1.Controls.Add(this.lblProton);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.txtSymbol);
            this.tabPage1.Controls.Add(this.txtWeight);
            this.tabPage1.Controls.Add(this.txtNeutron);
            this.tabPage1.Controls.Add(this.txtProton);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnModify);
            this.tabPage1.Controls.Add(this.btnCreate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(251, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Element manipulation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(136, 107);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(73, 13);
            this.lblWeight.TabIndex = 17;
            this.lblWeight.Text = "Atomic weight";
            // 
            // lblNeutron
            // 
            this.lblNeutron.AutoSize = true;
            this.lblNeutron.Location = new System.Drawing.Point(136, 61);
            this.lblNeutron.Name = "lblNeutron";
            this.lblNeutron.Size = new System.Drawing.Size(45, 13);
            this.lblNeutron.TabIndex = 16;
            this.lblNeutron.Text = "Neutron";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(18, 62);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(41, 13);
            this.lblSymbol.TabIndex = 15;
            this.lblSymbol.Text = "Symbol";
            // 
            // lblProton
            // 
            this.lblProton.AutoSize = true;
            this.lblProton.Location = new System.Drawing.Point(136, 9);
            this.lblProton.Name = "lblProton";
            this.lblProton.Size = new System.Drawing.Size(38, 13);
            this.lblProton.TabIndex = 14;
            this.lblProton.Text = "Proton";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(18, 78);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(95, 20);
            this.txtSymbol.TabIndex = 12;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(136, 126);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 11;
            // 
            // txtNeutron
            // 
            this.txtNeutron.Location = new System.Drawing.Point(136, 78);
            this.txtNeutron.Name = "txtNeutron";
            this.txtNeutron.Size = new System.Drawing.Size(100, 20);
            this.txtNeutron.TabIndex = 10;
            // 
            // txtProton
            // 
            this.txtProton.Location = new System.Drawing.Point(136, 28);
            this.txtProton.Name = "txtProton";
            this.txtProton.Size = new System.Drawing.Size(100, 20);
            this.txtProton.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(18, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(95, 20);
            this.txtName.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(117, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(18, 188);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(18, 152);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvElements);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(251, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Elements";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvElements
            // 
            this.dgvElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElements.Location = new System.Drawing.Point(0, 3);
            this.dgvElements.Name = "dgvElements";
            this.dgvElements.Size = new System.Drawing.Size(247, 216);
            this.dgvElements.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvElements;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblProton;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtNeutron;
        private System.Windows.Forms.TextBox txtProton;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblNeutron;

    }
}

