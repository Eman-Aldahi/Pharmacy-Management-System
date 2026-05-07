using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;



namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    public class Class_Base : Form    
    {
        //مسار قاعدة البيانات
       private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePH.mdf;Integrated Security=True";
       // للاتصال بقاعدة البيانات
       private static SqlConnection con = new SqlConnection(connectionString);

       public static class UserSession
       {
           // هذا المتغير سيحمل اسم المستخدم الذي سجل دخوله حالياً
           public static string CurrentUser = "";
       }
       protected bool pb_close()
       {
           DialogResult result = MessageBox.Show("هل أنت متأكد أنك تريد إنهاء البرنامج؟", "إغلاق", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           if (result == DialogResult.Yes)
           {
               return true; 
           }
           else
           {
               return false; 
           }
       }
        protected static SqlCommand Connect_DB(string query)
        {
           
            if (con.State == ConnectionState.Closed)
            {
                con.Open();// لفتح الاتصال
            }
            //للاستعلام من قاعدة البيانات
            SqlCommand com = new SqlCommand(query, con);
           
            // لإرجاع قيمة عند التنفيذ
            return com;
            }
        protected static void Close_DB()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();//لإغلاق قاعدة البيانات
            }
        }

        protected static DataTable Get_Data(string sql_query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = Connect_DB(sql_query);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ في جلب البيانات: " + ex.Message);
            }
            return dt;
        }
        // لتحديث جدول البيانات
        protected static void RefreshGrid(string name_table, DataGridView dgv, BindingSource bs)
        {
            SqlDataAdapter da = new SqlDataAdapter(Connect_DB("SELECT * FROM " +name_table));
            DataTable dt = new DataTable();
            da.Fill(dt);
            bs.DataSource = dt;
            dgv.DataSource = bs;
        }

        protected void RefreshGrid_Join(string query, DataGridView dgv, BindingSource bs)
        {
            SqlDataAdapter da = new SqlDataAdapter(Connect_DB(query));
            DataTable dt = new DataTable();
            da.Fill(dt);
            bs.DataSource = dt;
            dgv.DataSource = bs;

        }

    
        protected static void Se_rch(string name_table, string col_num, string col_num2, DataGridView dgv, BindingSource bs)
        {
            SqlDataAdapter da = new SqlDataAdapter(Connect_DB("SELECT * FROM " + name_table+"where"+ col_num+"LIKE @search OR"+col_num2+"LIKE @search"));
            DataTable dt = new DataTable();
            da.Fill(dt);
            bs.DataSource = dt;
            dgv.DataSource = bs;
             }

        protected static void Combo_box(string name_table,string nam_col_memb, string nam_col_val,ComboBox combo)
        {
            SqlDataAdapter da = new SqlDataAdapter(Connect_DB("SELECT * FROM " + name_table));
            DataTable dt = new DataTable();
            da.Fill(dt);
            combo.DataSource =dt;
            combo.DisplayMember = nam_col_memb;
            combo.ValueMember = nam_col_val;
           
        }
        protected static void Fill_Grid_Combo(string name_table, string nam_col_memb, string nam_col_val, DataGridViewComboBoxColumn comboCol)
        {
            SqlDataAdapter da = new SqlDataAdapter(Connect_DB("SELECT * FROM " + name_table));
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboCol.DataSource = dt;
            comboCol.DisplayMember = nam_col_memb;
            comboCol.ValueMember = nam_col_val;
        }
        protected static  void IsUniqueConstraintError(SqlException ex, string message)
        {
            // 2627 = Violation of PRIMARY KEY or UNIQUE constraint
            // 2601 = Cannot insert duplicate key row in object
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("لا يمكن " + message + " ،هذا الاسم مستخدم بالفعل", "تكرار بيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء : " + message + ex.Message);
            }
         }
        protected void GetNextID(string tableName, string columnName, TextBox targetTextBox)
        {
            try
            {
         
                string query = string.Format("SELECT ISNULL(MAX({0}), 0) + 1 FROM {1}", columnName, tableName);

                SqlCommand cmd = Connect_DB(query);

                object result = cmd.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                {
                    targetTextBox.Text = "1";
                }
                else
                {
                    targetTextBox.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }
            finally
            {
                Close_DB();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Class_Base
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Class_Base";
            this.Load += new System.EventHandler(this.Class_Base_Load);
            this.ResumeLayout(false);

        }
        //  دالة التصدير إلى إكسيل 
        protected void ExportToExcel(DataGridView dgv)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Workbooks.Add();
                Excel._Worksheet workSheet = excelApp.ActiveSheet;

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Rows[i].Cells[j].Value != null)
                            workSheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في التصدير: " + ex.Message);
            }
        }

        //دالة الطباعة 
        int rowIndex = 0;
        protected void PrintGridMultiPage(DataGridView dgv, string reportTitle)
    {
        rowIndex = 0; // إعادة ضبط العداد عند بدء عملية طباعة جديدة
        PrintDocument pd = new PrintDocument();
        
        pd.PrintPage += (sender, e) =>
        {
            //  إعدادات الخطوط والمقاسات
            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font rowFont = new Font("Arial", 10);
            
            float x = 50; // الهامش الأيسر
            float y = 50; // الهامش العلوي
            float rowHeight = 30; // ارتفاع الصف

            //  رسم العنوان والتاريخ في كل صفحة
            e.Graphics.DrawString(reportTitle, titleFont, Brushes.Blue, x + 200, y);
            y += 40;
            e.Graphics.DrawString("تاريخ التقرير: " + DateTime.Now.ToShortDateString(), rowFont, Brushes.Black, x, y);
            y += 40;

            //  رسم رؤوس الأعمدة (Headers)
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, x, y, dgv.Columns[i].Width, rowHeight);
                e.Graphics.DrawRectangle(Pens.Black, x, y, dgv.Columns[i].Width, rowHeight);
                e.Graphics.DrawString(dgv.Columns[i].HeaderText, headerFont, Brushes.Black, x + 5, y + 5);
                x += dgv.Columns[i].Width;
            }
            
            y += rowHeight;
            x = 50; // إعادة الهامش لليسار لبدء الصفوف

            //  رسم الصفوف مع فحص نهاية الصفحة
            while (rowIndex < dgv.Rows.Count)
            {
                // إذا لم يتبقى مساحة في الصفحة الحالية (ترك هامش سفلي)
                if (y + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true; // إخبار الطابعة بوجود صفحة تالية
                    return; // الخروج من الدالة الحالية لبدء صفحة جديدة
                }

                DataGridViewRow row = dgv.Rows[rowIndex];
                x = 50;
                
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    e.Graphics.DrawRectangle(Pens.Black, x, y, dgv.Columns[j].Width, rowHeight);
                    string cellValue = (row.Cells[j].Value != null) ? row.Cells[j].Value.ToString() : "";
                    e.Graphics.DrawString(cellValue, rowFont, Brushes.Black, x + 5, y + 5);
                    x += dgv.Columns[j].Width;
                }

                y += rowHeight;
                rowIndex++;
            }

            e.HasMorePages = false; 
        };

        // عرض المعاينة
        PrintPreviewDialog ppd = new PrintPreviewDialog { Document = pd };
        ppd.WindowState = FormWindowState.Maximized;
        ppd.ShowDialog();
    }
        // دالة فحص الكميات الناقصة بناءً على إعدادات المستخدم
        protected void CheckLowStockAlert()
        {
            try
            {
                // 1. فحص هل المستخدم يريد التنبيه أم لا
                if (Properties.Settings.Default.ShowLowStockAlert == false)
                {
                    return;
                }

                //  جملة الاستعلام الكمية أقل من 5 وأكبر من 0
                string sql = "SELECT COUNT(*) FROM Store WHERE Quantity < 5 AND Quantity > 0";

                System.Data.DataTable dt = Get_Data(sql);

                if (dt != null && dt.Rows.Count > 0)
                {
                    int count = Convert.ToInt32(dt.Rows[0][0]);

                    if (count > 0)
                    {
                        // رسالة تنبيه متوافقة مع إصدار 2013
                        MessageBox.Show("تنبيه المخزن: يوجد عدد (" + count.ToString() + ") أصناف رصيدها أقل من 5 قطع.\nيرجى مراجعة تقرير الأدوية النافذة.",
                                        "نظام الصيدلية",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning,
                                        MessageBoxDefaultButton.Button1,
                                        (MessageBoxOptions)0x00080000 | (MessageBoxOptions)0x00100000); // دعم اليمين لليسار
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في فحص النواقص: " + ex.Message);
            }
        }

        protected void CheckExpiredAlert()
        {
            try
            {
                // 1. فحص هل التنبيه مفعل في الإعدادات
                if (Properties.Settings.Default.ShowExpiredAlert == false) return;

                // 2. جلب عدد الأيام المسموح بها من الإعدادات مثلاً 30 يوم
                int daysLimit = Properties.Settings.Default.ExpiryDaysLimit;

                // 3. جملة الاستعلام: جلب الأدوية التي ستنتهي خلال الأيام المحددة
                // ملاحظة: GETDATE() تجلب تاريخ اليوم، و DATEDIFF تحسب الفرق بالأيام
                string sql = "SELECT COUNT(*) FROM Store WHERE DATEDIFF(day, GETDATE(), Expiration_date) <= " + daysLimit.ToString() + " AND DATEDIFF(day, GETDATE(), Expiration_date) >= 0";

                System.Data.DataTable dt = Get_Data(sql);

                if (dt != null && dt.Rows.Count > 0)
                {
                    int count = Convert.ToInt32(dt.Rows[0][0]);
                    if (count > 0)
                    {
                        MessageBox.Show("تنبيه الصلاحية: يوجد عدد (" + count.ToString() + ") أصناف ستنتهي صلاحيتها خلال " + daysLimit.ToString() + " يوماً.",
                                        "تنبيه الأدوية",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning,
                                        MessageBoxDefaultButton.Button1,
                                        (MessageBoxOptions)0x00080000 | (MessageBoxOptions)0x00100000);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في فحص صلاحية الأدوية: " + ex.Message);
            }
        }
        private void Class_Base_Load(object sender, EventArgs e)
        {

        }
          
        
  

    }
}