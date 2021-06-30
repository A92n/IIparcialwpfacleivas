using HRManagment.Controllers;
using System.Windows;

namespace HRManagment.Views.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowController mc;
        public MainWindow()
        {
            InitializeComponent();
            SetupController();
        }
        public void SetupController()
        {
            mc = new MainWindowController(this);
            this.Loaded += new RoutedEventHandler(mc.MainWindowEventHandler);
            RoutedEventHandler routed = new RoutedEventHandler(mc.MainMenuEventHandler);

            this.exitItem.Click += routed;
            this.PersonMenuItem.Click += routed;
          
          
        }
    }
}

