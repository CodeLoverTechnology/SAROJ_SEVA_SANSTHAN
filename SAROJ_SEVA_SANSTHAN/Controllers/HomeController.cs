using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace SAROJ_SEVA_SANSTHAN.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Mission()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        
       
        public ActionResult Enquiry()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Enquiry")]
        public ActionResult Enquiry(FormCollection formCollection)
        {
            if (string.IsNullOrEmpty(formCollection["txtName"]))
            {
                ViewBag.Status = "Please Enter User Name.";
                return View();
            }
            if (string.IsNullOrEmpty(formCollection["txtPopMobileNo"]))
            {
                ViewBag.Status = "Please Enter Contact No.";
                return View();
            }
            if (string.IsNullOrEmpty(formCollection["txtEmailID"]))
            {
                ViewBag.Status = "Please Enter EmailID.";
                return View();
            }
            if (string.IsNullOrEmpty(formCollection["txtAddress"]))
            {
                ViewBag.Status = "Please Enter EmailID.";
                return View();
            }
            if (string.IsNullOrEmpty(formCollection["txtMessage"]))
            {
                ViewBag.Status = "Please Enter EMail Body.";
                return View();
            }

            try
            {
                MailMessage message = new MailMessage();
                message.To.Add(formCollection["txtEmailID"].ToString());
                message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                message.From = new System.Net.Mail.MailAddress("info@sarojsevasansthan.in", "SAROJ SEVA SANSTHAN BAGHNOCHA, VAISHALI,BIHAR ENQUIRY");
                message.Bcc.Add("sarojsevasansthanbaghnocha@gmail.com");
                message.Subject = "SAROJ SEVA SANSTHAN BAGHNOCHA, VAISHALI,BIHAR ENQUIRY : " + formCollection["txtName"].ToString();
                message.Body = "Hi " + formCollection["txtName"].ToString() + ", " + System.Environment.NewLine + System.Environment.NewLine
                    + " Your Enquiry Details as Follows : " + System.Environment.NewLine
                    + "======================================================================================== " + System.Environment.NewLine
                    + "  Name : " + formCollection["txtName"].ToString() + System.Environment.NewLine 
                    + "  Contact No : " + formCollection["txtPopMobileNo"].ToString() + System.Environment.NewLine 
                    + "  Email ID : " + formCollection["txtEmailID"].ToString() + System.Environment.NewLine
                    + "  Address : " + formCollection["txtAddress"].ToString() + System.Environment.NewLine
                    + "  Description : " + formCollection["txtMessage"].ToString() + System.Environment.NewLine
                    + " ======================================================================================== " + System.Environment.NewLine
                    + System.Environment.NewLine
                    + System.Environment.NewLine
                    + System.Environment.NewLine
                    + "Thanks & Regards," + System.Environment.NewLine
                   + "SAROJ SEVA SANSTHAN BAGHNOCHA, VAISHALI BIHAR," + System.Environment.NewLine
                   + "info@sarojsevasansthan.in/sarojsevasansthanbaghnocha@gmail.com" + System.Environment.NewLine
                   + "+91- 9797164403/8860845700" + System.Environment.NewLine;
                message.IsBodyHtml = false;
                SmtpClient client = new SmtpClient();
                client.Host = "mail.sarojsevasansthan.in";
                client.Port = 25;
                client.Credentials = new System.Net.NetworkCredential("info@sarojsevasansthan.in", "India$123");
                client.Send(message);
                ViewBag.Status = "Enquiry send Successfully To SAROJ SEVA SANSTHAN BAGHNOCHA, VAISHALI (BIHAR).";
                ModelState.Clear();
            }
            catch (Exception ex)
            {
                ViewBag.Status = "Problem while sending email, Please check details." + ex.ToString();
            }
            return View("Contact");

        }
    }
}