using Entities.Models;
using HRManagment.ViewModels;
using HRManagment.Views.UserControls;
using HRManagment.Views.Windows;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HRManagment.Controllers
{
    public class MainWindowController
    {
        private MainWindow mainWindow;
        private PersonForm p;
      
        public MainWindowController(MainWindow window)
        {
            mainWindow = window;
        
        }
        public void MainWindowEventHandler(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
        }
        public void MainMenuEventHandler(object sender, RoutedEventArgs e)
        {
            MenuItem Option = (MenuItem)sender;
            switch (Option.Name)
            {
                case "exitItem":
                    Application.Current.Shutdown();
                    break;
                case "PersonMenuItem":
                    mainWindow.DataContext = new PersonViewModel();
                    break;
                  
                case "PersonListMenuItem":
                  //  mainWindow.DataContext = new GroupViewModel() { Title = "Listado" ,  Group = GetGroup()  };
                    break;
               

            }
        }

      /*  private Group GetGroup() {
            Group g = new Group()
            {
                Name = "Listado de nombres",
                Members = new List<Person>
                {


                    g.Members.Add(p.SetData),


                   }
         
            };
        return g;
        
        
        }
      */
       
    }

