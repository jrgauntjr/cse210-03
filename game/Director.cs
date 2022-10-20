using System;
using System.Collections.Generic;

namespace Lab03.Game
{
    public class Director
    {
        bool isPlaying = true;
        int score = 0;
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
            Jumper jumper = new Jumper();
            jumper.draw();
            Console.Write("Guess a letter [a-z]: ");
            string choice = Console.ReadLine();
        }
        public void doUpdates()
        {

        }
        public void doOutputs()
        {
            if (score == 0)
            {
                isPlaying = false;
            }
        }
    }
}