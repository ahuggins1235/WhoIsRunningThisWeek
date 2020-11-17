using System.Collections.Generic;
using System.Web.Mvc;
using System;
using System.Diagnostics;

namespace WhoIsRunningThisWeek.Controllers
{
    public class HomeController : Controller
    {

        #region Actions

        public ActionResult Index()
        {
            // pass in the upcoming sessions view model
            return View(new UpcomingSessionsViewModel());
        }

        public ActionResult Edit()
        {
            return View(new UpcomingSessionsViewModel());
        }


        /// <summary>
        /// Handles the post event for the edit view 
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(FormCollection formData)
        {
            // update the people assigned to both upcoming sessions
            SessionManagement.ThisWeekSession.Person = (Person) Enum.Parse(typeof(Person), formData["ThisWeekSession.Person"].ToString(), true);
            SessionManagement.NextWeekSesssion.Person = (Person) Enum.Parse(typeof(Person), formData["NextWeekSession.Person"].ToString(), true);

            return RedirectToAction("Index");
        }

        public ActionResult TimeCheck()
        {
            // check if today is the date of this week's session
            if (DateTime.Now.Date == SessionManagement.ThisWeekSession.DateOfSession.Date)
            {
                // set next week's session to this week's session
                SessionManagement.ThisWeekSession = SessionManagement.NextWeekSesssion;

                // determine create a new session for next week
                SessionManagement.NextWeekSesssion = SessionManagement.GetNextWeekSession();
            }

            return View();
        }

        #endregion Actions
    }
}