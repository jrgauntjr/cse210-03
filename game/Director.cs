using System;
using System.Collections.Generic;

namespace Lab03.Game
{
    public class Director
    {
        bool isPlaying = true;
        int score = 0;
        Jumper jumperDefult = new Jumper();

        public Director()
        {
            jumperDefult.points_updates(score);
            jumperDefult.draw();
        }
        public void StartGame()
        {
            jumperDefult.points_updates(score);
            jumperDefult.draw();
            while (isPlaying==true)
            {
                getInputs();
                doUpdates();
                doOutputs();
            }
        }
        public void getInputs()
        {
            Console.Write("Guess a letter [a-z]: ");
            string choice = Console.ReadLine();
        }
        public void doUpdates()
        {
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