using System.Collections.Generic;
using System.Web.Mvc;

namespace WhoIsRunningThisWeek.Controllers
{
    public class HomeController : Controller
    {

        #region Actions

        public ActionResult Index()
        {
            // pass in this week session 
            return View(SessionManagement.ThisWeekSession);
        }

        public ActionResult Edit()
        {
            return View();
        }

        #endregion Actions
    }
}