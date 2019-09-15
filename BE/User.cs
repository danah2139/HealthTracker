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
        public int ID { get; set; }
        public int GoalWeight { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public string DateOfWeight { get; set;}
        //public DateTime DateOfBirth2 { get; set; }
        public enum Gender { male, female,itsComplicated };
        public enum Mood {happy,sad,angry,bored,amused,moody,exited,nervous,stressed };
        public enum FamilyStatus { single,married,divorced,itsComplicated };
        public enum Activity {work,home,fun,study,other };
        private Gender _gender;
        private Mood _mood;
        private FamilyStatus _familyStatus;
        private Activity _activity;
        public string DateOfBirth { get; set; }
        public List<KeyValuePair<string, double>> lstweights { get; set; }

        public User(string name, int iD, int goalWeight, int height, double weight, string dateOfWeight, string dateOfBirth , Gender gender,Mood mood,FamilyStatus familyStatus,Activity activity)
        {
            Name = name;
            ID = iD;
            GoalWeight = goalWeight;
            Height = height;
            Weight = weight;
            DateOfWeight = dateOfWeight;
            DateOfBirth = dateOfBirth;
            _gender = gender;
            _mood=mood;
            _familyStatus = familyStatus;
            _activity = activity;
            lstweights = new List<KeyValuePair<string, double>>() { new KeyValuePair<string, double>(dateOfWeight, weight) };
        }
        public User()
        {
            Name = "Jhon";
            ID = 666;
            GoalWeight = 67;
            Height = 167;
            Weight = 69.0;
            DateOfWeight = "2/3/456";
            DateOfBirth = "2/4/456";
            _gender = Gender.female;
            _mood = Mood.amused;
            _familyStatus = FamilyStatus.divorced;
            _activity = Activity.fun;
            lstweights = new List<KeyValuePair<string, double>>() { new KeyValuePair<string, double>("2/3/456", 31.7), new KeyValuePair<string, double>("2/3/456", 32.0) };
        }
    }
}

