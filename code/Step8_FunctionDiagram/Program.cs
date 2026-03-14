using System;

class Program
{
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => a / b;

    static void Main()
    {
        Console.WriteLine("Простой калькулятор");

        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nВыберите операцию:");
        Console.WriteLine("1 - Сложение");
        Console.WriteLine("2 - Вычитание");
        Console.WriteLine("3 - Умножение");
        Console.WriteLine("4 - Деление");

        Console.Write("Ваш выбор (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double result = 0;
        bool validChoice = true;

        if (choice == 1)
        {
            result = Add(num1, num2);
            Console.WriteLine($"Результат: {num1} + {num2} = {result}");
        }
        else if (choice == 2)
        {
            result = Subtract(num1, num2);
            Console.WriteLine($"Результат: {num1} - {num2} = {result}");
        }
        else if (choice == 3)
        {
            result = Multiply(num1, num2);
            Console.WriteLine($"Результат: {num1} * {num2} = {result}");
        }
        else if (choice == 4)
        {
            result = Divide(num1, num2);
            Console.WriteLine($"Результат: {num1} / {num2} = {result}");
        }
        else
        {
            validChoice = false;
            Console.WriteLine("Неверный выбор операции!");
        }
    }
}
