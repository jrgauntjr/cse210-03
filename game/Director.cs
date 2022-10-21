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
        char choice;

        public Director()
        {
            jumperDefult.points_updates(score);
            jumperDefult.draw();
        }
        public void StartGame()
        {
            jumperDefult.points_updates(score);
            jumperDefult.draw();
            guess.wordinarray();
            
            while (isPlaying==true)
            {
                choice = getInputs();
                doUpdates(choice);
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
        public void doUpdates(char choice)
        {
           bool stat_flag = guess.CheckLetter(choice);
        
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