namespace FirstClass
{
    internal class Program
    {
        static void Main()
        {
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();

            dog1.name = "Sarah";
            dog1.breed = "Golden Retriever";
            dog1.age = 3;
            dog1.weight = 6.9;
            dog1.Barking();

            dog2.name = "Cezar";
            dog2.age = 2;
            dog2.breed = "Ulichna prevazhodna";

            dog2.Barking();
            Console.WriteLine($"Happy birthday {dog2.name}! You are now {dog2.GrowUp()}");
        }
    }
}
