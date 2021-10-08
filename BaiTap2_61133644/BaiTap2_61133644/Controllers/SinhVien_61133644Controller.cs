using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap2_61133644.Models;

namespace BaiTap2_61133644.Controllers
{
    public class SinhVien_61133644Controller : Controller
    {
        // GET: SinhVien_61133644
        public ActionResult Index()
        {
            return View();
        }
      public ActionResult Detail(sinhvien sv)
        {
            ViewBag.Id = sv.Id;
            ViewBag.Name = sv.Name;
            ViewData["Marks"] = sv.Marks;
            return View();
        }
        public ActionResult Index1(sinhvien sv)
        {
            ViewBag.Id = sv.Id;
            ViewBag.Name = sv.Name;
            ViewData["Marks"] = sv.Marks;
            return View();
        }
    }
}