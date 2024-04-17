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

        public void FindOldestAndYoungers()
        {
            int minAge = int.MaxValue;
            int minIndex = 0;
            int maxAge = int.MinValue;
            int maxIndex = 0;
            for (int i = 0; i < this.Members.Count; i++)
            {
                if (Members[i].Age < minAge)
                {
                    minIndex = i;
                    minAge = Members[i].Age;
                }
                if (Members[i].Age > maxAge)
                {
                    maxIndex = i;
                    maxAge = Members[i].Age;
                }
            }
            Console.WriteLine($"{Members[minIndex].Name} is the youngest, being {Members[minIndex].Age}");
            Console.WriteLine($"{Members[maxIndex].Name} is the oldest, being {Members[maxIndex].Age}");
        }
        public int FindSumOfAges()
        {
            int sum = 0;
            for (int i = 0; i < this.Members.Count; i++)
            {
                sum += Members[i].Age;
            }
            return sum;
        }
        public void SortMembers()
        {
            int count = this.Members.Count;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (this.Members[j].Age > this.Members[j + 1].Age)
                    {
                        Person swap = this.Members[j];
                        this.Members[j] = this.Members[j + 1];
                        this.Members[j + 1] = swap;
                    }
                    else
                    {
                        if (this.Members[j].Age == this.Members[j + 1].Age)
                        {
                            if (string.Compare(this.Members[j].Name, this.Members[j + 1].Name, true) > 0)
                            {
                                Person swap = this.Members[j];
                                this.Members[j] = this.Members[j + 1];
                                this.Members[j + 1] = swap;
                            }
                        }
                    }
                }
            }
        }
    }
}
