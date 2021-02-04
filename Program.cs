using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Exitium
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformShutdown();
        }

        static void PerformShutdown()
        {
            Console.WriteLine("Exitium - A Windows Complete Shutdown Utility");
            Console.WriteLine("Created by Joeffel Faelnar");
            Console.WriteLine("All rights reserved. \n \n");

            Console.WriteLine("Are you sure you want to shutdown Windows? yes/no");
            string response = Console.ReadLine();


            if (response == "yes")
            {
                Console.WriteLine("\nSpecify shutdown delay in seconds:");
                int delay = Convert.ToInt32(Console.ReadLine());

                Process.Start($"shutdown.exe", "/s /f /t " + delay);

                Environment.Exit(1);
            }

            else if (response == "no")
            {
                Environment.Exit(1);
            }

            else
            {
                Console.Clear();
                PerformShutdown();
            }
        }
    }
}
