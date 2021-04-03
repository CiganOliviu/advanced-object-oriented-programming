using System;
using System.Collections.Generic;

namespace ArrayProcessor
{
    public class ArrayObject
    {
        private int[] _array;

        public ArrayObject(int[] array)
        {
            _array = array;
            GetLength = _array.Length;
        }
        
        public ArrayObject(int length, int[] array)
        {
            GetLength = length;
            _array = array;
        }

        public IEnumerable<int> GetArray => _array;

        public void DisplayArray()
        {
            foreach (var element in _array)
                Console.Write(element + " ");
            
            Console.WriteLine();
        }
        
        public int GetLength { get; }

        public int GetSumOfElements()
        {
            var sum = 0;

            foreach (var element in _array)
                sum += element;

            return sum;
        }
        
        public int GetMaxValue()
        {
            var maximum = Int32.MinValue;

            foreach (var element in _array)
                maximum = element > maximum ? element : maximum;
            
            return maximum;
        }
    }
}