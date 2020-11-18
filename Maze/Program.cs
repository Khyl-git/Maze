using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Program
    {
        static int Room0(int room_number)
        {
            Console.WriteLine("");
            Console.WriteLine("▄▄▄▄▄▄▄▄   ▄▄▄▄▄▄▄▄");
            Console.WriteLine("█╔═════╣ n ╠═════╗█");
            Console.WriteLine("█║               ║█");
            Console.WriteLine("█║       ▲       ╩█");
            Console.WriteLine("█║       ☻  ►    e");
            Console.WriteLine("█║               ╦█");
            Console.WriteLine("█║               ║█");
            Console.WriteLine("█╚═══════════════╝█");
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("");
            Console.WriteLine("There is 2 doors in your room: (n)orth,(e)ast, where do you want to go ? ");

            string choice = Console.ReadLine();
            if (choice == "n")
            {
                Console.Clear();
                Console.WriteLine("> going to north...");
                room_number = 3;
            }
            else if (choice == "e")
            {
                Console.Clear();
                Console.WriteLine("> going to east...");
                room_number = 1;
            }
            else
            {
                Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
            }
            return room_number;
        }

        static int Room1(int room_number)
        {
            Console.WriteLine("");
            Console.WriteLine("▄▄▄▄▄▄▄▄   ▄▄▄▄▄▄▄▄");
            Console.WriteLine("█╔═════╣ n ╠═════╗█");
            Console.WriteLine("█║               ║█");
            Console.WriteLine("█╩       ▲       ╩█");
            Console.WriteLine(" w    ◄  ☻  ►    e");
            Console.WriteLine("█╦               ╦█");
            Console.WriteLine("█║               ║█");
            Console.WriteLine("█╚═══════════════╝█");
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("");
            Console.WriteLine("There is 3 doors in your room: (n)orth,(w)est, (e)ast, where do you want to go ? ");

            string choice = Console.ReadLine();
            if (choice == "n")
            {
                Console.Clear();
                Console.WriteLine("> going to north...");
                room_number = 4;
            }
            else if (choice == "w")
            {
                Console.Clear();
                Console.WriteLine("> going to west...");
                room_number = 0;
            }
            else if (choice == "e")
            {
                Console.Clear();
                Console.WriteLine("> going to east...");
                room_number = 2;
            }
            else
            {
                Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
            }
            return room_number;
        }

        static int Room2(int room_number)
        {
            //TODO: complete
            Console.Clear(); Console.WriteLine("");
            Console.WriteLine("▄▄▄▄▄▄▄▄   ▄▄▄▄▄▄▄▄");
            Console.WriteLine("█╔═════╣ n ╠═════╗█");
            Console.WriteLine("█║               ║█");
            Console.WriteLine("█╩       ▲       ║█");
            Console.WriteLine(" w    ◄  ☻       ║█");
            Console.WriteLine("█╦               ║█");
            Console.WriteLine("█║               ║█");
            Console.WriteLine("█╚═══════════════╝█");
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("");
            Console.WriteLine("There is two doors in your room: (n)orth, (w)est, where do you want to go ?");
            string choice = Console.ReadLine();
            if (choice == "n")
            {
                Console.Clear();
                Console.WriteLine("> Going to north...");
                room_number = 5;
            }
            else if (choice == "w")
            {
                Console.Clear();
                Console.WriteLine("> Going to west...");
                room_number = 1;
            }
            return room_number;
        }

        static int Room4(int room_number)
        {
            //TODO: complete
            Console.WriteLine("88.._|      | `-.  | `.  -_-_ _-_  _-  _- -_ -  .'|   |.'|     |  _..88");
            Console.WriteLine("88   `-.._  |    |`!  |`.  -_ -__ -_ _- _-_-  .'  |.;'   |   _.!-'|  88");
            Console.WriteLine("88      | `-!._  |  `;!  ;. _______________ ,'| .-' |   _!.i'     |  88");
            Console.WriteLine("88..__  |     |`-!._ | `.| |_______________||.\"'|  _!.;' | _ | ..88");
            Console.WriteLine("88   |``\"..__ |    |`\";.| i|_|MMMMMMMMMMM|_|'| _!-|   |   _|..-|'    88");
            Console.WriteLine("88   |      |``--..|_ | `;!|l|MMoMMMMoMMM|1|.'j   |_..!-'|     |     88");
            Console.WriteLine("88   |      |    |   |`-,!_|_|MMMMPfYMMMM|_||.!-;'  |    |     |     88");
            Console.WriteLine("88___|______|____!.,.!,.!,!|d|MMMoMloloMM|p|,!,.!.,.!..__|_____|_____88");
            Console.WriteLine("88      |     |    |  |  | |_|MMMMbddMMMM|_|| |   |   |    |      |  88");
            Console.WriteLine("88      |     |    |..!-;'i|r|MPYMoMMMMoM|r| |`-..|   |    |      |  88");
            Console.WriteLine("88      |    _!.-j'  | _!,\"|_|M<>MMMMoMMM|_|| !._ |  `i - !.._ |    |88");
            Console.WriteLine("88     _!.-'|    | _.\" |!; |1|MbdMMoMMMMM|l|`.| `-._ |    |``-.._ |  88");
            Console.WriteLine("88..-i'     |  _.''|  !-| !|_|MMMoMMMMoMM|_|.|`-. | ``._ |     |``\"..88");
            Console.WriteLine("88   |      |.|    |.|  !| |u|MoMMMMoMMMM|n||`. |`!   | `\".    |     88");
            Console.WriteLine("88   |  _.-'  |  .'  |.' |/|_|MMMMoMMMMoM|_|! |`!  `,.|    |-._|     88");
            Console.WriteLine("88  _!\"'|     !.' |  .'| .'|[@]MMMMMMMMMMM[@] \\|  `. | `._ |   `-._  88");
            Console.WriteLine("88-'    |   .'   |.|  |/| /                 \\|`.  |`!    |.|      |`-88");
            Console.WriteLine("88      |_.'|   .' | .' |/                   \\  \\ |  `.  | `._-Lee|  88");
            Console.WriteLine("88     .'   | .'   |/|  /                     \\ |`!   |`.|    `.  |  88");
            Console.WriteLine("88  _.'     !'|   .' | /                       \\|  `  |  `.    |`.|  88");
            Console.WriteLine("88 vanishing point 888888888888888888888888888888888888888888888(FL)888");
            Console.WriteLine("");
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.WriteLine("█╔═══════════════╗█");
            Console.WriteLine("█║               ║█");
            Console.WriteLine("█║               ║█");
            Console.WriteLine("█║       ☻       ║█");
            Console.WriteLine("█║       ▼       ║█");
            Console.WriteLine("█║               ║█");
            Console.WriteLine("█╚═════╣ s ╠═════╝█");
            Console.WriteLine("▀▀▀▀▀▀▀▀   ▀▀▀▀▀▀▀▀");
            Console.WriteLine("");
            Console.WriteLine("There is only one door in this room: (s)outh, where do you want to go?");
            string choice = Console.ReadLine();
            if (choice == "s")
            {
                Console.Clear();
                Console.WriteLine("> Going to south...");
                room_number = 1;
            }
            return room_number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("              ██ ▄█▀ ██▓ ██▓     ██▓     ██▓ ███▄    █   ▄████       ███▄ ▄███▓ ▄▄▄     ▒███████▒▓█████ ");
            Console.WriteLine("              ██▄█▒ ▓██▒▓██▒    ▓██▒    ▓██▒ ██ ▀█   █  ██▒ ▀█▒     ▓██▒▀█▀ ██▒▒████▄   ▒ ▒ ▒ ▄▀░▓█   ▀ ");
            Console.WriteLine("             ▓███▄░ ▒██▒▒██░    ▒██░    ▒██▒▓██  ▀█ ██▒▒██░▄▄▄░     ▓██    ▓██░▒██  ▀█▄ ░ ▒ ▄▀▒░ ▒███   ");
            Console.WriteLine("             ▓██ █▄ ░██░▒██░    ▒██░    ░██░▓██▒  ▐▌██▒░▓█  ██▓     ▒██    ▒██ ░██▄▄▄▄██  ▄▀▒   ░▒▓█  ▄ ");
            Console.WriteLine("             ▒██▒ █▄░██░░██████▒░██████▒░██░▒██░   ▓██░░▒▓███▀▒     ▒██▒   ░██▒ ▓█   ▓██▒███████▒░▒████▒");
            Console.WriteLine("             ▒ ▒▒ ▓▒░▓  ░ ▒░▓  ░░ ▒░▓  ░░▓  ░ ▒░   ▒ ▒  ░▒   ▒      ░ ▒░   ░  ░ ▒▒   ▓▒█░▒▒ ▓░▒░▒░░ ▒░ ░");
            Console.WriteLine("             ░ ░▒ ▒░ ▒ ░░ ░ ▒  ░░ ░ ▒  ░ ▒ ░░ ░░   ░ ▒░  ░   ░      ░  ░      ░  ▒   ▒▒ ░░▒ ▒ ░ ▒ ░ ░  ░");
            Console.WriteLine("             ░ ░░ ░  ▒ ░  ░ ░     ░ ░    ▒ ░   ░   ░ ░ ░ ░   ░      ░      ░     ░   ▒  ░ ░ ░ ░ ░   ░   ");
            Console.WriteLine("             ░  ░    ░      ░  ░    ░  ░ ░           ░       ░             ░         ░  ░ ░ ░       ░  ░");
            Console.WriteLine("                                                                                        ░               ");
            Console.WriteLine("");
            Console.WriteLine("You are lost inside a Maze, try to escape...");
            Console.WriteLine("");
            bool gameRunning = true;
            int room_number = 1;
            while (gameRunning)
            {
                if (room_number == 0)
                {
                    room_number = Room0(room_number);
                }


                else if (room_number == 1)
                {
                    room_number = Room1(room_number);
                }

                else if (room_number == 2)
                {
                    room_number = Room2(room_number);
                }
                else if (room_number == 3)
                {
                    Console.WriteLine("               ...");
                    Console.WriteLine("             ;::::;");
                    Console.WriteLine("           ;::::; :;");
                    Console.WriteLine("         ;:::::'   :;");
                    Console.WriteLine("        ;:::::;     ;.");
                    Console.WriteLine("       ,:::::'       ;           OOO\\");
                    Console.WriteLine("       ::::::;       ;          OOOOO\\");
                    Console.WriteLine("       ;:::::;       ;         OOOOOOOO");
                    Console.WriteLine("      ,;::::::;     ;'         / OOOOOOO");
                    Console.WriteLine("    ;:::::::::`. ,,,;.        /  / DOOOOOO");
                    Console.WriteLine("  .';:::::::::::::::::;,     /  /     DOOOO");
                    Console.WriteLine(" ,::::::;::::::;;;;::::;,   /  /        DOOO");
                    Console.WriteLine(";`::::::`'::::::;;;::::: ,#/  /          DOOO");
                    Console.WriteLine(":`:::::::`;::::::;;::: ;::#  /            DOOO");
                    Console.WriteLine("::`:::::::`;:::::::: ;::::# /              DOO");
                    Console.WriteLine("`:`:::::::`;:::::: ;::::::#/               DOO");
                    Console.WriteLine(" :::`:::::::`;; ;:::::::::##                OO");
                    Console.WriteLine(" ::::`:::::::`;::::::::;:::#                OO");
                    Console.WriteLine(" `:::::`::::::::::::;'`:;::#                O");
                    Console.WriteLine("  `:::::`::::::::;' /  / `:#");
                    Console.WriteLine("   ::::::`:::::;'  /  /   `#\" ");
                    Console.WriteLine("");
                    Console.WriteLine(">>>>>>>>>>>> It's a trap... you are DEAD :/");
                    Console.ReadKey();
                    gameRunning = false;
                }
                else if (room_number == 4)
                {
                    room_number = Room4(room_number);
                }
                else if (room_number == 5)
                {
                    Console.WriteLine("                           (   )");
                    Console.WriteLine("                          (    )");
                    Console.WriteLine("                           (    )");
                    Console.WriteLine("                          (    )");
                    Console.WriteLine("                            )  )");
                    Console.WriteLine("                           (  (                  /\\");
                    Console.WriteLine("                            (_)                 /  \\  /\\");
                    Console.WriteLine("                    ________[_]________      /\\/    \\/  \\");
                    Console.WriteLine("           /\\      /\\        ______    \\    /   /\\/\\  /\\/\\");
                    Console.WriteLine("          /  \\    //_\\       \\    /\\    \\  /\\/\\/    \\/    \\");
                    Console.WriteLine("   /\\    / /\\/\\  //___\\       \\__/  \\    \\/");
                    Console.WriteLine("  /  \\  /\\/    \\//_____\\       \\ |[]|     \\");
                    Console.WriteLine(" /\\/\\/\\/       //_______\\       \\|__|      \\");
                    Console.WriteLine("/      \\      /XXXXXXXXXX\\                  \\");
                    Console.WriteLine("        \\    /_I_II  I__I_\\__________________\\");
                    Console.WriteLine("               I_I|  I__I_____[]_|_[]_____I");
                    Console.WriteLine("               I_II  I__I_____[]_|_[]_____I");
                    Console.WriteLine("               I_II  I__I_____[]_|_[]_____I");
                    Console.WriteLine("               I II__I  I     XXXXXXX     I");
                    Console.WriteLine("            ~~~~~\"   \"~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("");
                    Console.WriteLine(">>>>>>>>>>>> You found the EXIT...Congratulations:)");
                    Console.ReadKey();
                    gameRunning = false;
                }
            }
        }
    }
}