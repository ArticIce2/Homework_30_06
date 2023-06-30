// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// System.Console.Write("Введите количество чисел M -> ");
// int M = Convert.ToInt32(Console.ReadLine());

// int count = 0;

// for(int i = 0; i < M; i++)
// {
// System.Console.Write("Введите число -> ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number > 0)
// count ++;
// }
// Console.WriteLine("Количество чисел больше 0: " + count);

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


        // Ввод коэффициентов первой прямой
        Console.WriteLine("Введите коэффициенты первой прямой:");
        Console.Write("k1: ");
        double k1 = double.Parse(Console.ReadLine());
        Console.Write("b1: ");
        double b1 = double.Parse(Console.ReadLine());

        // Ввод коэффициентов второй прямой
        Console.WriteLine("Введите коэффициенты второй прямой:");
        Console.Write("k2: ");
        double k2 = double.Parse(Console.ReadLine());
        Console.Write("b2: ");
        double b2 = double.Parse(Console.ReadLine());

        // Проверка на параллельность прямых
        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны и не пересекаются.");
        }
        else
        {
            // Вычисление координат точки пересечения
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            // Вывод результатов
            Console.WriteLine("Точка пересечения прямых: ({0}, {1})", x, y);
        }
    




