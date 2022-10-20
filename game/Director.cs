using System;
using System.Collections.Generic;

namespace Lab03.Game
{
    public class Director
    {
        public void StartGame()
        {
            getInputs();
            doUpdates();
            doOutputs();
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

        }
    }
}