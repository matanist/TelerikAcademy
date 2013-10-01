﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePhone
{
    public class Display
    {
        // display characteristics
        private byte? size;
        private uint? colors;

        // constructors
        public Display() { }                        // constructor without parameters

        public Display(byte? size, uint? colors)    // constructor with two parameters
        {
            this.Size = size;
            this.Colors = colors;
        }

        // properties
        public byte? Size
        {
            get { return this.size; }
            set
            {
                if (value > 150)
                {
                    throw new ArgumentOutOfRangeException("Too big size of display!");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public uint? Colors
        {
            get { return this.colors; }
            set
            {
                if (value > 200000)
                {
                    throw new ArgumentOutOfRangeException("The number of colors is too big!");
                }
                else
                {
                    this.colors = value;
                }
            }
        }

        // methods
        public override string ToString()
        {
            return 
                "\nDisplay information" +
                "\n\tSize: \t\t" + this.size +
                "\n\tColors: \t" + this.colors;
        }
    }
}
