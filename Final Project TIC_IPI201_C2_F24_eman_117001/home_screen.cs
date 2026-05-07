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
    public partial class home_screen : Class_Base
    {
            public home_screen()
        {
            InitializeComponent();
        }

        private void home_screen_Load(object sender, EventArgs e)
            {
                string loggedInUser = UserSession.CurrentUser;

                if (loggedInUser.ToLower() != "admin")
                {
                    button5.Enabled = false; 
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button3.Enabled = false;
                    button1.Enabled = false;
                    الموردينToolStripMenuItem.Enabled = false;

                }
                
            CheckLowStockAlert(); // فحص الكمية 5
            CheckExpiredAlert();  // فحص الصلاحية قريبة الانتهاء
            inv_dateDateTimePicker.Format = DateTimePickerFormat.Custom;
            inv_dateDateTimePicker.CustomFormat = "yyyy/MM/dd";
            // TODO: This line of code loads data into the 'databasePHDataSet8.Sales_invoices' table. You can move, or remove it, as needed.
            this.sales_invoicesTableAdapter.Fill(this.databasePHDataSet8.Sales_invoices);
            // TODO: This line of code loads data into the 'databasePHDataSet7.Purchase_invoices' table. You can move, or remove it, as needed.
            this.purchase_invoicesTableAdapter.Fill(this.databasePHDataSet7.Purchase_invoices);
            string Query = @"SELECT S.store_id as [رمز الدواء], S.medicine_name  as [اسم الدواء], C.Categories_name as [اسم التصنيف], 
                       S.Barcode as [الباركود],S.Purchase_Price as [سعر الشراء] ,S.Selling_Price as [سعر البيع],
                       S.Quantity as [الكمية],S.Expiration_date as [تاريخ انتهاء الصلاحية],S.Stock_storage as[مكان التخزين]
                       from Store S LEFT JOIN Categories C on S.Categories_id_St = C.Categories_id ";
            RefreshGrid_Join(Query, dataGridView1, purchase_invoicesBindingSource); // From theClass_Base
            dataGridView1.ForeColor = Color.Black;
            dataGridView3.ForeColor = Color.Black;
            GetNextID("Sales_invoices", "sal_inv_id", sal_inv_idTextBox);
            try
            {
               Combo_box("Clients", "clients_name", "clients_id", client_idComboBox);
                SetupSalesGrid();
                dataGridView1.AllowUserToAddRows = true;
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء تحميل البيانات: " + ex.Message);
            }
          
        }
        private void home_screen_Load_Click(object sender, EventArgs e)
        {
           
        }
        private void إغلاقالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (pb_close())
            {
                Application.Exit();
            }
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تسجيل الخروج؟", "تنبيه", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // إخفاء الشاشة الحالية فقط
                this.Hide();

                Login_Screen view = new Login_Screen();
                // إظهار شاشة الدخول وانتظار إغلاقها
                view.ShowDialog();

                // بعد إغلاق شاشة الدخول، إذا عاد المستخدم يغلق البرنامج ككل
                this.Close();
            }
        }

     

       

        private void الأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Company company = new Company(); // إنشاء نسخة من الفورم
            company.ShowDialog();
        }

        private void home_screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void butt_Chat_Click(object sender, EventArgs e)
        {
            chat Ch = new chat();
            Ch.ShowDialog();
        }

        private void الموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void التصنيفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void معلوماتالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void بياناتالأدويةوتخزينهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Company company = new Company(); // إنشاء نسخة من الفورم
            company.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            contextMenuStrip6.Show(button2, new Point(button2.Width, button2.Height));
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(button3, new Point(button3.Width, button3.Height));
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void التصنيفاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Categories C = new Categories();
            C.ShowDialog();

        }

        private void المخزونToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void مخزنالأدويةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Store S = new Store();
            S.TopMost = true;
            S.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Setting Se = new Setting();
            Se.Show();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            contextMenuStrip5.Show(button6, new Point(button6.Width, button6.Height));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            contextMenuStrip4.Show(button7, new Point(button7.Width, button7.Height));
        }

        private void btn_LogOut_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btn_LogOut, new Point(btn_LogOut.Width, btn_LogOut.Height));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(button8, new Point(button8.Width, button8.Height));
        }

        private void الموردينToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Suppliers S = new Suppliers();
            S.ShowDialog();
        }
      
        private void تقاريرالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

      
    
        private void contextMenuStrip6_Opening(object sender, CancelEventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void الزبائنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients C = new Clients();
            C.ShowDialog();
        }

        private void فاتورةمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_invoice P = new Purchase_invoice();
            P.ShowDialog();
        }


       
        private void purchase_invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchase_invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasePHDataSet7);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string Query = @"SELECT S.store_id as [رمز الدواء], S.medicine_name  as [اسم الدواء], C.Categories_name as [اسم التصنيف], 
                       S.Barcode as [الباركود],S.Purchase_Price as [سعر الشراء] ,S.Selling_Price as [سعر البيع],
                       S.Quantity as [الكمية],S.Expiration_date as [تاريخ انتهاء الصلاحية],S.Stock_storage as[مكان التخزين]
                       from Store S LEFT JOIN Categories C on S.Categories_id_St = C.Categories_id ";
            RefreshGrid_Join(Query, dataGridView1, purchase_invoicesBindingSource); // From theClass_Base

        }
        private void CalculateFinalInvoiceTotal()
        {
            decimal totalBeforeDiscount = 0;

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                // التأكد من أن الصف يحتوي على قيمة في عمود "الإجمالي" (Total)
                if (row.Cells["total"].Value != null && row.Cells["total"].Value.ToString() != "")
                {
                    totalBeforeDiscount += Convert.ToDecimal(row.Cells["total"].Value);
                }
            }

            //  تحديث خانة "المبلغ قبل الحسم"
            total_before_discountTextBox.Text = totalBeforeDiscount.ToString("0.00");

            //  حساب المبلغ الصافي المبلغ قبل الحسم - الحسم الممنوح
            decimal discount = 0;
            if (discountTextBox.Text != "")
            {
                discount = Convert.ToDecimal(discountTextBox.Text);
            }

            decimal netAmount = totalBeforeDiscount - discount;

            //  تحديث خانة "المبلغ الصافي"
            net_AmountTextBox.Text = netAmount.ToString("0.00");
        }
        private void butt_Update_Click(object sender, EventArgs e)
        {
    try
    {
        int invId = Convert.ToInt32(sal_inv_idTextBox.Text);
        foreach (DataGridViewRow row in dataGridView3.Rows)
        {
            if (!row.IsNewRow && row.Cells["med_id"].Value != null)
            {
                int mid = Convert.ToInt32(row.Cells["med_id"].Value);
                decimal newQty = Convert.ToDecimal(row.Cells["Qunt"].Value);
                DataTable dtOldInvo = Get_Data("SELECT Qunt FROM Sales_invo_Data WHERE sel_id="+invId+" AND med_id="+mid);
                decimal oldInvoQty = (dtOldInvo.Rows.Count > 0) ? Convert.ToDecimal(dtOldInvo.Rows[0]["Qunt"]) : 0;
                // جلب الكمية الحالية في المستودع
                DataTable dtStore = Get_Data("SELECT Quantity, medicine_name FROM Store WHERE store_id=" + mid);
                decimal storeQty = Convert.ToDecimal(dtStore.Rows[0]["Quantity"]);
                if (newQty > (storeQty + oldInvoQty))
                {
                    MessageBox.Show("الكمية المعدلة للدواء (" + dtStore.Rows[0]["medicine_name"] + ") تتجاوز المتاح في المخزن!");
                    return;
                }
            }
        }
        DataTable dtAllOld = Get_Data("SELECT med_id, Qunt FROM Sales_invo_Data WHERE sel_id = " + invId);
        foreach (DataRow r in dtAllOld.Rows)
        {
            Connect_DB("UPDATE Store SET Quantity = Quantity + " + r["Qunt"] + " WHERE store_id = " + r["med_id"]).ExecuteNonQuery();
        }

        
        Connect_DB("DELETE FROM Sales_invo_Data WHERE sel_id = " + invId).ExecuteNonQuery();
        string sqlUpM = "UPDATE Sales_invoices SET inv_date=@date, client_id=@cId, Pay_Payment=@pay, total_before_discount=@totalB, discount=@disc, net_Amount=@net WHERE sal_inv_id=@id";
        SqlCommand cmdUpM = Connect_DB(sqlUpM);
        cmdUpM.Parameters.AddWithValue("@date", inv_dateDateTimePicker.Value.Date);
        cmdUpM.Parameters.AddWithValue("@cId", client_idComboBox.SelectedValue);
        cmdUpM.Parameters.AddWithValue("@pay", pay_PaymentComboBox.Text);
        cmdUpM.Parameters.AddWithValue("@totalB", Convert.ToDecimal(total_before_discountTextBox.Text));
        cmdUpM.Parameters.AddWithValue("@disc", Convert.ToDecimal(discountTextBox.Text));
        cmdUpM.Parameters.AddWithValue("@net", Convert.ToDecimal(net_AmountTextBox.Text));
        cmdUpM.Parameters.AddWithValue("@id", invId);
        cmdUpM.ExecuteNonQuery();
        MessageBox.Show("تم التعديل بنجاح");
        ClearFields();
        GetNextID("Sales_invoices", "sal_inv_id", sal_inv_idTextBox);

    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        Close_DB();
    }
}

        private void butt_Add_Click(object sender, EventArgs e)
        {

    try
    {
        if (client_idComboBox.SelectedValue == null) { MessageBox.Show("يرجى اختيار العميل"); return; }
        if (string.IsNullOrEmpty(pay_PaymentComboBox.Text)) { MessageBox.Show("يرجى اختيار نوع الدفع"); return; }
        if (dataGridView3.Rows.Count <= 1) { MessageBox.Show("الفاتورة فارغة"); return; }
        foreach (DataGridViewRow row in dataGridView3.Rows)
        {
            if (!row.IsNewRow && row.Cells["med_id"].Value != null)
            {
                string medId = row.Cells["med_id"].Value.ToString();
                decimal reqQty = Convert.ToDecimal(row.Cells["Qunt"].Value);
                
                DataTable dtStock = Get_Data("SELECT Quantity, medicine_name FROM Store WHERE store_id = " + medId);
                decimal currentStock = Convert.ToDecimal(dtStock.Rows[0]["Quantity"]);
                
                if (reqQty > currentStock)
                {
                    MessageBox.Show("الكمية غير كافية للدواء: " + dtStock.Rows[0]["medicine_name"] + 
                                    "\nالمتاح: " + currentStock);
                    return; // الخروج ومنع الحفظ
                }
            }
        }

        //  حفظ رأس الفاتورة
        string sqlM = "INSERT INTO Sales_invoices (inv_date, client_id, Pay_Payment, total_before_discount, discount, net_Amount) " +
                      "VALUES (@date, @cId, @pay, @totalB, @disc, @net); SELECT SCOPE_IDENTITY();";
        SqlCommand cmdM = Connect_DB(sqlM);
        cmdM.Parameters.AddWithValue("@date", inv_dateDateTimePicker.Value.Date);
        cmdM.Parameters.AddWithValue("@cId", client_idComboBox.SelectedValue);
        cmdM.Parameters.AddWithValue("@pay", pay_PaymentComboBox.Text);
        cmdM.Parameters.AddWithValue("@totalB", Convert.ToDecimal(total_before_discountTextBox.Text));
        cmdM.Parameters.AddWithValue("@disc", Convert.ToDecimal(discountTextBox.Text));
        cmdM.Parameters.AddWithValue("@net", Convert.ToDecimal(net_AmountTextBox.Text));
        
        int lastId = Convert.ToInt32(cmdM.ExecuteScalar());

        //  حفظ الأصناف وتحديث المخزن
        foreach (DataGridViewRow row in dataGridView3.Rows)
        {
            if (!row.IsNewRow && row.Cells["med_id"].Value != null)
            {
                // حفظ الصنف
                SqlCommand cmdD = Connect_DB("INSERT INTO Sales_invo_Data (sel_id, med_id, Qunt, item, price, total, notes) VALUES (@sid, @mid, @q, @item, @p, @t, @n)");
                cmdD.Parameters.AddWithValue("@sid", lastId);
                cmdD.Parameters.AddWithValue("@mid", row.Cells["med_id"].Value);
                cmdD.Parameters.AddWithValue("@q", row.Cells["Qunt"].Value);
                cmdD.Parameters.AddWithValue("@item", row.Cells["item"].Value ?? "");
                cmdD.Parameters.AddWithValue("@p", row.Cells["price"].Value);
                cmdD.Parameters.AddWithValue("@t", row.Cells["total"].Value);
                cmdD.Parameters.AddWithValue("@n", row.Cells["notes"].Value ?? "");
                cmdD.ExecuteNonQuery();

                // خصم من المخزن
                SqlCommand cmdUp = Connect_DB("UPDATE Store SET Quantity = Quantity - @q WHERE store_id = @mid");
                cmdUp.Parameters.AddWithValue("@q", row.Cells["Qunt"].Value);
                cmdUp.Parameters.AddWithValue("@mid", row.Cells["med_id"].Value);
                cmdUp.ExecuteNonQuery();
            }
        }
        MessageBox.Show("تم الحفظ بنجاح");
        ClearFields();
        // جلب الرقم القادم للفاتورة الجديدة
        GetNextID("Sales_invoices", "sal_inv_id", sal_inv_idTextBox);

    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally { Close_DB(); }
}
        private void button12_Click(object sender, EventArgs e)
        {
            ClearFields();
            // جلب الرقم القادم للفاتورة الجديدة
            GetNextID("Sales_invoices", "sal_inv_id", sal_inv_idTextBox);

        }
        private void ClearFields()
        {
            client_idComboBox.SelectedIndex = -1; 
            pay_PaymentComboBox.SelectedIndex = -1; 
            inv_dateDateTimePicker.Value = DateTime.Now; 
            //  تصفير خانات المبالغ
            total_before_discountTextBox.Text = "0.00";
            discountTextBox.Text = "0.00";
            net_AmountTextBox.Text = "0.00";

            //  مسح بيانات الجدول (الأصناف)
            dataGridView3.Rows.Clear();
        }
        private void SetupSalesGrid()
        {
            dataGridView3.Columns.Clear();

           
            DataGridViewComboBoxColumn medCol = new DataGridViewComboBoxColumn();
            medCol.Name = "med_id";
            medCol.HeaderText = "اسم الدواء";
            medCol.Width = 200;
            medCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            Fill_Grid_Combo("Store", "medicine_name", "store_id", medCol);
            dataGridView3.Columns.Add(medCol);

            // إضافة باقي الأعمدة يدوياً لتظهر فوراً
            dataGridView3.Columns.Add("Qunt", "الكمية");
            dataGridView3.Columns.Add("item", "الوحدة");
            dataGridView3.Columns.Add("price", "السعر");
            dataGridView3.Columns.Add("total", "الإجمالي");
            dataGridView3.Columns.Add("notes", "ملاحظات");
        }
        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex < 0) return;

            try
            {
                //  معالجة اختيار الدواء (med_id)
                if (dataGridView3.Columns[e.ColumnIndex].Name == "med_id")
                {
                    if (dataGridView3.Rows[e.RowIndex].Cells["med_id"].Value != null)
                    {
                        //   منع تكرار الدواء في الجدول
                        foreach (DataGridViewRow r in dataGridView3.Rows)
                        {
                            if (!r.IsNewRow && r.Index != e.RowIndex)
                            {
                                if (r.Cells["med_id"].Value != null &&
                                    r.Cells["med_id"].Value.ToString() == dataGridView3.Rows[e.RowIndex].Cells["med_id"].Value.ToString())
                                {
                                    MessageBox.Show("هذا الدواء مضاف مسبقاً في الجدول، لا يمكن تكراره", "تنبيه");
                                    dataGridView3.Rows[e.RowIndex].Cells["med_id"].Value = null;
                                    return;
                                }
                            }
                        }

                        //  جلب السعر والتحقق من الكمية المتاحة 
                        string selectedMedId = dataGridView3.Rows[e.RowIndex].Cells["med_id"].Value.ToString();
                        DataTable dt = Get_Data("SELECT Selling_Price, Quantity FROM Store WHERE store_id = " + selectedMedId);

                        if (dt.Rows.Count > 0)
                        {
                            // وضع السعر
                            if (dt.Rows[0]["Selling_Price"] != DBNull.Value)
                                dataGridView3.Rows[e.RowIndex].Cells["price"].Value = dt.Rows[0]["Selling_Price"].ToString();

                            decimal stock = Convert.ToDecimal(dt.Rows[0]["Quantity"]);
                            if (stock <= 0)
                                MessageBox.Show("تنبيه: هذا الدواء نفذ من المخزن (الكمية الحالية: 0)");
                        }
                    }
                }

                
                if (dataGridView3.Columns[e.ColumnIndex].Name == "Qunt")
                {
                    if (dataGridView3.Rows[e.RowIndex].Cells["Qunt"].Value != null && dataGridView3.Rows[e.RowIndex].Cells["med_id"].Value != null)
                    {
                        string medId = dataGridView3.Rows[e.RowIndex].Cells["med_id"].Value.ToString();
                        decimal requestedQty = Convert.ToDecimal(dataGridView3.Rows[e.RowIndex].Cells["Qunt"].Value);

                        DataTable dtStock = Get_Data("SELECT Quantity FROM Store WHERE store_id = " + medId);
                        if (dtStock.Rows.Count > 0)
                        {
                            decimal availableStock = Convert.ToDecimal(dtStock.Rows[0]["Quantity"]);
                            if (requestedQty > availableStock)
                            {
                                MessageBox.Show("الكمية المطلوبة أكبر من المتوفر في المخزن!\nالمتاح حالياً: " + availableStock, "عجز في المخزون");
                                
                                dataGridView3.Rows[e.RowIndex].Cells["Qunt"].Value = availableStock;
                            }
                        }
                    }
                }

                //  حساب إجمالي السطر (الكمية × السعر
                if (dataGridView3.Columns[e.ColumnIndex].Name == "Qunt" || dataGridView3.Columns[e.ColumnIndex].Name == "price")
                {
                    if (dataGridView3.Rows[e.RowIndex].Cells["Qunt"].Value != null && dataGridView3.Rows[e.RowIndex].Cells["price"].Value != null)
                    {
                        decimal qty = Convert.ToDecimal(dataGridView3.Rows[e.RowIndex].Cells["Qunt"].Value);
                        decimal price = Convert.ToDecimal(dataGridView3.Rows[e.RowIndex].Cells["price"].Value);

                        dataGridView3.Rows[e.RowIndex].Cells["total"].Value = (qty * price).ToString();
                    }
                }

                // تحديث إجمالي الفاتورة بالكامل في الأسفل
                CalculateFinalInvoiceTotal();
            }
            catch (Exception ex)
            {
                Console.WriteLine("خطأ مؤقت في الحساب: " + ex.Message);
            }
        }
        private void sal_inv_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void company_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void inv_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void butt_ٍSerch_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT S.store_id as [رمز الدواء], S.medicine_name  as [اسم الدواء], C.Categories_name as [اسم التصنيف], 
                       S.Barcode as [الباركود],S.Purchase_Price as [سعر الشراء] ,S.Selling_Price as [سعر البيع],
                       S.Quantity as [الكمية],S.Expiration_date as [تاريخ انتهاء الصلاحية],S.Stock_storage as[مكان التخزين]
                       from Store S LEFT JOIN Categories C on S.Categories_id_St = C.Categories_id 
                       WHERE medicine_name LIKE @search OR store_id LIKE @search";
                SqlCommand com = Connect_DB(query);// From theClass_Base
                com.Parameters.AddWithValue("@search", "%" + txtBx_ٍSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                purchase_invoicesBindingSource.DataSource = dt;
                dataGridView1.DataSource = purchase_invoicesBindingSource;
                Close_DB();// From theClass_Base


            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message);
            }
        }

        private void label9_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void txtBx_ٍSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void butt_ٍSerch_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtBx_ٍSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void client_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                //  التحقق من أن مربع النص textBox1 ليس فارغاً
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("يرجى إدخال رقم الفاتورة أولاً");
                    return;
                }

                //  تحويل النص إلى رقم int
                int invoiceId;
                if (!int.TryParse(textBox1.Text, out invoiceId))
                {
                    MessageBox.Show("يرجى إدخال أرقام فقط في خانة البحث");
                    return;
                }

                //  جلب بيانات رأس الفاتورة
                DataTable dtMaster = Get_Data("SELECT * FROM Sales_invoices WHERE sal_inv_id = " + invoiceId);

                if (dtMaster.Rows.Count > 0)
                {
                    sal_inv_idTextBox.Text = dtMaster.Rows[0]["sal_inv_id"].ToString();
                    inv_dateDateTimePicker.Value = Convert.ToDateTime(dtMaster.Rows[0]["inv_date"]);
                    client_idComboBox.SelectedValue = dtMaster.Rows[0]["client_id"];
                    pay_PaymentComboBox.Text = dtMaster.Rows[0]["Pay_Payment"].ToString();
                    total_before_discountTextBox.Text = dtMaster.Rows[0]["total_before_discount"].ToString();
                    discountTextBox.Text = dtMaster.Rows[0]["discount"].ToString();
                    net_AmountTextBox.Text = dtMaster.Rows[0]["net_Amount"].ToString();

                    //  جلب تفاصيل الأصناف في الجدول
                    DataTable dtDetails = Get_Data("SELECT med_id, Qunt, item, price, total, notes FROM Sales_invo_Data WHERE sel_id = " + invoiceId);

                    dataGridView3.Rows.Clear();
                    foreach (DataRow row in dtDetails.Rows)
                    {
                        dataGridView3.Rows.Add(
                            row["med_id"],
                            row["Qunt"],
                            row["item"],
                            row["price"],
                            row["total"],
                            row["notes"]
                        );
                    }
                }
                else
                {
                    MessageBox.Show("الفاتورة رقم " + invoiceId + " غير موجودة");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في البحث: " + ex.Message);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void client_idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateFinalInvoiceTotal();
        }

        private void net_AmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_before_discountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void الأدويةالمتوفرةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report1 R1 = new Report1();
            R1.ShowDialog();
        }

        private void الأدويةالنافذةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report2 R2 = new Report2();
            R2.ShowDialog();
        }

        private void الأدويةالفاسدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report3 R3 = new Report3();
            R3.ShowDialog();
        }

        private void home_screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (pb_close() == false)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.ExitThread();
                }
            }
        }

        private void pay_PaymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void بياناتالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Password U = new User_Password();
            U.ShowDialog();
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void مبيعاتتاريخمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSel1 RSel1 = new ReportSel1();
            RSel1.ShowDialog();
        }

        private void مبيعاتبينتاريخينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSel2 Rsel2 = new ReportSel2();
            Rsel2.ShowDialog();
        }

     
       
    }
    }

