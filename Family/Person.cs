using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get; set;
        }
        public int Age
        {
            get { return age; }
            set
            {
                while (value < 0 || value > 117)
                {
                    Console.WriteLine("Invalid age, please try again");
                    value = int.Parse(Console.ReadLine());
                }
                age = value;

            }
        }


        public void IntroduceYourself()
        {
            Console.WriteLine($"I am {this.Name} i sum na {this.Age}");
        }
    }
}
