using System;

namespace ArrayProcessor
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var arrayProcessor = new ArrayObject(new[] {1, 2, 3, 4, 5});
            
            Console.WriteLine(arrayProcessor.GetArray);
            Console.WriteLine(arrayProcessor.GetLength);

            arrayProcessor.DisplayArray();
        }
    }
}