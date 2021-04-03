using System;
using System.Collections.Generic;

namespace ArrayProcessor
{
    internal class ArrayProcessor
    {
        private int[] _array;

        public ArrayProcessor(int[] array)
        {
            _array = array;
            GetLength = _array.Length;
        }
        
        public ArrayProcessor(int length, int[] array)
        {
            GetLength = length;
            _array = array;
        }
        
        public IEnumerable<int> GetArray => _array;
        public int GetLength { get; }

        public int GetSumOfElements()
        {
            /* Algorithm implementation here */
            
            return 0;
        }
        
        public int GetMaxValue()
        {
            /* Algorithm implementation here */
            
            return 0;
        }
    }
    
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var arrayProcessor = new ArrayProcessor(new[] {1, 2, 3, 4, 5});
            
            Console.WriteLine(arrayProcessor.GetArray);
            Console.WriteLine(arrayProcessor.GetLength);
        }
    }
}