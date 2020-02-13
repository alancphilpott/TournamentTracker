using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Represents the person(s) in the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        
        /// <summary>
        /// Represents the teams name.
        /// </summary>
        public string TeamName { get; set; }
    }
}
