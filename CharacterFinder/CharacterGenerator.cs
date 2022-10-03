using System;

namespace CharacterFinder
{
    static class CharacterGenerator
    {
        public static Character[] GenerateCharacters()
        {
            Character[] characters = new Character[100];

            string[] baseNames = new string[]
            {
                "George",
                "Nikos",
                "Stelios",
                "Alexia",
            };

            Random randomizer = new Random();
            int rndInt = 0;
            string rndName = String.Empty;
            int rndLevel = 0;
            CharClass rndClass;

            for (int i = 0; i < characters.Length; i++)
            {
                rndInt = i;
                rndName = baseNames[randomizer.Next(0, baseNames.Length)] + randomizer.Next(0, 100);
                rndLevel = randomizer.Next(1, 60);
                rndClass = (CharClass)randomizer.Next(0, sizeof(CharClass));

                Character newChar = new Character(rndInt,rndName,rndLevel,rndClass);

                characters[i] = newChar;
            }

            return characters;
        }
    }
}
