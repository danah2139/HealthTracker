﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Models
{
    public class MainModel
    {
      
        public BL.FoodBL getModel()
        {
            return new BL.FoodBL();
        }


    }
}
