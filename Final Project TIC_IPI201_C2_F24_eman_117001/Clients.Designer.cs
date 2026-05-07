namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    partial class Clients
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
            System.Windows.Forms.Label suppliers_idLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.databasePHDataSet6 = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet6();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet6TableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet6TableAdapters.TableAdapterManager();
            this.clientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clients_idTextBox = new System.Windows.Forms.TextBox();
            this.clients_nameTextBox = new System.Windows.Forms.TextBox();
            this.clients_Phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.clients_addressTextBox = new System.Windows.Forms.TextBox();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butt_ٍSerch = new System.Windows.Forms.Button();
            this.txtBx_ٍSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butt_Delete = new System.Windows.Forms.Button();
            this.butt_Update = new System.Windows.Forms.Button();
            this.butt_Add = new System.Windows.Forms.Button();
            suppliers_idLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).BeginInit();
            this.clientsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // suppliers_idLabel
            // 
            suppliers_idLabel.AutoSize = true;
            suppliers_idLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            suppliers_idLabel.ForeColor = System.Drawing.Color.White;
            suppliers_idLabel.Location = new System.Drawing.Point(254, 33);
            suppliers_idLabel.Name = "suppliers_idLabel";
            suppliers_idLabel.Size = new System.Drawing.Size(57, 16);
            suppliers_idLabel.TabIndex = 9;
            suppliers_idLabel.Text = "رمز العميل";
            suppliers_idLabel.Click += new System.EventHandler(this.suppliers_idLabel_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(255, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 16);
            label1.TabIndex = 10;
            label1.Text = "اسم العميل";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(251, 95);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 16);
            label2.TabIndex = 11;
            label2.Text = "رقم الهاتف";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(254, 126);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 16);
            label3.TabIndex = 12;
            label3.Text = "العنوان";
            label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // databasePHDataSet6
            // 
            this.databasePHDataSet6.DataSetName = "DatabasePHDataSet6";
            this.databasePHDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.databasePHDataSet6;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.CompaniesTableAdapter = null;
            this.tableAdapterManager.invoices_DataTableAdapter = null;
            this.tableAdapterManager.Purchase_invoicesTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // clientsBindingNavigator
            // 
            this.clientsBindingNavigator.AddNewItem = null;
            this.clientsBindingNavigator.BindingSource = this.clientsBindingSource;
            this.clientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientsBindingNavigator.DeleteItem = null;
            this.clientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.clientsBindingNavigatorSaveItem});
            this.clientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientsBindingNavigator.Name = "clientsBindingNavigator";
            this.clientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientsBindingNavigator.Size = new System.Drawing.Size(611, 25);
            this.clientsBindingNavigator.TabIndex = 0;
            this.clientsBindingNavigator.Text = "bindingNavigator1";
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
            // clientsBindingNavigatorSaveItem
            // 
            this.clientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsBindingNavigatorSaveItem.Image")));
            this.clientsBindingNavigatorSaveItem.Name = "clientsBindingNavigatorSaveItem";
            this.clientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clientsBindingNavigatorSaveItem.Text = "Save Data";
            this.clientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientsBindingNavigatorSaveItem_Click);
            // 
            // clients_idTextBox
            // 
            this.clients_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "clients_id", true));
            this.clients_idTextBox.Location = new System.Drawing.Point(140, 24);
            this.clients_idTextBox.Multiline = true;
            this.clients_idTextBox.Name = "clients_idTextBox";
            this.clients_idTextBox.Size = new System.Drawing.Size(108, 25);
            this.clients_idTextBox.TabIndex = 2;
            this.clients_idTextBox.TextChanged += new System.EventHandler(this.clients_idTextBox_TextChanged);
            // 
            // clients_nameTextBox
            // 
            this.clients_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "clients_name", true));
            this.clients_nameTextBox.Location = new System.Drawing.Point(6, 55);
            this.clients_nameTextBox.Multiline = true;
            this.clients_nameTextBox.Name = "clients_nameTextBox";
            this.clients_nameTextBox.Size = new System.Drawing.Size(242, 25);
            this.clients_nameTextBox.TabIndex = 4;
            this.clients_nameTextBox.TextChanged += new System.EventHandler(this.clients_nameTextBox_TextChanged);
            // 
            // clients_Phone_numberTextBox
            // 
            this.clients_Phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "clients_Phone_number", true));
            this.clients_Phone_numberTextBox.Location = new System.Drawing.Point(105, 86);
            this.clients_Phone_numberTextBox.Multiline = true;
            this.clients_Phone_numberTextBox.Name = "clients_Phone_numberTextBox";
            this.clients_Phone_numberTextBox.Size = new System.Drawing.Size(140, 25);
            this.clients_Phone_numberTextBox.TabIndex = 6;
            this.clients_Phone_numberTextBox.TextChanged += new System.EventHandler(this.clients_Phone_numberTextBox_TextChanged);
            // 
            // clients_addressTextBox
            // 
            this.clients_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "clients_address", true));
            this.clients_addressTextBox.Location = new System.Drawing.Point(3, 117);
            this.clients_addressTextBox.Multiline = true;
            this.clients_addressTextBox.Name = "clients_addressTextBox";
            this.clients_addressTextBox.Size = new System.Drawing.Size(242, 25);
            this.clients_addressTextBox.TabIndex = 8;
            this.clients_addressTextBox.TextChanged += new System.EventHandler(this.clients_addressTextBox_TextChanged);
            // 
            // clientsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.clientsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(6, 19);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(577, 102);
            this.clientsDataGridView.TabIndex = 9;
            this.clientsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "clients_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "رمز العميل";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "clients_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم العميل";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "clients_Phone_number";
            this.dataGridViewTextBoxColumn3.HeaderText = "رقم الهاتف";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "clients_address";
            this.dataGridViewTextBoxColumn4.HeaderText = "العنوان";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(suppliers_idLabel);
            this.groupBox1.Controls.Add(this.clients_idTextBox);
            this.groupBox1.Controls.Add(this.clients_nameTextBox);
            this.groupBox1.Controls.Add(this.clients_addressTextBox);
            this.groupBox1.Controls.Add(this.clients_Phone_numberTextBox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 153);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إدخال البيانات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clientsDataGridView);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 127);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عرض البيانات";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // butt_ٍSerch
            // 
            this.butt_ٍSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.butt_ٍSerch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_ٍSerch.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.butt_ٍSerch.ForeColor = System.Drawing.Color.White;
            this.butt_ٍSerch.Location = new System.Drawing.Point(271, 37);
            this.butt_ٍSerch.Name = "butt_ٍSerch";
            this.butt_ٍSerch.Size = new System.Drawing.Size(56, 25);
            this.butt_ٍSerch.TabIndex = 20;
            this.butt_ٍSerch.Text = "بحث";
            this.butt_ٍSerch.UseVisualStyleBackColor = false;
            this.butt_ٍSerch.Click += new System.EventHandler(this.butt_ٍSerch_Click);
            // 
            // txtBx_ٍSearch
            // 
            this.txtBx_ٍSearch.Location = new System.Drawing.Point(39, 37);
            this.txtBx_ٍSearch.Multiline = true;
            this.txtBx_ٍSearch.Name = "txtBx_ٍSearch";
            this.txtBx_ٍSearch.Size = new System.Drawing.Size(225, 25);
            this.txtBx_ٍSearch.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.pictureBox1.Image = global::Final_Project_TIC_IPI201_C2_F24_eman_117001.Properties.Resources.Searchw;
            this.pictureBox1.Location = new System.Drawing.Point(9, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // butt_Delete
            // 
            this.butt_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.butt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_Delete.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.butt_Delete.ForeColor = System.Drawing.Color.White;
            this.butt_Delete.Location = new System.Drawing.Point(509, 400);
            this.butt_Delete.Name = "butt_Delete";
            this.butt_Delete.Size = new System.Drawing.Size(90, 35);
            this.butt_Delete.TabIndex = 23;
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
            this.butt_Update.Location = new System.Drawing.Point(271, 400);
            this.butt_Update.Name = "butt_Update";
            this.butt_Update.Size = new System.Drawing.Size(90, 35);
            this.butt_Update.TabIndex = 22;
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
            this.butt_Add.Location = new System.Drawing.Point(9, 400);
            this.butt_Add.Name = "butt_Add";
            this.butt_Add.Size = new System.Drawing.Size(90, 35);
            this.butt_Add.TabIndex = 21;
            this.butt_Add.Text = "إضافة";
            this.butt_Add.UseVisualStyleBackColor = false;
            this.butt_Add.Click += new System.EventHandler(this.butt_Add_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(611, 439);
            this.Controls.Add(this.butt_Delete);
            this.Controls.Add(this.butt_Update);
            this.Controls.Add(this.butt_Add);
            this.Controls.Add(this.butt_ٍSerch);
            this.Controls.Add(this.txtBx_ٍSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clientsBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "Clients";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العملاء";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).EndInit();
            this.clientsBindingNavigator.ResumeLayout(false);
            this.clientsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabasePHDataSet6 databasePHDataSet6;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private DatabasePHDataSet6TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private DatabasePHDataSet6TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox clients_idTextBox;
        private System.Windows.Forms.TextBox clients_nameTextBox;
        private System.Windows.Forms.TextBox clients_Phone_numberTextBox;
        private System.Windows.Forms.TextBox clients_addressTextBox;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butt_ٍSerch;
        private System.Windows.Forms.TextBox txtBx_ٍSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button butt_Delete;
        private System.Windows.Forms.Button butt_Update;
        private System.Windows.Forms.Button butt_Add;
    }
}