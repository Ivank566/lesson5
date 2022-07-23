using System;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("vvedit' pershe chyslo:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("vvedit' druge chyslo:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Сума чисел що знаходяться між ними");
            int sum = 0;
            for (int i= a +1; i<b; i++ )
            {
                Console.WriteLine(sum += i);
            }
            

            Console.WriteLine("Введите первое число:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Непарні числа що знаходяться між ними:");
            for(int j = x+1; j<y; j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
            }
            Console.ReadKey();
        }
    }
}
