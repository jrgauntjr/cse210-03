using System;

using System.Collections.Generic;


namespace Lab03.Game
{
    public class Services 
    {
        public string word1;
        List<string> words = new List<string> (){"calculator", "phone", "glasses", "pencil", "grape", "duck", "crawl", "parachute", "sphinx", "motherhood"};
        public string getWord()
        {
            Random random = new Random();
            int index = random.Next(words.Count);
            word1 = words[index];
            return word1;
        }
    }
}