using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int GoalWeight { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public DateTime DateOfBirth { get; set; }
        public enum Gender { male, female };

    }
}

