using System;


namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                //creating five variables
                int x = 5;

                string y = "2";

                double a = 6;

                float q = 0.4f;

                bool u = true;

                //testing the five variables
                if (x == 5)
                {
                    Console.Write("x is 5\n");
                }

               if (q == 0.4f)
                {
                    Console.Write("q is 0.4\n");

                }
               
                if (a == 6)
                {
                    Console.Write("a is 6\n");

                }
                if (y == "2")
                {
                    Console.Write("y is 2\n");

                }
                if (u is true)
                {
                    Console.Write("u is true");

                }
            }
        }
    }
}
