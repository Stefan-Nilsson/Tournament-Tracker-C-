using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
   public class PersonModel
    {
        /// <summary>
        /// move order for top effeciency:
        /// prop tab tab, write typehint, press enter, press tab, write name, enter, enter
        /// 
        /// This represents the first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Best practice by the industry to split first and last name.
        /// Also easier to adress someone in a more personal or formal way by using first or last name to adress in an email
        /// instead of just using the full name: dear stefan vs dear stefan nilsson
        /// Also better practice to let the user split the first and last name beforehand instead of formatting it afterwards.
        /// Someone might have a space in their first or last name. This could make things more difficult.
        /// 
        /// This represents the last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// This represents the email.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// best practice to store as a string because we don't treat it as a number.
        /// We won't add to a cellphone number for example.
        /// It is what it is and it shouldn't change. 
        /// Also easier to format if it is a string, things like area code etc.
        /// 
        /// This represents the cellphone number.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
