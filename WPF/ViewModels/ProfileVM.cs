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
using System.ComponentModel;
using System.Windows;

namespace WPF.ViewModels
{
    public class ProfileVM: DependencyObject, INotifyPropertyChanged
    {
        public Profile Profile { get; set; }
        public ProfileModel ProfileModel { get; set; }
        public ICommand AddProfile { get; set; }
        public ICommand CancelProfileCommand { get; set; }

        public ProfileVM()
        {
            ProfileModel = new ProfileModel();
            AddProfile = new AddProfileCommand(this);
            CancelProfileCommand = new CancelProfileCommand();

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    
        private Boolean isDone;//true when user was registered successfully or when user click on cancel button.
        public Boolean IsDoneProperty
        {
            get { return isDone; }
            set
            {
                isDone = value;
                if (value == true)
                    NotifyPropertyChanged("IsDone");
            }
        }

        internal void addNewProfile()
        {
            ProfileModel.addUser();
            this.IsDoneProperty = true;

        }

        public void close()
        {
            this.IsDoneProperty = true;
        }
    }
}
