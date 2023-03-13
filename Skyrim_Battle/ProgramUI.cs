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
               System.Console.WriteLine($"Bobby retaliates with {(Bobby.Attack()).Name}" +
                $"You take {Billy.TakeDamage(Bobby.Attack())}");
            }

            if (Bobby.Health <= 0)
            {
                System.Console.WriteLine("Who's next?");
            }
            else if (Billy.Health <= 0)
            {
                System.Console.WriteLine("You dishonor your family");
            } 
            
        }

        private void ChooseElf()
        {
            Console.Clear();
            Nord nord = new Nord();
            Attack Sword_Slash = new Attack("Sword Slash", 10, AttackType.Slashing);
            Attack Bow_Shot = new Attack("Bow Shot", 10, AttackType.Ranged);
            Attack Fire_Bolt = new Attack("Fire Bolt", 10, AttackType.Magic);

            System.Console.WriteLine("You are a High-Elf, born and raised in the Summerset Isles");
            System.Console.WriteLine("You are traveling to Solsteim and have suddenly been attacked by a Nord, Defend yourself!");
        }

    }
}