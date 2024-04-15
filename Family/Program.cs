namespace Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person gosho = new Person();
            //gosho.Name = Console.ReadLine();
            //gosho.Age = int.Parse(Console.ReadLine());
            //gosho.IntroduceYourself();

            ////List<Person> group2 = new List<Person>();
            ////string answer = "YES";
            ////int index = 1;
            ////while (answer == "YES")
            ////{
            ////    Person current = new Person();
            ////    Console.WriteLine($"Dai ime na {index} chovek");
            ////    current.Name = Console.ReadLine();

            ////    Console.WriteLine($"Dai vuzrast na {index} choevek");
            ////    current.Age = int.Parse(Console.ReadLine());
            ////    group2.Add(current);

            ////    Console.WriteLine("Do you want more? (YES for more)");
            ////    answer = Console.ReadLine();

            ////    index++;
            ////}

            ////foreach (Person current in group2)
            ////{
            ////    Console.WriteLine(current.Name);
            ////}
            ///


            Familiq family = new Familiq();
            family.FamilyName = "Belezirevi";
            Console.Write("Input count of family members: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i+1} chovek");
                Person current = new Person();
                Console.Write("Ime: ");
                current.Name = Console.ReadLine();
                Console.Write("Age: ");
                current.Age = int.Parse(Console.ReadLine());
                family.Members.Add(current);
            }
           
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count-1; j++)
                {
                    if (family.Members[j].Age > family.Members[j + 1].Age)
                    {
                        Person swap = family.Members[j];
                        family.Members[j] = family.Members[j + 1];
                        family.Members[j + 1] = swap;
                    }
                }
            }
            family.PrintAllMembers();
        }
    }
}
