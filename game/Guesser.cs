using System;
using System.Collections.Generic;

namespace Lab03.Game
{
    public class Guesser
    {

    string ChosenWord = Services.word();
    char[] word = ChosenWord.ToCharArray();
    char[] arrayBlanks;
    List<char> badLetters = new List<char>();
    private char[] Blanks(char[] word){

        for ( int runs = 0; runs< word.Length; runs ++ )
            {
                arrayBlanks[runs] = '_';
            }

            return arrayBlanks;
        }

    private bool CheckLetter (char letter){

        bool stat_flag = false;

        for ( int runs = 0; runs< word.Length; runs ++)
        {
            if (letter == word[runs]){
                arrayBlanks[runs] = letter;
                stat_flag = true;
            }
            else{
                badLetters.Add(letter);
            }

        }

        return stat_flag;
    }


    }
    
}