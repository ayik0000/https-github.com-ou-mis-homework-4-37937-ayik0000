using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person
            {
                Name = "Walder",
                Alias = "Hodor",
                Alliance = "House Stark",

            };
            Person person2 = new Person
            {
                Name = "Margaery Tyrell",
                Alias = "The Little Queen, the Little Rose,Maid Margaery",
                Alliance = "House Tyrell",
            };
            List<Person> listPerson = new List<Person>();
            listPerson.Add(person);
            listPerson.Add(person2);

            JavascriptSerializer javascriptSerializer = new JavascriptSerializer();
            string jsonstring = javascriptSerializer.Serialize(listPerson);

            Console.Write(jsonstring);
            



        }
    }

}
