namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    partial class Suppliers
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
            System.Windows.Forms.Label supp_addressLabel;
            System.Windows.Forms.Label Supp_phone_numberLabel;
            System.Windows.Forms.Label suppliers_idLabel;
            System.Windows.Forms.Label suppliers_nameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasePHDataSet3 = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet3();
            this.suppliersTableAdapter = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet3TableAdapters.SuppliersTableAdapter();
            this.tableAdapterManager = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet3TableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.suppliersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.supp_addressTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.suppliers_nameTextBox = new System.Windows.Forms.TextBox();
            this.suppliers_idTextBox = new System.Windows.Forms.TextBox();
            this.butt_Delete = new System.Windows.Forms.Button();
            this.butt_Update = new System.Windows.Forms.Button();
            this.butt_Add = new System.Windows.Forms.Button();
            this.butt_ٍSerch = new System.Windows.Forms.Button();
            this.txtBx_ٍSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            supp_addressLabel = new System.Windows.Forms.Label();
            Supp_phone_numberLabel = new System.Windows.Forms.Label();
            suppliers_idLabel = new System.Windows.Forms.Label();
            suppliers_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingNavigator)).BeginInit();
            this.suppliersBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // supp_addressLabel
            // 
            supp_addressLabel.AutoSize = true;
            supp_addressLabel.Location = new System.Drawing.Point(256, 125);
            supp_addressLabel.Name = "supp_addressLabel";
            supp_addressLabel.Size = new System.Drawing.Size(40, 16);
            supp_addressLabel.TabIndex = 11;
            supp_addressLabel.Text = "العنوان";
            // 
            // Supp_phone_numberLabel
            // 
            Supp_phone_numberLabel.AutoSize = true;
            Supp_phone_numberLabel.Location = new System.Drawing.Point(254, 96);
            Supp_phone_numberLabel.Name = "Supp_phone_numberLabel";
            Supp_phone_numberLabel.Size = new System.Drawing.Size(57, 16);
            Supp_phone_numberLabel.TabIndex = 5;
            Supp_phone_numberLabel.Text = "رقم الهاتف";
            Supp_phone_numberLabel.Click += new System.EventHandler(this.company_phone_numberLabel_Click);
            // 
            // suppliers_idLabel
            // 
            suppliers_idLabel.AutoSize = true;
            suppliers_idLabel.Location = new System.Drawing.Point(254, 34);
            suppliers_idLabel.Name = "suppliers_idLabel";
            suppliers_idLabel.Size = new System.Drawing.Size(59, 16);
            suppliers_idLabel.TabIndex = 1;
            suppliers_idLabel.Text = "رمز المورد";
            // 
            // suppliers_nameLabel
            // 
            suppliers_nameLabel.AutoSize = true;
            suppliers_nameLabel.Location = new System.Drawing.Point(254, 67);
            suppliers_nameLabel.Name = "suppliers_nameLabel";
            suppliers_nameLabel.Size = new System.Drawing.Size(58, 16);
            suppliers_nameLabel.TabIndex = 3;
            suppliers_nameLabel.Text = "اسم المورد";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.databasePHDataSet3;
            // 
            // databasePHDataSet3
            // 
            this.databasePHDataSet3.DataSetName = "DatabasePHDataSet3";
            this.databasePHDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CompaniesTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.suppliersDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 177);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عرض البيانات";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // suppliersDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.suppliersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.suppliersDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.suppliersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.suppliersDataGridView.DataSource = this.suppliersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.suppliersDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.suppliersDataGridView.Location = new System.Drawing.Point(6, 22);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.Size = new System.Drawing.Size(597, 149);
            this.suppliersDataGridView.TabIndex = 22;
            this.suppliersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.suppliersDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Suppliers_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "رمز المورد";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Suppliers_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم المورد";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "رقم الهاتف";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Supp_address";
            this.dataGridViewTextBoxColumn4.HeaderText = "العنوان";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // suppliersBindingNavigator
            // 
            this.suppliersBindingNavigator.AddNewItem = null;
            this.suppliersBindingNavigator.BindingSource = this.suppliersBindingSource;
            this.suppliersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.suppliersBindingNavigator.DeleteItem = null;
            this.suppliersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.suppliersBindingNavigatorSaveItem});
            this.suppliersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.suppliersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.suppliersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.suppliersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.suppliersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.suppliersBindingNavigator.Name = "suppliersBindingNavigator";
            this.suppliersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.suppliersBindingNavigator.Size = new System.Drawing.Size(624, 25);
            this.suppliersBindingNavigator.TabIndex = 22;
            this.suppliersBindingNavigator.Text = "bindingNavigator1";
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
            // suppliersBindingNavigatorSaveItem
            // 
            this.suppliersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.suppliersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("suppliersBindingNavigatorSaveItem.Image")));
            this.suppliersBindingNavigatorSaveItem.Name = "suppliersBindingNavigatorSaveItem";
            this.suppliersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.suppliersBindingNavigatorSaveItem.Text = "Save Data";
            this.suppliersBindingNavigatorSaveItem.Click += new System.EventHandler(this.suppliersBindingNavigatorSaveItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(supp_addressLabel);
            this.groupBox1.Controls.Add(this.supp_addressTextBox);
            this.groupBox1.Controls.Add(this.phone_numberTextBox);
            this.groupBox1.Controls.Add(this.suppliers_nameTextBox);
            this.groupBox1.Controls.Add(this.suppliers_idTextBox);
            this.groupBox1.Controls.Add(Supp_phone_numberLabel);
            this.groupBox1.Controls.Add(suppliers_idLabel);
            this.groupBox1.Controls.Add(suppliers_nameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(4, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(327, 154);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إدخال البيانات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // supp_addressTextBox
            // 
            this.supp_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Supp_address", true));
            this.supp_addressTextBox.Location = new System.Drawing.Point(6, 118);
            this.supp_addressTextBox.Multiline = true;
            this.supp_addressTextBox.Name = "supp_addressTextBox";
            this.supp_addressTextBox.Size = new System.Drawing.Size(242, 25);
            this.supp_addressTextBox.TabIndex = 10;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(108, 89);
            this.phone_numberTextBox.Multiline = true;
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(140, 25);
            this.phone_numberTextBox.TabIndex = 8;
            // 
            // suppliers_nameTextBox
            // 
            this.suppliers_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Suppliers_name", true));
            this.suppliers_nameTextBox.Location = new System.Drawing.Point(6, 60);
            this.suppliers_nameTextBox.Multiline = true;
            this.suppliers_nameTextBox.Name = "suppliers_nameTextBox";
            this.suppliers_nameTextBox.Size = new System.Drawing.Size(242, 25);
            this.suppliers_nameTextBox.TabIndex = 7;
            this.suppliers_nameTextBox.TextChanged += new System.EventHandler(this.suppliers_nameTextBox_TextChanged);
            // 
            // suppliers_idTextBox
            // 
            this.suppliers_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Suppliers_id", true));
            this.suppliers_idTextBox.Location = new System.Drawing.Point(148, 31);
            this.suppliers_idTextBox.Multiline = true;
            this.suppliers_idTextBox.Name = "suppliers_idTextBox";
            this.suppliers_idTextBox.Size = new System.Drawing.Size(100, 25);
            this.suppliers_idTextBox.TabIndex = 6;
            // 
            // butt_Delete
            // 
            this.butt_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.butt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_Delete.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.butt_Delete.ForeColor = System.Drawing.Color.White;
            this.butt_Delete.Location = new System.Drawing.Point(522, 420);
            this.butt_Delete.Name = "butt_Delete";
            this.butt_Delete.Size = new System.Drawing.Size(90, 35);
            this.butt_Delete.TabIndex = 20;
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
            this.butt_Update.Location = new System.Drawing.Point(270, 420);
            this.butt_Update.Name = "butt_Update";
            this.butt_Update.Size = new System.Drawing.Size(90, 35);
            this.butt_Update.TabIndex = 19;
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
            this.butt_Add.Location = new System.Drawing.Point(19, 420);
            this.butt_Add.Name = "butt_Add";
            this.butt_Add.Size = new System.Drawing.Size(90, 35);
            this.butt_Add.TabIndex = 18;
            this.butt_Add.Text = "إضافة";
            this.butt_Add.UseVisualStyleBackColor = false;
            this.butt_Add.Click += new System.EventHandler(this.butt_Add_Click);
            // 
            // butt_ٍSerch
            // 
            this.butt_ٍSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.butt_ٍSerch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_ٍSerch.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.butt_ٍSerch.ForeColor = System.Drawing.Color.White;
            this.butt_ٍSerch.Location = new System.Drawing.Point(270, 37);
            this.butt_ٍSerch.Name = "butt_ٍSerch";
            this.butt_ٍSerch.Size = new System.Drawing.Size(56, 25);
            this.butt_ٍSerch.TabIndex = 17;
            this.butt_ٍSerch.Text = "بحث";
            this.butt_ٍSerch.UseVisualStyleBackColor = false;
            this.butt_ٍSerch.Click += new System.EventHandler(this.butt_ٍSerch_Click);
            // 
            // txtBx_ٍSearch
            // 
            this.txtBx_ٍSearch.Location = new System.Drawing.Point(38, 37);
            this.txtBx_ٍSearch.Multiline = true;
            this.txtBx_ٍSearch.Name = "txtBx_ٍSearch";
            this.txtBx_ٍSearch.Size = new System.Drawing.Size(225, 25);
            this.txtBx_ٍSearch.TabIndex = 16;
            this.txtBx_ٍSearch.TextChanged += new System.EventHandler(this.txtBx_ٍSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.pictureBox1.Image = global::Final_Project_TIC_IPI201_C2_F24_eman_117001.Properties.Resources.Searchw;
            this.pictureBox1.Location = new System.Drawing.Point(8, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.suppliersBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butt_Delete);
            this.Controls.Add(this.butt_Update);
            this.Controls.Add(this.butt_Add);
            this.Controls.Add(this.butt_ٍSerch);
            this.Controls.Add(this.txtBx_ٍSearch);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Suppliers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموردين";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingNavigator)).EndInit();
            this.suppliersBindingNavigator.ResumeLayout(false);
            this.suppliersBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_ٍSerch;
        private System.Windows.Forms.TextBox txtBx_ٍSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butt_Delete;
        private System.Windows.Forms.Button butt_Update;
        private System.Windows.Forms.Button butt_Add;
        private System.Windows.Forms.GroupBox groupBox1;
        private DatabasePHDataSet3 databasePHDataSet3;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private DatabasePHDataSet3TableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private DatabasePHDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator suppliersBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton suppliersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox supp_addressTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox suppliers_nameTextBox;
        private System.Windows.Forms.TextBox suppliers_idTextBox;
        private System.Windows.Forms.DataGridView suppliersDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}