using System;
using System.Collections.Generic;

namespace Lab03.Game
{
    public class Guesser
    {
        Services service = new Services();
        char[] word;
        char[] arrayBlanks = {'_'};
        public void wordinarray(){
            string ChosenWord = service.getWord();
            this.word = ChosenWord.ToCharArray();

            for ( int runs = 0; runs< word.Length; runs ++ )
            {
                arrayBlanks[] = '_';
            }
            
            Console.WriteLine(arrayBlanks);
        }
        List<char> badLetters = new List<char>();

        public bool CheckLetter (char letter)
        {

            bool stat_flag = false;

            for ( int runs = 0; runs< word.Length; runs ++)
            {
                if (letter == word[runs])
                {
                    arrayBlanks[runs] = letter;
                    stat_flag = true;
                }
                else
                {
                    badLetters.Add(letter);
                }

            }
            return stat_flag;
        }


    }
    
}