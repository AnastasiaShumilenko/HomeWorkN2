using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Clear();
            Console.Write("Введите любое число: ");
            int a = int.Parse(Console.ReadLine() ?? "0" );
            if (a < 100)
            {
            Console.WriteLine("Число меньше 100!");
            }
            else{
            
              while (a>1000)
              {
                 a/=10;
              }
                Console.WriteLine(a%10);
            }
        }
    }
}
