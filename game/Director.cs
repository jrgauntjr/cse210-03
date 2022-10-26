using System;
using System.Collections.Generic;

namespace Lab03.Game
{
    public class Director
    {
        bool isPlaying = true;
        int score = 0;
        char[] choice_letter;
        char bad_letter;
        List<char> bad_letters = new List<char>();
        string choice;
        bool loosepoints;
        string ChosenWord;
        char[] the_word_ ;
        char[] wordle2;
        List<char> wordle = new List<char>();
        int win;

        public Director()
        
        {

        }
        public void StartGame()
        { 
            Jumper jumperDefult = new Jumper();
            jumperDefult.points_updates(score);
            jumperDefult.draw();
            Guesser guess = new Guesser();
            
            Services service = new Services();
            ChosenWord = service.getWord();
            for(int i = 0;ChosenWord.Length>i;i++)
            {
                Console.Write("_");
            }
            Console.WriteLine(" ");

            while (isPlaying==true)
            {
                getInputs();
                doUpdates();
                doOutputs();
            }
        }
        public void getInputs()
        {
            Guesser guess = new Guesser();
            
            Console.WriteLine("Guess a letter [a-z]: ");
            choice = Console.ReadLine();
            choice_letter = choice.ToCharArray();
            guess.wordinarray(ChosenWord);
            loosepoints = guess.printArray(choice_letter[0]);
            bad_letter = guess.BadLetterPrint();
            bad_letters.Add(bad_letter);
            Console.WriteLine("Guesses: ");
            for (int runs = 0; runs<bad_letters.Count; runs++)
            {
                Console.Write(bad_letters[runs] + ", " );
            }
            Console.WriteLine(" ");
        }
        public void doUpdates()
        {
            char choice_letter1 = choice_letter[0];
            this.the_word_ = ChosenWord.ToCharArray();
            for ( int runi = 0; runi< the_word_.Length; runi ++ )
            {

                wordle.Add('_'); 
            }
            if (wordle2 == null)
            {
                wordle2 = wordle.ToArray();
            }

            for ( int runs = 0; runs< the_word_.Length; runs ++ )
            {
                if (the_word_[runs] == choice_letter1)
                {
                    wordle2[runs] = choice_letter1;
                }
                Console.Write(wordle2[runs]);
            }
            Console.WriteLine(" ");
            if (loosepoints == true)
            {
                score = score -1;
            }
        }
        public void doOutputs()
        {
            Jumper jump = new Jumper();
            jump.points_updates(score);
            jump.draw();
            int win = the_word_.Length;
            for ( int runs = 0; runs< the_word_.Length; runs ++ )
            {
                if (the_word_[runs] == wordle2[runs])
                {
                    win = win -1;
                }
            }
            if (win == 0)
            {
                Console.WriteLine($"You won!! The word was {ChosenWord}");
                isPlaying = false;
            }
            if (score == -4)
            {
                Console.WriteLine($"The word was {ChosenWord}");
                isPlaying = false;
            }
        }
    }
}