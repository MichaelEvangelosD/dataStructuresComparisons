using System;

namespace CharacterFinder
{
    class MainHub
    {
        static Character[] characters;

        static void Main(string[] args)
        {
            //Generate characters
            characters = CharacterGenerator.GenerateCharacters();

            new MainHub().MenuSelection();
        }

        void MenuSelection()
        {
            int userChoice;

            do
            {
                PrintMenu();

                userChoice = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.WriteLine();

                SwitchOnChoice(userChoice);

            } while (userChoice < 0 || userChoice > 3);
        }

        void PrintMenu()
        {
            Console.WriteLine("\tOptions");
            Console.WriteLine("------------------------");
            Console.WriteLine("0) Find character by index.");
            Console.WriteLine("1) Find character by name.");
            Console.WriteLine("2) Print characters.");
            Console.WriteLine("3) Exit program.");
        }

        void SwitchOnChoice(int choice)
        {
            switch (choice)
            {
                case 0:
                {
                    FindByIndex();
                    break;
                }

                case 1:
                {
                    FindByNameString();
                    break;
                }

                case 2:
                {
                    PrintCharacters();
                    break;
                }

                case 3:
                {
                    Console.WriteLine("Terminating!");
                    Environment.Exit(0);
                    break;
                }

                default:
                {
                    Console.WriteLine("Invalid choice");
                    break;
                }
            }
        }

        #region SERVICES
        void FindByIndex()
        {
            int userGivenIndex = 0;

            do
            {
                Console.WriteLine("Please insert an index.");

                string tempStr = Console.ReadLine();

                userGivenIndex = int.Parse(tempStr);
                Console.WriteLine();

            } while (userGivenIndex < 0 || userGivenIndex > characters.Length);

            Console.WriteLine($"User at index #:{userGivenIndex}\n" +
                $"Name: {characters[userGivenIndex].GetName()}\n" +
                $"Level: {characters[userGivenIndex].GetLevel()}");
        }

        void FindByNameString()
        {
            string userString = string.Empty;
            Console.WriteLine("Please insert a name substring.");
            userString = Console.ReadLine();

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i].GetName().Contains(userString))
                {
                    Console.WriteLine("Index: " + characters[i].GetIndex());
                    Console.WriteLine("Name: " + characters[i].GetName());
                    Console.WriteLine("Level: " + characters[i].GetLevel());
                    Console.WriteLine("Class: " + characters[i].GetClass());
                    Console.WriteLine("-------------------------");
                }
            }
        }

        void PrintCharacters()
        {
            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine("Index: " +characters[i].GetIndex());
                Console.WriteLine("Name: " +characters[i].GetName());
                Console.WriteLine("Level: " +characters[i].GetLevel());
                Console.WriteLine("Class: " +characters[i].GetClass());
                Console.WriteLine("-------------------------");
            }
        }
        #endregion
    }
}
