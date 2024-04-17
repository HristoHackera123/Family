﻿using System;
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
                }
                else if (Members[i].Age > maxAge) 
                {
                    maxIndex = i; 
                }
            }
            Console.WriteLine($"{Members[maxIndex].Name} is the youngest, being {Members[maxIndex].Age}");
            Console.WriteLine($"{Members[minIndex].Name} is the oldest, being {Members[minIndex].Age}");
        }
        public int FindSumOfAges()
        {
            int sum = 0;
            for (int i = 0; i < this.Members.Count ; i++)
            {
                sum += Members[i].Age;
            }
            return sum;
        }
    }
}
