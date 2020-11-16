using System;

namespace WhoIsRunningThisWeek
{
    /// <summary>
    /// Model for an upcoming session
    /// </summary>
    public class SessionModel
    {
        /// <summary>
        /// The date of the session
        /// </summary>
        public DateTime DateOfSession { get; set; }

        /// <summary>
        /// The person who is currently assigned to run the session
        /// </summary>
        public PersonModel Person { get; set; }

        /// <summary>
        /// True if the session is scheduled for a Saturday. False if it is scheduled for a Sunday
        /// </summary>
        public bool Saturday { get; set; } = true;
    }
}