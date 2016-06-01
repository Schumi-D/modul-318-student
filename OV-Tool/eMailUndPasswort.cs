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

        //eMail senden
        //*********************************************************************
        private void btSenden_Click(object sender, EventArgs e)
        {
            if (tbSender.Text != "" && tbPW.Text != "" && tbEmpfänger.Text != "" && tbBetreff.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;
                btSenden.Enabled = false;
                try
                {
                    //Daten für neue Mail sammeln
                    MailAddress fromAddress = new MailAddress(tbSender.Text, "Transport Swiss");
                    MailAddress toAddress = new MailAddress(tbEmpfänger.Text);
                    string fromPassword = tbPW.Text;
                    string subject = tbBetreff.Text;
                    string body = rtbInhalt.Text;

                    //ListView in body einfüllen
                    foreach (ListViewItem item in m_LVResultate.Items)
                    {
                        body += Environment.NewLine;
                        foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                        {
                            body += subitem.Text + "  |  ";
                        }
                    }

                    //Neuen smtp Client setzen, über den das Mail dann gesendet wird
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.live.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                    };

                    //Neues Mail erstellen und abschicken
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                    Cursor.Current = Cursors.Default;
                    btSenden.Enabled = false;
                    this.Close();
                }
                catch (Exception ex)
                {
                    //Fehlermeldungen anzeigen
                    Cursor.Current = Cursors.Default;
                    btSenden.Enabled = false;
                    DialogResult result = MessageBox.Show("Beim Versenden der eMail ist folgender Fehler aufgetreten: " + Environment.NewLine + ex.Message,
                                                          "Fehler", 
                                                          MessageBoxButtons.RetryCancel, 
                                                          MessageBoxIcon.Error);
                    if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }

                }
            }
            //Fehlermeldung bei leeren Feldern
            else
            {
                MessageBox.Show("Es sind nicht alle erforderlichen Felder eingetragen. Bitte alle Felder mit einem Stern ausfüllen.",
                                "Leere Felder", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }
    }
}
