using DemoMVVM.Todo.Enumerations;
using DemoMVVM.Todo.Repositories;
using Odisee.Common;

namespace DemoMVVM.Todo.ViewModel
{
    class TodoDetailViewModel : ObservableObject
    {
        private bool isEnabled = false;
        private TodoDetailStatus? status;
        private string todoTitle;
        private DateTime? todoDueDate;
        private bool todoIsChecked;

        public bool IsEnabled { get => isEnabled; set => SetProperty(ref isEnabled, value); }

        public string TodoTitle { get => todoTitle; set => SetProperty(ref todoTitle, value); }
        public DateTime? TodoDueDate { get => todoDueDate; set => SetProperty(ref todoDueDate, value); }
        public bool TodoIsChecked { get => todoIsChecked; set => SetProperty(ref todoIsChecked, value); }

        public Guid Id { get; set; }

        public RelayCommand SaveCommand { get; set; }

        public TodoDetailStatus? Status { get => status; set => SetProperty(ref status, value); }

        public TodoDetailViewModel()
        {
            SaveCommand = new RelayCommand(SaveTodo, CanSaveTodo);
        }

        private bool CanSaveTodo()
        {
            return !String.IsNullOrEmpty(TodoTitle) && TodoDueDate >= DateTime.Today;
        }

        private void SaveTodo()
        {
            Models.Todo todo = new Models.Todo();
            todo.Title = TodoTitle;
            todo.DueDate = TodoDueDate;
            todo.Checked = TodoIsChecked;

            if (Status == TodoDetailStatus.Create)
            {
                TodoRepository.Add(todo);
                Status = TodoDetailStatus.ItemCreated;
            }
            else if (Status == TodoDetailStatus.Edit)
            {
                todo.Id = Id;
                TodoRepository.Update(todo);
                Status = TodoDetailStatus.ItemEdited;
            }
        }
    }
}
