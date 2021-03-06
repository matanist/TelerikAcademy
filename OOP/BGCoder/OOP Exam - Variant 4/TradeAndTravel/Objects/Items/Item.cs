﻿using System;

namespace TradeAndTravel
{
    public abstract class Item : WorldObject
    {
        // Properties
        public ItemType ItemType { get; private set; }
        public int Value { get; protected set; }

        // Constructors
        protected Item(string name, int itemValue, string type, Location location = null)
            : base(name)
        {
            this.Value = itemValue;
            foreach (var itemType in (ItemType[])Enum.GetValues(typeof(ItemType)))
            {
                if (itemType.ToString() == type) this.ItemType = itemType;
            }
        }

        protected Item(string name, int itemValue, ItemType type, Location location = null)
            : base(name)
        {
            this.Value = itemValue;
            this.ItemType = type;
        }

        // Method
        public virtual void UpdateWithInteraction(string interaction)
        {
        }
    }
}
