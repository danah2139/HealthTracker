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

namespace WPF.ViewModels
{
    public class ProfileDetailsVM: DependencyObject, INotifyPropertyChanged
    {
        public ProfileDetailsModel ProfileDetailsModel { get; set; }
        public ProfileDetails ProfileDetails { get; set; }
        public ObservableCollection<User> userInfo { get; set; }

        public ProfileDetailsVM(string id)
        {
            ProfileDetailsModel = new ProfileDetailsModel(id);
            //userInfo = new ObservableCollection<User>(ProfileDetailsModel.GetUserInformation(id));

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
