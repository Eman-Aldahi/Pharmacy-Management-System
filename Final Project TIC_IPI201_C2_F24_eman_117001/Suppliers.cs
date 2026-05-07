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
    public partial class Suppliers : Class_Base
    {
        public Suppliers()
        {
            InitializeComponent();
        }
        private void Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePHDataSet3.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.databasePHDataSet3.Suppliers);
            TextBox_Clear();
            GetNextID("suppliers", "suppliers_id", suppliers_idTextBox);
            suppliersDataGridView.ForeColor = Color.Black;
        }
        private void TextBox_Clear()
        {
            txtBx_ٍSearch.Clear();
            suppliers_nameTextBox.Clear();
            phone_numberTextBox.Clear();
            supp_addressTextBox.Clear();
        }
        private void butt_ٍSerch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * FROM Suppliers 
                         WHERE Suppliers_name LIKE @search 
                         OR Suppliers_id LIKE @search";

                SqlCommand com = Connect_DB(query);// From theClass_Base
                com.Parameters.AddWithValue("@search", "%" + txtBx_ٍSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                suppliersBindingSource.DataSource = dt;
                suppliersDataGridView.DataSource = suppliersBindingSource;
                Close_DB();// From theClass_Base
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message);
            }
        }

        private void txtBx_ٍSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
      

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePHDataSet3);

        }

        private void suppliers_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void suppliers_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void company_phone_numberLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void butt_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(suppliers_nameTextBox.Text))
            {
                MessageBox.Show("يرجى إدخال اسم المورد أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                suppliers_nameTextBox.Focus();
                return; // الخروج من الدالة ومنع الإضافة
            }
            try
            {
                string query = @"Insert into suppliers(Suppliers_name, Phone_number,Supp_address) values (@name,@phone_number,@address)";
                SqlCommand com = Connect_DB(query); // From theClass_Base
                com.Parameters.AddWithValue("@name", suppliers_nameTextBox.Text);
                com.Parameters.AddWithValue("@phone_number", phone_numberTextBox.Text);
                com.Parameters.AddWithValue("@address", supp_addressTextBox.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("تم الإضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid("suppliers", suppliersDataGridView, suppliersBindingSource); // From theClass_Base
                Close_DB();// From theClass_Base
                TextBox_Clear();
                GetNextID("suppliers", "suppliers_id", suppliers_idTextBox);// From theClass_Base
            }
            catch (SqlException ex)
            {
                IsUniqueConstraintError(ex, "الإضافة");
            }
        }

        private void butt_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"UPDATE suppliers SET suppliers_name = ISNULL(NULLIF(@name,''), suppliers_name),
                               Phone_number = ISNULL(NULLIF(@phone_number,''),Phone_number),
                               supp_address = ISNULL(NULLIF(@address,''),supp_address)
                               WHERE suppliers_id = @id";
                SqlCommand com = Connect_DB(query);// From theClass_Base
                com.Parameters.AddWithValue("@name", suppliers_nameTextBox.Text);
                com.Parameters.AddWithValue("@phone_number", phone_numberTextBox.Text);
                com.Parameters.AddWithValue("@id", int.Parse(suppliers_idTextBox.Text));
                com.Parameters.AddWithValue("@address", supp_addressTextBox.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid("suppliers", suppliersDataGridView, suppliersBindingSource);// From theClass_Base
                Close_DB();// From theClass_Base
                TextBox_Clear();
                GetNextID("suppliers", "suppliers_id", suppliers_idTextBox);// From theClass_Base
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
                string quray = @"delete from Suppliers where Suppliers_id = @id";
                SqlCommand com = Connect_DB(quray);// From theClass_Base
                com.Parameters.AddWithValue("@id", int.Parse(suppliers_idTextBox.Text));
                com.ExecuteNonQuery();
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid("suppliers", suppliersDataGridView, suppliersBindingSource);// From theClass_Base
                Close_DB();// From theClass_Base
                TextBox_Clear();
                GetNextID("suppliers", "suppliers_id", suppliers_idTextBox);// From theClass_Base
            }
            catch (Exception ex)
            {
                // هذا السطر لعرض الخطأ إذا حدث توقف
                MessageBox.Show("حدث خطأ أثناء الحذف: " + ex.Message);
            }
        }

        private void suppliersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void suppliers_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

 
    }
}
