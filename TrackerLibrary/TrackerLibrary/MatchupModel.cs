using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// the matchup object.
    /// 
    /// This represents one match in the tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// This represents the set of teams that were involved in this match.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Easier if later we want to see a list of everyone who won.
        /// 
        /// This represents the winner of the match.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// This represents which round this match is a port of.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
