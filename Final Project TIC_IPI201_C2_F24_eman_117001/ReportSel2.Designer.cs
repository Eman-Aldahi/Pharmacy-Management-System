namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    partial class ReportSel2
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
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.Excport.Location = new System.Drawing.Point(32, 418);
            this.Excport.Name = "Excport";
            this.Excport.Size = new System.Drawing.Size(112, 28);
            this.Excport.TabIndex = 32;
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
            this.print_butt.Location = new System.Drawing.Point(477, 418);
            this.print_butt.Name = "print_butt";
            this.print_butt.Size = new System.Drawing.Size(70, 28);
            this.print_butt.TabIndex = 31;
            this.print_butt.Text = "طباعة";
            this.print_butt.UseVisualStyleBackColor = false;
            this.print_butt.Click += new System.EventHandler(this.print_butt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(198, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "تقرير المبيعات بين تاريخين ";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(117, 80);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFrom.RightToLeftLayout = true;
            this.dtpFrom.Size = new System.Drawing.Size(100, 26);
            this.dtpFrom.TabIndex = 43;
            this.dtpFrom.Value = new System.DateTime(2026, 1, 29, 0, 24, 16, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpSearchDate_ValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(477, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 28);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(32, 127);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.Size = new System.Drawing.Size(515, 285);
            this.dgvSalesReport.TabIndex = 41;
            this.dgvSalesReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesReport_CellContentClick);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy-MM-dd";
            this.dtpTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(324, 82);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpTo.RightToLeftLayout = true;
            this.dtpTo.Size = new System.Drawing.Size(100, 26);
            this.dtpTo.TabIndex = 45;
            this.dtpTo.Value = new System.DateTime(2026, 1, 29, 0, 24, 16, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(49, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "من تاريخ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(248, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "حتى تاريخ";
            // 
            // ReportSel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(559, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.Excport);
            this.Controls.Add(this.print_butt);
            this.MaximizeBox = false;
            this.Name = "ReportSel2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إجمالي المبيعات بين تاريخين";
            this.Load += new System.EventHandler(this.ReportSel2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Excport;
        private System.Windows.Forms.Button print_butt;
        protected System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.DateTimePicker dtpTo;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
    }
}