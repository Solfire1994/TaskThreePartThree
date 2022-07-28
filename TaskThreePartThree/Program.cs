using System;

namespace TaskThreePartThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число и программа проверит простое ли оно");
            int number = int.Parse(Console.ReadLine());
            int i = 2;
            bool isValid = false;
            while (i < number)
            {
                if(number % i == 0)
                {
                    isValid = true;
                }
                i++;
            }

            Console.WriteLine(isValid ? "Число не простое" : "Число простое");
            Console.ReadKey();
        }
    }
}
