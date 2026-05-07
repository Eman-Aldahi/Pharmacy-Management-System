namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    partial class Report2
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
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.databasePHDataSet8 = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet8();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeTableAdapter = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet8TableAdapters.StoreTableAdapter();
            this.tableAdapterManager = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet8TableAdapters.TableAdapterManager();
            this.storeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excport = new System.Windows.Forms.Button();
            this.print_butt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(169, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "تقرير عن الأدوية النافذة";
            // 
            // databasePHDataSet8
            // 
            this.databasePHDataSet8.DataSetName = "DatabasePHDataSet8";
            this.databasePHDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.databasePHDataSet8;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CompaniesTableAdapter = null;
            this.tableAdapterManager.invoices_DataTableAdapter = null;
            this.tableAdapterManager.Purchase_invoicesTableAdapter = null;
            this.tableAdapterManager.Sales_invo_DataTableAdapter = null;
            this.tableAdapterManager.Sales_invoicesTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = this.storeTableAdapter;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet8TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // storeDataGridView
            // 
            this.storeDataGridView.AutoGenerateColumns = false;
            this.storeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.storeDataGridView.DataSource = this.storeBindingSource;
            this.storeDataGridView.Location = new System.Drawing.Point(12, 87);
            this.storeDataGridView.Name = "storeDataGridView";
            this.storeDataGridView.Size = new System.Drawing.Size(443, 290);
            this.storeDataGridView.TabIndex = 25;
            this.storeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.storeDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "store_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "رمز الدواء";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "medicine_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم الدواء";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "الكمية";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Expiration_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "تاريخ انتهاء الصلاحية";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Excport
            // 
            this.Excport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.Excport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Excport.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Excport.ForeColor = System.Drawing.Color.White;
            this.Excport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Excport.Location = new System.Drawing.Point(338, 407);
            this.Excport.Name = "Excport";
            this.Excport.Size = new System.Drawing.Size(112, 28);
            this.Excport.TabIndex = 28;
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
            this.print_butt.Location = new System.Drawing.Point(12, 407);
            this.print_butt.Name = "print_butt";
            this.print_butt.Size = new System.Drawing.Size(70, 28);
            this.print_butt.TabIndex = 27;
            this.print_butt.Text = "طباعة";
            this.print_butt.UseVisualStyleBackColor = false;
            this.print_butt.Click += new System.EventHandler(this.print_butt_Click);
            // 
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(467, 458);
            this.Controls.Add(this.Excport);
            this.Controls.Add(this.print_butt);
            this.Controls.Add(this.storeDataGridView);
            this.Controls.Add(this.label9);
            this.MaximizeBox = false;
            this.Name = "Report2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير عن الأدوية النافذة";
            this.Load += new System.EventHandler(this.Report2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label9;
        private DatabasePHDataSet8 databasePHDataSet8;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private DatabasePHDataSet8TableAdapters.StoreTableAdapter storeTableAdapter;
        private DatabasePHDataSet8TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView storeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button Excport;
        private System.Windows.Forms.Button print_butt;
    }
}