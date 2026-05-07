namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    partial class Categories
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
            System.Windows.Forms.Label categories_idLabel;
            System.Windows.Forms.Label categories_nameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasePHDataSet3 = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet3();
            this.categoriesTableAdapter = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet3TableAdapters.CategoriesTableAdapter();
            this.tableAdapterManager = new Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet3TableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categories_nameTextBox = new System.Windows.Forms.TextBox();
            this.categories_idTextBox = new System.Windows.Forms.TextBox();
            this.butt_Delete = new System.Windows.Forms.Button();
            this.butt_Update = new System.Windows.Forms.Button();
            this.butt_Add = new System.Windows.Forms.Button();
            this.butt_ٍSerch = new System.Windows.Forms.Button();
            this.txtBx_ٍSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            categories_idLabel = new System.Windows.Forms.Label();
            categories_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingNavigator)).BeginInit();
            this.categoriesBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // categories_idLabel
            // 
            categories_idLabel.AutoSize = true;
            categories_idLabel.Location = new System.Drawing.Point(139, 29);
            categories_idLabel.Name = "categories_idLabel";
            categories_idLabel.Size = new System.Drawing.Size(70, 16);
            categories_idLabel.TabIndex = 1;
            categories_idLabel.Text = "رمز التصنيف";
            // 
            // categories_nameLabel
            // 
            categories_nameLabel.AutoSize = true;
            categories_nameLabel.Location = new System.Drawing.Point(139, 58);
            categories_nameLabel.Name = "categories_nameLabel";
            categories_nameLabel.Size = new System.Drawing.Size(69, 16);
            categories_nameLabel.TabIndex = 3;
            categories_nameLabel.Text = "اسم التصنيف";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.databasePHDataSet3;
            // 
            // databasePHDataSet3
            // 
            this.databasePHDataSet3.DataSetName = "DatabasePHDataSet3";
            this.databasePHDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager.CompaniesTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Final_Project_TIC_IPI201_C2_F24_eman_117001.DatabasePHDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.categoriesDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 151);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عرض البيانات";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // categoriesDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.categoriesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.categoriesDataGridView.AutoGenerateColumns = false;
            this.categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.categoriesDataGridView.DataSource = this.categoriesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoriesDataGridView.Location = new System.Drawing.Point(6, 22);
            this.categoriesDataGridView.Name = "categoriesDataGridView";
            this.categoriesDataGridView.Size = new System.Drawing.Size(345, 116);
            this.categoriesDataGridView.TabIndex = 28;
            this.categoriesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoriesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Categories_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "رمز التصنيف";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Categories_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "اسم التصنيف";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // categoriesBindingNavigator
            // 
            this.categoriesBindingNavigator.AddNewItem = null;
            this.categoriesBindingNavigator.BindingSource = this.categoriesBindingSource;
            this.categoriesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoriesBindingNavigator.DeleteItem = null;
            this.categoriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.categoriesBindingNavigatorSaveItem});
            this.categoriesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoriesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoriesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoriesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoriesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoriesBindingNavigator.Name = "categoriesBindingNavigator";
            this.categoriesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoriesBindingNavigator.Size = new System.Drawing.Size(371, 25);
            this.categoriesBindingNavigator.TabIndex = 28;
            this.categoriesBindingNavigator.Text = "bindingNavigator1";
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
            // categoriesBindingNavigatorSaveItem
            // 
            this.categoriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoriesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriesBindingNavigatorSaveItem.Image")));
            this.categoriesBindingNavigatorSaveItem.Name = "categoriesBindingNavigatorSaveItem";
            this.categoriesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.categoriesBindingNavigatorSaveItem.Text = "Save Data";
            this.categoriesBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriesBindingNavigatorSaveItem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categories_nameTextBox);
            this.groupBox1.Controls.Add(this.categories_idTextBox);
            this.groupBox1.Controls.Add(categories_idLabel);
            this.groupBox1.Controls.Add(categories_nameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(4, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(214, 89);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إدخال البيانات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // categories_nameTextBox
            // 
            this.categories_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "Categories_name", true));
            this.categories_nameTextBox.Location = new System.Drawing.Point(6, 51);
            this.categories_nameTextBox.Multiline = true;
            this.categories_nameTextBox.Name = "categories_nameTextBox";
            this.categories_nameTextBox.Size = new System.Drawing.Size(127, 25);
            this.categories_nameTextBox.TabIndex = 5;
            this.categories_nameTextBox.TextChanged += new System.EventHandler(this.categories_nameTextBox_TextChanged);
            // 
            // categories_idTextBox
            // 
            this.categories_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "Categories_id", true));
            this.categories_idTextBox.Location = new System.Drawing.Point(33, 22);
            this.categories_idTextBox.Multiline = true;
            this.categories_idTextBox.Name = "categories_idTextBox";
            this.categories_idTextBox.Size = new System.Drawing.Size(100, 25);
            this.categories_idTextBox.TabIndex = 4;
            // 
            // butt_Delete
            // 
            this.butt_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.butt_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_Delete.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.butt_Delete.ForeColor = System.Drawing.Color.White;
            this.butt_Delete.Location = new System.Drawing.Point(277, 316);
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
            this.butt_Update.Location = new System.Drawing.Point(145, 316);
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
            this.butt_Add.Location = new System.Drawing.Point(4, 316);
            this.butt_Add.Name = "butt_Add";
            this.butt_Add.Size = new System.Drawing.Size(90, 35);
            this.butt_Add.TabIndex = 24;
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
            this.butt_ٍSerch.Location = new System.Drawing.Point(210, 35);
            this.butt_ٍSerch.Name = "butt_ٍSerch";
            this.butt_ٍSerch.Size = new System.Drawing.Size(56, 23);
            this.butt_ٍSerch.TabIndex = 23;
            this.butt_ٍSerch.Text = "بحث";
            this.butt_ٍSerch.UseVisualStyleBackColor = false;
            this.butt_ٍSerch.Click += new System.EventHandler(this.butt_ٍSerch_Click);
            // 
            // txtBx_ٍSearch
            // 
            this.txtBx_ٍSearch.Location = new System.Drawing.Point(34, 35);
            this.txtBx_ٍSearch.Multiline = true;
            this.txtBx_ٍSearch.Name = "txtBx_ٍSearch";
            this.txtBx_ٍSearch.Size = new System.Drawing.Size(170, 23);
            this.txtBx_ٍSearch.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.pictureBox1.Image = global::Final_Project_TIC_IPI201_C2_F24_eman_117001.Properties.Resources.Searchw;
            this.pictureBox1.Location = new System.Drawing.Point(4, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(371, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.categoriesBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butt_Delete);
            this.Controls.Add(this.butt_Update);
            this.Controls.Add(this.butt_Add);
            this.Controls.Add(this.butt_ٍSerch);
            this.Controls.Add(this.txtBx_ٍSearch);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Categories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تصنيفات الأدوية";
            this.Load += new System.EventHandler(this.Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasePHDataSet3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingNavigator)).EndInit();
            this.categoriesBindingNavigator.ResumeLayout(false);
            this.categoriesBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_Delete;
        private System.Windows.Forms.Button butt_Update;
        private System.Windows.Forms.Button butt_Add;
        private System.Windows.Forms.Button butt_ٍSerch;
        private System.Windows.Forms.TextBox txtBx_ٍSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DatabasePHDataSet3 databasePHDataSet3;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private DatabasePHDataSet3TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DatabasePHDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoriesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton categoriesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox categories_nameTextBox;
        private System.Windows.Forms.TextBox categories_idTextBox;
        private System.Windows.Forms.DataGridView categoriesDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

    }
}