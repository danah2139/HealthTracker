using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class WeekComleteWeightInfo
    {

        public int WeightBefore { get; set; }
        public int WeightNow { get; set; }
        // public DateTime LastUpdatedWeightDate { get; set; }
        //the last time the user updated the system
        //by its weight
        public DateTime CurrentDate { get; set; }
        //the current time that the user is inpuding his
        //weight data
        public User User{ get; set; }


    }
}
