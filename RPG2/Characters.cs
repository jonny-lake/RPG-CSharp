using System;

namespace RPG2
{
    public class Protagonist
    {
        public string NarrationName { get; set; }
        public string Name { get; set; }
        public Protagonist(string name)
        {
            Name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            NarrationName = name.ToUpper();
        }
    }
}