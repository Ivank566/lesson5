using System;

namespace stars
{
    class Program
    {
        static void Main(string[] args)
        {
             
             Console.WriteLine("Прямокутник");
             for (int i=0; i<5; i++)
             {
                 for(int j=0; j<12; j++)
                 {

                     Console.Write("*");

                 }
                 Console.Write("\n");
             }

             Console.WriteLine("Прямокутний трикутник"); 
             for(int q=0; q<10; q++)
             {
                 for(int w=0; w<q; w++)
                 {
                     Console.Write("*");
                 }
                 Console.Write("\n");
             }

            Console.WriteLine("Рiвностороннiй трикутник");

            for (int y = 1; y < 5; y++)
            {
                for (int x = 1 + y; x < 5; x++)
                {
                    Console.Write(" ");
                }
                for (int x = 1; x < y*2; x++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
 
            Console.WriteLine("Ромб");
            Console.WriteLine("");
            for (int o = 1; o < 6; o++)
            {
                for (int v = 0+o; v < 6; v++)
                {
                    Console.Write(" ");
                }
                for (int v = 1; v < o*2; v++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int o = 6; o >= 0; o--)
            {
                for (int v = 0 + o; v < 6; v++)
                {
                    Console.Write(" ");
                }
                for (int v = 1; v < o * 2; v++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
                }
            
    }
}
