using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace TodoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string TodoTitle { get; set; }
        public string TodoDescription { get; set; }
        public DateTime TodoDueDate { get; set; } = DateTime.Now;
        public ObservableCollection<Todo> Todos { get; set; }

        public ICommand SaveTodoCommand { get; set; }

        public MainWindow()
        {
            DataContext = this;

            Todos = new ObservableCollection<Todo>()
            {
                new Todo("Demo", "Demo", new DateTime(2025,1,1))
            };

            SaveTodoCommand = new RelayCommand(
                () =>
                {
                    Todos.Add(new Todo(TodoTitle, TodoDescription, TodoDueDate));
                },() =>
                {
                    return !string.IsNullOrEmpty(TodoTitle) && !string.IsNullOrEmpty(TodoDescription) && TodoDueDate >= DateTime.Today;
                });

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Todos.Add(new Todo(TodoTitle, TodoDescription, TodoDueDate ));
        //}
    }

}