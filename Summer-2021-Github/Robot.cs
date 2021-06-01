using System;

namespace Summer_2021_Github
{
    class Robot
    {
        static void Main(string[] args)
        {
            //Read the input string
            Console.WriteLine("Please enter sequence of moves [U/D/L/R]");
            string moves = Console.ReadLine();
            //Calling the method
            bool pos = JudgeCircle(moves);
            //Checking the return value of method
            if (pos)
                Console.WriteLine("The Robot returns to the initial position (0,0)");
            else
                Console.WriteLine("The Robot does not return to the initial postion (0,0)");
        }

        static public bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;
            try 
            {
                char[] array = moves.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    //increasing and decreasing the value of x for horizontal motion (x-axis)
                    if (array[i] == 'R')
                        x++;
                    else if (array[i] == 'L')
                        x--;
                    //increasing and decreasing the value of y for vertical motion (y-axis)
                    else if (array[i] == 'U')
                        y++;
                    else if (array[i] == 'D')
                        y--;
                    else
                        Console.WriteLine("{0} is invalid input ", array[i]);
                }
            }
            catch
            {
                Console.WriteLine("Please provide correct input\n");
            }
            //returns true if x==0 and y==0
            return (x == 0 && y == 0);
        }
    }
}

