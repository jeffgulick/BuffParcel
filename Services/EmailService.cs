using System.Net.Mail;
using System.Net;
using System.Text;

namespace BuffParcel.Services;
public class EmailService
{
    public void SendPackageNotification(string toEmail)
    {
        try
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("noreply@buffteks.org");
            message.To.Add(toEmail);
            message.Subject = "Package Pickup Notification";
           
            string htmlContent = @"
            <html>
                <body>
                    <p>Dear Resident,</p>
                    <p>We have received a package for you at the leasing office. Due to limited storage space, please pick up your package within <strong>5 days</strong>.</p>
                    <p>If the package is not picked up within this time frame, it will be returned to the post office.</p>
                    <p>Thank you!</p>
                    <p>BuffTeks Apartment Leasing Office</p>
                </body>
            </html>
            ";

            message.Body = htmlContent;
            message.IsBodyHtml = true;

            using (SmtpClient smtpClient = new SmtpClient("mail.privateemail.com", 587))
            {
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("noreply@buffteks.org", "cidm4360fall2024@*");
                
                smtpClient.Send(message);
            }
        }
        catch (Exception ex)
        {
            // Log the error or handle it appropriately
            Console.WriteLine($"Failed to send email: {ex.Message}");
        }
    }
}