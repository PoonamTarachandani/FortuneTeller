using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            int retirementyears = 0;
            string location = "";
            string transportation = "";
            double bankbalance = 0;
            string tryAgain = "restart";
            string age2 = "";
            string siblings2 = "";
            do
            {
                Console.WriteLine("Enjoy your FORTUNE\n");
                Console.WriteLine("what's your first name");
                string firstname = Console.ReadLine();
                if (firstname.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }
                else if (firstname.ToUpper() == "RESTART")
                {
                    continue;
                }

                Console.WriteLine("whats your last name");
                string lastname = Console.ReadLine();
                if (lastname.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }
               else if (lastname.ToUpper() == "RESTART")
                {
                    continue;
                }

                Console.WriteLine("what's your age");
                age2 = Console.ReadLine();
                if (age2.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }

               else if (age2.ToUpper() == "RESTART")
                {
                    continue;
                }
                int age = int.Parse(age2);

                Console.WriteLine("what's your birth month");
                string birthmonth = Console.ReadLine();

                while (birthmonth.ToUpper() != "JANUARY" && birthmonth.ToUpper() != "FEBUARY" && birthmonth.ToUpper() != "MARCH" && birthmonth.ToUpper() != "APRIL" && birthmonth.ToUpper() != "MAY" && birthmonth.ToUpper() != "JUNE" && birthmonth.ToUpper() != "JULY" && birthmonth.ToUpper() != "AUGUST" && birthmonth.ToUpper() != "SEPTEMBER" && birthmonth.ToUpper() != "OCTOBER" && birthmonth.ToUpper() != "NOVEMBER" &&   birthmonth.ToUpper() != "DECEMBER" && birthmonth.ToUpper() != "QUIT" && birthmonth.ToUpper
                    () != "RESTART")
                    {
                    Console.WriteLine("what's your birth month");
                    birthmonth = Console.ReadLine();
                    }

                    if (birthmonth.ToUpper() == "QUIT")
                    {
                        Console.WriteLine("Nobody likes a quitter...");
                        break;
                    }
                    else if (birthmonth.ToUpper() == "RESTART")
                    {
                        continue;
                    }

                 Console.WriteLine("what's your favorite color");
                Console.WriteLine("Pleae enter \"Help\" if you dont know what's ROYGBIV");
                string ROYGBIV = Console.ReadLine();
                if (ROYGBIV.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }
                else if (ROYGBIV.ToUpper() == "RESTART")
                {
                    continue;
                }

                while (ROYGBIV.Equals("Help", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("R-RED,O-ORANGE,Y-YELLOW,G-GREEN,B-BLUE,I-INDIGO,V-VIOLET");
                    Console.WriteLine("what's your favorite color");
                    Console.WriteLine("Pleae enter \"Help\" if you dont know what's ROYGBIV");
                    ROYGBIV = Console.ReadLine();
                }
                if (ROYGBIV.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }

                else if (ROYGBIV.ToUpper() == "RESTART")
                {
                    continue;
                }

                Console.WriteLine("how many sibling you have");
                siblings2 = Console.ReadLine();
                if (siblings2.ToUpper() == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }

               else if (siblings2.ToUpper() == "RESTART")
                {
                    continue;
                }
                int siblings = int.Parse(siblings2);



                if (age % 2 == 1)
                    retirementyears = 20;
                else
                    retirementyears = 30;

                if  (siblings == 0)
                    location = "US";
                else if (siblings == 1)
                    location = "India";
                else if (siblings == 2)
                    location = "Dubai";
                else if (siblings == 3)
                    location = "Europe";
                else
                    location = "Saudi";



                switch (ROYGBIV.ToUpper())
                {
                    case "R":
                        transportation = "Helicopter";
                        break;
                    case "O":
                        transportation = "Car";
                        break;
                    case "Y":
                        transportation = "plane";
                        break;
                    case "G":
                        transportation = "boat";
                        break;
                    case "B":
                        transportation = "skates";
                        break;
                    case "I":
                        transportation = "bus";
                        break;
                    case "V":
                        transportation = "bike";
                        break;
                }

                if (firstname.IndexOf(birthmonth[0].ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0 || lastname.IndexOf(birthmonth[0].ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                    bankbalance = 60000;
                else if (firstname.IndexOf(birthmonth[1].ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0 || lastname.IndexOf(birthmonth[1].ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                    bankbalance = 80000;
                else if (firstname.IndexOf(birthmonth[2].ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0 || lastname.IndexOf(birthmonth[2].ToString(), StringComparison.CurrentCultureIgnoreCase) >= 0)
                    bankbalance = 1200000;

                Console.WriteLine(firstname + " " + lastname + " will retire in " + retirementyears + " years with $" + bankbalance + " in the bank, a vacation home in " + location + " and a " + transportation + ".");

                Console.WriteLine("Would u like to try again?(Yes/No) : ");
                tryAgain = Console.ReadLine();

            }
            while (tryAgain.ToLower() == "yes"|| tryAgain.ToLower()=="restart");


        }
    }
}
