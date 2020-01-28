using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaymentsTrack.Controllers
{
    public class HomeController : Controller
    {
        private PaymentTrackerEntities db = new PaymentTrackerEntities();
        public ActionResult Index()
        {
            ViewBag.TotalPayments = db.Payments.Sum(p => p.Amount);
            ViewBag.TotalPaymentsCurrentMonth = db.Payments.Where(p=>p.CreatedOn.Month == DateTime.Now.Month).Sum(p => p.Amount);
            var lastSevenDays = DateTime.Now.AddDays(-7);
            ViewBag.TotalPaymentsLastSevenDays = db.Payments.Where(p => p.CreatedOn >= lastSevenDays).Sum(p => p.Amount);
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
    }
}