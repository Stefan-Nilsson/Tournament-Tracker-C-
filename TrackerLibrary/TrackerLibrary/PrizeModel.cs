using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        ///  1 = first place. 2 = second place.
        /// 
        /// This represents the placement in form of a number.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// 1 = first place = champion. 2 = second place = runner up. or maybe 2 = second place = second.
        /// 
        /// This represents the name of the place.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// For example 100.
        /// 
        /// This represents the fixed prize amount.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// For example 50 percent = 50 for first place. 20 percent = 20 for second place etc.
        /// 
        /// This represents the percentage of the 
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
