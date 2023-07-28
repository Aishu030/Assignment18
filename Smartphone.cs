using System;
namespace Assignment18
{
    internal class Smartphone: IConnectable, IRechargeable, IDisplayable
    {
        public string Model { get; set; }
        public bool IsConnected { get;  set; }
        public int BatteryPercentage { get;  set; }

        public Smartphone(string model)
        {
            Model = model;
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
            BatteryPercentage += minutes / 3; 
            if (BatteryPercentage > 100)
                BatteryPercentage = 100;
        }

        public string Display()
        {
            return $"\nSmartphone Model: {Model} \n\nBattery Percentage: {BatteryPercentage}% \n";
        }
    }
}

