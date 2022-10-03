using System;
using System.Collections.Generic;

namespace CharacterFinder
{
    class MainHub
    {
        static Character[] charactersArray;
        //static List<Character> charactersList;

        static void Main(string[] args)
        {
            //Generate characters
            charactersArray = CharacterGenerator.GenerateCharacters();

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

            } while (userChoice < 0 || userChoice > 4);
        }

        void PrintMenu()
        {
            Console.WriteLine("\tOptions");
            Console.WriteLine("------------------------");
            Console.WriteLine("0) Find character by index.");
            Console.WriteLine("1) Find character by name.");
            Console.WriteLine("2) Print characters.");
            Console.WriteLine("3) Exit program.");
            Console.WriteLine("4) Run statistics.");
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

                case 4:
                {
                    RunStatistics();
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

            } while (userGivenIndex < 0 || userGivenIndex > charactersArray.Length);

            Console.WriteLine($"User at index #:{userGivenIndex}\n" +
                $"Name: {charactersArray[userGivenIndex].GetName()}\n" +
                $"Level: {charactersArray[userGivenIndex].GetLevel()}");
        }

        void FindByNameString()
        {
            string userString = string.Empty;
            Console.WriteLine("Please insert a name substring.");
            userString = Console.ReadLine();

            for (int i = 0; i < charactersArray.Length; i++)
            {
                if (charactersArray[i].GetName().Contains(userString))
                {
                    Console.WriteLine("Index: " + charactersArray[i].GetIndex());
                    Console.WriteLine("Name: " + charactersArray[i].GetName());
                    Console.WriteLine("Level: " + charactersArray[i].GetLevel());
                    Console.WriteLine("Class: " + charactersArray[i].GetClass());
                    Console.WriteLine("-------------------------");
                }
            }
        }

        void PrintCharacters()
        {
            for (int i = 0; i < charactersArray.Length; i++)
            {
                Console.WriteLine("Index: " + charactersArray[i].GetIndex());
                Console.WriteLine("Name: " + charactersArray[i].GetName());
                Console.WriteLine("Level: " + charactersArray[i].GetLevel());
                Console.WriteLine("Class: " + charactersArray[i].GetClass());
                Console.WriteLine("-------------------------");
            }
        }

        void RunStatistics()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime;
            TimeSpan elapsedTime;

            Console.WriteLine("Starting run...");
            int runTimes = 1000000;
            int tempI = 0;
            for (int i = 0; i <= charactersArray.Length; i++)
            {
                if (tempI >= runTimes) break;

                if (i > charactersArray.Length - 1)
                {
                    i = 0;
                }

                Console.WriteLine(charactersArray[i].GetIndex().ToString());

                tempI++;
            }

            endTime = DateTime.Now;

            elapsedTime = (endTime - startTime);

            double ms = elapsedTime.TotalMilliseconds / 1000;

            Console.WriteLine(ms + "ms");
        }
        #endregion
    }
}
