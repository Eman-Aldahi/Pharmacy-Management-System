using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;//
using System.Net.Http; // 

namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    public partial class chat : Form
    {
       
        // 1. تعريف الكلاينت والمفتاح في أعلى الكلاس ليكون متاحاً لكل الدوال
        private static readonly HttpClient client = new HttpClient();
        private string ApiKey = "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;
        // حفظ المحادثة
        private List<object> conversationHistory = new List<object>();
        public chat()
        {
            InitializeComponent();
             // تفعيل بروتوكول الأمان TLS 1.2 للاتصال بالسيرفرات
            System.Net.ServicePointManager.SecurityProtocol = (System.Net.SecurityProtocolType)3072;
        }

        private void ShowLoading()
        {
            progressBarLoading.Visible = true;
        }

        private void HideLoading()
        {
            progressBarLoading.Visible = false;
        }

        private void chat_Load(object sender, EventArgs e)
        {
        conversationHistory.Add(new
        {
            role = "system",
            content =
            "أنت مساعد ذكاء اصطناعي متخصص في الصيدلة والعلوم الطبية فقط وتعمل ضمن السياق الدوائي في سوريا. " +
            "يجب عليك الالتزام دائمًا وبشكل إلزامي بالتنسيق التالي عند الإجابة عن أي سؤال يتضمن دواء أو علاج أو عرض صحي دون استثناء:\n\n" +

            "الاسم العلمي:\n" +
            "الأسماء التجارية في سوريا:\n" +
            "الاستخدامات:\n" +
            "الجرعة المعتادة:\n" +
            "تنبيهات مهمة:\n\n" +

            "ممنوع تغيير هذا التنسيق أو حذف أي بند. " +
            "إذا لم تكن المعلومة متوفرة اكتب (غير متوفر). " +
            "اذكر الاسم العلمي أولًا دائمًا ثم الأسماء التجارية المتوفرة في سوريا. " +
            "استخدم لغة عربية طبية واضحة ومهنية. " +
            "لا تقدم تشخيصًا نهائيًا ولا تغني عن استشارة الطبيب أو الصيدلي. " +
            "إذا كان السؤال خارج المجال الطبي أو الصيدلاني، اعتذر بلطف واذكر أنك مختص فقط بهذا المجال."
        });
    }



        // عرض الرسائل الملونة في الشات
        private void AddMessage(string sender, string message, Color color)
        {
            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            rtbChat.SelectionColor = color;
            rtbChat.AppendText(sender + ": ");

            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            rtbChat.SelectionColor = Color.Black;
            rtbChat.AppendText(message + Environment.NewLine + Environment.NewLine);

            rtbChat.ScrollToCaret();
        }
        // 3. دالة جلب الرد من OpenRouter
         // جلب رد الذكاء الاصطناعي
    private async Task<string> GetBotResponse(string userMessage)
    {
        var url = "https://openrouter.ai/api/v1/chat/completions";

        // إضافة رسالة المستخدم للشات
        conversationHistory.Add(new
        {
            role = "user",
            content = userMessage
        });

        // تقليص المحادثة لتفادي الانقطاع
        if (conversationHistory.Count > 15)
        {
            conversationHistory.RemoveRange(1, 2);
        }

        var requestData = new
        {
            model = "tngtech/deepseek-r1t2-chimera:free",
            messages = conversationHistory,
            temperature = 0.3,
            max_tokens = 2000
        };

        string json = JsonConvert.SerializeObject(requestData);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        client.DefaultRequestHeaders.Clear();
        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);
        client.DefaultRequestHeaders.Add("HTTP-Referer", "http://localhost");
        client.DefaultRequestHeaders.Add("X-Title", "Syrian Medical Pharmacy Chatbot");
        client.DefaultRequestHeaders.Add("Accept", "application/json");

        try
        {
            var response = await client.PostAsync(url, content);
            var responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                return "خطأ ({(int)response.StatusCode}): {response.ReasonPhrase}";

            dynamic result = JsonConvert.DeserializeObject(responseString);
            string botReply = result.choices[0].message.content;

            // حفظ رد البوت في الشات
            conversationHistory.Add(new
            {
                role = "assistant",
                content = botReply
            });

            return botReply;
        }
        catch (Exception ex)
        {
            return "خطأ في الاتصال: " + ex.Message;
        }
    }

          // زر الإرسال
        private async void btnAsk_Click(object sender, EventArgs e)
{
    string userText = txtQuestion.Text.Trim();
    if (string.IsNullOrWhiteSpace(userText)) return;

    AddMessage("أنت", userText, Color.DodgerBlue);
    txtQuestion.Clear();

    btnAsk.Enabled = false;
    ShowLoading();

    try
    {
        string botResponse = await GetBotResponse(userText);
        AddMessage("جيمي", botResponse, Color.MediumSeaGreen);
    }
    finally
    {
        HideLoading();
        btnAsk.Enabled = true;
    }
}

        
         private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblDisclaimer_Click(object sender, EventArgs e)
        {

        }
    }
}







        
      
        
       

       

               
