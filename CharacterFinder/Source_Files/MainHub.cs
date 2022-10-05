using System;
using System.Collections.Generic;

namespace CharacterFinder
{
    class MainHub
    {
        static Character[] charactersArray;
        static List<Character> charactersList;

        static void Main(string[] args)
        {
            //Generate characters
            charactersArray = CharacterGenerator.GenerateCharacters(100);

            new MainHub().MenuSelection();
        }

        /// <summary>
        /// Call to initiate the main menu selection sequence and prompt the user for a choice.
        /// </summary>
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

        /// <summary>
        /// Call to print the menu
        /// </summary>
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

        /// <summary>
        /// Call to execute the desired method based on the user choice passed.
        /// </summary>
        /// <param name="choice">User selected choice.</param>
        void SwitchOnChoice(int choice)
        {
            switch (choice)
            {
                //Seach user by index
                case 0:
                {
                    FindByIndex();
                    break;
                }

                //Search user by name substring
                case 1:
                {
                    FindByNameString();
                    break;
                }

                //Print all the users
                case 2:
                {
                    PrintCharacters();
                    break;
                }

                //Quit the program
                case 3:
                {
                    Console.WriteLine("Terminating!");
                    Environment.Exit(0);
                    break;
                }

                //Run the currently used data structure statistics and print its execution time.
                case 4:
                {
                    RunStatistics();
                    break;
                }

                //Default for invalid input.
                default:
                {
                    Console.WriteLine("Invalid choice");
                    break;
                }
            }
        }

        #region SERVICES
        /// <summary>
        /// Call to prompt the user for a character index and print its corresponding character.
        /// </summary>
        void FindByIndex()
        {
            int userGivenIndex = 0;
            string tempStr = String.Empty;

            do
            {
                Console.WriteLine("Please insert an index.");

                tempStr = Console.ReadLine();
                userGivenIndex = int.Parse(tempStr);

                Console.WriteLine();

            } while (userGivenIndex < 0 || userGivenIndex > charactersArray.Length);

            Console.WriteLine($"User at index #:{userGivenIndex}\n" +
                $"Name: {charactersArray[userGivenIndex].GetName()}\n" +
                $"Level: {charactersArray[userGivenIndex].GetLevel()}");
        }

        /// <summary>
        /// Call to print all the characters that contain the substring the user passed in.
        /// </summary>
        void FindByNameString()
        {
            string userString = string.Empty;

            Console.WriteLine("Please insert a name substring.");
            userString = Console.ReadLine();

            for (int i = 0; i < charactersArray.Length; i++)
            {
                //Checks every name for the user input
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

        /// <summary>
        /// Call to print the whole data structure in the console.
        /// </summary>
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

        /// <summary>
        /// Call to access and print every array element X times and calculate its execution time.
        /// Then print it.
        /// </summary>
        void RunStatistics()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime;
            TimeSpan elapsedTime;

            Console.WriteLine("Starting run...");

            int runTimes = 100000;
            int tempI = 0;
            for (int i = 0; i <= charactersArray.Length; i++)
            {
                if (tempI >= runTimes) break;

                if (i > charactersArray.Length - 1)
                {
                    i = 0;
                }

                int num = charactersArray[i].GetIndex();

                tempI++;
            }

            //Exec time calculation
            endTime = DateTime.Now;
            elapsedTime = (endTime - startTime);
            double ms = elapsedTime.TotalMilliseconds / 1000;

            Console.WriteLine(ms + "ms");
        }
        #endregion
    }
}
