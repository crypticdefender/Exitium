using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Exitium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exitium - A Windows Complete Shutdown Utility");
            Console.WriteLine("Created by Joeffel Faelnar");
            Console.WriteLine("All rights reserved. \n \n");

            Console.WriteLine("Are you sure you want to shutdown Windows? yes/no");
            string response = Console.ReadLine();

            if (response == "yes")
            {

                Process.Start("shutdown.exe", "/s /f /t 0");
            }

            else if (response == "no")
            {
                Environment.Exit(1);
            }

            else
            {
                Console.Clear();
                Process.Start("Exitium.exe");
            }
        }
    }
}
