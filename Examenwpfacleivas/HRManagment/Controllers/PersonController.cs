using Entities.Models;
using HRManagment.Views.UserControls;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HRManagment.Controllers
{
    public class PersonController
    {
        PersonForm pwindow;
        SaveFileDialog sfdialog;
        OpenFileDialog ofdialog;
       
         public PersonController(PersonForm form)
        {
            pwindow = form;
            sfdialog = new SaveFileDialog();
            ofdialog = new OpenFileDialog();
        }
        public void PersonEventHandler(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            switch (B.Name)
            {
                case "SaveButton":
                    SaveData();
                    break;
                case "OpenButton":
                    OpenFile();
                    break;
                case "Agregar":



                    break;
            }
        }

        private void agregar() {
          
          
                sfdialog.Filter = "Xml File (*.xml)|*.xml";

                if (sfdialog.ShowDialog() == true)
                {
                    Person p;

                    p = pwindow.GetItem;

                    p.ToXml(sfdialog.FileName);
                }
            



        }


        private void OpenFile()
        {
            ofdialog.Filter = "Xml File (*.xml)|*.xml";

            if (ofdialog.ShowDialog() == true)
            {
                Person p = new Person();
                pwindow.SetData(p.FromXml(ofdialog.FileName));               

            }
        }

        private void SaveData()
        {
            sfdialog.Filter = "Xml File (*.xml)|*.xml";
        
            if (sfdialog.ShowDialog() == true)
            {
                Person p;
                
                    p = pwindow.GetData();

                p.ToXml(sfdialog.FileName);
            }
        }
    
            
            
            
            
            }








        }


     


        

