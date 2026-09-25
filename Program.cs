using System;

class Program
{
    static void Main()
    {
        Methods m = new Methods();

        Console.WriteLine("ЛАБОРАТОРНАЯ РАБОТА №1");
        Console.WriteLine();
        Console.WriteLine("--- Задание 1. Методы ---");
        Console.WriteLine("1. Дробная часть.");
        Console.WriteLine("2. Букву в число.");
        Console.WriteLine("3. Двузначное.");
        Console.WriteLine("4. Диапазон.");
        Console.WriteLine("5. Равенство.");
        Console.WriteLine();
        Console.WriteLine("--- Задание 2. Условия ---");
        Console.WriteLine("6. Модуль числа.");
        Console.WriteLine("7. Тридцать пять.");
        Console.WriteLine("8. Тройной максимум.");
        Console.WriteLine("9. Двойная сумма.");
        Console.WriteLine("10. День недели.");
        Console.WriteLine();
        Console.WriteLine("--- Задание 3. Циклы ---");
        Console.WriteLine("11. Числа подряд.");
        Console.WriteLine("12. Четные числа.");
        Console.WriteLine("13. Длина числа.");
        Console.WriteLine("14. Квадрат.");
        Console.WriteLine("15. Правый треугольник.");
        Console.WriteLine();
        Console.WriteLine("--- Задание 4. Массивы ---");
        Console.WriteLine("16. Поиск первого значения.");
        Console.WriteLine("17. Поиск максимального.");
        Console.WriteLine("18. Добавление массива в массив.");
        Console.WriteLine("19. Возвратный реверс.");
        Console.WriteLine("20. Все вхождения.");

        int choice;
        bool running = true;
        do
        {
            Console.WriteLine();
            Console.Write("Введите номер задачи: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Некорректный ввод");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Введите x: ");
                    if (!double.TryParse(Console.ReadLine(), out double x1))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Дробная часть числа: {m.fraction(x1)}");
                    break;

                case 2:
                    Console.Write("Введите символ в диапазоне от 0 до 9: ");
                    if (!char.TryParse(Console.ReadLine(), out char x2))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    if (x2 < '0' || x2 > '9')
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {m.charToNum(x2)}");
                    break;

                case 3:
                    Console.Write("Введите число: ");
                    if (!int.TryParse(Console.ReadLine(), out int x3))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {m.is2Digits(x3)}");
                    break;

                case 4:
                    Console.Write("Введите первую границу: ");
                    if (!int.TryParse(Console.ReadLine(), out int x4a))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.Write("Введите вторую границу: ");
                    if (!int.TryParse(Console.ReadLine(), out int x4b))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.Write("Введите число: ");
                    if (!int.TryParse(Console.ReadLine(), out int x4num))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {m.isInRange(x4a, x4b, x4num)}");
                    break;

                case 5:
                    Console.Write("Введите a: ");
                    if (!int.TryParse(Console.ReadLine(), out int x5a))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.Write("Введите b: ");
                    if (!int.TryParse(Console.ReadLine(), out int x5b))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.Write("Введите c: ");
                    if (!int.TryParse(Console.ReadLine(), out int x5c))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {m.isEqual(x5a, x5b, x5c)}");
                    break;

                case 6:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x6))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Модуль числа {x6}: {m.abs(x6)}");
                    break;

                case 7:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x7))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {m.is35(x7)}");
                    break;

                case 8:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x8x))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.Write("Введите y: ");
                    if (!int.TryParse(Console.ReadLine(), out int x8y))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.Write("Введите z: ");
                    if (!int.TryParse(Console.ReadLine(), out int x8z))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Максимальное: {m.max3(x8x, x8y, x8z)}");
                    break;

                case 9:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x9x))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.Write("Введите y: ");
                    if (!int.TryParse(Console.ReadLine(), out int x9y))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {m.sum2(x9x, x9y)}");
                    break;

                case 10:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x10))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {m.day(x10)}");
                    break;

                case 11:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x11))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {m.listNums(x11)}");
                    break;

                case 12:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x12))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {m.chet(x12)}");
                    break;

                case 13:
                    Console.Write("Введите x: ");
                    if (!long.TryParse(Console.ReadLine(), out long x13))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {m.numLen(x13)}");
                    break;

                case 14:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x14))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine("Результат:");
                    m.square(x14);
                    break;

                case 15:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x15))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine("Результат:");
                    m.rightTriangle(x15);
                    break;

                case 16:
                    int[] arr16 = m.ReadArray();
                    if (arr16 == null)
                    {
                        break;
                    }
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x16))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {m.findFirst(arr16, x16)}");
                    break;

                case 17:
                    int[] arr17 = m.ReadArray();
                    if (arr17 == null)
                    {
                        break;
                    }
                    Console.WriteLine($"Результат: {m.maxAbs(arr17)}");
                    break;

                case 18:
                    int[] arr18a = m.ReadArray();
                    if (arr18a == null)
                    {
                        break;
                    }
                    int[] arr18b = m.ReadArray();
                    if (arr18b == null)
                    {
                        break;
                    }
                    Console.Write("Введите позицию: ");
                    if (!int.TryParse(Console.ReadLine(), out int pos18))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {string.Join(", ", m.add(arr18a, arr18b, pos18))}");
                    break;

                case 19:
                    int[] arr19 = m.ReadArray();
                    if (arr19 == null)
                    {
                        break;
                    }
                    Console.WriteLine($"Результат: {string.Join(", ", m.reverseBack(arr19))}");
                    break;

                case 20:
                    int[] arr20 = m.ReadArray();
                    if (arr20 == null)
                    {
                        break;
                    }
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x20))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {string.Join(", ", m.findAll(arr20, x20))}");
                    break;

                case 0:
                    Console.WriteLine("Выход");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Нет такой задачи");
                    break;
            }
        } while (running);
    }
}
