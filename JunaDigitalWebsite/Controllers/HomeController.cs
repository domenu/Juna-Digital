using JunaDigitalWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

    public JsonResult SendMessage(MessageModel messageModel)
      {
      return Json(new { MessageSent = true });
      }
    }
  }