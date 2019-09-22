using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BE;
using BL;

namespace WPF.Models
{
    public class ProfileModel:INotifyPropertyChanged
    {
        public FoodBL FoodBL { get; set; }
        public ProfileModel()
        {
            FoodBL = new FoodBL();


        }

        public List<WeekComleteWeightInfo> LstWights { get; set; }
        public User GetUserInfo()
        {

            return FoodBL.getUserDataById(Id);

        }
        public void AddUser()
        {

            BE.User user = new User(Name,ID ,Id, GoalWeight, Height, Weight, DateOfWeight, DateOfBirth, Gender,Mood, FamilyStatus, Activity, LstWights);
            

            FoodBL.addUser(user);
            MessageBox.Show("Id add Successfully");
        }
        public void UpdateUser()
        {

            BE.User user = new User(Name, ID, Id, GoalWeight, Height, Weight, DateOfWeight, DateOfBirth, Gender, Mood, FamilyStatus, Activity, LstWights);


            FoodBL.UpdateUser(user);
            MessageBox.Show("Id update Successfully");
        }
        public event PropertyChangedEventHandler GenderChanged;
        public event PropertyChangedEventHandler MoodChanged;
        public event PropertyChangedEventHandler FamilyStatusChanged;
        public event PropertyChangedEventHandler ActivityChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property=null)
        {
            this.GenderChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public void OnMoodChanged(string property = null)
        {
            this.MoodChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public void OnFamilyChanged(string property = null)
        {
            this.FamilyStatusChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public void OnActivityChanged(string property = null)
        {
            this.ActivityChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string id;
        public string Id
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
        private Gender gender;
        public Gender Gender
        {
             get         {return gender; }
             set {gender = value; OnPropertyChanged(); }
           // get; set;
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
        public Mood mood;
        public Mood Mood
        {
            get { return mood; }
            set { mood = value; OnMoodChanged(); }
        }

        
        private FamilyStatus familyStatus;
        public FamilyStatus FamilyStatus
        {
            get { return familyStatus; }
            set { familyStatus = value; OnFamilyChanged(); }
        }

        //public enum ActivityEnum { work, home, fun, study, other }
        private Activity activity;
        public Activity Activity
        {
            get { return activity; }
            set { activity = value; OnActivityChanged(); }
        }
    }
}
