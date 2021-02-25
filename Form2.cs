using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontaktandmed
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
            
        private void btn_all_Click(object sender, EventArgs e)
        {

        }

        private void btn_address_Click(object sender, EventArgs e)
        {

        }

        private void btn_addfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "TextFile|*.txt|ZipFile|*.zip|All|*.*";
            open.FilterIndex = 1;
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = open.FileName;
                label3.Text = open.FileName;
                _ = MessageBox.Show(text: "Fail avati");
            }

        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            {
                MailMessage mail = new MailMessage();
            
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new System.Net.NetworkCredential("faskin2002@gmail.com", "alexzx200231"), // почта и пароль отправителя
                EnableSsl = true
            };
            mail.From = new MailAddress("faskin2002@gmail.com ");
            }
        }
    }
}

