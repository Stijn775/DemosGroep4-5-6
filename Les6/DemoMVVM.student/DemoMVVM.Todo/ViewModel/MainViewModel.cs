using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.Todo.ViewModel
{
    class MainViewModel
    {
        public string Title { get; set; } = "Todo App";

        public TodoDetailViewModel TodoDetailViewModel { get; set; }
        public TodoListViewModel TodoListViewModel { get; set; }

        public MainViewModel()
        {
            TodoDetailViewModel = new TodoDetailViewModel();
            TodoListViewModel = new TodoListViewModel();

            TodoListViewModel.PropertyChanged += TodoListViewModel_PropertyChanged;
            TodoDetailViewModel.PropertyChanged += TodoDetailViewModel_PropertyChanged;
        }

        private void TodoListViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Status":
                    if (TodoListViewModel.Status == Enumerations.TodoListStatus.Create)
                    {
                        TodoDetailViewModel.IsEnabled = true;
                        TodoListViewModel.IsEnabled = false;
                    }
                    break;
            }
        }

        private void TodoDetailViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(TodoDetailViewModel.IsEnabled) && !TodoDetailViewModel.IsEnabled)
            {
                TodoListViewModel.IsEnabled = true;
            }
        }
    }
}
