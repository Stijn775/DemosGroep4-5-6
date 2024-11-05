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

        public TodoDetailViewModel TodoDetailViewModel { get; set; } = new TodoDetailViewModel();
        public TodoListViewModel TodoListViewModel { get; set; } = new TodoListViewModel();

        public MainViewModel()
        {
            TodoListViewModel.PropertyChanged += TodoListViewModel_PropertyChanged;
        }

        private void TodoListViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Status":
                    if(TodoListViewModel.Status == Enumerations.TodoListStatus.Create)
                    {
                        TodoDetailViewModel.IsEnabled = true;
                        TodoListViewModel.IsEnabled = false;
                    }
                    break;
            }
        }
    }
}
