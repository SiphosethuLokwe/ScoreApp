using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoresApplication.Helpers
{
    public static class MessageHelper
    {

        public static void GetInputValidationMessage()
        {
            Console.WriteLine("Input file does not exist.");
            return;
        }
        public static void GetInvalidLine(string line)
        {
            Console.WriteLine($"Invalid line: {line}");

        }

        public static void GetHighestScore(int maxScore)
        {
            Console.WriteLine($"Score: {maxScore}");

        }

        public static void GetUserDetails(string name, string lastName)
        {
            Console.WriteLine($"{name} {lastName}");
        }




    }
}
