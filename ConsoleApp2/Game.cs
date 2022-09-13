using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    class Game {
        public void Start() {
            RunMainMenu();
        }

        private void RunMainMenu() {

            while(true) {
                string prompt = "\r\n███╗   ███╗ ██████╗ ███╗   ██╗██╗  ██╗███████╗██╗   ██╗\r\n████╗ ████║██╔═══██╗████╗  ██║██║ ██╔╝██╔════╝╚██╗ ██╔╝\r\n██╔████╔██║██║   ██║██╔██╗ ██║█████╔╝ █████╗   ╚████╔╝ \r\n██║╚██╔╝██║██║   ██║██║╚██╗██║██╔═██╗ ██╔══╝    ╚██╔╝  \r\n██║ ╚═╝ ██║╚██████╔╝██║ ╚████║██║  ██╗███████╗   ██║   \r\n╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═╝╚══════╝   ╚═╝   \r\n                                                       \r\n";

                string[] options = { "Monkey1","Monkey2","Monkey3" };
                Menu mainMenu = new Menu(prompt,options);
                int selectedIndex = mainMenu.Run();

                switch(selectedIndex) {
                    case 0:
                        Monkey1();
                        break;
                    case 1:
                        Monkey2();
                        break;
                    case 2:
                        Monkey3();
                        break;
                }
            }

        }

        private void Monkey1() {
            Console.Clear();
            Console.WriteLine("     _...._\r\n   .-.     /\r\n  /o.o\\ ):.\\\r\n  \\   / `- .`--._\r\n  // /            `-.\r\n '...\\     .         `.\r\n  `--''.    '          `.\r\n      .'   .'            `-.\r\n   .-'    /`-.._            \\\r\n .'    _.'      :      .-'\"'/\r\n| _,--`       .'     .'    /\r\n\\ \\          /     .'     /\r\n \\///        |    ' |    /\r\n             \\   (  `.   ``-.\r\n              \\   \\   `._    \\\r\n            _.-`   )    .'    )\r\n  LGB       `.__.-'  .-' _-.-'\r\n                     `.__,'");
            Console.WriteLine("\nPress Any Key to comeback to main menu\n");
            Console.ReadKey(true);
        }

        private void Monkey2() {
            Console.Clear();
            Console.WriteLine("         ||\r\n         ||\r\n        _;|\r\n       /__3\r\n      / /||\r\n     / / // .--.\r\n     \\ \\// / (OO)\r\n      \\//  |( _ )\r\n      // \\__/`-'\\__\r\n     // \\__      _ \\\r\n _.-'/    | ._._.|\\ \\\r\n(_.-'     |      \\ \\ \\\r\n   .-._   /    o ) / /\r\n  /_ \\ \\ /   \\__/ / /\r\n    \\ \\_/   / /  E_/\r\n     \\     / /\r\n      `-._/-' :F_P:");
            Console.WriteLine("\nPress Any Key to comeback to main menu\n");
            Console.ReadKey(true);
        }

        private void Monkey3() {
            Console.Clear();
            Console.WriteLine("           .\"`\".\r\n       .-./ _=_ \\.-.\r\n      {  (,(oYo),) }}\r\n      {{ |   \"   |} }\r\n      { { \\(---)/  }}\r\n      {{  }'-=-'{ } }\r\n      { { }._:_.{  }}\r\n      {{  } -:- { } }\r\njgs   {_{ }`===`{  _}\r\n     ((((\\)     (/))))");
            Console.WriteLine("\nPress Any Key to comeback to main menu\n");
            Console.ReadKey(true);
        }
    }
}
