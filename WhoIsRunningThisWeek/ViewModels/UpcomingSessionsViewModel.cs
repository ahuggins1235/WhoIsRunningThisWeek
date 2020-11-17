namespace WhoIsRunningThisWeek
{
    /// <summary>
    /// View model that holds and manages data for the upcoming sessions
    /// </summary>
    public class UpcomingSessionsViewModel
    {

        #region public properties

        /// <summary>
        /// The session model for session this week
        /// </summary>
        public SessionModel ThisWeekSession { get { return SessionManagement.ThisWeekSession; } set { SessionManagement.ThisWeekSession = value; } } 

        /// <summary>
        /// The session model for the session next week
        /// </summary>
        public SessionModel NextWeekSession { get { return SessionManagement.NextWeekSesssion; } set { SessionManagement.NextWeekSesssion = value;  } }


        #endregion public properties

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public UpcomingSessionsViewModel()
        {
            
        }

        #endregion Constructor

    }
}