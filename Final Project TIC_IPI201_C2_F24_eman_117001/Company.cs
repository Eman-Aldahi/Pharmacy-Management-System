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
    public partial class Company : Class_Base
    {
        public Company()
        {
            InitializeComponent();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'databasePHDataSet2.Companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.databasePHDataSet2.Companies);
            TextBox_Clear();
            GetNextID("Companies","Company_id",company_idTextBox);
            companiesDataGridView.ForeColor = Color.Black;

        }
        //دالة لمسح الحقول
        private void TextBox_Clear()
        {
            txtBx_ٍSearch.Clear();
            company_nameTextBox.Clear();
            company_phone_numberTextBox.Clear();
        }
        private void companiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            this.Validate();
            this.companiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePHDataSet2);

        }

        private void company_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void companiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
         
        }

        private void butt_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(company_nameTextBox.Text))
            {
                MessageBox.Show("يرجى إدخال اسم الشركة أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                company_nameTextBox.Focus();
                return; // التوقف عن التنفيذ وعدم الانتقال للكود بالأسفل
            }
            try
            {
               string query = @"Insert into Companies(Company_name, Company_Phone_number) values (@name,@phone_number)";
                SqlCommand com = Connect_DB(query); // From theClass_Base
                com.Parameters.AddWithValue("@name",company_nameTextBox.Text);
                com.Parameters.AddWithValue("@phone_number", company_phone_numberTextBox.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("تم الإضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid("Companies", companiesDataGridView, companiesBindingSource); // From theClass_Base
                Close_DB();// From theClass_Base
                TextBox_Clear();
                GetNextID("Companies", "Company_id", company_idTextBox);// From theClass_Base
            }
            catch (SqlException ex)
            {
                IsUniqueConstraintError(ex,"الإضافة");
            }
        }

        private void butt_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"UPDATE Companies SET Company_name = ISNULL(NULLIF(@name,''), Company_name),Company_Phone_number = ISNULL(NULLIF(@phone_number,''), Company_Phone_number) WHERE Company_id = @id";
                SqlCommand com = Connect_DB(query);// From theClass_Base
                com.Parameters.AddWithValue("@name", company_nameTextBox.Text);
                com.Parameters.AddWithValue("@phone_number", company_phone_numberTextBox.Text);
                com.Parameters.AddWithValue("@id",int.Parse(company_idTextBox.Text));
                com.ExecuteNonQuery(); 
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid("Companies", companiesDataGridView, companiesBindingSource);// From theClass_Base
                Close_DB();// From theClass_Base
                TextBox_Clear();
                GetNextID("Companies", "Company_id", company_idTextBox);// From theClass_Base
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
                string quray = @"delete from Companies where Company_id = @id";
                SqlCommand com = Connect_DB(quray);// From theClass_Base
                com.Parameters.AddWithValue("@id", int.Parse(company_idTextBox.Text));
                com.ExecuteNonQuery();
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid("Companies", companiesDataGridView, companiesBindingSource); // From theClass_Base
                Close_DB();// From theClass_Base
                TextBox_Clear();
                GetNextID("Companies", "Company_id", company_idTextBox);// From theClass_Base
            }
             catch (Exception ex)
            {
                // هذا السطر لعرض الخطأ إذا حدث توقف
                MessageBox.Show("حدث خطأ أثناء الحذف: " + ex.Message);
            }
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void butt_ٍSerch_Click(object sender, EventArgs e)
        {
    try
    {
        string query = @"SELECT * FROM Companies 
                         WHERE Company_name LIKE @search 
                         OR Company_id LIKE @search";

        SqlCommand com = Connect_DB(query);// From theClass_Base
        com.Parameters.AddWithValue("@search", "%" + txtBx_ٍSearch.Text + "%");
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        companiesBindingSource.DataSource = dt;
        companiesDataGridView.DataSource = companiesBindingSource;
        Close_DB();// From theClass_Base
        
    }
    catch (Exception ex)
    {
        MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message);
    }
}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void company_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void company_phone_numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        }


    }

