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
    public partial class Report1 : Class_Base
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void storeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePHDataSet8);

        }

        private void Report1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'databasePHDataSet8.Store' table.
                this.storeTableAdapter.Fill(this.databasePHDataSet8.Store);
                LoadStockData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل النموذج: " + ex.Message, "خطأ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStockData()
        {
            try
            {
                string sql = "SELECT store_id, medicine_name, Quantity, Expiration_date FROM Store WHERE Quantity > 0";
                System.Data.DataTable dt = Get_Data(sql);

                if (dt != null)
                {
                    storeDataGridView.DataSource = dt;

                    if (storeDataGridView.Columns.Count >= 4)
                    {
                        storeDataGridView.Columns[0].HeaderText = "رمز الدواء";
                        storeDataGridView.Columns[1].HeaderText = "اسم الدواء";
                        storeDataGridView.Columns[2].HeaderText = "الكمية المتاحة";
                        storeDataGridView.Columns[3].HeaderText = "تاريخ الصلاحية";

                        storeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                else
                {
                    MessageBox.Show("لا توجد بيانات متاحة في المخزن حالياً.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في جلب تقرير المخزن: " + ex.Message);
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void storeDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return; // حماية إضافية

            var column = storeDataGridView.Columns[e.ColumnIndex];

            if (column != null
                && column.DataPropertyName == "Quantity"
                && e.Value != null)
            {
                int qty;
                if (int.TryParse(e.Value.ToString(), out qty))
                {
                    if (qty <= 5)
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.SelectionBackColor = Color.DarkRed;
                    }
                }
   

            }
    }
       
        private void print_butt_Click(object sender, EventArgs e)
        {
            // استدعاء دالة الطباعة وتمرير الجدول مع عنوان التقرير
            PrintGridMultiPage(storeDataGridView, "تقرير مخزن الأدوية المتوفرة"); ;
        }

        private void Excport_Click(object sender, EventArgs e)
        {
           // استدعاء الدالة من الكلاس الأب وتمرير الجدول الحالي لها
           ExportToExcel(storeDataGridView);        
        }

}
    }

