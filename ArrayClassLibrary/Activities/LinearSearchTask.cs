using ArrayClassLibrary.Interfaces;
using System;
using System.Linq;

namespace ArrayClassLibrary.Activities
{
    public class ArrayManipulation : IArrayActivity
    {
        private int[] _array;

        public ArrayManipulation(int[] array)
        {
            _array = array;
        }

        public void SetArray(int[] array)
        {
            _array = array;
        }

        public void Output()
        {
            Console.WriteLine("The original array:");
            foreach (var item in _array)
            {
                Console.Write($"{item} ");
            }

            var reversedArray = ReverseArray(_array);

            Console.WriteLine("\nReversed array:");
            foreach (var item in reversedArray)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        public void SearchArray(int? target, bool? findLargestValue)
        {
            if (findLargestValue ?? false)
            {
                Console.WriteLine($"The largest value in the array is: {_array.Max()}");
            }
            else if (target.HasValue)
            {
                int index = -1;
                for (int i = 0; i < _array.Length; i++)
                {
                    if (_array[i] == target.Value)
                    {
                        index = i;
                        break;
                    }
                }

                if (index != -1)
                    Console.WriteLine($"Value {target.Value} found at index {index}.");
                else
                    Console.WriteLine($"Value {target.Value} not found in the array.");
            }
            else
            {
                Console.WriteLine("No valid input provided for search.");
            }
        }

        private int[] ReverseArray(int[] array)
        {
            int[] result = new int[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                result[j++] = array[i];
            }
            return result;
        }
    }
}
