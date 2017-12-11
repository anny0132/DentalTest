using Dental.Infrastructure;
using Dental.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace Dental.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<AppointmentDateGroupViewModel> data = from appointment in db.Appointments
                                                             group appointment by appointment.Date into dateGroup
                                                             select new AppointmentDateGroupViewModel()
                                                             {
                                                                 AppointmentDate = dateGroup.Key,
                                                                 PatientCount = dateGroup.Count()
                                                             };
            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}