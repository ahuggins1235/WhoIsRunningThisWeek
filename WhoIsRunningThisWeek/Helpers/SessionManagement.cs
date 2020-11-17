
using System;

namespace WhoIsRunningThisWeek
{
    /// <summary>
    /// Helper class to manage all of the sessions in the applicatoin
    /// </summary>
    public static class SessionManagement
    {
        #region Public members

        /// <summary>
        /// The sesesion model for the session happening this week
        /// </summary>
        public static SessionModel ThisWeekSession { get; set; } = GetThisWeekSesssion();

        /// <summary>
        /// The session moodel for the session happeing next week
        /// </summary>
        public static SessionModel NextWeekSesssion { get; set; } = GetNextWeekSession();

        #endregion Public members


        #region Public methods

        /// <summary>
        /// Gets a session model for the session this week
        /// </summary>
        /// <returns>A session model for this weeks session</returns>
        public static SessionModel GetThisWeekSesssion()
        {
            // stores the date of the session this week
            var dateOfThisWeekSession = DateTime.Now;

            // increments through each day of the current week until it arrives at a Saturday
            while (dateOfThisWeekSession.DayOfWeek != DayOfWeek.Saturday)
            {
                dateOfThisWeekSession = dateOfThisWeekSession.AddDays(1);
            }
                

            // assembles the session model for the next session
            return new SessionModel 
            { 
                Saturday = true, 
                DateOfSession = dateOfThisWeekSession,
                Person = Person.Ben
                //PeopleManagement.People.Find(p => p.Name == "Ben")
            };
            
        }



        /// <summary>
        /// Gets a session model for the session next week
        /// </summary>
        /// <returns>A session model for next week session</returns>
        public static SessionModel GetNextWeekSession()
        {
            // stores the date of session next week
            var dateOfNextSession = ThisWeekSession.DateOfSession.AddDays(3);

            // increments through each day of next week until it arrives at a Saturday
            while (dateOfNextSession.DayOfWeek != DayOfWeek.Saturday)
            {
                dateOfNextSession = dateOfNextSession.AddDays(1);
            }


            // determines if the person running next weeks session should default to should be Ben or Tom
            var nextWeekPerson = ThisWeekSession.Person == Person.Ben ? Person.Tom : Person.Ben;

            // assembles the session model for the next session
            return new SessionModel
            {
                Saturday = true,
                DateOfSession = dateOfNextSession,
                Person = nextWeekPerson
            };
        }

        #endregion Public methods
    }
}