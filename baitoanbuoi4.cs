using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("What your name?");
        string name = ""+ Console.ReadLine();
        Console.WriteLine("You have 1000$. Let's play game!!");
        Console.WriteLine("Neu thua doan sai 1 lan tru 100$, ban co 3 lan choi, hay doan so tu 1 toi 9 ");
        int money = 1000;
        int Time = 0;
        int Win = 0;
        do
        {
            int Win2 = 0;
            Time = Time + 1;
            int money2 = 0;
            money = money - money2;
            Random rnd = new Random();
            int comp_num = rnd.Next(1, 10);
            int man_num = 0;
            int j = 0;

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Your number is: ");
                man_num = Convert.ToInt32(Console.ReadLine());
                if (man_num == comp_num)
                {
                    Win2 += 1;
                    Win = Win + Win2;
                    Console.WriteLine("You are VIP, Genius Man!!");
                    Console.WriteLine($"So tien con lai la {money}$");
                    break;
                }
                else if (man_num < comp_num)
                {
                    Console.WriteLine("Your number is less than computer number");
                    j += 1;
                    money2 += 100;
                    money = money - money2;
                    Console.WriteLine($"So tien con lai la {money}$");
                }
                else
                { Console.WriteLine("Your number is greater than computer num");
                    j+= 1;
                    money2 += 100; 
                    money = money - money2;
                    Console.WriteLine($"So tien con lai la {money}$");
                }
            }
            Console.WriteLine($"Your number is {man_num}, but computer number is {comp_num}");
            Console.WriteLine($"Ban da doan {j} lan de dung");
            Console.WriteLine();
            Console.WriteLine("Do you want to continue");
            string respond = "" + Console.ReadLine();
            if (respond.ToUpper().Equals("N"))
            {
                Console.WriteLine("BYE KU");
                Console.WriteLine($"So tien con lai la {money}");
                Console.WriteLine($"So lan ban da choi la {Time}");
                Console.WriteLine($"So lan thang la{Win}");
                break;
            }
            Console.WriteLine($"So tien con lai la {money}");
        } while (money >=0);
                                                                                                                                                                                             
        }  
}