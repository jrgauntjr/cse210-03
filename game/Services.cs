using System;

using System.Collections.Generic;


namespace Lab03.Game
{
    public class Services {

        public string getWord()
        {

            string[] words = { "calculator", "phone", "glasses", "pencil", "grape", "duck", "crawl", "parachute", "sphinx", "motherhood"};

            Random rand = new Random();

            int index = rand.Next(words.Length);

            string word = words[index];

            return word;
    
        }
    }
}