using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int num = new Random().Next(100, 1000);
            int second =  num / 10 % 10;
            Console.WriteLine($"Вторая цифра в числе: {num} -> {second}");
        
    }
}
}
