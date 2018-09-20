using Nexmo.Api;
using sms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sms.Controllers
{
    public class SMSMessageController : Controller
    {
        // GET: SMSMessage
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendMessage(Message message)
        {
            var results = SMS.Send(new SMS.SMSRequest
            {
                from = Configuration.Instance.Settings["appsettings:27815833532"],
                to = message.To,
                text = message.ContentMsg
            });


            return View();
        }
    }
}