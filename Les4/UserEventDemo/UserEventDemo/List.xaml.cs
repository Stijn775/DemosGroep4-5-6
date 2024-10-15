using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : UserControl, INotifyPropertyChanged
    {   
        public event EventHandler<Person> selectionChanged;
        public event PropertyChangedEventHandler? PropertyChanged;

        private List<Person> people = new List<Person>()
            {
                new Person() { Name = "John Doe", PhoneNumber = "1234567890", Email = "john.doe@example.com" },
                new Person() { Name = "Jane Smith", PhoneNumber = "9876543210", Email = "jane.smith@example.com" },
                new Person() { Name = "Mike Johnson", PhoneNumber = "5555555555", Email = "mike.johnson@example.com" }
            };
        private Person selectedPerson;
        private int age;

        public Person SelectedPerson
        {
            get => selectedPerson; 
            set
            {
                selectedPerson = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get => age; 
            set
            {
                age = value;
                OnPropertyChanged();
            }
        }
        public List()
        {
            InitializeComponent();
            PeopleListView.ItemsSource = people;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void PeopleListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PeopleListView.SelectedItem != null )
            {
                SelectedPerson = (Person) PeopleListView.SelectedItem;
               // OnSelectionChanged(SelectedPerson);
                //selectionChanged?.Invoke(this, SelectedPerson);

                //if (onSelectionChanged != null)
                //{
                //    onSelectionChanged(this, SelectedPerson);
                //}
            }
        }
        
        //protected virtual void OnSelectionChanged(Person p)
        //{
        //    selectionChanged?.Invoke(this, p);
        //}
    }
}
