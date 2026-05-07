using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    public partial class Login_Screen : Class_Base
    {

        Point originalLocation;
        public Login_Screen()
        {
            InitializeComponent();
        }

        private void Login_Screen_Load(object sender, EventArgs e)
        {
            txt_UserName.Focus(); // وضع المؤشر في خانة اسم المستخدم
        }
          
        private void button2_Click(object sender, EventArgs e)
        {
            pb_close(); //From theClass_Base
            Application.Exit();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool is_Pressed = true;
        private void button3_Click(object sender, EventArgs e)
        {
            is_Pressed = !is_Pressed;
            if (is_Pressed == true)
            {
                button3.BackgroundImage = Properties.Resources.Maximize_Button;
            }
            else
            {
                button3.BackgroundImage = Properties.Resources.Restore_Down;
            }

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void chk_ShowPassword_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = !chk_ShowPassword.Checked;
        }
        
       
        private void btn_login_Click(object sender, EventArgs e)
        {
           
          try
          {
              if (string.IsNullOrEmpty(txt_UserName.Text) || string.IsNullOrEmpty(txt_Password.Text))
              {   //اذا أحد الحقول فارغة
                  DialogResult result = MessageBox.Show(
                      "حقل اسم المستخدم أو حقل كلمة المرور فارغ", "خطأ",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              }
              else
              {
                  string query = "SELECT COUNT(*) FROM Users WHERE User_name=@user AND password=@pass";
                  SqlCommand com = Connect_DB(query); //From theClass_Base
                  com.Parameters.AddWithValue("@user", txt_UserName.Text);
                  com.Parameters.AddWithValue("@pass", txt_Password.Text);
                  int count = (int)com.ExecuteScalar();
                  com.Connection.Close();
                  if (count > 0)
                  {
                      MessageBox.Show("تم تسجيل الدخول بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      UserSession.CurrentUser = txt_UserName.Text;
                      home_screen home = new home_screen(); // إنشاء نسخة من الفورم
                      home.ShowDialog();
                      this.Close();
                      
                  }
                  else// اذا اسم المستخدم أو كلمة المرور خطأ
                  {
                      DialogResult result = MessageBox.Show(
                          "اسم المستخدم أو كلمة المرور غير صحيحة", "خطأ",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                      txt_UserName.Clear();// مسح المحتويات
                      txt_Password.Clear();// مسح المحتويات
                      txt_UserName.Focus(); // وضع المؤشر في خانة اسم المستخدم

                  }

              }
              Close_DB(); //From theClass_Base
              return;
          }
          catch (Exception ex)
          {
              // هذا السطر لعرض الخطأ إذا حدث توقف
              MessageBox.Show("حدث خطأ أثناء تسجيل الدخول: " + ex.Message);
          }
        }
        private void btn_login_MouseDown(object sender, MouseEventArgs e)
        {
            originalLocation = btn_login.Location;
            btn_login.Location = new Point(btn_login.Location.X + 2,btn_login.Location.Y + 2);
            btn_login.BackColor = Color.FromArgb(60, 150, 130);
        }

        private void btn_login_MouseUp(object sender, MouseEventArgs e)
        {

            btn_login.Location = originalLocation;
            btn_login.BackColor = Color.FromArgb(40, 120, 100);
        }

      



     
    }
}
