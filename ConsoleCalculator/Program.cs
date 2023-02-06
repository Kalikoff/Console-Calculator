using System;

namespace ConsoleCalculator {
    class Program {
        static void Main(string[] args) {
            double a, b, c;

            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());

            c = a + b;
            Console.WriteLine($"Ответ сложение целых чисел: {c}");

            c = a - b;
            Console.WriteLine($"Ответ вычитание целых чисел: {c}");

            c = a * b;
            Console.WriteLine($"Ответ умножение целых чисел: {c}");

            c = a / b;
            Console.WriteLine($"Ответ деление целых чисел: {c}");
        }
    }
}
