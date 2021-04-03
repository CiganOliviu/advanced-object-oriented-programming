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
}