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
    public partial class Report2 : Class_Base
    {
        public Report2()
        {
            InitializeComponent();
        }

        private void storeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePHDataSet8);

        }

        private void Report2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePHDataSet8.Store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.databasePHDataSet8.Store);
            LoadLowStockData();
        }
        private void LoadLowStockData()
        {
            try
            {
                // جلب الأدوية التي كميتها أقل من 5 قطع
                string sql = "SELECT store_id, medicine_name, Quantity, Expiration_date FROM Store WHERE Quantity < 5";

                System.Data.DataTable dt = Get_Data(sql);

                if (dt != null)
                {
                    storeDataGridView.DataSource = dt;

                    // تسمية الأعمدة
                    if (storeDataGridView.Columns.Count >= 4)
                    {
                        storeDataGridView.Columns[0].HeaderText = "رمز الدواء";
                        storeDataGridView.Columns[1].HeaderText = "اسم الدواء";
                        storeDataGridView.Columns[2].HeaderText = "الكمية المتبقية";
                        storeDataGridView.Columns[3].HeaderText = "تاريخ الصلاحية";
                        storeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في جلب بيانات النواقص: " + ex.Message);
            }
        }
        private void storeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void print_butt_Click(object sender, EventArgs e)
        {
            PrintGridMultiPage(storeDataGridView, "تقرير نواقص الأدوية");
        }

        private void Excport_Click(object sender, EventArgs e)
        {
            ExportToExcel(storeDataGridView);
        }
    }
}
