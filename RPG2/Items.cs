using System;

namespace RPG2
{
    class ItemCreator
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Properties { get; set; }
        public bool Found { get; set; }
        public ItemCreator (string name, string description, string[] properties, bool found)
        {
            Name = name;
            Description = description;
            Properties = properties;
            Found = found;
        }
    }
    //class Item1
    //{
    //    public static object Item(string name, string description, string[] properties, bool found)
    //    {
    //        var _item = new ItemCreator(name, description, properties, found);
    //        return _item;
    //    }
    //}
}