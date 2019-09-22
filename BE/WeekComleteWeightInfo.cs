using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class WeekComleteWeightInfo
    {

        //public int WeightBefore { get; set; }
        //public int WeightNow { get; set; }
        // public DateTime LastUpdatedWeightDate { get; set; }
        //the last time the user updated the system
        //by its weight
        //public DateTime CurrentDate { get; set; }
        //the current time that the user is inpuding his
        //weight data
        [Key]
        public int Id { get; set; }
        public string UserId{ get; set; }
        public double WeightNow { get; set; }
        public string CurrentDate { get; set; }
        public WeekComleteWeightInfo(int id ,string userId,double weightNow,string currentDate)
        {
            Id = id;
            UserId = userId;
            WeightNow = weightNow;
            CurrentDate = currentDate;
        }
        //public string LastUpdatedWeightDate { get; set; }



    }
}
