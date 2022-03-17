using System;

namespace _153501_Filipenya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber / secondNumber;
            Console.WriteLine($"Division result: {result}");
        }
    }
}
