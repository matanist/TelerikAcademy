﻿using System.Collections.Generic;

namespace TradeAndTravel
{
    public class Armor : Item
    {
        // Field
        const int GeneralArmorValue = 5;

        // Constructor
        public Armor(string name, Location location = null)
            : base(name, Armor.GeneralArmorValue, ItemType.Armor, location) { }

        // Method
        static List<ItemType> GetComposingItems()
        {
            return new List<ItemType>() { ItemType.Iron };
        }
    }
}
