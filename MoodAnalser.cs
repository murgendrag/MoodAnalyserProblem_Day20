﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MoodAnalzerProblem
{
    public class MoodAnalser
    {
        public static string message1 = "I am in Sad Mood";
        public static string message2 = "I am in Happy Mood";
        public bool AnalyseMood(string User_message)
        {
            return Regex.IsMatch(User_message,message1);
        }
        
    }
}