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
            TodoDetailViewModel.PropertyChanged += TodoDetailViewModel_PropertyChanged;
        }

        private void TodoDetailViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Status":
                    if(TodoDetailViewModel.Status == Enumerations.TodoDetailStatus.ItemCreated)
                    {
                        TodoDetailViewModel.IsEnabled = false;
                        TodoListViewModel.IsEnabled = true;
                        TodoListViewModel.Status = null;
                    }
                    break;
            }
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
                        TodoDetailViewModel.Status = Enumerations.TodoDetailStatus.Create;
                    } else if(TodoListViewModel.Status == Enumerations.TodoListStatus.Edit)
                    {
                        TodoDetailViewModel.IsEnabled = true;
                        TodoListViewModel.IsEnabled = false;
                        TodoDetailViewModel.Status = Enumerations.TodoDetailStatus.Edit;
                        TodoDetailViewModel.Id = TodoListViewModel.SelectedTodo.Id;
                    }
                    break;
                case "SelectedTodo":
                    TodoDetailViewModel.TodoTitle = TodoListViewModel.SelectedTodo.Title;
                    TodoDetailViewModel.TodoDueDate = TodoListViewModel.SelectedTodo.DueDate;
                    TodoDetailViewModel.TodoIsChecked = TodoListViewModel.SelectedTodo.Checked;
                    break;
            }
        }
    }
}
