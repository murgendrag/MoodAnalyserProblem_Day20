using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MoodAnalzerProblem
{
    public class Program
    {
         static void Main(string[] args)
        {
            string UserMessage;
            bool result;
            MoodAnalser Check = new MoodAnalser();

            Console.WriteLine("If sad then enter I am in Sad Mood ,If Happy then I am in Happy Mood");

            UserMessage = Console.ReadLine();

            result = Check.AnalyseMood(UserMessage);
            

            if (result = true)
            {
                Console.WriteLine("SAD");
            }
            else
            {
                Console.WriteLine("HAPPY");
            }
        }
    }
}