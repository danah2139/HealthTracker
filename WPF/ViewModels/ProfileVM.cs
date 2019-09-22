using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BE;
using WPF.UserControls;
using WPF.Models;
using System.Windows.Input;
using WPF.Commands;

namespace WPF.ViewModels
{
    public class ProfileVM
    {
        public Profile Profile { get; set; }
        public ProfileModel ProfileModel { get; set; }
        public ICommand AddProfile { get; set; }
        public ICommand UpdateProfileCommand { get; set; }


        // public ObservableCollection<User> Users { get; set; }
        public ProfileVM()
        {
            ProfileModel = new ProfileModel();
            AddProfile = new AddProfileCommand(this);
            //Users = new ObservableCollection<User>();
            UpdateProfileCommand = new UpdateProfileCommand(this);


        }

        internal void AddNewProfile()
        {
            ProfileModel.AddUser();
        }
        internal void UpdateNewProfile()
        {
            ProfileModel.UpdateUser();
        }
    }
}
