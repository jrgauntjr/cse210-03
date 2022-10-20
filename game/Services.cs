using System;

using System.Collections.Generic;

using Random;

namespace Lab03.Game
{
    public class Services {

        public static void Main();

            string[] words = { "calculator", "phone", "glasses", "pencil", "grape", "duck", "crawl", "parachute", "sphinx", "motherhood"};

            Random rand = new Random();

            int index = rand.Next(words.Length);

        

        

            public string word() {
             string word = words[index];

             return word;
    
    }
    }
}