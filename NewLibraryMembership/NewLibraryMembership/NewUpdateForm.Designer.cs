namespace NewLibraryMembership
{
    partial class NewUpdateForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tPNRegistration = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.adBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(898, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Update Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 689);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 48);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telephone Number:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1590, 205);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(225, 69);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1232, 825);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(225, 69);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(635, 205);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(768, 55);
            this.txtID.TabIndex = 7;
            // 
            // tPNRegistration
            // 
            this.tPNRegistration.Location = new System.Drawing.Point(635, 682);
            this.tPNRegistration.Name = "tPNRegistration";
            this.tPNRegistration.Size = new System.Drawing.Size(768, 55);
            this.tPNRegistration.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(635, 363);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(768, 55);
            this.txtName.TabIndex = 9;
            // 
            // adBox
            // 
            this.adBox.Location = new System.Drawing.Point(635, 511);
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(768, 55);
            this.adBox.TabIndex = 10;
            // 
            // NewUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2098, 1214);
            this.Controls.Add(this.adBox);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.tPNRegistration);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewUpdateForm";
            this.Text = "NewUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox tPNRegistration;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox adBox;
    }
}