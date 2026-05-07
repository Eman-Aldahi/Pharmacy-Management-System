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
    public partial class Setting : Class_Base
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            checkBox2.Checked = Properties.Settings.Default.ShowLowStockAlert; // تنبيه الكمية < 5
            checkBox1.Checked = Properties.Settings.Default.ShowExpiredAlert; // تنبيه الصلاحية
            textBox1.Text = Properties.Settings.Default.ExpiryDaysLimit.ToString(); // فرق الأيام
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void company_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void butt_ٍSave_Click(object sender, EventArgs e)
        {
            try 
    {
        Properties.Settings.Default.ShowExpiredAlert = checkBox1.Checked;
        Properties.Settings.Default.ShowLowStockAlert = checkBox2.Checked;
        
        // التأكد من أن النص المدخل في عدد الأيام هو رقم صحيح
        int days;
        if (int.TryParse(textBox1.Text, out days))
        {
            Properties.Settings.Default.ExpiryDaysLimit = days;
        }
        else
        {
            MessageBox.Show("يرجى إدخال رقم صحيح في حقل عدد الأيام");
            return;
        }

        //  أمر الحفظ الفعلي على القرص الصلب
        Properties.Settings.Default.Save();
        
        MessageBox.Show("تم حفظ جميع الإعدادات بنجاح!", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        // إغلاق الفورم بعد الحفظ
        this.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show("حدث خطأ أثناء الحفظ: " + ex.Message);
    }
}
        }
    }

