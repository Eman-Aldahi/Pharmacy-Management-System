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
    public partial class Categories : Class_Base
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePHDataSet3);

        }

        private void categoriesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePHDataSet3);

        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePHDataSet3.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.databasePHDataSet3.Categories);
            TextBox_Clear();
            GetNextID("Categories", "Categories_id", categories_idTextBox);
            categoriesDataGridView.ForeColor = Color.Black;

        }
        //ددالة لمسح الحقول
        private void TextBox_Clear()
        {
            txtBx_ٍSearch.Clear();
            categories_idTextBox.Clear();
            categories_nameTextBox.Clear();
        }

        private void suppliersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoriesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butt_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"UPDATE Categories SET Categories_name = ISNULL(NULLIF(@name_Cat,''), Categories_name) WHERE Categories_id = @id";
                SqlCommand com = Connect_DB(query);// From theClass_Base
                com.Parameters.AddWithValue("@name_Cat", categories_nameTextBox.Text);
                com.Parameters.AddWithValue("@id", int.Parse(categories_idTextBox.Text));
                com.ExecuteNonQuery();
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid("Categories", categoriesDataGridView, categoriesBindingSource); // From theClass_Base
                Close_DB();// From theClass_Base
                TextBox_Clear();
                GetNextID("Categories", "Categories_id", categories_idTextBox);// From theClass_Base
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
                string quray = @"delete from Categories where Categories_id = @id";
                SqlCommand com = Connect_DB(quray);// From theClass_Base
                com.Parameters.AddWithValue("@id", int.Parse(categories_idTextBox.Text));
                com.ExecuteNonQuery();
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid("Categories", categoriesDataGridView, categoriesBindingSource); // From theClass_Base
                Close_DB();// From theClass_Base
                TextBox_Clear();
                GetNextID("Categories", "Categories_id", categories_idTextBox);// From theClass_Base
            }
            catch (Exception ex)
            {
                // هذا السطر لعرض الخطأ إذا حدث توقف
                MessageBox.Show("حدث خطأ أثناء الحذف: " + ex.Message);
            }
           
        }

        private void butt_Add_Click(object sender, EventArgs e)
        {
            // 1. التحقق من أن حقل الاسم ليس فارغاً أو يحتوي على مسافات 
            if (string.IsNullOrWhiteSpace(categories_nameTextBox.Text))
            {
                MessageBox.Show("يرجى إدخال اسم التصنيف أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                categories_nameTextBox.Focus(); // وضع المؤشر داخل الحقل للتسهيل على المستخدم
                return; // الخروج من الدالة ومنع إكمال عملية الإضافة
            }

            try
            {
                string query = @"Insert into Categories(Categories_name) values (@name_Cat)";
                SqlCommand com = Connect_DB(query); // From theClass_Base

                com.Parameters.AddWithValue("@name_Cat", categories_nameTextBox.Text.Trim()); // استخدام Trim لإزالة المسافات الزائدة

                com.ExecuteNonQuery();
                MessageBox.Show("تم الإضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshGrid("Categories", categoriesDataGridView, categoriesBindingSource); // From theClass_Base
                Close_DB();// From theClass_Base
                TextBox_Clear();
                GetNextID("Categories", "Categories_id", categories_idTextBox);// From theClass_Base
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

        private void butt_ٍSerch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * FROM Categories 
                         WHERE Categories_name LIKE @search 
                         OR Categories_id LIKE @search";

                SqlCommand com = Connect_DB(query);// From theClass_Base
                com.Parameters.AddWithValue("@search", "%" + txtBx_ٍSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                categoriesBindingSource.DataSource = dt;
                categoriesDataGridView.DataSource = categoriesBindingSource;
                Close_DB();// From theClass_Base
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void categories_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
