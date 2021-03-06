﻿using System.Collections.Generic;

namespace TradeAndTravel
{
    public class Person : WorldObject
    {
        // Field
        HashSet<Item> inventoryItems;

        // Property
        public Location Location { get; protected set; }

        // Constructor
        public Person(string name, Location location)
            : base(name)
        {
            this.Location = location;
            this.inventoryItems = new HashSet<Item>();
        }

        // Methods
        public void AddToInventory(Item item)
        {
            this.inventoryItems.Add(item);
        }

        public void RemoveFromInventory(Item item)
        {
            this.inventoryItems.Remove(item);
        }

        public List<Item> ListInventory()
        {
            List<Item> items = new List<Item>();
            foreach (var item in this.inventoryItems)
            {
                items.Add(item);
            }
            return items;
        }
    }
}
