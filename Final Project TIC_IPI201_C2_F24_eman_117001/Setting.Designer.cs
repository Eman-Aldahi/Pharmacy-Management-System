namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    partial class Setting
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.butt_ٍSave = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(401, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "إعدادات النظام";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butt_ٍSave);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(label6);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 243);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.Transparent;
            label6.Location = new System.Drawing.Point(108, 31);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(24, 18);
            label6.TabIndex = 5;
            label6.Text = "يوم";
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(15, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(360, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "إظهار الأدوية الفاسدة ذات الصلاحية المنتهية في بداية تشغيل النظام";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(107, 104);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(272, 22);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "إظهار رسالة عندما تصبح كمية أي دواء أقل من 5";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.Transparent;
            label5.Location = new System.Drawing.Point(198, 33);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(180, 18);
            label5.TabIndex = 3;
            label5.Text = "فرق الأيام قبل اعتبار الدواء الفاسد";
            label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(409, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // butt_ٍSave
            // 
            this.butt_ٍSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.butt_ٍSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_ٍSave.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.butt_ٍSave.ForeColor = System.Drawing.Color.White;
            this.butt_ٍSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butt_ٍSave.Location = new System.Drawing.Point(6, 202);
            this.butt_ٍSave.Name = "butt_ٍSave";
            this.butt_ٍSave.Size = new System.Drawing.Size(91, 35);
            this.butt_ٍSave.TabIndex = 22;
            this.butt_ٍSave.Text = "حفظ الإعدادات";
            this.butt_ٍSave.UseVisualStyleBackColor = false;
            this.butt_ٍSave.Click += new System.EventHandler(this.butt_ٍSave_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(410, 285);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Setting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الإعدادات";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button butt_ٍSave;

    }
}