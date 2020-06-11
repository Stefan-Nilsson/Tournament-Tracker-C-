using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// this Class will be the central data hub
    /// It will be all the data that surrounds the actual tournament
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Every tournament will be given a name. This will help to know what tournament we are talking about
        /// the name is a Natural key. But we should add an id later for indexing purphoses.
        /// 
        /// this represents the tournament name.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Store in type decimal not double.
        /// Decimal is a lot more precise but uses a lot more memory.
        /// That why it is typically only used in the case of money.
        /// 
        /// This represents the entryfee in case the tournament creator decides to add one.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// This represents the list of teams that have entered the tournament.
        /// This is a list of type team.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// This represents the list of prizes in a tournament.
        /// 0 or more list.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// matchup team A vs team B
        /// list of those match ups per round
        /// a list of match ups, round one
        /// another list of match ups is round two, etc.
        /// One list represents one round.
        /// Therefor we have a list of all the lists of matchups
        /// This represents a list of a set of match ups. Thus this holds all the rounds.
        /// For example list match ups round one
        /// 
        /// This represents a list of a list of matchups.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
