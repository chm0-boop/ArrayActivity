using ArrayClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCLassLibrary.Activities
{
    public class ArrayManipulationActivity : IArrayActivity
    {
        private int[] _array;

        public ArrayManipulationActivity(int[] array)
        {
            _array = array;
        }
        public void Output()
        {
            Console.WriteLine("The orinal array: ");
            foreach (var ar in _array)
            {
                Console.Write($"{ar} ");
            }

            var resersedArray = ReverseArray(_array);

            Console.WriteLine("\nReversed Array: ");
            foreach (var reverse in resersedArray)
            {
                Console.Write($"{reverse} ");
            }
        }

        public void SearchArray(int? target, bool? findLargestValue)
        {
            if (findLargestValue ?? false)
            {
                Console.WriteLine($"The largest value in the array is: {_array.Max()}");
            }
        }

        public void SetArray(int[] array)
        {
            _array = array;
        }

        private int[] ReverseArray(int[] array)
        {
            int[] tempArray = new int[array.Length];
            int counter = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                tempArray[counter] = array[i];
                counter++;
            }

            return tempArray;
        }
    }
}