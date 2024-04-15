using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Familiq
    {
        private string familyName;

        public string FamilyName
        {
            get
            {
                return familyName;
            }
            set
            {
                familyName = value;
            }
        }

        private List<Person> members = new List<Person>();
        public List<Person> Members
        {
            get
            {
                return members;
            }
            set
            {
                members = value;
            }
        }

        public void PrintAllMembers()
        {
            Console.WriteLine($"Family: {this.familyName}");
            foreach (Person item in this.Members)
            {
                item.IntroduceYourself();
            }
        }
    }
}
