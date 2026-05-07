using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;


namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    public partial class Purchase_invoice : Class_Base
    {
        public Purchase_invoice()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void purchase_invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchase_invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePHDataSet7);

        }


        private void Purchase_invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databasePHDataSet7.Purchase_invoices' table. You can move, or remove it, as needed.
            this.purchase_invoicesTableAdapter.Fill(this.databasePHDataSet7.Purchase_invoices);
            invoic_DateDateTimePicker.Format = DateTimePickerFormat.Custom;
            invoic_DateDateTimePicker.CustomFormat = "yyyy/MM/dd";
            Combo_box("Suppliers", "Suppliers_name", "Suppliers_id", suppl_idComboBox);
            GetNextID("[Purchase invoices]", "invoic_id", invoic_idTextBox);
            dataGridView1.AllowUserToAddRows = true;
            // تجهيز أعمدة الـ ComboBox داخل الجدول
            SetupGridColumns();
            dataGridView1.ForeColor = Color.Black;
            ClearForm();


        }
        private void SetupGridColumns()
        {

            dataGridView1.Columns.Clear();

            //  عمود اسم الدواء (ComboBox)
            DataGridViewComboBoxColumn medCombo = new DataGridViewComboBoxColumn();
            medCombo.Name = "med_id";
            medCombo.HeaderText = "اسم الدواء";
            medCombo.Width = 150;
            medCombo.FlatStyle = FlatStyle.Flat;
            Fill_Grid_Combo("Store", "medicine_name", "store_id", medCombo);
            dataGridView1.Columns.Add(medCombo);

            //  عمود الكمية
            dataGridView1.Columns.Add("Qunt", "الكمية");

            dataGridView1.Columns.Add("item", "الوحدة");
            dataGridView1.Columns["item"].Width = 80;

            //  عمود سعر الشراء
            dataGridView1.Columns.Add("price", "سعر الشراء");

            //  عمود الإجمالي (للقراءة فقط)
            dataGridView1.Columns.Add("total", "الإجمالي");
            dataGridView1.Columns["total"].ReadOnly = true;

            //  عمود اسم الشركة (ComboBox)
            DataGridViewComboBoxColumn compCombo = new DataGridViewComboBoxColumn();
            compCombo.Name = "comp_id";
            compCombo.HeaderText = "اسم الشركة";
            compCombo.FlatStyle = FlatStyle.Flat;
            Fill_Grid_Combo("Companies", "Company_name", "Company_id", compCombo);
            dataGridView1.Columns.Add(compCombo);

            //  عمود الملاحظات
            dataGridView1.Columns.Add("notes", "الملاحظات");
            dataGridView1.Columns["notes"].Width = 150;
        }

        // دالة حساب إجمالي السطر الكمية × السعر
        private void CalculateRowTotal(int rowIndex)
        {
            decimal qty = 0, prc = 0;
            decimal.TryParse(Convert.ToString(dataGridView1.Rows[rowIndex].Cells["Qunt"].Value), out qty);
            decimal.TryParse(Convert.ToString(dataGridView1.Rows[rowIndex].Cells["price"].Value), out prc);
            dataGridView1.Rows[rowIndex].Cells["total"].Value = (qty * prc).ToString("0.00");
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void CalculateFinalInvoiceTotal()
        {
            decimal totalBefore = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["total"].Value != null)
                {
                    decimal val = 0;
                    decimal.TryParse(row.Cells["total"].Value.ToString(), out val);
                    totalBefore += val;
                }
            }
            total_before_discountTextBox.Text = totalBefore.ToString("0.00");
            decimal disc = 0;
            decimal.TryParse(discountTextBox.Text, out disc);
            net_AmountTextBox.Text = (totalBefore - disc).ToString("0.00");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Qunt" || dataGridView1.Columns[e.ColumnIndex].Name == "price")
            {
                CalculateRowTotal(e.RowIndex);     
                CalculateFinalInvoiceTotal();      
            }
        }
        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateFinalInvoiceTotal();
        }

        private bool IsMedicineRepeated()
        {
            // قائمة لتخزين المعرفات التي نمر عليها
            List<string> seenIds = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells["med_id"].Value != null)
                {
                    string currentId = row.Cells["med_id"].Value.ToString();

                    if (seenIds.Contains(currentId))
                    {
                        // إذا وجدنا المعرف مسبقاً في القائمة، فهذا يعني وجود تكرار
                        string medName = row.Cells["med_id"].FormattedValue.ToString(); // جلب الاسم المعروض في الـ ComboBox
                        MessageBox.Show(string.Format("عذراً، لقد قمت بتكرار الدواء ({0}) في الجدول. يرجى دمج الكميات في سطر واحد.", medName),
                                        "تكرار بيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                    seenIds.Add(currentId);
                }
            }
            return false; // لا يوجد تكرار
        }


      private void butt_Add_Click(object sender, EventArgs e)
{
    //  التأكد من اختيار المورد
    if (suppl_idComboBox.SelectedValue == null || suppl_idComboBox.SelectedIndex == -1)
    {
        MessageBox.Show("يرجى اختيار اسم المورد أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        suppl_idComboBox.Focus();
        return;
    }

    //  التأكد من اختيار نوع الدفع
    if (string.IsNullOrEmpty(payment_typeComboBox.Text))
    {
        MessageBox.Show("يرجى اختيار نوع الدفع (نقدي / آجل)", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        payment_typeComboBox.Focus();
        return;
    }

    //  منع حفظ الفاتورة إذا كان الجدول فارغاً تماماً
    // ملاحظة: الجدول يحتوي عادة على صف فارغ أخير للادخال الجديد، لذا نتحقق من الصفوف الحقيقية
    int rowsCount = 0;
    foreach (DataGridViewRow row in dataGridView1.Rows)
    {
        if (!row.IsNewRow && row.Cells["med_id"].Value != null)
        {
            rowsCount++;
        }
    }

    if (rowsCount == 0)
    {
        MessageBox.Show("لا يمكن حفظ فاتورة فارغة، يرجى إضافة دواء واحد على الأقل في الجدول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    //  التحقق من اكتمال البيانات داخل كل سطر (الدواء، الكمية، السعر، والشركة)
    foreach (DataGridViewRow row in dataGridView1.Rows)
    {
        if (!row.IsNewRow) // نتجاهل الصف الفارغ الأخير
        {
            // التحقق من اسم الدواء
            if (row.Cells["med_id"].Value == null)
            {
                MessageBox.Show("يرجى اختيار اسم الدواء في السطر رقم {row.Index + 1}", "بيانات ناقصة");
                return;
            }
            // التحقق من اسم الشركة
            if (row.Cells["comp_id"].Value == null)
            {
                MessageBox.Show("يرجى اختيار اسم الشركة في السطر رقم {row.Index + 1}", "بيانات ناقصة");
                return;
            }
            // التحقق من السعر والكمية
            if (row.Cells["Qunt"].Value == null || Convert.ToDecimal(row.Cells["Qunt"].Value) <= 0)
            {
                MessageBox.Show("يرجى إدخال كمية صحيحة في السطر رقم {row.Index + 1}", "بيانات ناقصة");
                return;
            }
            if (row.Cells["price"].Value == null || Convert.ToDecimal(row.Cells["price"].Value) <= 0)
            {
                MessageBox.Show("يرجى إدخال السعر في السطر رقم {row.Index + 1}", "بيانات ناقصة");
                return;
            }
        }
    }

    try 
    {
        // حفظ رأس الفاتورة
                string headerSql = "INSERT INTO [Purchase invoices] (Suppl_id, invoic_Date, total_before_discount, discount, net_Amount, payment_type) " +
                                   "VALUES (@supId, @invDate, @totalB, @disc, @net, @payType); " +
                                   "SELECT SCOPE_IDENTITY();";

                SqlCommand cmdHeader = Connect_DB(headerSql);
                cmdHeader.Parameters.Clear();
                cmdHeader.Parameters.AddWithValue("@supId", suppl_idComboBox.SelectedValue);
                cmdHeader.Parameters.AddWithValue("@invDate", invoic_DateDateTimePicker.Value);
                cmdHeader.Parameters.AddWithValue("@totalB", decimal.Parse(total_before_discountTextBox.Text));
                cmdHeader.Parameters.AddWithValue("@disc", decimal.Parse(discountTextBox.Text));
                cmdHeader.Parameters.AddWithValue("@net", decimal.Parse(net_AmountTextBox.Text));
                cmdHeader.Parameters.AddWithValue("@payType", payment_typeComboBox.Text);

                int newInvId = Convert.ToInt32(cmdHeader.ExecuteScalar());

                // حفظ تفاصيل الأصناف وتحديث المخزن
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // إدخال بيانات 
                        string detailSql = "INSERT INTO [invoices_Data] (inv_id, med_id, Qunt, item, price, total, comp_id, notes) " +
                                           "VALUES (@invId, @medId, @qty, @item, @price, @total, @compId, @notes)";

                        SqlCommand cmdDetail = Connect_DB(detailSql);
                        cmdDetail.Parameters.Clear();
                        cmdDetail.Parameters.AddWithValue("@invId", newInvId);
                        cmdDetail.Parameters.AddWithValue("@medId", row.Cells["med_id"].Value);
                        cmdDetail.Parameters.AddWithValue("@qty", row.Cells["Qunt"].Value);
                        cmdDetail.Parameters.AddWithValue("@item", row.Cells["item"].Value != null ? row.Cells["item"].Value : "");
                        cmdDetail.Parameters.AddWithValue("@price", row.Cells["price"].Value);
                        cmdDetail.Parameters.AddWithValue("@total", row.Cells["total"].Value);
                        cmdDetail.Parameters.AddWithValue("@compId", row.Cells["comp_id"].Value != null ? row.Cells["comp_id"].Value : DBNull.Value);
                        cmdDetail.Parameters.AddWithValue("@notes", row.Cells["notes"].Value != null ? row.Cells["notes"].Value : "");
                        cmdDetail.ExecuteNonQuery();

                        string updateSql = "UPDATE Store SET Quantity = Quantity + @qty, " +
                                    "Purchase_Price = @price, " +
                                    "Selling_Price = ROUND(@price * 1.10, 2) " +
                                    "WHERE store_id = @medId";

                        SqlCommand cmdUpdate = Connect_DB(updateSql);
                        cmdUpdate.Parameters.Clear();

                        // معالجة القيم الرقمية بأمان لتفادي خطأ التحويل
                        decimal rowQty = 0;
                        decimal rowPrice = 0;
                        if (row.Cells["Qunt"].Value != null) decimal.TryParse(row.Cells["Qunt"].Value.ToString(), out rowQty);
                        if (row.Cells["price"].Value != null) decimal.TryParse(row.Cells["price"].Value.ToString(), out rowPrice);

                        cmdUpdate.Parameters.Add("@qty", SqlDbType.Decimal).Value = rowQty;
                        cmdUpdate.Parameters.Add("@price", SqlDbType.Decimal).Value = rowPrice;
                        cmdUpdate.Parameters.Add("@medId", SqlDbType.Int).Value = row.Cells["med_id"].Value;

                        cmdUpdate.ExecuteNonQuery();

                    }
                }

                Close_DB();
                MessageBox.Show("تم حفظ الفاتورة وتحديث المخزن بنجاح ", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // تنظيف الواجهة لإدخال فاتورة جديدة
                dataGridView1.Rows.Clear();
                GetNextID("[Purchase invoices]", "invoic_id", invoic_idTextBox);
                ClearForm(); 
            }
            catch (Exception ex)
            {
                Close_DB();
                MessageBox.Show("حدث خطأ أثناء الحفظ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  
        private void butt_Update_Click(object sender, EventArgs e)
        {
            //  إضافة التحقق من التكرار
            if (IsMedicineRepeated()) return;
            //  التحقق من وجود رقم للفاتورة المراد تعديلها
            if (string.IsNullOrEmpty(invoic_idTextBox.Text))
            {
                MessageBox.Show("يرجى اختيار فاتورة أولاً لتعديلها", "تنبيه");
                return;
            }

            //  التحقق من الحقول الأساسية
            if (suppl_idComboBox.SelectedValue == null)
            {
                MessageBox.Show("يرجى اختيار المورد", "تنبيه");
                return;
            }

            //  التحقق من وجود بيانات في الجدول
            if (dataGridView1.Rows.Count <= (dataGridView1.AllowUserToAddRows ? 1 : 0))
            {
                MessageBox.Show("لا يمكن تعديل فاتورة لتصبح فارغة", "تنبيه");
                return;
            }

            try
            {
                int invId = Convert.ToInt32(invoic_idTextBox.Text);

                // تعديل رأس الفاتورة باستخدام البارامترات 
                string updateHeaderSql = "UPDATE [Purchase invoices] SET " +
                                         "Suppl_id = @supId, invoic_Date = @invDate, " +
                                         "total_before_discount = @totalB, discount = @disc, " +
                                         "net_Amount = @net, payment_type = @payType " +
                                         "WHERE invoic_id = @invId";

                SqlCommand cmdHeader = Connect_DB(updateHeaderSql);
                cmdHeader.Parameters.Clear();
                cmdHeader.Parameters.AddWithValue("@supId", suppl_idComboBox.SelectedValue);
                cmdHeader.Parameters.AddWithValue("@invDate", invoic_DateDateTimePicker.Value);
                cmdHeader.Parameters.AddWithValue("@totalB", decimal.Parse(total_before_discountTextBox.Text));
                cmdHeader.Parameters.AddWithValue("@disc", decimal.Parse(discountTextBox.Text));
                cmdHeader.Parameters.AddWithValue("@net", decimal.Parse(net_AmountTextBox.Text));
                cmdHeader.Parameters.AddWithValue("@payType", payment_typeComboBox.Text);
                cmdHeader.Parameters.AddWithValue("@invId", invId);
                cmdHeader.ExecuteNonQuery();

                DataTable oldDetails = Get_Data("SELECT med_id, Qunt FROM invoices_Data WHERE inv_id = " + invId);
                foreach (DataRow r in oldDetails.Rows)
                {
                    string rollbackSql = "UPDATE Store SET Quantity = Quantity - @qty WHERE store_id = @medId";
                    SqlCommand cmdRollback = Connect_DB(rollbackSql);
                    cmdRollback.Parameters.Clear();
                    cmdRollback.Parameters.AddWithValue("@qty", r["Qunt"]);
                    cmdRollback.Parameters.AddWithValue("@medId", r["med_id"]);
                    cmdRollback.ExecuteNonQuery();
                }

                Connect_DB("DELETE FROM invoices_Data WHERE inv_id = " + invId).ExecuteNonQuery();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells["med_id"].Value == null) continue;

                        string insertDetailSql = "INSERT INTO invoices_Data (inv_id, med_id, Qunt, item, price, total, comp_id, notes) " +
                                                 "VALUES (@invId, @medId, @qty, @item, @price, @total, @compId, @notes)";

                        SqlCommand cmdDetail = Connect_DB(insertDetailSql);
                        cmdDetail.Parameters.Clear();
                        cmdDetail.Parameters.AddWithValue("@invId", invId);
                        cmdDetail.Parameters.AddWithValue("@medId", row.Cells["med_id"].Value);
                        cmdDetail.Parameters.AddWithValue("@qty", row.Cells["Qunt"].Value);
                        cmdDetail.Parameters.AddWithValue("@item", row.Cells["item"].Value != null ? row.Cells["item"].Value : "");
                        cmdDetail.Parameters.AddWithValue("@price", row.Cells["price"].Value);
                        cmdDetail.Parameters.AddWithValue("@total", row.Cells["total"].Value);
                        cmdDetail.Parameters.AddWithValue("@compId", row.Cells["comp_id"].Value != null ? row.Cells["comp_id"].Value : DBNull.Value);
                        cmdDetail.Parameters.AddWithValue("@notes", row.Cells["notes"].Value != null ? row.Cells["notes"].Value : "");
                        cmdDetail.ExecuteNonQuery();

                        string updateStoreSql = "UPDATE Store SET Quantity = Quantity + @qty, " +
                                        "Purchase_Price = @price, " +
                                        "Selling_Price = ROUND(@price * 1.10, 2) " +
                                        "WHERE store_id = @medId";

                        SqlCommand cmdUpdate = Connect_DB(updateStoreSql);
                        cmdUpdate.Parameters.Clear();

                        decimal rowQty = 0, rowPrice = 0;
                        if (row.Cells["Qunt"].Value != null) decimal.TryParse(row.Cells["Qunt"].Value.ToString(), out rowQty);
                        if (row.Cells["price"].Value != null) decimal.TryParse(row.Cells["price"].Value.ToString(), out rowPrice);

                        cmdUpdate.Parameters.Add("@qty", SqlDbType.Decimal).Value = rowQty;
                        cmdUpdate.Parameters.Add("@price", SqlDbType.Decimal).Value = rowPrice;
                        cmdUpdate.Parameters.Add("@medId", SqlDbType.Int).Value = row.Cells["med_id"].Value;

                        cmdUpdate.ExecuteNonQuery();
                }

                Close_DB();
                MessageBox.Show("تم تعديل الفاتورة وتحديث المخزن بنجاح ", "عملية ناجحة");
                ClearForm(); 
            }
         }
            catch (Exception ex)
            {
                Close_DB();
                MessageBox.Show("خطأ أثناء التعديل: " + ex.Message, "خطأ");
            }
        }
        
    
        private void butt_ٍSerch_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtBx_ٍSearch.Text))
            {
                MessageBox.Show("أدخل رقم الفاتورة");
                return;
            }

            try
            {
                int invId = Convert.ToInt32(txtBx_ٍSearch.Text);

                
                DataTable headerDt = Get_Data(
                    "SELECT * FROM [Purchase invoices] WHERE invoic_id = " + invId);

                if (headerDt.Rows.Count == 0)
                {
                    MessageBox.Show("الفاتورة غير موجودة");
                    return;
                }

                DataRow h = headerDt.Rows[0];
                invoic_idTextBox.Text = h["invoic_id"].ToString();
                suppl_idComboBox.SelectedValue = h["Suppl_id"];
                invoic_DateDateTimePicker.Value = Convert.ToDateTime(h["invoic_Date"]);
                total_before_discountTextBox.Text = h["total_before_discount"].ToString();
                discountTextBox.Text = h["discount"].ToString();
                net_AmountTextBox.Text = h["net_Amount"].ToString();
                payment_typeComboBox.Text = h["payment_type"].ToString();

                DataTable detailsDt = Get_Data("SELECT * FROM invoices_Data WHERE inv_id = " + invId);

                dataGridView1.Rows.Clear();

                foreach (DataRow r in detailsDt.Rows)
                {
                    int rowIndex = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowIndex].Cells["med_id"].Value = r["med_id"];
                    dataGridView1.Rows[rowIndex].Cells["Qunt"].Value = r["Qunt"];
                    dataGridView1.Rows[rowIndex].Cells["item"].Value = r["item"];
                    dataGridView1.Rows[rowIndex].Cells["price"].Value = r["price"];
                    dataGridView1.Rows[rowIndex].Cells["total"].Value = r["total"];
                    dataGridView1.Rows[rowIndex].Cells["comp_id"].Value = r["comp_id"];
                    dataGridView1.Rows[rowIndex].Cells["notes"].Value = r["notes"];
                }

                MessageBox.Show("تم تحميل الفاتورة ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء البحث: " + ex.Message);
            }


        }

        private void ClearForm()
        {
            dataGridView1.Rows.Clear();

            total_before_discountTextBox.Text = "0";
            discountTextBox.Text = "0";
            net_AmountTextBox.Text = "0";

            payment_typeComboBox.SelectedIndex = -1;
            suppl_idComboBox.SelectedIndex = -1;

            invoic_DateDateTimePicker.Value = DateTime.Now;

            GetNextID("[Purchase invoices]", "invoic_id", invoic_idTextBox);
        }

        private void invoic_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void company_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void invoic_DateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void suppl_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void suppl_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void net_AmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void net_AmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void invoic_DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void payment_typeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void total_before_discountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void payment_typeLabel_Click(object sender, EventArgs e)
        {

        }

        private void payment_typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void suppl_idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void suppl_idLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void payment_typeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }



    
        private void txtBx_ٍSearch_TextChanged(object sender, EventArgs e)
        {

        }

    }
        

         
}
