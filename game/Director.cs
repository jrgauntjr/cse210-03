using System;
using System.Collections.Generic;

namespace Lab03.Game
{
    public class Director
    {
        bool isPlaying = true;
        int score = 0;
        Jumper jumperDefult = new Jumper();
        Guesser guess = new Guesser();

        public Director()
        {
            jumperDefult.points_updates(score);
            jumperDefult.draw();
        }
        public void StartGame()
        {
            jumperDefult.points_updates(score);
            jumperDefult.draw();
            char[] word = guess.wordinarray();
            guess.Blanks(word);
            
            while (isPlaying==true)
            {
                char action = getInputs();
                doUpdates(action, word);
                doOutputs();
            }
        }
        public char getInputs()
        {
            Console.Write("Guess a letter [a-z]: ");
            string choice = Console.ReadLine();
            char choiceChar = char.Parse(choice);

            return choiceChar;
        }
        public void doUpdates(char choice, char[] word)
        {
           bool stat_flag = guess.CheckLetter(choice, word);
            
        }
        public void doOutputs()
        {
            jumperDefult.points_updates(score);
            jumperDefult.draw();

            if (score == 0)
            {
                isPlaying = false;
            }
        }
    }
}