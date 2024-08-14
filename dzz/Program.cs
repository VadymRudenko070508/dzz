using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
   

    // Задача 1: Приветственное сообщение с именем и возрастом
    static void Task1()
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите ваш возраст: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Привет, {name}! Тебе {age} лет.");
    }

    // Задача 2: Вывод значений переменных различных типов
    static void Task2()
    {
        int number = 10;
        double pi = 3.14159;
        char letter = 'A';
        string greeting = "Hello, World!";

        Console.WriteLine($"int: {number}");
        Console.WriteLine($"double: {pi}");
        Console.WriteLine($"char: {letter}");
        Console.WriteLine($"string: {greeting}");
    }

    // Задача 3: Преобразование строки в число и вывод удвоенного значения
    static void Task3()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine($"Удвоенное значение: {number * 2}");
        }
        else
        {
            Console.WriteLine("Ошибка: введенная строка не является числом.");
        }
    }

    // Задача 4: Проверка числа на положительность, отрицательность или ноль
    static void Task4()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Число положительное.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Число отрицательное.");
        }
        else
        {
            Console.WriteLine("Число равно нулю.");
        }
    }

    // Задача 5: Вывод названия месяца по его номеру
    static void Task5()
    {
        Console.Write("Введите номер месяца (1-12): ");
        int month = int.Parse(Console.ReadLine());

        switch (month)
        {
            case 1: Console.WriteLine("Январь"); break;
            case 2: Console.WriteLine("Февраль"); break;
            case 3: Console.WriteLine("Март"); break;
            case 4: Console.WriteLine("Апрель"); break;
            case 5: Console.WriteLine("Май"); break;
            case 6: Console.WriteLine("Июнь"); break;
            case 7: Console.WriteLine("Июль"); break;
            case 8: Console.WriteLine("Август"); break;
            case 9: Console.WriteLine("Сентябрь"); break;
            case 10: Console.WriteLine("Октябрь"); break;
            case 11: Console.WriteLine("Ноябрь"); break;
            case 12: Console.WriteLine("Декабрь"); break;
            default: Console.WriteLine("Неверный номер месяца."); break;
        }
    }

    // Задача 6: Вывод всех чётных чисел от 1 до 100
    static void Task6()
    {
        Console.WriteLine("Чётные числа от 1 до 100:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    // Задача 7: Сумма чисел от 1 до 50 с использованием цикла while
    static void Task7()
    {
        int sum = 0;
        int i = 1;

        while (i <= 50)
        {
            sum += i;
            i++;
        }

        Console.WriteLine($"Сумма чисел от 1 до 50: {sum}");
    }

    // Задача 8: Инициализация и вывод массива из 10 элементов
    static void Task8()
    {
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        Console.WriteLine("Массив:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Задача 9: Генерация случайного числа от 1 до 100
    static void Task9()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);

        Console.WriteLine($"Случайное число: {randomNumber}");
    }

    // Задача 10: Двумерный массив 3x3, заполненный случайными числами
    static void Task10()
    {
        Random random = new Random();
        int[,] matrix = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = random.Next(1, 11);
            }
        }

        Console.WriteLine("Двумерный массив 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Задача 11: Функция, возвращающая сумму двух целых чисел
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Task11()
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = Add(num1, num2);
        Console.WriteLine($"Сумма {num1} и {num2} равна {sum}");
    }

    // Задача 12: Список, заполненный случайными числами, и их сумма
    static void Task12()
    {
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            numbers.Add(random.Next(1, 101));
        }

        Console.WriteLine("Список чисел:");
        int sum = 0;
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
            sum += number;
        }

        Console.WriteLine($"Сумма чисел в списке: {sum}");
    }
}
