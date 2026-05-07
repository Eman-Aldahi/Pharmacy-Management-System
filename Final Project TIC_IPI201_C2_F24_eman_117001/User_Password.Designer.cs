namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    partial class User_Password
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
            this.txt_OldPass = new System.Windows.Forms.TextBox();
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.txt_ConfirmPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_OldPass
            // 
            this.txt_OldPass.Location = new System.Drawing.Point(171, 20);
            this.txt_OldPass.Multiline = true;
            this.txt_OldPass.Name = "txt_OldPass";
            this.txt_OldPass.Size = new System.Drawing.Size(123, 25);
            this.txt_OldPass.TabIndex = 0;
            this.txt_OldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_OldPass.UseSystemPasswordChar = true;
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.Location = new System.Drawing.Point(171, 51);
            this.txt_NewPass.Multiline = true;
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.Size = new System.Drawing.Size(123, 25);
            this.txt_NewPass.TabIndex = 1;
            this.txt_NewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_NewPass.UseSystemPasswordChar = true;
            // 
            // txt_ConfirmPass
            // 
            this.txt_ConfirmPass.Location = new System.Drawing.Point(171, 82);
            this.txt_ConfirmPass.Multiline = true;
            this.txt_ConfirmPass.Name = "txt_ConfirmPass";
            this.txt_ConfirmPass.Size = new System.Drawing.Size(123, 25);
            this.txt_ConfirmPass.TabIndex = 2;
            this.txt_ConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ConfirmPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "كلمة المرور الحالية :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 57);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "كلمة المرور الجديدة :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 88);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "تأكيد كلمة المرور الجديدة :";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.btn_Save.FlatAppearance.BorderSize = 5;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(237, 119);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(57, 28);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // User_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(306, 159);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ConfirmPass);
            this.Controls.Add(this.txt_NewPass);
            this.Controls.Add(this.txt_OldPass);
            this.MaximizeBox = false;
            this.Name = "User_Password";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغيير كلمة المرور";
            this.Load += new System.EventHandler(this.User_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_OldPass;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.TextBox txt_ConfirmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Save;
    }
}