using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите число: ");
            int num = int.Parse(Console.ReadLine());
             
             if ((num > 7) ||  (num < 1))
             {
             Console.WriteLine("Неверний день недели");
             return;
             }

             if ((num > 5))
             {
                Console.WriteLine("Выходной");
             }

             else
            {
             Console.WriteLine("Будний");
            }
            
            

        }
    }
}
