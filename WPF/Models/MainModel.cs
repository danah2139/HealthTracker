﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Models
{
    public class MainModel
    {
        public MainModel()
        {

        }

        public BL.FoodBL getModel()
        {
            return new BL.FoodBL();
        }
//we need to check if we r getting one report or 
//a several reports
    }
}
