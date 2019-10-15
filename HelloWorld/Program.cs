using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace HelloWorld
{
    class Program
    {  
        //Variables to be used.
        private static string answer;
        private static string website;
        private static string exit;

        static void Main(string[] args)
        {
            //Script choices
            string con = "/K ipconfig";
            string ren = "/K ipconfig /renew";
            string rel = "/K ipconfig /release";
            string flush = "/K ipconfig /flushdns";
            string register = "/K ipconfig /registerdns";
            string tracert = "/K  tracert -4" + website + "";
            string LanDisable = "netsh interface set interface" + " " + "LAN0" + " " + "admin=disable";

            //Answer variable
            int inputAnswer = Convert.ToInt32(answer);

            //CMD choice options
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Check all CMD options build in");
                string answer = Console.ReadLine();
                if(answer == "")
                {
                    for (int a = 0; a < 64; a++)
                    {   //Options to choose which script shall be ran
                        Console.WriteLine("Choose your workflow: 1 Ipconfig, 2 Release, 3 Renew, 4 Register DNS, 5 Flush DNS, 6 Tracert");
                        string input = Console.ReadLine();
                        Console.WriteLine(input);
                        if (input == "")
                        {
                            Console.WriteLine("No input detected");
                            a = -1;
                        }
                        else
                        {
                            //Convert the input string to an integer so that it can be used in the switch
                            int caseSwitch = Convert.ToInt32(input);

                            switch (caseSwitch)
                            {
                                //Depending on the input number, it will go to the appropriate cmd script
                                default:
                                    Process.Start("CMD.exe", con);

                                    break;
                                case 2:
                                    Process.Start("CMD.exe", ren);
                                    
                                    break;
                                case 3:
                                    Process.Start("CMD.exe", rel);

                                    break;
                                case 4:
                                    Process.Start("CMD.exe", register);

                                    break;
                                case 5:
                                    Process.Start("CMD.exe", flush);
                                    break;
                                case 6:
                                    Console.WriteLine("type the website http address to start tracert");
                                    string website = Console.ReadLine();
                                    Process.Start("CMD.exe", tracert);
                                    break;
                                case 7:
                                    Process.Start("CMD.exe", LanDisable);
                                    a = -1;
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    //This switch is purely for when you press H.
                    //It will give you the options to see which cmd Scripts are present.
                    switch (inputAnswer)
                    {
                        default:
                            Console.WriteLine(con);

                            break;
                        case 2:
                            Console.WriteLine(ren);

                            break;
                        case 3:
                            Console.WriteLine(rel);

                            break;
                        case 4:
                            Console.WriteLine(flush);

                            break;
                        case 5:
                            Console.WriteLine(register);
                            break;
                        case 6:
                            Console.WriteLine(LanDisable);
                            break;
                    }
                }
            }
        }
    }
}