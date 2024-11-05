using Odisee.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.BMI
{
    class MainViewModel: ObservableObject
    {
        private double bmi;

        public string Title { get; set; } = "Bereken BMI!";

        public double Lengte { 
            get; 
            set; 
        }
        public double Gewicht { get; set; }
        public double BMI
        {
            get { return bmi; }
            set
            {
                SetProperty(ref bmi, value);
            }
        }

        public RelayCommand BMIClickCommand { get; private set; }

        public MainViewModel()
        {
            BMIClickCommand = new RelayCommand(CalculateBMI, CanCalculateBMI);
        }

        private bool CanCalculateBMI()
        {
            return Gewicht > 0 && Lengte > 0; 
        }

        private void CalculateBMI()
        {
            BMI = Gewicht / (Lengte * Lengte);
        }
    }
}
