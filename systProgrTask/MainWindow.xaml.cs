using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace systProgrTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
        
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LaunchProgram();
        }
        public void LaunchProgram() {
            try

            {// Configure open file dialog box
                var dialog = new Microsoft.Win32.OpenFileDialog();
                dialog.FileName = "Document"; // Default file name
                dialog.DefaultExt = ".exe"; // Default file extension
                dialog.Filter = "Exe Files(.exe) | *.exe | All Files(*.*) | *.* ";

                // Show open file dialog box
                bool? result = dialog.ShowDialog();

                // Process open file dialog box results
                if (result == true)
                {
                    // Open document
                    string processName = dialog.FileName;Process.Start(processName);
                }
                
            }
            catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
