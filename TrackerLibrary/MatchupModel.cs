using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the teams in the matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        
        /// <summary>
        /// Represents the winner of the matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
        
        /// <summary>
        /// Represents the round of the matchup.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
