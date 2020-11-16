
namespace WhoIsRunningThisWeek
{
    /// <summary>
    /// Model for a person that could be running an upcoming session
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// name of the person
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// How good they are on a scale of 1 to 10
        /// </summary>
        public int HowGoodTheyAre { get; set; } = 1;
    }
}