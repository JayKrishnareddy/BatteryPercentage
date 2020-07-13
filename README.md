First of all, Let me just explain to you in short about WMI & Win32_Battery!
 
What is WMI?
 
Windows Management Instrumentation(WMI) is the infrastructure for management data and operations on Windows-based operating systems.
You can write WMI scripts or applications to automate administrative tasks on remote computers but WMI also supplies management data to
other parts of the operating system and products. 
What is the Win32_Battery Class?
 
The  Win32_Battery WMI Class represents a battery connected to the computer system.
 
Let's create a simple Console Application in Visual Studio 
 
 
 
Click on Next -> Button 
 
 
 
Give a sample solution name and then click on Create -> Button.
 
Add the System. Management package into our project.
 
System.Management Namespace:
 
 project Provides access to a rich set of management information and management events about the system, devices, and applications instrumented to the windows management Instrumentation(WMI) infrastructure. Applications and services can query for interesting management information (such as how much free space is left on the desk, what is the current CPU utilization, which database a certain application is connected to, and much more), using classes derived from ManagementObjectSearcher and ManagementQuery or subscribe to a variety of management events using a ManagementEventWatcher class. The accessible data can be from both managed and unmanaged components in the distributed environment.
 
 
 
Program.cs
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
            //Retrieves a collection of system management objects based on the below query!  
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
Run the application to get the result of the battery name and battery status. 
 
 
