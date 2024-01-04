namespace NewLibraryMembership
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adBox = new System.Windows.Forms.TextBox();
            this.tPNRegistration = new System.Windows.Forms.TextBox();
            this.cmbMemType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpRegistration = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(553, 283);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(707, 55);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(277, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(983, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library Member Registration Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(180, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(180, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(171, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 48);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telephone Number:";
            // 
            // adBox
            // 
            this.adBox.Location = new System.Drawing.Point(553, 384);
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(707, 55);
            this.adBox.TabIndex = 5;
            // 
            // tPNRegistration
            // 
            this.tPNRegistration.Location = new System.Drawing.Point(553, 509);
            this.tPNRegistration.Name = "tPNRegistration";
            this.tPNRegistration.Size = new System.Drawing.Size(707, 55);
            this.tPNRegistration.TabIndex = 6;
            // 
            // cmbMemType
            // 
            this.cmbMemType.FormattingEnabled = true;
            this.cmbMemType.Items.AddRange(new object[] {
            "Student",
            "Professional"});
            this.cmbMemType.Location = new System.Drawing.Point(553, 755);
            this.cmbMemType.Name = "cmbMemType";
            this.cmbMemType.Size = new System.Drawing.Size(363, 56);
            this.cmbMemType.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(180, 630);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 48);
            this.label5.TabIndex = 8;
            this.label5.Text = "Registration Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(180, 746);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 48);
            this.label6.TabIndex = 9;
            this.label6.Text = "Membership Type";
            // 
            // dtpRegistration
            // 
            this.dtpRegistration.Location = new System.Drawing.Point(553, 645);
            this.dtpRegistration.Name = "dtpRegistration";
            this.dtpRegistration.Size = new System.Drawing.Size(600, 55);
            this.dtpRegistration.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Cyan;
            this.btnSave.ForeColor = System.Drawing.Color.Red;
            this.btnSave.Location = new System.Drawing.Point(691, 897);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 69);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(180, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 48);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(553, 177);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(707, 55);
            this.txtID.TabIndex = 13;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 1060);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpRegistration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMemType);
            this.Controls.Add(this.tPNRegistration);
            this.Controls.Add(this.adBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Library Membership";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adBox;
        private System.Windows.Forms.TextBox tPNRegistration;
        private System.Windows.Forms.ComboBox cmbMemType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRegistration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
    }
}
