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

namespace Problem2
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

        private void Enter_Button_Click(object sender, RoutedEventArgs e)
        {

            
            string Name;

            Console.WriteLine("Please enter a dog breed");
            string userInput = Console.ReadLine();

            List<Dog_Breed> dog_Breeds = new List<Dog_Breed>();
            {
                if(userInput != "Dog_Breed")
                {
                    Console.WriteLine($"Invalid breed name !! Please enter correct breed name");
                }
            }


            
        }
    }
}
