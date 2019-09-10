using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class User
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int GoalWeight { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public DateTime DateOfBirth { get; set; }
        public enum Gender { male, female,itsComplicated };
        public enum Mood {happy,sad,angry,bored,amused,moody,exited,nervous,stressed };
        public enum FamilyStatus { single,married,divorced,itsComplicated };
        public enum Activity {work,home,fun,study,other };


    }
}

