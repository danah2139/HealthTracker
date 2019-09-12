using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BE;
using WPF.UserControls;
using WPF.Models;

namespace WPF.ViewModels
{
    public class ProfileVM
    {
        public Profile Profile { get; set; }
        ProfileModel ProfileModel { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public ProfileVM(int id)
        {
            ProfileModel = new ProfileModel();
            Users = new ObservableCollection<User>();
        }

        
    }
}
