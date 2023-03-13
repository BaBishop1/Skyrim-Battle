using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skyrim_Battle
{
    public class ProgramUI
    {
        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                System.Console.WriteLine("Choose your character:\n" +
                "1. Nord\n" +
                "2. High-Elf\n" +
                "3. Embrace your cowardice!\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ChooseNord();
                        break;
                    case "2":
                        ChooseElf();
                        break;
                    case "3": 
                        System.Console.WriteLine("Warriors never quit");
                        keepRunning = false;
                        break;
                    default:
                        System.Console.WriteLine("Write a valid number (1, 2, or 3)");
                        break;

                }
                System.Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }      
        }
    }
}