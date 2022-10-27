using System;
using System.Collections.Generic;

namespace Lab03.Game
{
    public class Guesser
    //This is a Guesser class and has two function in it.
    {
        List<char> badLetters = new List<char>();
        Services service = new Services();
        char[] word;
        List<char> charList = new List<char>();
        public List<char> wordinarray(string ChosenWord)
        //This function is has list of word and returns the chosen word.
        {
            this.word = ChosenWord.ToCharArray();
            return charList;
        }
        public bool printArray(char choice_letter)
        //This function starts with a condition and has a for loop under the condition.
        //This for loop look words in runs and if the word is cosen word the bool condition ends.
        {
            bool loosepoints = true;

            for (int runs = 0; runs<word.Length; runs++ )
            {
                
                if (word[runs] == choice_letter)
                {
                    loosepoints = false;
                }
            } 
            badLetters.Add(choice_letter);
            return loosepoints;
        }
        public char BadLetterPrint()
        //This function is for bad letters and return bad letters. 
        {

                return badLetters[0];  
        }
    }
    
}