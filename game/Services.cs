using System;

using System.Collections.Generic;


namespace Lab03.Game
{
    public class Services
    //This class has list of words and one function
    {
        public string word1;
        List<string> words = new List<string>() { "calculator", "phone", "glasses", "pencil", "grape", "duck", "crawl", "parachute", "sphinx", "motherhood" };
        public string getWord()
        //This function basiclly handels random word. Generate Rendom words from the list and return the value. 
        {
            Random random = new Random();
            int index = random.Next(words.Count);
            word1 = words[index];
            return word1;
        }
    }
}