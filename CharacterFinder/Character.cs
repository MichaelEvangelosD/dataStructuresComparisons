namespace CharacterFinder
{
    public enum CharClass
    {
        Mage,
        Paladin,
        Warrior,
        Druid,
    }

    class Character
    {
        private Character() { }

        public Character(int index, string name, int level, CharClass charClass)
        {
            SetCharIndex(index);
            SetCharName(name);
            SetCharLevel(level);
            SetCharClass(charClass);
        }

        int charIndex;
        string charName;
        int charLevel;
        CharClass charClass;

        #region SETTERS
        public void SetCharIndex(int index)
        {
            this.charIndex = index;
        }

        public void SetCharName(string name)
        {
            this.charName = name;
        }

        public void SetCharLevel(int level)
        {
            this.charLevel = level;
        }

        public void SetCharClass(CharClass charClass)
        {
            this.charClass= charClass; 
        }
        #endregion

        public int GetIndex() => charIndex;
        public string GetName() => charName;
        public int GetLevel() => charLevel;
        public CharClass GetClass() => charClass;
    }
}
