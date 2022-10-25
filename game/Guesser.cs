using System;
using System.Collections.Generic;

namespace Lab03.Game
{
    public class Guesser
    {
        List<char> badLetters = new List<char>();
        Services service = new Services();
        char[] word;
        List<char> charList = new List<char>();
        public List<char> wordinarray(string ChosenWord)
        {
            this.word = ChosenWord.ToCharArray();
            return charList;
        }
        public bool printArray(char choice_letter)
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
        {

                return badLetters[0];  
        }
    }
    
}