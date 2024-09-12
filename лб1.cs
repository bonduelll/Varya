using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в калькулятор!");

        while (true)
        {
            Console.WriteLine("\nВыберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Выход");

            Console.Write("Введите номер операции: ");
            string choice = Console.ReadLine();

            if (int.TryParse(choice, out int operation))
            {
                switch (operation)
                {
                    case 1:
                        CalculateSum();
                        break;
                    case 2:
                        CalculateDifference();
                        break;
                    case 3:
                        CalculateProduct();
                        break;
                    case 4:
                        CalculateQuotient();
                        break;
                    case 5:
                        Console.WriteLine("До свидания!");
                        return; // Выход из программ
                    default:
                        Console.WriteLine("Неверный выбор операции.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
            }
        }
    }

    static void CalculateSum()
    {
        Console.Write("Введите первое число: ");
        double num1 = GetNumberInput();

        Console.Write("Введите второе число: ");
        double num2 = GetNumberInput();

        Console.WriteLine($"Результат: {num1 + num2}");
    }

    static void CalculateDifference()
    {
        Console.Write("Введите первое число: ");
        double num1 = GetNumberInput();

        Console.Write("Введите второе число: ");
        double num2 = GetNumberInput();

        Console.WriteLine($"Результат: {num1 - num2}");
    }

    static void CalculateProduct()
    {
        Console.Write("Введите первое число: ");
        double num1 = GetNumberInput();

        Console.Write("Введите второе число: ");
        double num2 = GetNumberInput();

        Console.WriteLine($"Результат: {num1 * num2}");
    }

    static void CalculateQuotient()
    {
        Console.Write("Введите первое число: ");
        double num1 = GetNumberInput();

        Console.Write("Введите второе число: ");
        double num2 = GetNumberInput();

        if (num2 == 0)
        {
            Console.WriteLine("Деление на ноль невозможно.");
        }
        else
        {
            Console.WriteLine($"Результат: {num1 / num2}");
        }
    }

    static double GetNumberInput()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                return num;
            }
            else
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
            }
        }
    }
}

