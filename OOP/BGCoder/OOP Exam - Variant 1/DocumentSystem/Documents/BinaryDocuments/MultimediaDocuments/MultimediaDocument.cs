﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class MultimediaDocument : BinaryDocument
    {
        // Property
        public long? Length { get; protected set; }

        // Methods
        public override void LoadProperty(string key, string value)
        {
            if (key == "length") this.Length = long.Parse(value);
            else base.LoadProperty(key, value);
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("length", this.Length));
            base.SaveAllProperties(output);
        }
    }
}
