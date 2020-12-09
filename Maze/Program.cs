using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Program
    {
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

            Dictionary<string, string> sentenceWhenMoving = new Dictionary<string, string>();
            sentenceWhenMoving.Add("n", "> going to north...");
            sentenceWhenMoving.Add("s", "> going to south...");
            sentenceWhenMoving.Add("e", "> going to east...");
            sentenceWhenMoving.Add("w", "> going to west...");

            List<Dictionary<string, int>> roomsDirections = new List<Dictionary<string, int>>();
            roomsDirections.Add(new Dictionary<string, int>() {
             { "n", 3 },
             { "e", 1 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "n", 4 },
             { "w", 0 },
             { "e", 2 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "n", 5 },
             { "w", 1 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "s", 0 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "s", 1 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "s", 2 }
            });

            bool gameRunning = true;
            int room_number = 1;
            while (gameRunning)
            {
                if (room_number == 3)
                {
                    gameRunning = Loose();
                }
                else if (room_number == 4)
                {
                    room_number = Room4(room_number, sentenceWhenMoving, roomsDirections);
                }
                else if (room_number == 5)
                {
                    gameRunning = Win();
                }
                else
                {
                    room_number = Room(room_number, sentenceWhenMoving, roomsDirections);
                }
            }
        }
        private static void DisplayStandardRoom(Dictionary<string, int> configForCurrentRoom)
        {
            bool canGoNorth = configForCurrentRoom.ContainsKey("n");
            bool canGoSouth = configForCurrentRoom.ContainsKey("s");
            bool canGoEast = configForCurrentRoom.ContainsKey("e");
            bool canGoWest = configForCurrentRoom.ContainsKey("w");
            Console.WriteLine("");
            generateRoom(canGoNorth, canGoSouth, canGoEast, canGoWest);
            Console.WriteLine("");
            Console.Write("There are " + configForCurrentRoom.Count() + " door(s) in your room: ");
            if (canGoNorth)
                Console.Write("(n)orth ");
            if (canGoSouth)
                Console.Write("(s)outh ");
            if (canGoEast)
                Console.Write("(e)ast ");
            if (canGoWest)
                Console.Write("(w)est ");
            Console.WriteLine("where do you want to go ? ");
        }

        static void generateRoom(bool canGoNorth, bool canGoSouth, bool canGoEast, bool canGoWest)
        {
            for (int y = 0; y < 7; y++)
            {
                string currentTextLine = "";
                for (int x = 0; x < 17; x++)
                {
                    bool isInside = x > 0 && x < 16 && y > 0 && y < 6;
                    bool northDoor = canGoNorth && x == 8 && y == 0;
                    bool southDoor = canGoSouth && x == 8 && y == 6;
                    bool eastDoor = canGoEast && x == 16 && y == 3;
                    bool westDoor = canGoWest && x == 0 && y == 3;
                    bool isDoor = northDoor || southDoor || eastDoor || westDoor;

                    if (isInside || isDoor)
                    {
                        currentTextLine += " ";
                    }
                    else
                    {
                        currentTextLine += "#";
                    }
                }
                Console.WriteLine(currentTextLine);
            }
        }

        private static bool Win()
        {
            bool gameRunning;
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
            return gameRunning;
        }

        private static bool Loose()
        {
            bool gameRunning;
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
            return gameRunning;
        }

        static int Room(int room_number, Dictionary<string, string> sentenceWhenMoving, List<Dictionary<string, int>> roomsDirections)
        {
            

            
            Dictionary<string, int> configForCurrentRoom = roomsDirections[room_number];
            DisplayStandardRoom(configForCurrentRoom);
            string choice = Console.ReadLine();
            if (configForCurrentRoom.ContainsKey(choice))
            {
                room_number = configForCurrentRoom[choice];
                if (sentenceWhenMoving.ContainsKey(choice))
                {
                    Console.Clear();
                    Console.WriteLine(sentenceWhenMoving[choice]);
                }
            }
            else
            {
                Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
            }
            return room_number;

        }
       
        

        static int Room4(int room_number, Dictionary<string, string> sentenceWhenMoving, List<Dictionary<string, int>> roomsDirections)
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


            
            Dictionary<string, int> configForCurrentRoom = roomsDirections[room_number];
            DisplayStandardRoom(configForCurrentRoom);
            string choice = Console.ReadLine();
            if (configForCurrentRoom.ContainsKey(choice))
            {
                room_number = configForCurrentRoom[choice];
                if (sentenceWhenMoving.ContainsKey(choice))
                {
                    Console.Clear();
                    Console.WriteLine(sentenceWhenMoving[choice]);
                }
            }
            else
            {
                Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
            }
            return room_number;
        }
    }
}