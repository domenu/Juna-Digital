using JunaDigitalWebsite.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace JunaDigitalWebsite.Controllers
  {
  public class HomeController : Controller
    {
    public ActionResult Index()
      {
      return View();
      }

    [HttpPost]
    public JsonResult SendMessage(MessageModel messageModel)
      {
      var mailTo = ConfigurationManager.AppSettings["ContactMailTo"];
      var user = ConfigurationManager.AppSettings["ContactSmtpUser"];
      var pwd = ConfigurationManager.AppSettings["ContactSmtpPwd"];

      var from = new MailAddress(messageModel.Email, messageModel.Name);
      var to = new MailAddress(mailTo, "");

      var smtp = new SmtpClient
      {
        Host = "smtp.gmail.com",
        Port = 587,
        EnableSsl = true,
        DeliveryMethod = SmtpDeliveryMethod.Network,
        UseDefaultCredentials = false,
        Credentials = new NetworkCredential(user, pwd)
      };

      var message = new MailMessage(from, to)
            {
              Subject = string.Format("Contact from Juna Digital Website from {0}", from.Address),
              Body = string.Format("{0} send the following message:\r\n\r\n{1}", from.Address, messageModel.Message)
            };

      smtp.Send(message);

      return Json(new { MessageSent = true });
      }
    }
  }