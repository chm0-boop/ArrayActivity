
using ArrayClassLibrary.Interfaces;
using System;

namespace ArrayClassLibrary.Activities
{
    public class StringReversal : IStringActivity
    {
        private string _input;

        public void SetInput(string input)
        {
            _input = input;
        }

        public void Execute()
        {
            Console.WriteLine($"Original String: {_input}");

            char[] chars = _input.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            Console.WriteLine($"Reversed String: {reversed}");
        }
    }
}
