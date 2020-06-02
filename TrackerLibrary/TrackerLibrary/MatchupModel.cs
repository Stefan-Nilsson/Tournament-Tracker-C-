using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// This represents the matchup object.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// This represents a list of entries.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Easier if later we want to see a list of everyone who won.
        /// 
        /// This represents a winner.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// This represents the round number.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
