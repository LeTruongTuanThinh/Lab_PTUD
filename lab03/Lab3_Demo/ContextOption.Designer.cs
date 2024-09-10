namespace Lab3_Demo
{
    partial class ContextOption
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
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rdID = new System.Windows.Forms.RadioButton();
            this.gbInfor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInfor = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdName = new System.Windows.Forms.RadioButton();
            this.rdDateOfBirth = new System.Windows.Forms.RadioButton();
            this.gbType.SuspendLayout();
            this.gbInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rdDateOfBirth);
            this.gbType.Controls.Add(this.rdName);
            this.gbType.Controls.Add(this.rdID);
            this.gbType.Location = new System.Drawing.Point(12, 12);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(200, 100);
            this.gbType.TabIndex = 0;
            this.gbType.TabStop = false;
            this.gbType.Text = "Loại";
            // 
            // rdID
            // 
            this.rdID.AutoSize = true;
            this.rdID.Checked = true;
            this.rdID.Location = new System.Drawing.Point(7, 21);
            this.rdID.Name = "rdID";
            this.rdID.Size = new System.Drawing.Size(68, 20);
            this.rdID.TabIndex = 1;
            this.rdID.TabStop = true;
            this.rdID.Text = "Mã SV";
            this.rdID.UseVisualStyleBackColor = true;
            // 
            // gbInfor
            // 
            this.gbInfor.Controls.Add(this.btnFind);
            this.gbInfor.Controls.Add(this.txtInfor);
            this.gbInfor.Controls.Add(this.label1);
            this.gbInfor.Location = new System.Drawing.Point(218, 12);
            this.gbInfor.Name = "gbInfor";
            this.gbInfor.Size = new System.Drawing.Size(300, 100);
            this.gbInfor.TabIndex = 1;
            this.gbInfor.TabStop = false;
            this.gbInfor.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin";
            // 
            // txtInfor
            // 
            this.txtInfor.Location = new System.Drawing.Point(111, 25);
            this.txtInfor.Name = "txtInfor";
            this.txtInfor.Size = new System.Drawing.Size(183, 22);
            this.txtInfor.TabIndex = 2;
            this.txtInfor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInfor_KeyPress);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(212, 70);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 118);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(137, 118);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Location = new System.Drawing.Point(7, 47);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(67, 20);
            this.rdName.TabIndex = 2;
            this.rdName.TabStop = true;
            this.rdName.Text = "Họ tên";
            this.rdName.UseVisualStyleBackColor = true;
            // 
            // rdDateOfBirth
            // 
            this.rdDateOfBirth.AutoSize = true;
            this.rdDateOfBirth.Location = new System.Drawing.Point(7, 74);
            this.rdDateOfBirth.Name = "rdDateOfBirth";
            this.rdDateOfBirth.Size = new System.Drawing.Size(88, 20);
            this.rdDateOfBirth.TabIndex = 3;
            this.rdDateOfBirth.TabStop = true;
            this.rdDateOfBirth.Text = "Ngày sinh";
            this.rdDateOfBirth.UseVisualStyleBackColor = true;
            // 
            // ContextOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 168);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.gbInfor);
            this.Controls.Add(this.gbType);
            this.Name = "ContextOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContextOption";
            this.Load += new System.EventHandler(this.ContextOption_Load);
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbInfor.ResumeLayout(false);
            this.gbInfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfor;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.GroupBox gbType;
        public System.Windows.Forms.GroupBox gbInfor;
        public System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.RadioButton rdDateOfBirth;
    }
}