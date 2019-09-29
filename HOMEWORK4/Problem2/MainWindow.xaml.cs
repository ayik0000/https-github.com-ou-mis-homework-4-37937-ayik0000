using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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


            string userURL = $"https://dog.ceo/api/breed/{dogName.Text}/images/random";



            if (dogName.Text != dogName.Text.Split(' ')[0])
            {
                userURL = $"https://dog.ceo/api/breed/{dogName.Text.Split(' ')[1]}-{dogName.Text.Split(' ')[0]}/images/random";
            }

            


            using (HttpClient http = new HttpClient())
            {
                var response = http.GetAsync(userURL).Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    DogApiInstance dog = JsonConvert.DeserializeObject<DogApiInstance>(content);

                    dogImage.Source = new BitmapImage(dog.message);

                }
                else
                {
                    MessageBox.Show("Invalid Name");
                    dogName.Clear();
                }
                

            }


            


            
        }
    }
}
