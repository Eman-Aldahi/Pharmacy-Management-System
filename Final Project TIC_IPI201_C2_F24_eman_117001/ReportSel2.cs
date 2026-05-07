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
    public partial class ReportSel2 : Class_Base
    {
        public ReportSel2()
        {
            InitializeComponent();
        }

        private void dgvSalesReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Excport_Click(object sender, EventArgs e)
        {
      
    try
    {
        if (dgvSalesReport.Rows.Count > 0)
        {
            // استدعاء دالة التصدير المورثة
            ExportToExcel(dgvSalesReport);
        }
        else
        {
            MessageBox.Show("لا توجد بيانات لتصديرها إلى ملف Excel.");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("خطأ أثناء تصدير البيانات: " + ex.Message);
    }
        }

        private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReportSel2_Load(object sender, EventArgs e)
        {
            LoadSalesReportBetweenDates();
        }
        private void LoadSalesReportBetweenDates()
        {
            try
            {
                DateTime dateFrom = dtpFrom.Value.Date;
                DateTime dateTo = dtpTo.Value.Date;

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
                       WHERE t1.inv_date BETWEEN @dateFrom AND @dateTo
                       ORDER BY t1.inv_date ASC"; // ترتيب حسب التاريخ

                SqlCommand cmd = Connect_DB(sql);

                cmd.Parameters.AddWithValue("@dateFrom", dateFrom);
                cmd.Parameters.AddWithValue("@dateTo", dateTo);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvSalesReport.DataSource = dt;

                    dgvSalesReport.Columns[0].HeaderText = "رقم الفاتورة";
                    dgvSalesReport.Columns[1].HeaderText = "اسم الدواء";
                    dgvSalesReport.Columns[2].HeaderText = "الوحدة";
                    dgvSalesReport.Columns[3].HeaderText = "الكمية";
                    dgvSalesReport.Columns[4].HeaderText = "السعر";
                    dgvSalesReport.Columns[5].HeaderText = "الإجمالي";
                    dgvSalesReport.Columns[6].HeaderText = "تاريخ البيع";

                    dgvSalesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvSalesReport.Columns[6].DefaultCellStyle.Format = "yyyy-MM-dd";

                    decimal totalPeriodSales = 0;
                    foreach (DataRow r in dt.Rows)
                    {
                        totalPeriodSales += Convert.ToDecimal(r["total"]);
                    }
                }
                else
                {
                    dgvSalesReport.DataSource = null;
                    MessageBox.Show("لا توجد مبيعات في هذه الفترة المحددة.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تقرير الفترة: " + ex.Message);
            }
            finally
            {
                Close_DB();
            }
        }

        private void print_butt_Click(object sender, EventArgs e)
        {
  
    try
    {
        if (dgvSalesReport.Rows.Count > 0)
        {
            string dateFrom = dtpFrom.Value.ToString("yyyy-MM-dd");
            string dateTo = dtpTo.Value.ToString("yyyy-MM-dd");
            string reportTitle = "تقرير مبيعات الصيدلية للفترة من " + dateFrom + " إلى " + dateTo;

            PrintGridMultiPage(dgvSalesReport, reportTitle);
        }
        else
        {
            MessageBox.Show("عذراً، الجدول فارغ. يرجى البحث عن البيانات أولاً قبل الطباعة.");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("خطأ أثناء محاولة الطباعة: " + ex.Message);
    }

        }

        private void btnSearch_Click(object sender, EventArgs e)
      
{
    try
    {
        DateTime dateFrom = dtpFrom.Value.Date;
        DateTime dateTo = dtpTo.Value.Date;

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
                       WHERE t1.inv_date BETWEEN @dateFrom AND @dateTo
                       ORDER BY t1.inv_date ASC";

        SqlCommand cmd = Connect_DB(sql);
        cmd.Parameters.AddWithValue("@dateFrom", dateFrom);
        cmd.Parameters.AddWithValue("@dateTo", dateTo);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        if (dt.Rows.Count > 0)
        {
            dgvSalesReport.DataSource = dt;

            dgvSalesReport.Columns[0].HeaderText = "رقم الفاتورة";
            dgvSalesReport.Columns[1].HeaderText = "اسم الدواء";
            dgvSalesReport.Columns[2].HeaderText = "الوحدة";
            dgvSalesReport.Columns[3].HeaderText = "الكمية المباعة";
            dgvSalesReport.Columns[4].HeaderText = "السعر";
            dgvSalesReport.Columns[5].HeaderText = "الإجمالي";
            dgvSalesReport.Columns[6].HeaderText = "تاريخ العملية";

            dgvSalesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalesReport.Columns[6].DefaultCellStyle.Format = "yyyy-MM-dd";

            decimal totalPeriod = 0;
            foreach (DataRow row in dt.Rows)
            {
                totalPeriod += Convert.ToDecimal(row["total"]);
            }
            
        }
        else
        {
            dgvSalesReport.DataSource = null;
            MessageBox.Show("لا توجد مبيعات مسجلة خلال الفترة من " + dateFrom.ToShortDateString() + " إلى " + dateTo.ToShortDateString());
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("حدث خطأ أثناء جلب البيانات: " + ex.Message);
    }
    finally
    {
        Close_DB();
    }

        }
    }
}
