namespace contact_list_winforms {
    partial class AddContactForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lul = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(172, 114);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(218, 26);
            this.txtFullName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên";
            // 
            // lul
            // 
            this.lul.AutoSize = true;
            this.lul.Location = new System.Drawing.Point(43, 163);
            this.lul.Name = "lul";
            this.lul.Size = new System.Drawing.Size(102, 20);
            this.lul.TabIndex = 2;
            this.lul.Text = "Số điện thoại";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(172, 157);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(218, 26);
            this.txtPhoneNum.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtFullName);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lul;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Button button1;
    }
}