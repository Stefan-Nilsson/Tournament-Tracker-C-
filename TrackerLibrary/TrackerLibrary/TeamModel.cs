using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// snippet: write prop and double tap. A property will hold one piece of data (autoproperty)
        /// snippet2 we wont use for now: ctor: this is to create a constructor
        /// constructor: every time a class is instanciated it would call the constructor and instanciate the property in the constructor
        /// the reason we don't use it is because we can immediately instanciate it as you se below by adding = new List<Person>();
        /// auto property = new list of person
        /// That is an auto-property. It is shorthand for a full property. 
        /// Properties are used when we want to pass data around.
        /// We don't use public variables because you cannot bind to them for one (there are a number of reasons). 
        /// An auto property (one with { get; set; } at the end with no other code) 
        /// does not need a private backing field because it is put in place by .NET behind the scenes. 
        /// A full property (one with an actual body of code for the get/set) does need a private backing field 
        /// (unless it is a special one like FullName which just returns FirstName+LastName and is read-only.
        /// Properties are the best way to store and expose data in a class. They allow you to protect data coming in and going out, if you so desire.
        /// They are also the only way to store data that can then be data-bound. 
        /// For example, in a combobox, 
        /// if it contains a list of Person, you cannot display a person's first name if that value is stored in a variable, only a property. 
        /// The general rule of thumb is that if a value needs to be accessed outside of the class, it should be a property, not a public variable.
        /// 
        /// The next property represents a list of all the persons in a team.
        /// It could be one person for example in a chess tournament.
        /// Or it could be multiple persons, in a team, for example in a basketball tournament.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// This represents the name of the team.
        /// </summary>
        public string TeamName { get; set; }

    }
}
