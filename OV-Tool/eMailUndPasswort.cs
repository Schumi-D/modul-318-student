using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace OV_Tool
{
    public partial class eMailUndPasswort : Form
    {
        ListView m_LVResultate;
        public eMailUndPasswort(ListView LVResultate)
        {
            InitializeComponent();
            m_LVResultate = LVResultate;
        }

        private void btSenden_Click(object sender, EventArgs e)
        { 
            MailAddress fromAddress = new MailAddress(tbSender.Text, "Transport Swiss");
            MailAddress toAddress = new MailAddress(tbEmpfänger.Text);
            string fromPassword = tbPW.Text;
            string subject = tbBetreff.Text;
            string body = rtbInhalt.Text;

            foreach (ListViewItem item in m_LVResultate.Items)
            {
                body += Environment.NewLine;
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                    body += subitem.Text + "  |  ";
                }
            }

            var smtp = new SmtpClient
            {
                Host = "smtp.live.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
