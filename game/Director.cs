using System;
using System.Collections.Generic;

namespace Lab03.Game
{
    public class Director
    {
        bool isPlaying = true;
        int score = 0;


        public Director()
        {
            Jumper jumper = new Jumper();
            jumper.points_updates(score);
            jumper.draw();
        }
        public void StartGame()
        {
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
            jumper.draw();
            if (score == 0)
            {
                isPlaying = false;
            }
        }
    }
}