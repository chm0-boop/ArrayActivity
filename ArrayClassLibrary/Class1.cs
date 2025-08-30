using ArrayClassLibrary;
using System;

namespace ArrayClassLibrary
{
    public abstract class ActivityBase
    {
        public abstract void Run();
    }

    public class ArrayManipulationActivity : ActivityBase
    {
        private int[] numbers;

        public ArrayManipulationActivity()
        {
            numbers = new int[] { 15, 5, 25, 20, 10 };
        }

        public override void Run()
        {
            Console.WriteLine("Original array: " + string.Join(", ", numbers));
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                    largest = numbers[i];
            }
            Console.WriteLine("Largest value: " + largest);
            Console.Write("Reversed array: ");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }

    public class LinearSearchTask : ActivityBase
    {
        private int[] data;

        public LinearSearchTask()
        {
            data = new int[] { 10, 20, 30, 40, 50 };
        }

        public override void Run()
        {
            Console.WriteLine("Original array: " + string.Join(", ", data));
            Console.Write("Enter number to search: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                int index = LinearSearch(data, num);
                if (index != -1)
                    Console.WriteLine("Number found at index " + index);
                else
                    Console.WriteLine("Number not found");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter the given number only.");
            }

            Console.WriteLine();
        }

        private int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }
    }

    public class StringReversalActivity : ActivityBase
    {
        public override void Run()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("No input provided.");
                return;
            }

            string reversed = ReverseString(word);
            Console.WriteLine($"Original: {word}");
            Console.WriteLine($"Reversed: {reversed}");
        }

        private string ReverseString(string input)
        {
            var builder = new System.Text.StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                builder.Append(input[i]);
            }
            return builder.ToString();
        }
    }

    public class StringSplitAndCount : ActivityBase
    {
        public override void Run()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length < 2)
            {
                Console.WriteLine("It is not a complete sentence bruuuhhh.");
            }
            else
            {
                Console.WriteLine("Number of words: " + words.Length);
            }
        }
    }
}