﻿using System;
using System.Text;

namespace List
{
    class GenericList<T> where T : IComparable
    {
        private const int defaultCapacity = 1;
        private T[] array;
        private int count = 0;
        private int capacity = defaultCapacity;

        // Constructors
        public GenericList() : this(defaultCapacity) { }

        public GenericList(int capacity)
        {
            this.capacity = capacity;
            array = new T[capacity];
        }

        // Indexer
        public T this[int index]                    // accessing element by index
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                return array[index];
            }
        }

        // Methods
        private void Resize(int count)              // reasize the array if it is full
        {
            // decrease the lenght of array
            if (count > array.Length - 1)
            {
                T[] newArray = new T[capacity * 2];
                Array.Copy(array, newArray, count);
                capacity *= 2;
                array = newArray;
            }

            // increase the lenght of array
            if (count < array.Length / 2)
            {
                T[] newArray = new T[capacity / 2];
                Array.Copy(array, newArray, count);
                capacity /= 2;
                array = newArray;
            }
        }

        public void Add(T value)                    // adding element
        {
            Resize(count);
            array[count] = value;
            count++;
        }

        public void Remove(int index)               // removing element by index
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            Array.Copy(array, index + 1, array, index, array.Length - index - 1);
            count--;
            Resize(count);
        }

        public void Insert(int index, T value)      // inserting element at given position
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            if (count == array.Length)
            {
                T[] newArray = new T[capacity * 2];
                Array.Copy(array, newArray, count);
                capacity *= 2;
                array = newArray;
            }
            Array.Copy(array, index, array, index + 1, array.Length - index - 1);
            array[index] = value;
            count++;
            Resize(count);
        }

        public void Clear()                         // clearing the list
        {
            array = new T[defaultCapacity];
            capacity = defaultCapacity;
            count = 0;
        }

        public int IndexOf(T value)                 // finding element by its value
        {
            return Array.IndexOf(array, value);
        }

        // Counting the current length of the array
        public int Count() { return count; }

        // Counting the allocated length of the array
        public int Length() { return array.Length; }

        // Generic method for finding the minimal element in array
        public T Min<T>()
        {
            dynamic min = array[0];
            for (int i = 1; i < count; i++)
            {
                if (array[i].CompareTo(min) <= 0) min = array[i];
            }
            return min;
        }

        // Generic method for finding the maximal element in array
        public T Max<T>()
        {
            dynamic max = array[0];
            for (int i = 1; i < count; i++)
            {
                if (array[i].CompareTo(max) >= 0) max = array[i];
            }
            return max;
        }

        // String output for this class
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("{");
            for (int element = 0; element < count; element++)
            {
                result.Append(array[element]);
                if (element != count - 1) result.Append(", ");
                else result.Append("}");
            }
            return result.ToString();
        }
    }
}