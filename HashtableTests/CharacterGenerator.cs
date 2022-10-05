using System.Collections;

namespace HashtableTests
{
    /// <summary>
    /// A static class that's used for creating random player characters.
    /// </summary>
    static class CharacterGenerator
    {
        #region VARIABLES
        static string[] baseNames = new string[]
        {
            "George",
            "Nikos",
            "Stelios",
            "Alexia",
        };

        static Random randomizer = new Random();
        #endregion

        public static Hashtable GenerateCharacters(int numberOfChars)
        {
            //Character[] characters = new Character[numberOfChars];
            Hashtable characters = new Hashtable();

            int rndInt = 0;
            string rndName = string.Empty;
            int rndLevel = 0;
            CharClass rndClass;

            for (int i = 0; i < numberOfChars; i++)
            {
                rndInt = i;
                rndName = baseNames[randomizer.Next(0, baseNames.Length)] + randomizer.Next(0, 100);
                rndLevel = randomizer.Next(1, 60);
                rndClass = (CharClass)randomizer.Next(0, sizeof(CharClass));

                Character newChar = new Character(rndInt, rndName, rndLevel, rndClass);

                characters.Add(i, newChar);
            }

            return characters;
        }

        /*/// <summary>
        /// Call to generate a passed amount of Character objs with random stats and return an array of them.
        /// </summary>
        public static Character[] GenerateCharacters(int numberOfChars)
        {
            Character[] characters = new Character[numberOfChars];

            int rndInt = 0;
            string rndName = string.Empty;
            int rndLevel = 0;
            CharClass rndClass;

            for (int i = 0; i < characters.Length; i++)
            {
                rndInt = i;
                rndName = baseNames[randomizer.Next(0, baseNames.Length)] + randomizer.Next(0, 100);
                rndLevel = randomizer.Next(1, 60);
                rndClass = (CharClass)randomizer.Next(0, sizeof(CharClass));

                Character newChar = new Character(rndInt, rndName, rndLevel, rndClass);

                characters[i] = newChar;
            }

            return characters;
        }

        /// <summary>
        /// Call to generate a passed amount of Character objs with random stats and return a List of them.
        /// </summary>
        public static List<Character> GenerateCharactersList(int numberOfChars)
        {
            List<Character> characters = new List<Character>();

            int rndInt = 0;
            string rndName = string.Empty;
            int rndLevel = 0;
            CharClass rndClass;

            for (int i = 0; i < numberOfChars; i++)
            {
                rndInt = i;
                rndName = baseNames[randomizer.Next(0, baseNames.Length)] + randomizer.Next(0, 100);
                rndLevel = randomizer.Next(1, 60);
                rndClass = (CharClass)randomizer.Next(0, sizeof(CharClass));

                Character newChar = new Character(rndInt, rndName, rndLevel, rndClass);

                characters.Add(newChar);
            }

            return characters;
        }*/
    }
}
