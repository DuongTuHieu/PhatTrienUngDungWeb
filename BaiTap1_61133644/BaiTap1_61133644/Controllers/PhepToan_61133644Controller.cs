using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap1_61133644.Models;

namespace BaiTap1_61133644.Controllers
{
    public class PhepToan_61133644Controller : Controller
    {
        // GET: PhepToan_61133644
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(double a, double b, string pt = "+")
        {
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }
        public ActionResult Indexmodel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Indexmodel(PhepToan cal)
        {
            switch (cal.pt)
            {
                case "+": ViewBag.KQ = cal.a + cal.b; break;
                case "-": ViewBag.KQ = cal.a - cal.b; break;
                case "*": ViewBag.KQ = cal.a * cal.b; break;
                case "/":
                    if (cal.b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = cal.a / cal.b; break;
            }
            return View();
        }

    }
}
