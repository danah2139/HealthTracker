using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using WPF.Models;
using BL;
using System.Collections.ObjectModel;
using WPF.UserControls;

namespace WPF.ViewModels
{
    public class EnterMealsVM

    {
        EnterMealsModel EnterMealsModel { get; set; }
        EnterMeals EnterMeals { get; set; }
        //public string Sr { get; set; }
       public EnterMealsVM()
        {
           // Sr = sr;
            EnterMealsModel = new EnterMealsModel();

        }

    }
}
