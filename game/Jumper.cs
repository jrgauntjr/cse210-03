using System;
using System.Collections.Generic;

namespace Lab03.Game
{
    public class Jumper
    //This is a jumper class and has life_point veriable and save points in it.
    {
        int life_points = 4;
        int _points;
        public Jumper()
        {
        }
        public void points_updates(int score)
        //This function is to add the score
        {
            _points = life_points + score;
        }
        public void draw()
        //This function is to draw under certain if statments conditions. 
        //Also has for loop which decides how to draw in certain conditions. 
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