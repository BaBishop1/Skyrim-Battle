namespace Skyrim_Battle
{
    public class ProgramUI
    {
        public void Run()
        {
            // NameSelector();
            Menu();
        }

        // private void NameSelector()
        // {
        //     Console.Clear();
        //     System.Console.WriteLine("Please enter your characters name:");
        //     string charName = Console.ReadLine();
        // }
        private void Menu()
        {
            

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                System.Console.WriteLine("Choose your character's race:\n" +
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

        private void ChooseNord()
        {
            Nord Billy = new Nord();
            High_Elf Bobby = new High_Elf();
            Attack Sword_Slash = new Attack("Sword Slash", 10, AttackType.Slashing);
            Attack Bow_Shot = new Attack("Bow Shot", 10, AttackType.Ranged);
            Attack Fire_Bolt = new Attack("Fire Bolt", 10, AttackType.Magic);

            Console.Clear();
            System.Console.WriteLine("You are a Nord, born and raised in the harsh winters of Skyrim.\n");
            System.Console.WriteLine("You are traveling to White-run and have suddenly been attacked by a High-Elf, Defend yourself!\n");
            while(Bobby.Health > 0 && Billy.Health > 0)
            {
                System.Console.WriteLine($"Choose Your Attack!\n" +
                    "1. Sword Slash\n" +
                    "2. Bow Shot\n" +
                    "3. Fire Bolt");
                string attackChoice = Console.ReadLine();
                
                switch(attackChoice)
                {
                    case "1":
                        Console.Clear();
                        System.Console.WriteLine($"You slash the High Elf for {Sword_Slash.Damage + 3} {Sword_Slash.Type} damage");
                        System.Console.WriteLine(Bobby.TakeDamage(Sword_Slash));
                        System.Console.WriteLine($"Bobby is at {Bobby.Health} Health.");
                    break;

                    case "2":
                        Console.Clear();
                        System.Console.WriteLine($"You shoot an arrow at the High Elf for {Bow_Shot.Damage} {Bow_Shot.Type} damage");
                        System.Console.WriteLine(Bobby.TakeDamage(Bow_Shot));
                        System.Console.WriteLine($"Bobby is at {Bobby.Health} Health.");
                        break;

                        case "3":
                        Console.Clear();
                        System.Console.WriteLine($"You shoot a fire bolt at the High Elf for {Fire_Bolt.Damage - 3} {Fire_Bolt.Type} damage");
                        System.Console.WriteLine(Bobby.TakeDamage(Fire_Bolt));
                        System.Console.WriteLine($"Bobby is at {Bobby.Health} Health.");
                        break;

                    default:
                        System.Console.WriteLine("No attack equipped");
                        break;
                    
                }
                
                System.Console.WriteLine($"Bobby retaliates with {(Bobby.Attack()).Name}\n" +
                $"{Billy.TakeDamage(Bobby.Attack())}\n" +
                $"You are at {Billy.Health} Health");

            }

            if (Bobby.Health <= 0 && Billy.Health <= 0)
            {
                System.Console.WriteLine("You've managed to end his life, at the cost of your own...");
            }
            else if (Billy.Health <= 0)
            {
                System.Console.WriteLine("You dishonor your family");
            } 
            else if (Bobby.Health <= 0)
            {
                System.Console.WriteLine("Who's Next!");
            }
        }

        private void ChooseElf()
        {
            Console.Clear();
            Nord Billy = new Nord();
            High_Elf Bobby = new High_Elf();
            Attack Sword_Slash = new Attack("Sword Slash", 10, AttackType.Slashing);
            Attack Bow_Shot = new Attack("Bow Shot", 10, AttackType.Ranged);
            Attack Fire_Bolt = new Attack("Fire Bolt", 10, AttackType.Magic);

            System.Console.WriteLine("You are a High-Elf, born and raised in the Summerset Isles");
            System.Console.WriteLine("You are traveling to Solsteim and have suddenly been attacked by a Nord, Defend yourself!");
            while(Bobby.Health > 0 && Billy.Health > 0)
            {
                System.Console.WriteLine($"Choose Your Attack!\n" +
                    "1. Sword Slash\n" +
                    "2. Bow Shot\n" +
                    "3. Fire Bolt");
                string attackChoice = Console.ReadLine();
                
                switch(attackChoice)
                {
                    case "1":
                        Console.Clear();
                        System.Console.WriteLine($"You slash the Nord for {Sword_Slash.Damage - 3} {Sword_Slash.Type} damage");
                        System.Console.WriteLine(Billy.TakeDamage(Sword_Slash));
                        System.Console.WriteLine($"Billy is at {Billy.Health} Health.");
                    break;

                    case "2":
                        Console.Clear();
                        System.Console.WriteLine($"You shoot an arrow at the Nord for {Bow_Shot.Damage} {Bow_Shot.Type} damage");
                        System.Console.WriteLine(Billy.TakeDamage(Bow_Shot));
                        System.Console.WriteLine($"Billy is at {Billy.Health} Health.");
                        break;

                        case "3":
                        Console.Clear();
                        System.Console.WriteLine($"You shoot a fire bolt at the Nord for {Fire_Bolt.Damage + 3} {Fire_Bolt.Type} damage");
                        System.Console.WriteLine(Billy.TakeDamage(Fire_Bolt));
                        System.Console.WriteLine($"Billy is at {Billy.Health} Health.");
                        break;

                    default:
                        System.Console.WriteLine("No attack equipped");
                        break;
                    
                }
                
                System.Console.WriteLine($"Billy retaliates with {(Billy.Attack()).Name}\n" +
                $"{Bobby.TakeDamage(Bobby.Attack())}\n" +
                $"You are at {Bobby.Health} Health");

            }

            
            if (Billy.Health <= 0 && Bobby.Health <= 0)
            {
                System.Console.WriteLine("You've managed to end his life, at the cost of your own...");
            }
            else if (Bobby.Health <= 0)
            {
                System.Console.WriteLine("You dishonor your family");
            } 
            else if (Billy.Health <= 0)
            {
                System.Console.WriteLine("Who's Next!");
            }
        }
    }
}