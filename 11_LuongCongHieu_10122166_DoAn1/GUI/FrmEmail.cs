using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using DevExpress.XtraMap;

namespace FrmTrangChu.cs
{
    public partial class FrmEmail : DevExpress.XtraEditors.XtraUserControl
    {
        public FrmEmail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string from, to,pass , content;
            from = txtSender.Text.Trim();
            to = txtReceiver.Text.Trim();
            pass = txtpass.Text.Trim();
            content = txtContent.Text;
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Subject = "Test mail";
            mailMessage.Body = txtContent.Text;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from, pass); // from: gmail of sender; pass: password of sender
            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("success","Email",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSender.Text = "";
            txtpass.Text = "";
            txtContent.Text = "";
        }

        private void btnLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://help.tenten.vn/huong-dan-tao-mat-khau-ung-dung-cho-gmail/");
        }

        private void ggMap_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/C%C3%94NG+TY+TNHH+MAI+LAN/@20.6745053,106.061093,858m/data=!3m1!1e3!4m6!3m5!1s0x3135c6d6a0ccd3df:0x5353f7022381a64f!8m2!3d20.6749489!4d106.0592449!16s%2Fg%2F1hc5v5tpj?entry=ttu");
        }
    }
}

