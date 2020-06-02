using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one team in the matchup
    /// </summary>
    public class MatchupEntryModel
    {
        // below i will use XML comments for the first time. This is initiated by using / 3 times in a row
        // it will then use an opening tag, space to write and a closing tag

        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team
        /// came from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        /*
        /// <summary>
        /// here you document the method
        /// we could even open a "<" at the end to see all the options
        /// some of the options are: exeption, permission, remarks, seealso etc.
        /// you can document a whole lot of things
        /// </summary>
        /// <param name="initialScore">
        /// here you can document the parameter
        /// We could even also document the return type
        /// </param>
        public MatchupEntryModel(double initialScore)
        {
            // snippet cw tab tab
            Console.WriteLine();
        }
        */
    }
}
