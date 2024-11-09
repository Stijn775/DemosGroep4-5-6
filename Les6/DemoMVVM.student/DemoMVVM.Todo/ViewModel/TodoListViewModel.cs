using Odisee.Common;
using System.Collections.ObjectModel;
using DemoMVVM.Todo.Models;
using DemoMVVM.Todo.Repositories;
using DemoMVVM.Todo.Enumerations;

namespace DemoMVVM.Todo.ViewModel
{
    class TodoListViewModel : ObservableObject
    {
        private TodoListStatus? status;
        private bool isEnabled;
        private string title;
        private string dueDate;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public RelayCommand CreateClicked { get; set; }
        public RelayCommand EditClicked { get; set; }
        public RelayCommand DeleteClicked { get; set; }
        public ObservableCollection<Todo> Todos { get; set; }

        public TodoListStatus? Status { get => status; set => SetProperty(ref status, value); }
        public bool IsEnabled { get => isEnabled; set => SetProperty(ref isEnabled, value); }

        public TodoListViewModel()
        {
            Todos = TodoRepository.GetAll();
            CreateClicked = new RelayCommand(CreateCommand);
            EditClicked = new RelayCommand(EditCommand, CanEditCommand);
            DeleteClicked = new RelayCommand(DeleteCommand, CanDeleteCommand);
            IsEnabled = true;
        }

        private void CreateCommand()
        {
            Status = TodoListStatus.Create;
        }

        private bool CanDeleteCommand()
        {
            return false;
        }

        private void DeleteCommand()
        {
            throw new NotImplementedException();
        }

        private bool CanEditCommand()
        {
            return false;
        }

        private void EditCommand()
        {
            throw new NotImplementedException();
        }
    }
}
