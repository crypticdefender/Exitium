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

                Console.WriteLine($"\nWARNING: Your computer will shutdown in " + delay + " seconds. Save any work to avoid data loss.");
                Console.WriteLine("\nPress 'S' to continue or 'Q' to cancel.");
                string response2 = Console.ReadLine();

                if (response2 == "S")
                {
                    Process.Start($"shutdown.exe", "/s /f /t " + delay);
                }

                else if (response2 == "Q")
                {
                    Environment.Exit(1);
                }

                else
                {
                    Console.Clear();
                    PerformShutdown();
                }       
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
