﻿using System;
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
            Console.WriteLine("Exitium - A Windows Process Purge Utility");
            Console.WriteLine("Created by Joeffel Faelnar");
            Console.WriteLine("All rights reserved. \n \n");

            Console.WriteLine("Are you sure you want to shut down Windows? (yes/no)");
            string response = Console.ReadLine();


            if (response == "yes")
            {
                Console.WriteLine("\nSpecify shut down delay in minutes:");
                double delay = Convert.ToDouble(Console.ReadLine());
                
                string timeunit;
                double actual_delay;

                actual_delay = delay * 60;
                
                if (delay > 1)
                {
                    timeunit = "minutes";
                }
                    
                else
                {
                    timeunit = "minute";
                }

                Console.WriteLine($"\nWARNING: Your computer will power off in " + delay + " " + timeunit + ". Save any work to avoid data loss.");

                Console.WriteLine("\nPress 'S' to continue or 'Q' to cancel. Press any other key to restart the application.");
                string response2 = Console.ReadLine();

                if (response2 == "S")
                {
                    Process.Start($"shutdown.exe", "/s /f /t " + actual_delay);
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
