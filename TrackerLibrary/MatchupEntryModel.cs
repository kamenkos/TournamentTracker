using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{

    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one Team in this matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this perticular matchup
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents matchup that this Team came from as a winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
