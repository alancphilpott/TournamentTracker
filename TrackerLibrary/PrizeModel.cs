using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the prize place as an integer.
        /// </summary><example>1, 2 ,3</example>
        public int PlaceNumber { get; set; }
        
        /// <summary>
        /// Represents the prize place as a string.
        /// </summary><example>1st, 2nd, 3rd</example>
        public string PlaceName { get; set; }
        
        /// <summary>
        /// Represents the amount offered by the prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        
        /// <summary>
        /// Represents the percentage amount offered by the prize.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
