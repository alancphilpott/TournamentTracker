using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }
        
        /// <summary>
        /// Represents the tournament entry fee.
        /// </summary>
        public decimal EntryFree { get; set; }
        
        /// <summary>
        /// Represents the list of teams in the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        
        /// <summary>
        /// Represents the list of prizes offered by the tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        
        /// <summary>
        /// Represents the matchups in each round of the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
