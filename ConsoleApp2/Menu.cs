using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {

    public class Menu {

        private int selectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string Prompt,string[] Options) {
            this.Prompt = Prompt;
            this.Options = Options;
            selectedIndex = 0;
        }

        public void DisplayOptions() {
            Console.WriteLine(Prompt);
            
            for(int i = 0;i <Options.Length;i++){
                string currentOption = Options[i];
                string prefix; ;
                if(i == selectedIndex) {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    prefix = ">";
                }
                else {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    prefix = " ";
                }
                Console.WriteLine(prefix + $"{currentOption}");
            }
            Console.ResetColor();
        }

        public int Run() {
            ConsoleKey keyPressed;
            do {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if(keyPressed == ConsoleKey.UpArrow) {
                    selectedIndex--;
                    if(selectedIndex == -1)
                        selectedIndex = Options.Length - 1;
                }

                if(keyPressed == ConsoleKey.DownArrow) {
                    selectedIndex++;
                    if(selectedIndex == Options.Length)
                        selectedIndex = 0;
                }


                } while(keyPressed != ConsoleKey.Enter);

            return selectedIndex;
        }



    }
}
