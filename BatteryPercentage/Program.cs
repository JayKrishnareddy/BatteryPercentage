using System;
using System.Management;

namespace BatteryPercentage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Title Display
            Console.Title = "Info about Laptop Battery";
            //Retrieves a collection of system management objects based on below query !
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_Battery");
            foreach(ManagementObject mo in mos.Get())
            {
                // To print the Battery name
                Console.WriteLine("Battery Name\t:{0}",mo["Name"]);
                // To print the Battery charging status
                Console.WriteLine("Charge \t\t:{0}%",mo["EstimatedChargeRemaining"]);
            }
            Console.ReadLine();
        }
    }
}
