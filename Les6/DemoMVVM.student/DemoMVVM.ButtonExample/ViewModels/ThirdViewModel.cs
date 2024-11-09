﻿using Odisee.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.ButtonExample.ViewModels
{
    class ThirdViewModel : BaseViewModel
    {
        public RelayCommand FirstButtonCommand { get; set; }
        public RelayCommand SecondButtonCommand { get; set; }

        public ThirdViewModel()
        {
            FirstButtonCommand = new RelayCommand(GotoPage1);
            SecondButtonCommand = new RelayCommand(GotoPage2);
        }

        private void GotoPage2()
        {
            ChangePage(this, 2);
        }

        private void GotoPage1()
        {
            ChangePage(this, 2);
        }
    }
}
