namespace HashtableTests
{
    public enum CharClass
    {
        Mage,
        Paladin,
        Warrior,
        Druid,
    }

    public class Character
    {
        private Character() { }

        public Character(int index, string name, int level, CharClass charClass)
        {
            SetCharIndex(index);
            SetCharName(name);
            SetCharLevel(level);
            SetCharClass(charClass);
        }

        int charIndex = 0;
        string charName = String.Empty;
        int charLevel = 0;
        CharClass charClass;

        #region SETTERS
        public void SetCharIndex(int index)
        {
            charIndex = index;
        }

        public void SetCharName(string name)
        {
            charName = name;
        }

        public void SetCharLevel(int level)
        {
            charLevel = level;
        }

        public void SetCharClass(CharClass charClass)
        {
            this.charClass = charClass;
        }
        #endregion

        public int GetIndex() => charIndex;
        public string GetName() => charName;
        public int GetLevel() => charLevel;
        public CharClass GetClass() => charClass;
    }
}
