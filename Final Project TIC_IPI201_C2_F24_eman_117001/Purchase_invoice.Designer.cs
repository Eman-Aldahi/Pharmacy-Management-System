namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    partial class Purchase_invoice
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
            System.Windows.Forms.Label company_idLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_invoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.payment_typeComboBox = new System.Windows.Forms.ComboBox();
            this.purchase_invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasePHDataSet7 = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet7();
            this.suppl_idComboBox = new System.Windows.Forms.ComboBox();
            this.net_AmountTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.total_before_discountTextBox = new System.Windows.Forms.TextBox();
            this.invoic_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.invoic_idTextBox = new System.Windows.Forms.TextBox();
            this.purchase_invoicesTableAdapter = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet7TableAdapters.Purchase_invoicesTableAdapter();
            this.tableAdapterManager = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet7TableAdapters.TableAdapterManager();
            this.purchase_invoicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.purchase_invoicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.butt_ٍSerch = new System.Windows.Forms.Button();
            this.txtBx_ٍSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butt_Update = new System.Windows.Forms.Button();
            this.butt_Add = new System.Windows.Forms.Button();
            company_idLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_invoicesBindingNavigator)).BeginInit();
            this.purchase_invoicesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // company_idLabel
            // 
            company_idLabel.AutoSize = true;
            company_idLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            company_idLabel.ForeColor = System.Drawing.Color.White;
            company_idLabel.Location = new System.Drawing.Point(402, 38);
            company_idLabel.Name = "company_idLabel";
            company_idLabel.Size = new System.Drawing.Size(69, 17);
            company_idLabel.TabIndex = 14;
            company_idLabel.Text = "رمز الفاتورة";
            company_idLabel.Click += new System.EventHandler(this.company_idLabel_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(402, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 17);
            label1.TabIndex = 15;
            label1.Text = "تاريخ الفاتورة";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(402, 100);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 17);
            label2.TabIndex = 16;
            label2.Text = "اسم المورد";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(402, 135);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 17);
            label3.TabIndex = 17;
            label3.Text = "نوع الدفع";
            label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(120, 43);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(137, 17);
            label4.TabIndex = 18;
            label4.Text = "المبلغ الإجمالي قبل الحسم";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(120, 77);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 17);
            label5.TabIndex = 19;
            label5.Text = "الحسم المكتسب";
            label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(122, 108);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(79, 17);
            label6.TabIndex = 20;
            label6.Text = "المبلغ الصافي";
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.payment_typeComboBox);
            this.groupBox1.Controls.Add(this.suppl_idComboBox);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(company_idLabel);
            this.groupBox1.Controls.Add(this.net_AmountTextBox);
            this.groupBox1.Controls.Add(this.discountTextBox);
            this.groupBox1.Controls.Add(this.total_before_discountTextBox);
            this.groupBox1.Controls.Add(this.invoic_DateDateTimePicker);
            this.groupBox1.Controls.Add(this.invoic_idTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إدخال البيانات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // payment_typeComboBox
            // 
            this.payment_typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_invoicesBindingSource, "payment_type", true));
            this.payment_typeComboBox.FormattingEnabled = true;
            this.payment_typeComboBox.Items.AddRange(new object[] {
            "نقداً",
            "آجل",
            "نقداً + آجل"});
            this.payment_typeComboBox.Location = new System.Drawing.Point(284, 131);
            this.payment_typeComboBox.Name = "payment_typeComboBox";
            this.payment_typeComboBox.Size = new System.Drawing.Size(112, 27);
            this.payment_typeComboBox.TabIndex = 23;
            this.payment_typeComboBox.SelectedIndexChanged += new System.EventHandler(this.payment_typeComboBox_SelectedIndexChanged_1);
            // 
            // purchase_invoicesBindingSource
            // 
            this.purchase_invoicesBindingSource.DataMember = "Purchase invoices";
            this.purchase_invoicesBindingSource.DataSource = this.databasePHDataSet7;
            // 
            // databasePHDataSet7
            // 
            this.databasePHDataSet7.DataSetName = "DatabasePHDataSet7";
            this.databasePHDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppl_idComboBox
            // 
            this.suppl_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_invoicesBindingSource, "Suppl_id", true));
            this.suppl_idComboBox.FormattingEnabled = true;
            this.suppl_idComboBox.Location = new System.Drawing.Point(284, 98);
            this.suppl_idComboBox.Name = "suppl_idComboBox";
            this.suppl_idComboBox.Size = new System.Drawing.Size(112, 27);
            this.suppl_idComboBox.TabIndex = 22;
            this.suppl_idComboBox.SelectedIndexChanged += new System.EventHandler(this.suppl_idComboBox_SelectedIndexChanged);
            // 
            // net_AmountTextBox
            // 
            this.net_AmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_invoicesBindingSource, "net_Amount", true));
            this.net_AmountTextBox.Location = new System.Drawing.Point(9, 100);
            this.net_AmountTextBox.Multiline = true;
            this.net_AmountTextBox.Name = "net_AmountTextBox";
            this.net_AmountTextBox.Size = new System.Drawing.Size(107, 25);
            this.net_AmountTextBox.TabIndex = 11;
            this.net_AmountTextBox.TextChanged += new System.EventHandler(this.net_AmountTextBox_TextChanged);
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_invoicesBindingSource, "discount", true));
            this.discountTextBox.Location = new System.Drawing.Point(9, 69);
            this.discountTextBox.Multiline = true;
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(105, 25);
            this.discountTextBox.TabIndex = 9;
            this.discountTextBox.TextChanged += new System.EventHandler(this.discountTextBox_TextChanged);
            // 
            // total_before_discountTextBox
            // 
            this.total_before_discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_invoicesBindingSource, "total_before_discount", true));
            this.total_before_discountTextBox.Location = new System.Drawing.Point(9, 38);
            this.total_before_discountTextBox.Multiline = true;
            this.total_before_discountTextBox.Name = "total_before_discountTextBox";
            this.total_before_discountTextBox.Size = new System.Drawing.Size(105, 25);
            this.total_before_discountTextBox.TabIndex = 7;
            this.total_before_discountTextBox.TextChanged += new System.EventHandler(this.total_before_discountTextBox_TextChanged);
            // 
            // invoic_DateDateTimePicker
            // 
            this.invoic_DateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.invoic_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchase_invoicesBindingSource, "invoic_Date", true));
            this.invoic_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoic_DateDateTimePicker.Location = new System.Drawing.Point(284, 66);
            this.invoic_DateDateTimePicker.Name = "invoic_DateDateTimePicker";
            this.invoic_DateDateTimePicker.RightToLeftLayout = true;
            this.invoic_DateDateTimePicker.Size = new System.Drawing.Size(112, 26);
            this.invoic_DateDateTimePicker.TabIndex = 5;
            this.invoic_DateDateTimePicker.ValueChanged += new System.EventHandler(this.invoic_DateDateTimePicker_ValueChanged);
            // 
            // invoic_idTextBox
            // 
            this.invoic_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchase_invoicesBindingSource, "invoic_id", true));
            this.invoic_idTextBox.Location = new System.Drawing.Point(284, 35);
            this.invoic_idTextBox.Multiline = true;
            this.invoic_idTextBox.Name = "invoic_idTextBox";
            this.invoic_idTextBox.Size = new System.Drawing.Size(112, 25);
            this.invoic_idTextBox.TabIndex = 1;
            this.invoic_idTextBox.TextChanged += new System.EventHandler(this.invoic_idTextBox_TextChanged);
            // 
            // purchase_invoicesTableAdapter
            // 
            this.purchase_invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CompaniesTableAdapter = null;
            this.tableAdapterManager.invoices_DataTableAdapter = null;
            this.tableAdapterManager.Purchase_invoicesTableAdapter = this.purchase_invoicesTableAdapter;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet7TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // purchase_invoicesBindingNavigator
            // 
            this.purchase_invoicesBindingNavigator.AddNewItem = null;
            this.purchase_invoicesBindingNavigator.BindingSource = this.purchase_invoicesBindingSource;
            this.purchase_invoicesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchase_invoicesBindingNavigator.DeleteItem = null;
            this.purchase_invoicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.purchase_invoicesBindingNavigatorSaveItem});
            this.purchase_invoicesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchase_invoicesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchase_invoicesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchase_invoicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchase_invoicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchase_invoicesBindingNavigator.Name = "purchase_invoicesBindingNavigator";
            this.purchase_invoicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchase_invoicesBindingNavigator.Size = new System.Drawing.Size(745, 25);
            this.purchase_invoicesBindingNavigator.TabIndex = 1;
            this.purchase_invoicesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // purchase_invoicesBindingNavigatorSaveItem
            // 
            this.purchase_invoicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchase_invoicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchase_invoicesBindingNavigatorSaveItem.Image")));
            this.purchase_invoicesBindingNavigatorSaveItem.Name = "purchase_invoicesBindingNavigatorSaveItem";
            this.purchase_invoicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.purchase_invoicesBindingNavigatorSaveItem.Text = "Save Data";
            this.purchase_invoicesBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchase_invoicesBindingNavigatorSaveItem_Click);
            // 
            // butt_ٍSerch
            // 
            this.butt_ٍSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.butt_ٍSerch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_ٍSerch.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.butt_ٍSerch.ForeColor = System.Drawing.Color.White;
            this.butt_ٍSerch.Location = new System.Drawing.Point(273, 37);
            this.butt_ٍSerch.Name = "butt_ٍSerch";
            this.butt_ٍSerch.Size = new System.Drawing.Size(56, 25);
            this.butt_ٍSerch.TabIndex = 23;
            this.butt_ٍSerch.Text = "بحث";
            this.butt_ٍSerch.UseVisualStyleBackColor = false;
            this.butt_ٍSerch.Click += new System.EventHandler(this.butt_ٍSerch_Click);
            // 
            // txtBx_ٍSearch
            // 
            this.txtBx_ٍSearch.Location = new System.Drawing.Point(41, 37);
            this.txtBx_ٍSearch.Multiline = true;
            this.txtBx_ٍSearch.Name = "txtBx_ٍSearch";
            this.txtBx_ٍSearch.Size = new System.Drawing.Size(225, 25);
            this.txtBx_ٍSearch.TabIndex = 22;
            this.txtBx_ٍSearch.TextChanged += new System.EventHandler(this.txtBx_ٍSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.pictureBox1.Image = global::Final_Project_TIC_IPI201_C2_F24_eman_117001.Properties.Resources.Searchw;
            this.pictureBox1.Location = new System.Drawing.Point(11, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 299);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "إدخال البيانات";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 268);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // butt_Update
            // 
            this.butt_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.butt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_Update.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.butt_Update.ForeColor = System.Drawing.Color.White;
            this.butt_Update.Location = new System.Drawing.Point(643, 570);
            this.butt_Update.Name = "butt_Update";
            this.butt_Update.Size = new System.Drawing.Size(90, 35);
            this.butt_Update.TabIndex = 27;
            this.butt_Update.Text = "تعديل";
            this.butt_Update.UseVisualStyleBackColor = false;
            this.butt_Update.Click += new System.EventHandler(this.butt_Update_Click);
            // 
            // butt_Add
            // 
            this.butt_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.butt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_Add.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.butt_Add.ForeColor = System.Drawing.Color.White;
            this.butt_Add.Location = new System.Drawing.Point(19, 570);
            this.butt_Add.Name = "butt_Add";
            this.butt_Add.Size = new System.Drawing.Size(90, 35);
            this.butt_Add.TabIndex = 26;
            this.butt_Add.Text = "إضافة";
            this.butt_Add.UseVisualStyleBackColor = false;
            this.butt_Add.Click += new System.EventHandler(this.butt_Add_Click);
            // 
            // Purchase_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(745, 617);
            this.Controls.Add(this.butt_Update);
            this.Controls.Add(this.butt_Add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.butt_ٍSerch);
            this.Controls.Add(this.txtBx_ٍSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.purchase_invoicesBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Purchase_invoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة مشتريات";
            this.Load += new System.EventHandler(this.Purchase_invoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_invoicesBindingNavigator)).EndInit();
            this.purchase_invoicesBindingNavigator.ResumeLayout(false);
            this.purchase_invoicesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DatabasePHDataSet7 databasePHDataSet7;
        private System.Windows.Forms.BindingSource purchase_invoicesBindingSource;
        private DatabasePHDataSet7TableAdapters.Purchase_invoicesTableAdapter purchase_invoicesTableAdapter;
        private DatabasePHDataSet7TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchase_invoicesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton purchase_invoicesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox net_AmountTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox total_before_discountTextBox;
        private System.Windows.Forms.DateTimePicker invoic_DateDateTimePicker;
        private System.Windows.Forms.TextBox invoic_idTextBox;
        private System.Windows.Forms.Button butt_ٍSerch;
        private System.Windows.Forms.TextBox txtBx_ٍSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox suppl_idComboBox;
        private System.Windows.Forms.ComboBox payment_typeComboBox;
        private System.Windows.Forms.Button butt_Update;
        private System.Windows.Forms.Button butt_Add;
    }
}