using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for AddView.xaml
    /// </summary>
    public partial class AddView : UserControl
    {
        private Person person = new Person();

        public event Action<Person> addPerson;

        public Person Person
        {
            get => person; set
            {
                person = value;
                DataContext = Person;
            }
        }
        public AddView()
        {
            InitializeComponent();
            DataContext = Person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            addPerson?.Invoke(Person);
            Person = new Person();
        }
    }
}
