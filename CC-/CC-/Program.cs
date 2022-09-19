using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|--Arena Corperation [Version 0.0.1--|");
            Console.WriteLine("|--Made By Faizurrehman-------------|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|---------------------------------------DaTa Base Sever Data---------------------------------------|");
            Console.WriteLine("------____-----_____-----______-----______-----____-----____-----_____-----____-----_____----_____");
            Console.WriteLine("______----_____-----_____------_____------_____-----_____----______--------_____----___---____----");
            Console.WriteLine("------____---__-Maker_------______-----_______----____--__--_____---Shehriyar___------______---______");
            Console.WriteLine("_____--___---__--_____---__------___-----__-----___---__-_--_---___--------___-__-__-_--_---_-----");
            Console.WriteLine("--_--_----_Hadi--__-----_--_-_--_-_---_Faizurrehman_-_--_--_------___---_-_-_----__--___--__--__-");
            Console.WriteLine("--__-_-_-_____----__-__-___-___-_-__-___---__-__---_---__---___---__Pro Member________---_------___");
            Console.WriteLine("------____-----_____-----______-----______-----____-----____-----_____-----____-----_____----_____");
            Console.WriteLine("------____-----_____-----------------------MrFurPlays___-----____-----_____----_____--------------");
            Console.WriteLine("------____-----_____-----______-----______-----____-----____-----_____Nayak Official-_____----_____");
            Console.WriteLine("-__---_--Shadow X Nayak--__--__--_----_______---__-_-------_____-__--____--__--_maker_-----_-----_-");
            Console.WriteLine("------____-----_____-----______-----______-----____-----____-----_____Hammad____-----_____----_____");
            Console.WriteLine("______----_____-----_____------Nayak------_____-----_____----______--------_____----___---____----");
            Console.WriteLine("------____---__--___------______-----_______----____--__--_____---___-----___------______---______");
            Console.WriteLine("_____--___---__Faizan---__------___-----__-----___---__-_--_---___--------___-__-__-_--_---_-----");
            Console.WriteLine("--_--_----___-----__-----_--_-_--_-_---_Anonymous---_-_--_--_------___---_-_-_----__--___--__--__-");
            Console.WriteLine("--__-_-_-_____----__-__-___-___-_-__-___---__-__---_---__---___---__-__------________---_------___");
            Console.WriteLine("------____-----_____-----______-----______-----____-----____-----_____-----____-----_____----_____");
            Console.WriteLine("------____-----_____-----______-----______-----____-----____-----_____-----____-----_____----_____");
            Console.WriteLine("------____-----_____-----______-----______-----____-----____-----_____-----____-----_____----_____");
            Console.WriteLine("-__---_---____-___---__--__------_----_______---__-_-------_____-__--____--__--__-___-----_-----_-");
            Console.WriteLine("|---------------------------------------Data Trafering End---------------------------------------|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please dont close this Window Before all Data Transfer to your computer");
            Console.ForegroundColor = ConsoleColor.Green;
            String command, a, b;
            b = "C:User:>";
        start:
            Console.Write(b + " ");
            command = Console.ReadLine();
            command = command.ToLower();
            if (command == "print")
            {
                a = Console.ReadLine();
                Console.WriteLine(a);

            }
            else if (command == "prompt")
            {
                b = Console.ReadLine();
            }
            else if (command == "clear")
            {
                Console.Clear();
            }
            else if (command == "help")
            {
                Console.WriteLine("--------------------Commands------------------------");
                Console.WriteLine("prompt   To change your command typeing name showing");
                Console.WriteLine("help     To get you all Commands List");
                Console.WriteLine("clear    To clear your window commands");
                Console.WriteLine("python   if you want to download python");
                Console.WriteLine("youtube  Attomatically you go to Owner Channel");
                Console.WriteLine("Top Billionar       You will get the News of Top Billionar");
                Console.WriteLine("Top hacker       You will get the Top hacker List");
                Console.WriteLine("Top gamer        You will get the Top youtube List");
                Console.WriteLine("Hacking          you Will go to hackin");
                Console.WriteLine("");
                Console.WriteLine("---------------------End------------------------------");
            }
            else if (command == "youtube")
            {
                Console.WriteLine("https://www.youtube.com/channel/UCjpQjhNowbsv2skYd_CtKLw");
            }
            else if (command == "top billionar")
            {
                Console.WriteLine("----------------------------TOP BILLIONAR-----------------------------------");
                Console.WriteLine("1 Elon Musk  $273.2 B  ▷ $321 M | ‑0.12%  51  Tesla, SpaceX");
                Console.WriteLine("2 Bernard Arnault & family  $154.7 B  ▷ $486 M | ‑0.31%  73 LVMH");
                Console.WriteLine("3 Gautam Adani & family  $152.2 B ▷ $2.2 B | ‑1.45% 60 infrastructure, commodities");
                Console.WriteLine("-------------------------------END----------------------------------------------");
            }
            else if (command == "top hacker")
            {
                Console.WriteLine("------------------------TOP HACKER----------------------");
                Console.WriteLine("Kevin Mitnick. A seminal figure in American hacking,");
                Console.WriteLine("Anonymous");
                Console.WriteLine("Adrian Lamo");
                Console.WriteLine("Albert Gonzalez");
                Console.WriteLine("Matthew Bevan and Richard Pryce");
                Console.WriteLine("Jeanson James Ancheta");
                Console.WriteLine("Michael Calce");
                Console.WriteLine("Kevin Poulsen.");
                Console.WriteLine("----------------------END------------------------------");
            }
            else if (command == "top gamer")
            {
                Console.WriteLine("---------------TOP GAMERS-----------------");
                Console.WriteLine("1. VanossGaming");
                Console.WriteLine("2. Markiplier");
                Console.WriteLine("3. Jacksepticeye");
                Console.WriteLine("4. DanTDM");
                Console.WriteLine("5. PopularMMOs");
                Console.WriteLine("6. W2S");
                Console.WriteLine("7. Ali-A");
                Console.WriteLine("8. H2ODelirious");
                Console.WriteLine("9. TheSyndicateProject");
                Console.WriteLine("10.CaptainSparklez");
                Console.WriteLine("11.The Game Theorists");
                Console.WriteLine("------------------END-----------------------");
            }
            else if (command == "")
            {
                Console.WriteLine("");
            }
            {
                Console.WriteLine("'" + command + "'" + " is not an command");
            }
            goto start;
        }
    }
}
