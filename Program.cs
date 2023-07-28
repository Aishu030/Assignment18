using System;
namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("**********Device Information*********");
                Smartphone smartphone = new Smartphone("SamsungA70");
                smartphone.Connect();
                smartphone.Charge(1000);
                Console.WriteLine($"Smartphone connected: {smartphone.Connect()}");
                Console.WriteLine(smartphone.Display());

                Laptop laptop = new Laptop("Asus VivoBook");
                laptop.Connect();
                laptop.Charge(89);
                Console.WriteLine($"Laptop connected: {laptop.Connect()}");
                Console.WriteLine(laptop.Display());
                Console.ReadKey();
            }
        }
    }
}
