using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// snippet: write prop and double tap. A property will hold one piece of data
        /// snippet2 we wont use for now: ctor: this is to create a constructor
        /// constructor: every time a class is instanciated it would call the constructor and instanciate the property in the constructor
        /// the reason we don't use it is because we can immediately instanciate it as you se below by adding = new List<Person>();
        /// auto property = new list of person
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }

    }
}
