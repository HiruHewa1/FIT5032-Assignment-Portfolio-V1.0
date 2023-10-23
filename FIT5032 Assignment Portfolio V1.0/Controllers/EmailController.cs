using FIT5032_Assignment_Portfolio_V1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;



namespace FIT5032_Assignment_Portfolio_V1._0.Controllers
{
    [Authorize]
    public class EmailController : Controller
    {
        // GET: Email
        // This action returns the view for the contact form.
        public ActionResult Index()
        {
            return View();
        }

        // POST: Email/Contact
        // This action handles the submission of the contact form.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailFormModel model)
        {
            // Check if the model is valid (all required fields are filled and valid)
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Constructing the email body
            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress("hiru.hewa98@gmail.com"));  // Receiver's email address
            message.From = new MailAddress("hiru.hewa98@gmail.com");  // Sender's email address
            message.Subject = "Your email subject";
            message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
            message.IsBodyHtml = true;

            // Check for attachment and add to email if present
            if (model.Attachment != null && model.Attachment.ContentLength > 0)
            {
                var fileName = System.IO.Path.GetFileName(model.Attachment.FileName);
                var attachment = new Attachment(model.Attachment.InputStream, fileName);
                message.Attachments.Add(attachment);
            }
                using (var smtp = new SmtpClient())
                {

                    var credential = new NetworkCredential
                    {
                        UserName = "hiru.hewa98@gmail.com",  // replace with your email
                        Password = "hzcj qdlu zukb zltw"              // replace with your password
                    };

                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";  // Corrected the SMTP server for Gmail
                    smtp.Port = 587;
                    smtp.EnableSsl = true;

                    try
                    {
                        await smtp.SendMailAsync(message);
                        return RedirectToAction("Sent");
                    }
                    catch
                    {
                        ViewBag.Error = "There was an error sending the email. Please try again later.";
                        return View(model);
                    }
                }
            
        }

        // This action returns a view when the email is sent successfully.
        public ActionResult Sent()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";


            return View();
        }
    }
}

