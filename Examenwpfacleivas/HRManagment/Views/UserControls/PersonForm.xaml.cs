using Entities.Models;
using HRManagment.Controllers;
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

namespace HRManagment.Views.UserControls
{
    /// <summary>
    /// Interaction logic for PersonForm.xaml
    /// </summary>
    public partial class PersonForm : UserControl
    {
        PersonController pc;
        public PersonForm()
        {
            InitializeComponent();
            SetupController();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Person GetData()
        {
            Person person = new Person
            {
                Names = NameTextBox.Text,
                ItemNames = ItemNameTextBox.Text,
              
            };
            return person;
        }

        public void SetData(Person data)
        {
            NameTextBox.DataContext = data;
            ItemNameTextBox.DataContext = data;
           
        }

       


        protected void SetupController()
        {
            pc = new PersonController(this);
            this.SaveButton.Click += new RoutedEventHandler(pc.PersonEventHandler);
            this.OpenButton.Click += new RoutedEventHandler(pc.PersonEventHandler);
            this.Agregar.Click += new RoutedEventHandler(pc.PersonEventHandler);
        }
        public void Hide()
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
