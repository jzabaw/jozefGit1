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

namespace WpfAppBinding
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> m_oPersonList = null;
        private Person person;
        public MainWindow()
        {
            InitializeComponent();
           
            person = new Person(1, "juju", "zab", 35);
            Grid1.DataContext = person;
            Label11.Content = person.Age;
            InitBinding();
        }
        private void InitBinding()
        {
            m_oPersonList = new List<Person>();
            m_oPersonList.Add(person);
            m_oPersonList.Add(new Person(2,"Jan","Kowalski",44));
            m_oPersonList.Add(new Person(3, "Józef", "Koza", 46));
            m_oPersonList.Add(new Person(4, "Leon", "Iksiński", 22));
            FirstPersons.ItemsSource = m_oPersonList;

        }

        private void FirstPersons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    public class Person
    {
        public int PersonId {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person(int nPersonId, string sFirstName, string sLastName, int nAge)
        {
            PersonId = nPersonId;
            FirstName = sFirstName;
            LastName = sLastName;
            Age = nAge;
        }
    }
}
