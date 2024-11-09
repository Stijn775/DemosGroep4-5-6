using Odisee.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.ButtonExample.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private FirstViewModel firstViewModel = new FirstViewModel();
        public MainViewModel secondViewModel = new SecondViewModel();
        public MainViewModel thirdViewModel = new ThirdViewModel();

        private BaseViewModel currentViewModel;

        public BaseViewModel CurrentVieuw { get { return currentViewModel; } set => SetProperty(ref currentViewModel, value);


    }
}
