using System;

namespace ConsoleCalculator {
    class Program {
        static void Main(string[] args) {
            int a, b, c;

            Console.WriteLine("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine($"Ответ сложение целых чисел: {c}");

            c = a - b;
            Console.WriteLine($"Ответ вычитание целых чисел: {c}");

            c = a / b;
            Console.WriteLine($"Ответ деление целых чисел: {c}");
        }
    }
}
