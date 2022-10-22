using System;
using System.Collections.Generic;

namespace Lab03.Game
{
    public class Guesser
    {
        Services service = new Services();
        char[] word;
        List<char> charList = new List<char>();


        public List<char> wordinarray(){

            string ChosenWord = service.getWord();
            this.word = ChosenWord.ToCharArray();

            for ( int runs = 0; runs< word.Length; runs ++ )
            {
                this.charList.Add('_');    
            }

            for (int runs = 0; runs<charList.Count; runs++ ){

                Console.Write(charList[runs] + " ");

            } 

            Console.WriteLine();

            return charList;
        }



        List<char> badLetters = new List<char>();

        public bool CheckLetter ()
        {
            
            bool stat_flag = false;
            int runs = 0;

            foreach (var letter in charList)
            {

                if (letter == word[runs])
                {
                    charList[runs] = letter;
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