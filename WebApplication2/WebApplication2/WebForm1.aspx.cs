using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net.Configuration;
using System.Net;
using System.Configuration;
using System.Text;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(TextBox1.Text);
                SmtpClient smtpobj = new SmtpClient("smtp.gmail.com");
                smtpobj.Port = 25;
                mail.SubjectEncoding = Encoding.UTF8;
                mail.Priority = MailPriority.Normal;
                smtpobj.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpobj.UseDefaultCredentials = false;
                smtpobj.Credentials = new System.Net.NetworkCredential("error4206@gmail.com", "aniket@2001");
                mail.Subject = TextBox3.Text;
                smtpobj.EnableSsl = true;
                smtpobj.Timeout = 40000;
                mail.To.Add(TextBox2.Text);
                //if (FileUpload1.HasFile)
               // {
                mail.Attachments.Add(new Attachment(@"c:\users\g.sudarshan\documents\visual studio 2010\Projects\WebApplication2\WebApplication2\HTMLPage1.htm"));

               // }

                smtpobj.Send(mail);
                Label4.Text = "Marksheet sent Through mail";
                mail.To.Clear();
            }
            catch (Exception ex)
            {
                Label4.Text = ex.StackTrace;
            }
        }
    }
}




