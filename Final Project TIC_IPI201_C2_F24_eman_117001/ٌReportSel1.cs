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
    public partial class ReportSel1 : Class_Base
    {
        public ReportSel1()
        {
            InitializeComponent();
        }

        private void ReportSel1_Load(object sender, EventArgs e)
        {

        }
        private void LoadSalesReportByDate()
        {
            try
            {
                
                DateTime searchDate = dtpSearchDate.Value.Date;

               
                string sql = @"SELECT 
                        t1.sal_inv_id, 
                        t3.medicine_name, 
                        t2.item, 
                        t2.Qunt, 
                        t2.price, 
                        t2.total, 
                        t1.inv_date 
                       FROM Sales_invoices t1 
                       INNER JOIN Sales_invo_Data t2 ON t1.sal_inv_id = t2.sel_id 
                       INNER JOIN Store t3 ON t2.med_id = t3.store_id 
                       WHERE t1.inv_date = @searchDate";

                SqlCommand cmd = Connect_DB(sql);
                cmd.Parameters.AddWithValue("@searchDate", searchDate);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvSalesReport.DataSource = dt;

                    //  تسمية الأعمدة بالعربية وتنسيقها
                    dgvSalesReport.Columns[0].HeaderText = "رقم الفاتورة";
                    dgvSalesReport.Columns[1].HeaderText = "اسم الدواء";
                    dgvSalesReport.Columns[2].HeaderText = "الوحدة";
                    dgvSalesReport.Columns[3].HeaderText = "الكمية";
                    dgvSalesReport.Columns[4].HeaderText = "السعر";
                    dgvSalesReport.Columns[5].HeaderText = "الإجمالي";
                    dgvSalesReport.Columns[6].HeaderText = "التاريخ";

                    // تنسيق عرض الجدول
                    dgvSalesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvSalesReport.Columns[6].DefaultCellStyle.Format = "yyyy-MM-dd";

                    // حساب المجموع النهائي للمبيعات في هذا اليوم
                    decimal totalDaySales = 0;
                    foreach (DataRow r in dt.Rows)
                    {
                        totalDaySales += Convert.ToDecimal(r["total"]);
                    }
                  
                }
                else
                {
                    dgvSalesReport.DataSource = null;
                    MessageBox.Show("لا توجد مبيعات مسجلة في هذا التاريخ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في جلب التقرير: " + ex.Message);
            }
            finally
            {
                Close_DB();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSalesReportByDate();
        }

        private void print_butt_Click(object sender, EventArgs e)
        {
            string title = "تقرير مبيعات يوم: " + dtpSearchDate.Value.ToString("yyyy-MM-dd");
            PrintGridMultiPage(dgvSalesReport, title);
        }

        private void Excport_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvSalesReport);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
