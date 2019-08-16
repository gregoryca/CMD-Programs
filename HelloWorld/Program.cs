using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            //Script choices
            string con = "/K ipconfig";
            string ren = "/K ipconfig /renew";
            string rel = "/K ipconfig /release";
            string LanDisable = "/K netsh interface set interface" + " " + "LAN0" + " " + "admin=disable";


            for(int i = 0; i < 64; i++)
            {
                Console.WriteLine("Choose your ipconfig script: 1 Ipconfig, 2 Release, 3 Renew, 4 Disable Lan, ");
                string choice = Console.ReadLine();
                if(choice == "")
                {
                    Console.WriteLine("No input detected");
                    i = 0;
                    
                }

                Console.WriteLine(i);
                int caseSwitch = Convert.ToInt32(choice);

                switch (caseSwitch)
                {
                    default:
                        Process.Start("CMD.exe", con);
                        i = 0;
                        break;
                    case 2:
                        Process.Start("CMD.exe", ren);
                        i = 0;
                        break;
                    case 3:
                        Process.Start("CMD.exe", rel);
                        i = 0;
                        break;
                    case 4:
                        Process.Start("CMD.exe", LanDisable);
                        i = 0;
                        break;
                }
                System.Diagnostics.Process.Start("CMD.exe", choice);
            }
        }
    }
}