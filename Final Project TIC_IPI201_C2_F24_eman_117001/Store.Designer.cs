namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    partial class Store
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasePHDataSet3 = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet3();
            this.butt_ٍSerch = new System.Windows.Forms.Button();
            this.txtBx_ٍSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.storeTableAdapter = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet3TableAdapters.StoreTableAdapter();
            this.tableAdapterManager = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet3TableAdapters.TableAdapterManager();
            this.storeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.storeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.storeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databasePHDataSet4 = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet4();
            this.storeTableAdapter1 = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet4TableAdapters.StoreTableAdapter();
            this.tableAdapterManager1 = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet4TableAdapters.TableAdapterManager();
            this.categories_id_StComboBox = new System.Windows.Forms.ComboBox();
            this.store_idTextBox = new System.Windows.Forms.TextBox();
            this.medicine_nameTextBox = new System.Windows.Forms.TextBox();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.purchase_PriceTextBox = new System.Windows.Forms.TextBox();
            this.selling_PriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.expiration_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stock_storageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butt_Delete = new System.Windows.Forms.Button();
            this.butt_Update = new System.Windows.Forms.Button();
            this.butt_Add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            company_idLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingNavigator)).BeginInit();
            this.storeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // company_idLabel
            // 
            company_idLabel.AutoSize = true;
            company_idLabel.Location = new System.Drawing.Point(436, 29);
            company_idLabel.Name = "company_idLabel";
            company_idLabel.Size = new System.Drawing.Size(57, 16);
            company_idLabel.TabIndex = 1;
            company_idLabel.Text = "رمز الدواء";
            company_idLabel.Click += new System.EventHandler(this.company_idLabel_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(436, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 16);
            label2.TabIndex = 24;
            label2.Text = "اسم الدواء";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(437, 91);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 16);
            label3.TabIndex = 25;
            label3.Text = "الباركود";
            label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(437, 121);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 16);
            label4.TabIndex = 26;
            label4.Text = "اسم الصنف";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(121, 29);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(63, 16);
            label6.TabIndex = 28;
            label6.Text = "سعر الشراء";
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(121, 60);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(53, 16);
            label7.TabIndex = 29;
            label7.Text = "سعر البيع";
            label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(437, 146);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(35, 16);
            label8.TabIndex = 30;
            label8.Text = "الكمية";
            label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(122, 85);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(110, 16);
            label9.TabIndex = 31;
            label9.Text = "تاريخ انتهاء الصلاحية";
            label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(122, 117);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(69, 16);
            label10.TabIndex = 32;
            label10.Text = "مكان التخزين";
            label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataMember = "Store";
            this.storeBindingSource.DataSource = this.databasePHDataSet3;
            // 
            // databasePHDataSet3
            // 
            this.databasePHDataSet3.DataSetName = "DatabasePHDataSet3";
            this.databasePHDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // butt_ٍSerch
            // 
            this.butt_ٍSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.butt_ٍSerch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_ٍSerch.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.butt_ٍSerch.ForeColor = System.Drawing.Color.White;
            this.butt_ٍSerch.Location = new System.Drawing.Point(272, 38);
            this.butt_ٍSerch.Name = "butt_ٍSerch";
            this.butt_ٍSerch.Size = new System.Drawing.Size(56, 25);
            this.butt_ٍSerch.TabIndex = 17;
            this.butt_ٍSerch.Text = "بحث";
            this.butt_ٍSerch.UseVisualStyleBackColor = false;
            this.butt_ٍSerch.Click += new System.EventHandler(this.butt_ٍSerch_Click);
            // 
            // txtBx_ٍSearch
            // 
            this.txtBx_ٍSearch.Location = new System.Drawing.Point(39, 38);
            this.txtBx_ٍSearch.Multiline = true;
            this.txtBx_ٍSearch.Name = "txtBx_ٍSearch";
            this.txtBx_ٍSearch.Size = new System.Drawing.Size(225, 25);
            this.txtBx_ٍSearch.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.pictureBox1.Image = global::Final_Project_TIC_IPI201_C2_F24_eman_117001.Properties.Resources.Searchw;
            this.pictureBox1.Location = new System.Drawing.Point(9, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // storeTableAdapter
            // 
            this.storeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CompaniesTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = this.storeTableAdapter;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // storeBindingNavigator
            // 
            this.storeBindingNavigator.AddNewItem = null;
            this.storeBindingNavigator.BindingSource = this.storeBindingSource;
            this.storeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.storeBindingNavigator.DeleteItem = null;
            this.storeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.storeBindingNavigatorSaveItem});
            this.storeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.storeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.storeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.storeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.storeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.storeBindingNavigator.Name = "storeBindingNavigator";
            this.storeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.storeBindingNavigator.Size = new System.Drawing.Size(653, 25);
            this.storeBindingNavigator.TabIndex = 18;
            this.storeBindingNavigator.Text = "bindingNavigator1";
            this.storeBindingNavigator.RefreshItems += new System.EventHandler(this.storeBindingNavigator_RefreshItems);
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
            // storeBindingNavigatorSaveItem
            // 
            this.storeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.storeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("storeBindingNavigatorSaveItem.Image")));
            this.storeBindingNavigatorSaveItem.Name = "storeBindingNavigatorSaveItem";
            this.storeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.storeBindingNavigatorSaveItem.Text = "Save Data";
            this.storeBindingNavigatorSaveItem.Click += new System.EventHandler(this.storeBindingNavigatorSaveItem_Click);
            // 
            // storeBindingSource1
            // 
            this.storeBindingSource1.DataMember = "Store";
            this.storeBindingSource1.DataSource = this.databasePHDataSet4;
            // 
            // databasePHDataSet4
            // 
            this.databasePHDataSet4.DataSetName = "DatabasePHDataSet4";
            this.databasePHDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeTableAdapter1
            // 
            this.storeTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CategoriesTableAdapter = null;
            this.tableAdapterManager1.CompaniesTableAdapter = null;
            this.tableAdapterManager1.StoreTableAdapter = this.storeTableAdapter1;
            this.tableAdapterManager1.SuppliersTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // categories_id_StComboBox
            // 
            this.categories_id_StComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource1, "Categories_id_St", true));
            this.categories_id_StComboBox.FormattingEnabled = true;
            this.categories_id_StComboBox.Location = new System.Drawing.Point(310, 113);
            this.categories_id_StComboBox.Name = "categories_id_StComboBox";
            this.categories_id_StComboBox.Size = new System.Drawing.Size(121, 24);
            this.categories_id_StComboBox.TabIndex = 33;
            this.categories_id_StComboBox.SelectedIndexChanged += new System.EventHandler(this.categories_id_StComboBox_SelectedIndexChanged);
            // 
            // store_idTextBox
            // 
            this.store_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource1, "store_id", true));
            this.store_idTextBox.Location = new System.Drawing.Point(330, 26);
            this.store_idTextBox.Name = "store_idTextBox";
            this.store_idTextBox.Size = new System.Drawing.Size(100, 23);
            this.store_idTextBox.TabIndex = 36;
            this.store_idTextBox.TextChanged += new System.EventHandler(this.store_idTextBox_TextChanged_1);
            // 
            // medicine_nameTextBox
            // 
            this.medicine_nameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.medicine_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource1, "medicine_name", true));
            this.medicine_nameTextBox.Location = new System.Drawing.Point(310, 55);
            this.medicine_nameTextBox.Name = "medicine_nameTextBox";
            this.medicine_nameTextBox.Size = new System.Drawing.Size(121, 23);
            this.medicine_nameTextBox.TabIndex = 37;
            this.medicine_nameTextBox.TextChanged += new System.EventHandler(this.medicine_nameTextBox_TextChanged_1);
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource1, "Barcode", true));
            this.barcodeTextBox.Location = new System.Drawing.Point(330, 84);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.barcodeTextBox.TabIndex = 38;
            this.barcodeTextBox.TextChanged += new System.EventHandler(this.barcodeTextBox_TextChanged_1);
            // 
            // purchase_PriceTextBox
            // 
            this.purchase_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource1, "Purchase_Price", true));
            this.purchase_PriceTextBox.Location = new System.Drawing.Point(15, 22);
            this.purchase_PriceTextBox.Name = "purchase_PriceTextBox";
            this.purchase_PriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.purchase_PriceTextBox.TabIndex = 39;
            this.purchase_PriceTextBox.TextChanged += new System.EventHandler(this.purchase_PriceTextBox_TextChanged_1);
            // 
            // selling_PriceTextBox
            // 
            this.selling_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource1, "Selling_Price", true));
            this.selling_PriceTextBox.Location = new System.Drawing.Point(15, 51);
            this.selling_PriceTextBox.Name = "selling_PriceTextBox";
            this.selling_PriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.selling_PriceTextBox.TabIndex = 40;
            this.selling_PriceTextBox.TextChanged += new System.EventHandler(this.selling_PriceTextBox_TextChanged_1);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource1, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(330, 143);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 23);
            this.quantityTextBox.TabIndex = 41;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged_1);
            // 
            // expiration_dateDateTimePicker
            // 
            this.expiration_dateDateTimePicker.CustomFormat = "";
            this.expiration_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.storeBindingSource1, "Expiration_date", true));
            this.expiration_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expiration_dateDateTimePicker.Location = new System.Drawing.Point(15, 80);
            this.expiration_dateDateTimePicker.Name = "expiration_dateDateTimePicker";
            this.expiration_dateDateTimePicker.RightToLeftLayout = true;
            this.expiration_dateDateTimePicker.Size = new System.Drawing.Size(101, 23);
            this.expiration_dateDateTimePicker.TabIndex = 42;
            this.expiration_dateDateTimePicker.Value = new System.DateTime(2026, 1, 29, 0, 0, 0, 0);
            this.expiration_dateDateTimePicker.ValueChanged += new System.EventHandler(this.expiration_dateDateTimePicker_ValueChanged_1);
            // 
            // stock_storageTextBox
            // 
            this.stock_storageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeBindingSource1, "Stock_storage", true));
            this.stock_storageTextBox.Location = new System.Drawing.Point(16, 109);
            this.stock_storageTextBox.Name = "stock_storageTextBox";
            this.stock_storageTextBox.Size = new System.Drawing.Size(100, 23);
            this.stock_storageTextBox.TabIndex = 43;
            this.stock_storageTextBox.TextChanged += new System.EventHandler(this.stock_storageTextBox_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stock_storageTextBox);
            this.groupBox1.Controls.Add(this.expiration_dateDateTimePicker);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.selling_PriceTextBox);
            this.groupBox1.Controls.Add(this.purchase_PriceTextBox);
            this.groupBox1.Controls.Add(this.barcodeTextBox);
            this.groupBox1.Controls.Add(this.medicine_nameTextBox);
            this.groupBox1.Controls.Add(this.store_idTextBox);
            this.groupBox1.Controls.Add(this.categories_id_StComboBox);
            this.groupBox1.Controls.Add(label10);
            this.groupBox1.Controls.Add(label9);
            this.groupBox1.Controls.Add(label8);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(company_idLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(3, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(506, 176);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إدخال البيانات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // butt_Delete
            // 
            this.butt_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.butt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_Delete.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.butt_Delete.ForeColor = System.Drawing.Color.White;
            this.butt_Delete.Location = new System.Drawing.Point(550, 452);
            this.butt_Delete.Name = "butt_Delete";
            this.butt_Delete.Size = new System.Drawing.Size(90, 35);
            this.butt_Delete.TabIndex = 26;
            this.butt_Delete.Text = "حذف";
            this.butt_Delete.UseVisualStyleBackColor = false;
            this.butt_Delete.Click += new System.EventHandler(this.butt_Delete_Click);
            // 
            // butt_Update
            // 
            this.butt_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.butt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_Update.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.butt_Update.ForeColor = System.Drawing.Color.White;
            this.butt_Update.Location = new System.Drawing.Point(292, 452);
            this.butt_Update.Name = "butt_Update";
            this.butt_Update.Size = new System.Drawing.Size(90, 35);
            this.butt_Update.TabIndex = 25;
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
            this.butt_Add.Location = new System.Drawing.Point(9, 455);
            this.butt_Add.Name = "butt_Add";
            this.butt_Add.Size = new System.Drawing.Size(90, 35);
            this.butt_Add.TabIndex = 24;
            this.butt_Add.Text = "إضافة";
            this.butt_Add.UseVisualStyleBackColor = false;
            this.butt_Add.Click += new System.EventHandler(this.butt_Add_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 184);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عرض البيانات";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(653, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.butt_Delete);
            this.Controls.Add(this.butt_Update);
            this.Controls.Add(this.storeBindingNavigator);
            this.Controls.Add(this.butt_ٍSerch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBx_ٍSearch);
            this.Controls.Add(this.butt_Add);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Store";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المخزن";
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingNavigator)).EndInit();
            this.storeBindingNavigator.ResumeLayout(false);
            this.storeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_ٍSerch;
        private System.Windows.Forms.TextBox txtBx_ٍSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DatabasePHDataSet3 databasePHDataSet3;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private DatabasePHDataSet3TableAdapters.StoreTableAdapter storeTableAdapter;
        private DatabasePHDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator storeBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton storeBindingNavigatorSaveItem;
        private DatabasePHDataSet4 databasePHDataSet4;
        private System.Windows.Forms.BindingSource storeBindingSource1;
        private DatabasePHDataSet4TableAdapters.StoreTableAdapter storeTableAdapter1;
        private DatabasePHDataSet4TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox categories_id_StComboBox;
        private System.Windows.Forms.TextBox store_idTextBox;
        private System.Windows.Forms.TextBox medicine_nameTextBox;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.TextBox purchase_PriceTextBox;
        private System.Windows.Forms.TextBox selling_PriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.DateTimePicker expiration_dateDateTimePicker;
        private System.Windows.Forms.TextBox stock_storageTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butt_Delete;
        private System.Windows.Forms.Button butt_Update;
        private System.Windows.Forms.Button butt_Add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}