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


        public void wordinarray(){

            string ChosenWord = service.getWord();
            this.word = ChosenWord.ToCharArray();

            for ( int runs = 0; runs< word.Length; runs ++ )
            {
                this.charList.Add('_');    
            }
        }

        public void printArray(){


            for (int runs = 0; runs<charList.Count; runs++ ){

                Console.Write(charList[runs] + " ");

            } 

            Console.WriteLine();

        }

        public void BadLetterPrint(){

            for (int runs = 0; runs<badLetters.Count; runs++){

            Console.Write("Wrong Guesses: " + badLetters[runs] + " " );

            }
        }


        public bool CheckLetter (char choice)
        {
            
            bool stat_flag = false;
            int runs = 0;

            foreach (var letter in charList)
            {

                if (letter == word[runs])
                {
                    charList[runs] = choice;
                    stat_flag = true;
                }
                else if (letter == '_'){
                    continue;
                }
                else
                {
                    badLetters.Add(choice);
                }
            }
            
            return stat_flag;
        }


    }
    
}