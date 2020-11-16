
using System.Collections.Generic;

namespace WhoIsRunningThisWeek
{
    /// <summary>
    /// Helper class to manage all of the people in the applicatoin
    /// </summary>
    public static class PeopleManagement
    {
        /// <summary>
        /// List of all the people in the application
        /// </summary>
        public static List<PersonModel> People { get; set; } = new List<PersonModel>
        {
            // creates a PersonModel for each person in the dnd group and adds it to the list
            new PersonModel {Name = "Ben", HowGoodTheyAre = 6},
            new PersonModel {Name = "Micheal", HowGoodTheyAre = 7},
            new PersonModel {Name = "Daina", HowGoodTheyAre = 8},
            new PersonModel {Name = "Matthew", HowGoodTheyAre = 7},
            new PersonModel {Name = "Tom", HowGoodTheyAre = 1},
            new PersonModel {Name = "Andrew", HowGoodTheyAre = 10}
        };
    }
}