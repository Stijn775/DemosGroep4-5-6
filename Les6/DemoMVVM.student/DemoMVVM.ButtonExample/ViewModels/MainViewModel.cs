using Odisee.Common;

namespace DemoMVVM.ButtonExample.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        FirstViewModel firstViewModel = new FirstViewModel();
        SecondViewModel secondViewModel = new SecondViewModel();
        ThirdViewModel thirdViewModel = new ThirdViewModel();

        private BaseViewModel currentViewModel;

        public BaseViewModel CurrentViewModel { get => currentViewModel; set => SetProperty(ref currentViewModel, value); }

        public MainViewModel()
        {
            firstViewModel.ChangePage += ChangePage;
            secondViewModel.ChangePage += ChangePage;
            thirdViewModel.ChangePage += ChangePage;
            currentViewModel = firstViewModel;
        }

        private void ChangePage(object? sender, int e)
        {
            switch (e)
            {
                case 1:
                    CurrentViewModel = firstViewModel;
                    break;
                case 2:
                    CurrentViewModel = secondViewModel;
                    break;
                case 3:
                    CurrentViewModel = thirdViewModel;
                    break;
            }
        }
    }
}
