using System;
using System.Collections.Generic;

namespace Lab03.Game
{
    public class Jumper
    {
        int life_points = 4;
        int _points;
        public Jumper()
        {
        }
        public void points_updates(int score)
        {
            _points = life_points + score;
        }
        public void draw()
        {
            if (_points < 4)
                {
                    Console.WriteLine(" ");
                }
            if (_points!=0)
            {
                
                
                for (int i = _points; i > 0;i = i-1 )
                {

                    if (i == 4)
                    {
                        Console.WriteLine(" ___     ");
                    }
                    if (i == 3)
                    {    
                        Console.WriteLine(@"/___\     ");
                    }
                    if (i == 2)
                    {    
                        Console.WriteLine(@"\   /     ");
                    }
                    if (i == 1)
                    {    
                        Console.WriteLine(@" \ /     ");
                    }
                }
                    Console.WriteLine("  0     ");
                    Console.WriteLine(@" /|\    ");
                    Console.WriteLine(@" / \     ");
                    Console.WriteLine(@"^^^^^^^^^^");
            }
            else
            {
            Console.WriteLine("       X     ");
            Console.WriteLine(@"      /|\    ");
            Console.WriteLine(@"      / \     ");  
            Console.WriteLine(@"^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("You lost the game"); 
            }
            
        }
    }
}