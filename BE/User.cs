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

       
        public string DateOfBirth { get; set; }

        public enum Gender { male, female,itsComplicated };
        public enum Mood {happy,sad,angry,bored,amused,moody,exited,nervous,stressed };
        public enum FamilyStatus { single,married,divorced,itsComplicated };
        public enum Activity {work,home,fun,study,other };

        private Gender _gender;
        private Mood _mood;
        private FamilyStatus _familyStatus;
        private Activity _activity;
        //public DateTime? DateOfBirth { get; set; }

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
    }
}

