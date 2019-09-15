using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;

namespace WPF.Models
{
    public class ProfileModel
    {
        public FoodBL FoodBL { get; set; }
        public ProfileModel()
        {
            FoodBL = new FoodBL();

        }
        public User GetUserInfo(int id)
        {

            return FoodBL.getUserDataById(id);

        }
        public void AddUser()
        {

            BE.User user = new User(Name, Id, GoalWeight, Height, Weight, DateOfWeight, DateOfBirth, Gender,Mood, FamilyStatus, Activity);
            

            FoodBL.addUser(user);
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string dateOfBirth;
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        //public enum Genders { male, female, itsComplicated };
        private User.Gender gender;
        public User.Gender Gender
        {
            get{return gender; }
           set{gender = value;}
        }

        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private int goalWeight;
        public int GoalWeight
        {
            get { return goalWeight; }
            set { goalWeight = value; }
        }

        private string dateOfWeight;
        public string DateOfWeight
        {
            get { return dateOfWeight; }
            set { dateOfWeight = value; }
        }

        //public enum Moods { happy, sad, angry, bored, amused, moody, exited, nervous, stressed }
        private User.Mood mood;
        public User.Mood Mood
        {
            get { return mood; }
            set { mood = value; }
        }

        
        private User.FamilyStatus familyStatus;
        public User.FamilyStatus FamilyStatus
        {
            get { return familyStatus; }
            set { familyStatus = value; }
        }

        //public enum ActivityEnum { work, home, fun, study, other }
        private User.Activity activity;
        public User.Activity Activity
        {
            get { return activity; }
            set { activity = value; }
        }
    }
}
