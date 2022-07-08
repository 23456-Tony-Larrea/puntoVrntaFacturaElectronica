using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace POSales
{
    public partial class WhatsappModule : Form
    {
        public WhatsappModule()
        {
            InitializeComponent();
        }

        private void SendWhatsapp(string number, string message)
        {
            try
            {
                if (number == "") {
                    MessageBox.Show("el numero no esta escrito");
                }
                if (number.Length <= 10)
                {
                    MessageBox.Show("+593 esta colocado automaticamente");
                    number = "593" + number;
                }
                number = number.Replace("-", "");
                System.Diagnostics.Process.Start("https://web.whatsapp.com/send?phone=" + number + "&text=" + message);

            }  catch(Exception ex)
            {
                
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            SendWhatsapp(txtTo.Text, txtMessage.Text);
        }
       
    }
}
