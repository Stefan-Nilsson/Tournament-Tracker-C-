using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
   public class PersonModel
    {
        // move order for top effeciency:
        // prop tab tab, write typehint, press enter, press tab, write name, enter, enter
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellphoneNumber { get; set; }
    }
}
