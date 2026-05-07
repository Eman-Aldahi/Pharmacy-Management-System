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
    public partial class Clients : Class_Base
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePHDataSet6);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePHDataSet6.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.databasePHDataSet6.Clients);
            clientsDataGridView.ForeColor = Color.Black;
            TextBox_Clear();
            GetNextID("Clients", "clients_id", clients_idTextBox);// From theClass_Base

        }
             private void TextBox_Clear()
        {
            txtBx_ٍSearch.Clear();
            clients_nameTextBox.Clear();
            clients_Phone_numberTextBox.Clear();
            clients_addressTextBox.Clear();
        }   
        private void butt_ٍSerch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * FROM Clients 
                         WHERE clients_name LIKE @search 
                         OR clients_id LIKE @search";

                SqlCommand com = Connect_DB(query);// From theClass_Base
                com.Parameters.AddWithValue("@search", "%" + txtBx_ٍSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                clientsBindingSource.DataSource = dt;
                clientsDataGridView.DataSource = clientsBindingSource;
                Close_DB();// From theClass_Base
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message);
            }
        }

        private void butt_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clients_nameTextBox.Text))
            {
                MessageBox.Show("يرجى إدخال اسم العميل أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clients_nameTextBox.Focus();
                return; // توقف العملية هنا إذا كان الاسم فارغاً
            }
            try
            {
                string query = @"Insert into Clients(clients_name, clients_Phone_number,clients_address) values (@name,@phone_number,@address)";
                SqlCommand com = Connect_DB(query); // From theClass_Base
                com.Parameters.AddWithValue("@name", clients_nameTextBox.Text);
                com.Parameters.AddWithValue("@phone_number", clients_Phone_numberTextBox.Text);
                com.Parameters.AddWithValue("@address", clients_addressTextBox.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("تم الإضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid("Clients", clientsDataGridView, clientsBindingSource); // From theClass_Base
                Close_DB();// From theClass_Base
                TextBox_Clear();
                GetNextID("Clients", "clients_id", clients_idTextBox);// From theClass_Base
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
                string query = @"UPDATE Clients SET clients_name = ISNULL(NULLIF(@name,''), clients_name),
                               clients_Phone_number = ISNULL(NULLIF(@phone_number,''),clients_Phone_number),
                               clients_address = ISNULL(NULLIF(@address,''),clients_address)
                               WHERE clients_id = @id";
                SqlCommand com = Connect_DB(query);// From theClass_Base
                com.Parameters.AddWithValue("@name", clients_nameTextBox.Text);
                com.Parameters.AddWithValue("@phone_number", clients_Phone_numberTextBox.Text);
                com.Parameters.AddWithValue("@id", int.Parse(clients_idTextBox.Text));
                com.Parameters.AddWithValue("@address", clients_addressTextBox.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid("Clients", clientsDataGridView, clientsBindingSource); // From theClass_Base
                Close_DB();// From theClass_Base
                TextBox_Clear();
                GetNextID("Clients", "clients_id", clients_idTextBox);// From theClass_Base
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
                 string quray = @"delete from Clients where clients_id = @id";
                 SqlCommand com = Connect_DB(quray);// From theClass_Base
                 com.Parameters.AddWithValue("@id", int.Parse(clients_idTextBox.Text));
                 com.ExecuteNonQuery();
                 MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 RefreshGrid("Clients", clientsDataGridView, clientsBindingSource); // From theClass_Base
                 Close_DB();// From theClass_Base
                 TextBox_Clear();
                 GetNextID("Clients", "clients_id", clients_idTextBox);// From theClass_Base
             }
             catch (Exception ex)
             {
                 // هذا السطر لعرض الخطأ إذا حدث توقف
                 MessageBox.Show("حدث خطأ أثناء الحذف: " + ex.Message);
             }
         }
        private void clients_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clients_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void suppliers_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clients_Phone_numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clients_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clients_addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       

       
        }

       

       
    }

