using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Dog
    {
        public string name;
        public string breed;
        public int age;
        public double weight;

        public void Barking()
        {
            Console.WriteLine($"{this.name} : I hate niggers");
        }
        public int GrowUp()
        {
            return ++age;
        }
    }

}
