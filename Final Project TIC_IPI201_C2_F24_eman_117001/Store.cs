using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    public partial class Store : Class_Base
    {
        string Query = @"SELECT S.store_id as [رمز الدواء], S.medicine_name  as [اسم الدواء], C.Categories_name as [اسم التصنيف], 
                       S.Barcode as [الباركود],S.Purchase_Price as [سعر الشراء] ,S.Selling_Price as [سعر البيع],
                       S.Quantity as [الكمية],S.Expiration_date as [تاريخ انتهاء الصلاحية],S.Stock_storage as[مكان التخزين]
                       from Store S LEFT JOIN Categories C on S.Categories_id_St = C.Categories_id ";
        public Store()
        {
            InitializeComponent();
        }

        private void storeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePHDataSet3);

        }

       
        private void Store_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePHDataSet4.Store' table. You can move, or remove it, as needed.
           // this.storeTableAdapter1.Fill(this.databasePHDataSet4.Store);
            // TODO: This line of code loads data into the 'databasePHDataSet3.Store' table. You can move, or remove it, as needed.
           // this.storeTableAdapter.Fill(this.databasePHDataSet3.Store);
            RefreshGrid_Join(Query, dataGridView1, storeBindingSource); // From theClass_Base 
            GetNextID("Store", "store_id", store_idTextBox);// From theClass_Base
            Combo_box("Categories", "Categories_name", "Categories_id",categories_id_StComboBox);//class_Base
            expiration_dateDateTimePicker.Format = DateTimePickerFormat.Custom;
            expiration_dateDateTimePicker.CustomFormat = "yyyy/MM/dd";
            dataGridView1.ForeColor = Color.Black;
            TextBox_Clear();
        }
        private void TextBox_Clear()
        {   
            txtBx_ٍSearch.Clear();
            medicine_nameTextBox.Clear();
            barcodeTextBox.Clear();
            purchase_PriceTextBox.Clear();
            selling_PriceTextBox.Clear();
            quantityTextBox.Clear();
            stock_storageTextBox.Clear();
            categories_id_StComboBox.SelectedIndex = -1;
        }
        private void butt_Add_Click(object sender, EventArgs e)
        {
       //  التحقق من الحقول الإلزامية قبل البدء لتجنب توقف البرنامج
    if (string.IsNullOrWhiteSpace(medicine_nameTextBox.Text) || 
        string.IsNullOrWhiteSpace(purchase_PriceTextBox.Text) || 
        string.IsNullOrWhiteSpace(selling_PriceTextBox.Text) || 
        string.IsNullOrWhiteSpace(quantityTextBox.Text))
    {
        MessageBox.Show("يرجى ملء جميع الحقول المطلوبة (الاسم، الأسعار، والكمية)", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return; // الخروج من الدالة وعدم تنفيذ الكود بالأسفل
    }

    try
    {
        decimal purchasePrice, sellingPrice;
        int quantity;

        if (!decimal.TryParse(purchase_PriceTextBox.Text, out purchasePrice) ||
            !decimal.TryParse(selling_PriceTextBox.Text, out sellingPrice) ||
            !int.TryParse(quantityTextBox.Text, out quantity))
        {
            MessageBox.Show("يرجى التأكد من إدخال أرقام صحيحة في خانات الأسعار والكمية", "خطأ في البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string query = @"Insert into Store(medicine_name, Barcode, Purchase_Price, Selling_Price, Quantity, 
                         Expiration_date, Stock_storage, Categories_id_St) 
                         values (@medicine, @code, @Pu, @Sel, @Qu, @exp, @storage, @Cat)";

        SqlCommand com = Connect_DB(query);

        com.Parameters.AddWithValue("@medicine", medicine_nameTextBox.Text);
        com.Parameters.AddWithValue("@code", string.IsNullOrEmpty(barcodeTextBox.Text) ? (object)DBNull.Value : barcodeTextBox.Text);
        com.Parameters.AddWithValue("@Pu", purchasePrice);
        com.Parameters.AddWithValue("@Sel", sellingPrice);
        com.Parameters.AddWithValue("@Qu", quantity);
        com.Parameters.AddWithValue("@exp", expiration_dateDateTimePicker.Value);
        com.Parameters.AddWithValue("@storage", stock_storageTextBox.Text ?? "");
        com.Parameters.AddWithValue("@Cat", categories_id_StComboBox.SelectedValue ?? DBNull.Value);

        com.ExecuteNonQuery();
        
        MessageBox.Show("تم الإضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        RefreshGrid_Join(Query, dataGridView1, storeBindingSource);
        Close_DB();
        TextBox_Clear();
        GetNextID("Store", "store_id", store_idTextBox);
    }
    catch (SqlException ex)
    {
        IsUniqueConstraintError(ex, "الإضافة");
    }
    catch (Exception ex)
    {
        MessageBox.Show("حدث خطأ غير متوقع: " + ex.Message);
    }
        }

        private void butt_Update_Click(object sender, EventArgs e)
        {
            try
              {
                 string query = @"UPDATE Store SET medicine_name = ISNULL(NULLIF(@medicine,''), medicine_name),Barcode = ISNULL(NULLIF(@code,''),Barcode),
                                 Purchase_Price = ISNULL(NULLIF(@Pu,''), Purchase_Price),Selling_Price = ISNULL(NULLIF(@Sel,''), Selling_Price),
                                 Quantity = ISNULL(NULLIF(@Qu,''), Quantity),Expiration_date = ISNULL(NULLIF(@exp,''),Expiration_date),
                                 Stock_storage = ISNULL(NULLIF(@storage,''), Stock_storage),Categories_id_St = ISNULL(NULLIF(@Cat,''), Categories_id_St)
                                 WHERE store_id = @id";
                 SqlCommand com = Connect_DB(query);// From theClass_Base
                 int id, pu, sel, qu;
                 int.TryParse(store_idTextBox.Text, out id);
                 int.TryParse(purchase_PriceTextBox.Text,out pu);
                 int.TryParse(purchase_PriceTextBox.Text,out sel);
                 int.TryParse(purchase_PriceTextBox.Text,out qu);
                 com.Parameters.AddWithValue("@id", id);
                 com.Parameters.AddWithValue("@medicine", medicine_nameTextBox.Text);
                 com.Parameters.AddWithValue("@code", barcodeTextBox.Text);
                 com.Parameters.AddWithValue("@Pu", pu);
                 com.Parameters.AddWithValue("@Sel", sel);
                 com.Parameters.AddWithValue("@Qu", qu);
                 com.Parameters.AddWithValue("@exp", expiration_dateDateTimePicker.Value);
                 com.Parameters.AddWithValue("@storage", stock_storageTextBox.Text);
                 com.Parameters.AddWithValue("@Cat", categories_id_StComboBox.SelectedValue);
                 com.ExecuteNonQuery();
                  MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  RefreshGrid_Join(Query, dataGridView1, storeBindingSource);
                  Close_DB();// From theClass_Base
                  TextBox_Clear();
                  GetNextID("Store", "store_id", store_idTextBox);// From theClass_Base
              }
              catch (SqlException ex)
              {
                  IsUniqueConstraintError(ex, "التعديل");
              }
        }

        private void butt_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string quray = @"delete from Store where store_id = @id";
                SqlCommand com = Connect_DB(quray);// From theClass_Base
                com.Parameters.AddWithValue("@id", int.Parse(store_idTextBox.Text));
                com.ExecuteNonQuery();
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid_Join(Query, dataGridView1, storeBindingSource);
                Close_DB();// From theClass_Base
                TextBox_Clear();
                GetNextID("Store", "store_id", store_idTextBox);// From theClass_Base
            }
            catch (Exception ex)
            {
                // هذا السطر لعرض الخطأ إذا حدث توقف
                MessageBox.Show("حدث خطأ أثناء الحذف: " + ex.Message);
            }

        }

        private void butt_ٍSerch_Click(object sender, EventArgs e)
        {
            try
            {
                string Query1 = @"SELECT S.store_id as [رمز الدواء], S.medicine_name as [اسم الدواء], C.Categories_name as [اسم التصنيف], 
                       S.Barcode as [الباركود], S.Purchase_Price as [سعر الشراء], S.Selling_Price as [سعر البيع],
                       S.Quantity as [الكمية], S.Expiration_date as [تاريخ انتهاء الصلاحية], S.Stock_storage as [مكان التخزين],
                       S.Categories_id_St -- جلب المعرف المخفي لضبط الـ ComboBox
                       from Store S LEFT JOIN Categories C on S.Categories_id_St = C.Categories_id
                       WHERE S.medicine_name LIKE @search OR S.store_id LIKE @search";

                SqlCommand com = Connect_DB(Query1);
                com.Parameters.AddWithValue("@search", "%" + txtBx_ٍSearch.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                storeBindingSource.DataSource = dt;
                dataGridView1.DataSource = storeBindingSource;
                Close_DB();

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                    // تعبئة العناصر باستخدام الأسماء العربية المستعارة في الاستعلام
                    store_idTextBox.Text = dr["رمز الدواء"].ToString();
                    medicine_nameTextBox.Text = dr["اسم الدواء"].ToString();
                    barcodeTextBox.Text = dr["الباركود"].ToString();
                    purchase_PriceTextBox.Text = dr["سعر الشراء"].ToString();
                    selling_PriceTextBox.Text = dr["سعر البيع"].ToString();
                    quantityTextBox.Text = dr["الكمية"].ToString();
                    expiration_dateDateTimePicker.Value = Convert.ToDateTime(dr["تاريخ انتهاء الصلاحية"]);
                    stock_storageTextBox.Text = dr["مكان التخزين"].ToString();
                    if (dr["Categories_id_St"] != DBNull.Value)
                    {
                        categories_id_StComboBox.SelectedValue = dr["Categories_id_St"];
                    }
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على نتائج مطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void selling_PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void stock_storageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void expiration_dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void expiration_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void quantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stock_storageLabel_Click(object sender, EventArgs e)
        {

        }

        private void selling_PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void purchase_PriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void purchase_PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void barcodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void medicine_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void store_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categories_name_StComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void company_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void storeBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void storeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void company_id_stLabel_Click(object sender, EventArgs e)
        {

        }

        private void company_id_stComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void medicine_nameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void barcodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void barcodeTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void purchase_PriceTextBox_TextChanged_1(object sender, EventArgs e)
        {
            // فحص إذا كان صندوق سعر الشراء يحتوي على نص
            if (!string.IsNullOrWhiteSpace(purchase_PriceTextBox.Text))
            {
                decimal val_Purchase = 0;
                // التحويل بشكل آمن تماماً باستخدام متغير مؤقت جديد
                if (decimal.TryParse(purchase_PriceTextBox.Text, out val_Purchase))
                {
                    // حساب سعر البيع سعر الشراء + 10%
                    decimal val_Selling = val_Purchase * 1.10m;

                    // عرض النتيجة فوراً في صندوق سعر البيع
                    selling_PriceTextBox.Text = val_Selling.ToString("0.00");
                }
            }
            else
            {
                // إذا مسح المستخدم سعر الشراء، يفرغ سعر البيع تلقائياً
                selling_PriceTextBox.Text = string.Empty;
            }
        }

        private void selling_PriceLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void selling_PriceTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void store_idTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void expiration_dateDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void stock_storageTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void suppliers_id_stComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categories_id_StComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void storeDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void storeDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

      

        

       
    }
}
