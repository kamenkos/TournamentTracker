using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one match at a Tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// The set of Teams that are involved in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round was this match part of
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
