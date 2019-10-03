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


            //string url = ($"https://https://dog.ceo/api/breed/{txtbreed.Text}/images/random");
            

            //creating http client
            using (HttpClient http = new HttpClient())
            {
                var response = http.GetAsync($"https://dog.ceo/api/breed/{txtbreed.Text}/images/random").Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<Dog_Breed>(content);

                    var image = new BitmapImage();
                    image.BeginInit();
                    image.UriSource = new Uri(result.message);
                    image.EndInit();

                    //Return dog image
                    dogImage.Source = image;

                }
                //return when name is invalid
                else
                {
                    MessageBox.Show("Invalid Name");
                    txtbreed.Clear();
                }
                

            }


            


            
        }
    }
}
