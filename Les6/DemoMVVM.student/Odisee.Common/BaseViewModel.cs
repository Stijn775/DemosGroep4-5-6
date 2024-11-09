using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odisee.Common
{
    public abstract class BaseViewModel : ObservableObject
    {
        private bool isEnabled;
        private string title = "";

        public bool IsEnabled
        {
            get { return isEnabled; }
            set { SetProperty(ref isEnabled, value); }
        }

        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected BaseViewModel()
        {
            Title = "<no title>";
            IsEnabled = true;
        }
    }
}
