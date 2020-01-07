using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF.UserControls;
using WPF.Models;
using BE;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WPF.Commands;

namespace WPF.ViewModels
{
    public class ProfileDetailsVM : DependencyObject, INotifyPropertyChanged
    {
        public ProfileDetailsModel ProfileDetailsModel { get; set; }
        public ProfileDetails ProfileDetails { get; set; }
        public ObservableCollection<User> userInfo { get; set; }
        public List<WeekComleteWeightInfo> LstWights { get; set; }
        public ICommand UpdateProfileCommand { get; set; }
        public event PropertyChangedEventHandler NamePropertyChanged;
        public ProfileDetailsVM(string id)
        {

            ProfileDetailsModel = new ProfileDetailsModel(id);
            UpdateProfileCommand = new UpdateProfileCommand(this);
            User user = ProfileDetailsModel.getUserDataById(id);
            bindUser(user);
        }
        public void bindUser(User user)
        {
            Name = user.Name;
            Id = user.UserId;
            ID = user.Id;
            GoalWeight = user.GoalWeight;
            Height = user.Height;
            Weight = user.Weight;
            DateOfWeight = user.DateOfWeight;
            DateOfBirth = user.DateOfBirth;
            Gender = user._gender;
            Mood = user._mood;
            FamilyStatus = user._familyStatus;
            Activity = user._activity;

        }

        internal void updateNewProfile()
        {
            BE.User user = new User(Name, ID, Id, GoalWeight, Height, Weight, DateOfWeight, DateOfBirth, Gender, Mood, FamilyStatus, Activity, LstWights);
            ProfileDetailsModel.updateUser(user);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name == value)
                    return;
                name = value;
                if (NamePropertyChanged != null)
                {
                    NamePropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
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
            get { return gender; }
            set { gender = value; }
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
            set { mood = value; }
        }


        private FamilyStatus familyStatus;
        public FamilyStatus FamilyStatus
        {
            get { return familyStatus; }
            set { familyStatus = value; }
        }

        //public enum ActivityEnum { work, home, fun, study, other }
        private Activity activity;
        public Activity Activity
        {
            get { return activity; }
            set { activity = value; }
        }
    }
}