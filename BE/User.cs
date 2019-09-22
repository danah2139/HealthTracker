using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BE
{
    public class User
    {
        // [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public string Name { get; set; }
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int GoalWeight { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public string DateOfWeight { get; set; }
        //public DateTime DateOfBirth2 { get; set; }
        public Gender Gender { get; set; }
        public Mood Mood { get; set; }
        public FamilyStatus FamilyStatus { get; set; }
        public Activity Activity { get; set; }
        public Gender _gender;
        private Mood _mood;
        private FamilyStatus _familyStatus;
        private Activity _activity;
        public string DateOfBirth { get; set; }
        //public Dictionary<string, double> Lstweights { get; set; }
        public List<WeekComleteWeightInfo> Lstweights { get; set; }
        public User(string name,int id ,string iD,int goalWeight, int height, double weight, string dateOfWeight, string dateOfBirth , Gender gender,Mood mood,FamilyStatus familyStatus,Activity activity,List<WeekComleteWeightInfo> lstweights)
        {
            Name = name;
            Id = id;
            UserId = iD;
            GoalWeight = goalWeight;
            Height = height;
            Weight = weight;
            DateOfWeight = dateOfWeight;
            DateOfBirth = dateOfBirth;
            _gender = gender;
            _mood=mood;
            _familyStatus = familyStatus;
            _activity = activity;
 
        }
        public User()
        {
            Name = "Jhon";
            Id = 1;
            UserId = "666";
            GoalWeight = 67;
            Height = 167;
            Weight = 69.0;
            DateOfWeight = "2/3/456";
            DateOfBirth = "2/4/456";
            _gender = Gender.FEMALE;
            _mood = Mood.AMUSED;
            _familyStatus = FamilyStatus.DIVORCED;
            _activity = Activity.FUN;
            //Lstweights = new List<WeekComleteWeightInfo> (new WeekComleteWeightInfo {Id = 1, UserId = "1111", WeightNow = 33.0, CurrentDate = "33/12/2019" });
        }
    }
}

