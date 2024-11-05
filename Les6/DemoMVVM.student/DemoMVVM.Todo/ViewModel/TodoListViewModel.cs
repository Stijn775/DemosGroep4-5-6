using Odisee.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMVVM.Todo.Models;
using DemoMVVM.Todo.Repositories;
using System.ComponentModel;
using DemoMVVM.Todo.Enumerations;

namespace DemoMVVM.Todo.ViewModel
{
    class TodoListViewModel : ObservableObject
    {
        private TodoListStatus? status;
        private bool isEnabled;

        public RelayCommand CreateClicked { get; set; }
        public RelayCommand EditClicked { get; set; }
        public RelayCommand DeleteClicked { get; set; }
        public  ObservableCollection<Models.Todo> Todos { get; set; }

        public TodoListStatus? Status { get => status; 
            set => SetProperty(ref status, value); }
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
