using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class Persoon : INotifyPropertyChanged
    {
        private string firstname;
        private string message;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Firstname
        {
            get => firstname;
            set
            {
                firstname = value;
                Message = $"Hello {firstname}";
                OnPropertyChanged();
            }
        }



        public string Message
        {
            get => message;
            set
            {
                message = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }




        public Persoon(string firstname)
        {
            Firstname = firstname;
        }
    }

    public partial class MainWindow : Window
    {
        public Persoon Persoon { get; set; } = new Persoon("Matthias Druwé");
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Persoon.Firstname = "World";
        }
    }
}