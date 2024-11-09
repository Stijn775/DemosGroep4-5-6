using DemoMVVM.Todo.Repositories;
using Odisee.Common;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace DemoMVVM.Todo.ViewModel
{
    class TodoDetailViewModel : ObservableObject
    {
        private bool isEnabled = false;
        private string title;
        private DateTime dueDate = DateTime.Now;
        private ObservableCollection<TodoDetailViewModel> todoItems;
        private TodoListViewModel selectedTodo;

        private bool isCompleted;
        public bool IsCompleted { get => isCompleted; set => SetProperty(ref isCompleted, value); }
        public bool IsEnabled { get => isEnabled; set => SetProperty(ref isEnabled, value); }

        public string TitleText
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged(nameof(TitleText));
            }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set
            {
                dueDate = value;
                OnPropertyChanged(nameof(DueDate));
            }
        }

        public ObservableCollection<TodoDetailViewModel> TodoItems
        {
            get { return todoItems; }
            set
            {
                todoItems = value;
                OnPropertyChanged(nameof(TodoItems));
            }
        }

        public TodoListViewModel SelectedTodo
        {
            get { return selectedTodo; }
            set
            {
                selectedTodo = value;
                OnPropertyChanged(nameof(SelectedTodo));
                UpdateFieldsFromSelectedTodo();
            }
        }

        public RelayCommand SaveCommand { get; set; }
        public RelayCommand CancelCommand { get; set; }

        public TodoDetailViewModel()
        {
            SaveCommand = new RelayCommand(Save);
            CancelCommand = new RelayCommand(Cancel);
        }

        private void Save()
        {
            var newTodo = new Models.Todo
            {
                Title = this.TitleText,
                DueDate = this.DueDate,
                IsCompleted = this.IsCompleted
            };

            TodoRepository.Add(newTodo);

            // Optioneel: velden wissen na opslaan
            TitleText = string.Empty;
            DueDate = DateTime.Now;
            IsCompleted = false;

            // Schakel de detailweergave uit en de lijstweergave in
            IsEnabled = false;
        }

        private void Cancel()
        {
            MessageBox.Show("Cancel");
            IsEnabled = false;
        }

        private void UpdateFieldsFromSelectedTodo()
        {
            if (SelectedTodo != null)
            {
                TitleText = SelectedTodo.Title;
            }
        }
    }
}
