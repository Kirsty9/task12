using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task12.Models
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            ViewBag.aaa = "这是我的控制器的index的动作内容kirsty";
            return View();
        }
    }
}