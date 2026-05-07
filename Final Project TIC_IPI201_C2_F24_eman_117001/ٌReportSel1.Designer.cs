namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    partial class ReportSel1
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
            this.Excport = new System.Windows.Forms.Button();
            this.print_butt = new System.Windows.Forms.Button();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // Excport
            // 
            this.Excport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.Excport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Excport.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Excport.ForeColor = System.Drawing.Color.White;
            this.Excport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Excport.Location = new System.Drawing.Point(415, 418);
            this.Excport.Name = "Excport";
            this.Excport.Size = new System.Drawing.Size(112, 28);
            this.Excport.TabIndex = 34;
            this.Excport.Text = "تصدير لملف إكسل";
            this.Excport.UseVisualStyleBackColor = false;
            this.Excport.Click += new System.EventHandler(this.Excport_Click);
            // 
            // print_butt
            // 
            this.print_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.print_butt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.print_butt.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.print_butt.ForeColor = System.Drawing.Color.White;
            this.print_butt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.print_butt.Location = new System.Drawing.Point(12, 418);
            this.print_butt.Name = "print_butt";
            this.print_butt.Size = new System.Drawing.Size(70, 28);
            this.print_butt.TabIndex = 33;
            this.print_butt.Text = "طباعة";
            this.print_butt.UseVisualStyleBackColor = false;
            this.print_butt.Click += new System.EventHandler(this.print_butt_Click);
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(12, 105);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.Size = new System.Drawing.Size(515, 285);
            this.dgvSalesReport.TabIndex = 37;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(152, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 28);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.CustomFormat = "yyyy-MM-dd";
            this.dtpSearchDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchDate.Location = new System.Drawing.Point(33, 50);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpSearchDate.RightToLeftLayout = true;
            this.dtpSearchDate.Size = new System.Drawing.Size(100, 26);
            this.dtpSearchDate.TabIndex = 39;
            this.dtpSearchDate.Value = new System.DateTime(2026, 1, 29, 0, 24, 16, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(189, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 40;
            this.label9.Text = "تقرير المبيعات ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ReportSel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(539, 458);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.Excport);
            this.Controls.Add(this.print_butt);
            this.MaximizeBox = false;
            this.Name = "ReportSel1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إجمالي المبيعات لتاريخ محدد";
            this.Load += new System.EventHandler(this.ReportSel1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Excport;
        private System.Windows.Forms.Button print_butt;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        protected System.Windows.Forms.Label label9;
    }
}