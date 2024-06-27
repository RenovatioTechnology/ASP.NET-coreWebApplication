using coreRTWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace coreRTWebApp.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public IActionResult Index()
        {
            return View(new ContactMessage());
        }

        // POST: Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContactMessage model)
        {
            if (ModelState.IsValid)
            {
                // Send email to recipient
                SendEmailToRecipient(model);

                // Forward email content to hello@renovatio.cloud
                ForwardEmailContent(model);

                // Redirect to success page
                return RedirectToAction("Success");
            }

            // If validation fails, redisplay form with errors
            return View(model);
        }

        // Send email to recipient method
        private void SendEmailToRecipient(ContactMessage model)
        {
            // Your existing code to send email to the recipient
            // Use the SendEmail method you previously implemented
        }

        // Forward email content to another email address
        private void ForwardEmailContent(ContactMessage model)
        {
            var senderEmail = !string.IsNullOrEmpty(model.Email) ? new MailAddress(model.Email, model.Name ?? "Sender") : new MailAddress("sender@example.com", "Sender");
            var receiverEmail = new MailAddress("jnah@renovatio.cloud", "Hello Renovatio");

            var subject = $"Contact Form Submission: {model.Subject}";
            var body = $"Name: {model.Name ?? "N/A"}\nEmail: {model.Email ?? "N/A"}\nSubject: {model.Subject}\nMessage: {model.Message}";

            using (var message = new MailMessage(senderEmail, receiverEmail))
            {
                message.Subject = subject;
                message.Body = body;

                using (var smtp = new SmtpClient())
                {
                    smtp.Send(message);
                }
            }
        }

        // Success page
        public IActionResult Success()
        {
            return View();
        }
    }
}
