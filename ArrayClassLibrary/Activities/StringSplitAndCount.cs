using ArrayClassLibrary.Interfaces;
using System;

namespace ArrayClassLibrary.Activities
{
    public class WordCounter : IStringActivity
    {
        private string _input;

        public void SetInput(string input)
        {
            _input = input;
        }

        public void Execute()
        {
            if (string.IsNullOrWhiteSpace(_input))
            {
                Console.WriteLine("The sentence contains 0 words.");
                return;
            }

            string[] words = _input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"The sentence contains {words.Length} word(s).");
        }
    }
}
