using System.ComponentModel;
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

namespace UserEventDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DetailView.SetSelectedPerson(new Person("Demo","Demo","Demo"));
            //ListView.onSelectionChanged += SelectedPersonChanged;
            ListView.PropertyChanged += ListView_PropertyChanged;
           // DetailView.addPerson += DetailView_addPerson;
            DetailView.AddView.addPerson += DetailView_addPerson;
        }

        private void DetailView_addPerson(Person obj)
        {
            ListView.AddPerson(obj);
        }

        private void ListView_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "SelectedPerson")
            {
                DetailView.SetSelectedPerson(ListView.SelectedPerson);
            }
        }
        public void SelectedPersonChanged(object sender, Person p)
        {
            DetailView.SetSelectedPerson(p);
        }
    }
}