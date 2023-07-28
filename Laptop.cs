using System;
namespace Assignment18
{
    public class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        public string Brand { get; set; }
        public bool IsConnected { get;  set; }
        public int BatteryPercentage { get; set; }

        public Laptop(string brand)
        {
            Brand = brand;
            IsConnected = false;
            BatteryPercentage = 0;
        }

        public bool Connect()
        {
            IsConnected = true;
            return IsConnected;
        }

        public void Charge(int minutes)
        {
           
            BatteryPercentage += minutes / 1; 

        }

        public string Display()
        {
            return $"\nLaptop Brand: {Brand} \n\nBattery Percentage: {BatteryPercentage}% \n";
        }
    }
}