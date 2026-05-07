namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    partial class chat
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.btnAsk = new System.Windows.Forms.Button();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(3, 468);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(525, 42);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // rtbChat
            // 
            this.rtbChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbChat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbChat.Location = new System.Drawing.Point(3, 41);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.Size = new System.Drawing.Size(594, 421);
            this.rtbChat.TabIndex = 2;
            this.rtbChat.Text = "";
            this.rtbChat.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // btnAsk
            // 
            this.btnAsk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAsk.BackgroundImage = global::Final_Project_TIC_IPI201_C2_F24_eman_117001.Properties.Resources.Scroll_Up;
            this.btnAsk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAsk.FlatAppearance.BorderSize = 0;
            this.btnAsk.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsk.ForeColor = System.Drawing.Color.White;
            this.btnAsk.Location = new System.Drawing.Point(534, 468);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(63, 42);
            this.btnAsk.TabIndex = 0;
            this.btnAsk.UseVisualStyleBackColor = false;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.ForeColor = System.Drawing.Color.Red;
            this.lblDisclaimer.Location = new System.Drawing.Point(0, 0);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(600, 38);
            this.lblDisclaimer.TabIndex = 3;
            this.lblDisclaimer.Text = "⚠️ هذا البوت مخصص لمساعدة الصيدلي في تقديم معلومات دوائية عامة, لايعد بديلاً عن ا" +
    "لحكم المهني الصيدلي أو الطبيب ولايستخدم لاتخاذ قرارات علاجية أو تشخيصية نهائية";
            this.lblDisclaimer.Click += new System.EventHandler(this.lblDisclaimer_Click);
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarLoading.Location = new System.Drawing.Point(0, 515);
            this.progressBarLoading.MarqueeAnimationSpeed = 30;
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(603, 23);
            this.progressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarLoading.TabIndex = 4;
            this.progressBarLoading.Visible = false;
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 538);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.lblDisclaimer);
            this.Controls.Add(this.rtbChat);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.txtQuestion);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "chat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "محادثة مع جيمي";
            this.Load += new System.EventHandler(this.chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.Label lblDisclaimer;
        private System.Windows.Forms.ProgressBar progressBarLoading;
    }
}