using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    public partial class Report3 : Class_Base
    {
        public Report3()
        {
            InitializeComponent();
        }

        private void storeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePHDataSet8);

        }

        private void Report3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePHDataSet8.Store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.databasePHDataSet8.Store);
            LoadExpiredDrugsReport();
        }
        private void LoadExpiredDrugsReport()
        {
            try
            {
                int daysLimit = Properties.Settings.Default.ExpiryDaysLimit;

                string sql = "SELECT store_id, medicine_name, Quantity, Expiration_date FROM Store " +
                             "WHERE DATEDIFF(day, GETDATE(), Expiration_date) <= " + daysLimit.ToString();

                System.Data.DataTable dt = Get_Data(sql);

                if (dt != null)
                {
                    storeDataGridView.DataSource = dt;

                    if (storeDataGridView.Columns.Count >= 4)
                    {
                        storeDataGridView.Columns[0].HeaderText = "رمز الدواء";
                        storeDataGridView.Columns[1].HeaderText = "اسم الدواء";
                        storeDataGridView.Columns[2].HeaderText = "الكمية";
                        storeDataGridView.Columns[3].HeaderText = "تاريخ انتهاء الصلاحية";

                        storeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        storeDataGridView.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";

                        // تمييز الأدوية المنتهية باللون الأحمر 
                        foreach (DataGridViewRow row in storeDataGridView.Rows)
                        {
                            if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                            {
                                DateTime expDate = Convert.ToDateTime(row.Cells[3].Value);

                                // إذا كان تاريخ الصلاحية أصغر من تاريخ اليوم (منتهي تماماً
                                if (expDate.Date < DateTime.Now.Date)
                                {
                                    row.DefaultCellStyle.BackColor = Color.Red;   // لون الخلفية أحمر
                                    row.DefaultCellStyle.ForeColor = Color.White; // لون الخط أبيض ليكون واضحاً
                                }
                                
                                else if (expDate.Date <= DateTime.Now.Date.AddDays(daysLimit))
                                {
                                    row.DefaultCellStyle.BackColor = Color.Yellow;
                                    row.DefaultCellStyle.ForeColor = Color.Black;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء تلوين الأصناف المنتهية: " + ex.Message);
            }
        }

        private void print_butt_Click(object sender, EventArgs e)
        {
            PrintGridMultiPage(storeDataGridView, "تقرير الأدوية منتهية الصلاحية والتي انتهاء صلاحيتها قريب");
        }

        private void Excport_Click(object sender, EventArgs e)
        {
            ExportToExcel(storeDataGridView);
        }
    }
}
