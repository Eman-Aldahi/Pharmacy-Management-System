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
    public partial class User_Password : Class_Base
    {
        public User_Password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void User_Password_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //  التحقق من الحقول الفارغة
            if (string.IsNullOrWhiteSpace(txt_OldPass.Text) || string.IsNullOrWhiteSpace(txt_NewPass.Text))
            {
                MessageBox.Show("يرجى ملء جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  التحقق من تطابق كلمة المرور الجديدة مع التأكيد
            if (txt_NewPass.Text != txt_ConfirmPass.Text)
            {
                MessageBox.Show("كلمة المرور الجديدة غير متطابقة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string checkQuery = "SELECT password FROM Users WHERE user_name = @user AND password = @oldPass";
                SqlCommand cmdCheck = Connect_DB(checkQuery);
                cmdCheck.Parameters.AddWithValue("@user", UserSession.CurrentUser);
                cmdCheck.Parameters.AddWithValue("@oldPass", txt_OldPass.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmdCheck);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //  إذا كانت صحيحة، نقوم بالتحديث
                    string updateQuery = "UPDATE Users SET password = @newPass WHERE user_name = @user";
                    SqlCommand cmdUpdate = Connect_DB(updateQuery);
                    cmdUpdate.Parameters.AddWithValue("@newPass", txt_NewPass.Text);
                    cmdUpdate.Parameters.AddWithValue("@user", UserSession.CurrentUser);

                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("تم تغيير كلمة المرور بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close_DB();
                    this.Close(); // إغلاق الواجهة بعد النجاح
                }
                else
                {
                    MessageBox.Show("كلمة المرور القديمة غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }
        }
    }
}
