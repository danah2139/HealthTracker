using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BE;
using WPF.Models;

namespace WPF.ViewModels
{
    public class ProfileVM:ObservableCollection<User>
    {
        ProfileModel ProfileModel { get; set; }
        public ProfileVM(int id)
        {
            ProfileModel = new ProfileModel();
        }
    }
}
