using System;

class Program
{
    static void Main()
    {
        Methods p = new Methods();

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
                    Console.WriteLine($"Дробная часть числа: {p.fraction(x1)}");
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
                    Console.WriteLine($"Результат: {p.charToNum(x2)}");
                    break;

                case 3:
                    Console.Write("Введите число: ");
                    if (!int.TryParse(Console.ReadLine(), out int x3))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {p.is2Digits(x3)}");
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
                    Console.WriteLine($"Результат: {p.isInRange(x4a, x4b, x4num)}");
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
                    Console.WriteLine($"Результат: {p.isEqual(x5a, x5b, x5c)}");
                    break;

                case 6:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x6))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Модуль числа {x6}: {p.abs(x6)}");
                    break;

                case 7:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x7))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {p.is35(x7)}");
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
                    Console.WriteLine($"Максимальное: {p.max3(x8x, x8y, x8z)}");
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
                    Console.WriteLine($"Результат: {p.sum2(x9x, x9y)}");
                    break;

                case 10:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x10))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {p.day(x10)}");
                    break;

                case 11:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x11))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {p.listNums(x11)}");
                    break;

                case 12:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x12))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {p.chet(x12)}");
                    break;

                case 13:
                    Console.Write("Введите x: ");
                    if (!long.TryParse(Console.ReadLine(), out long x13))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine($"Результат: {p.numLen(x13)}");
                    break;

                case 14:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x14))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine("Результат:");
                    p.square(x14);
                    break;

                case 15:
                    Console.Write("Введите x: ");
                    if (!int.TryParse(Console.ReadLine(), out int x15))
                    {
                        Console.WriteLine("Некорректный ввод");
                        break;
                    }
                    Console.WriteLine("Результат:");
                    p.rightTriangle(x15);
                    break;

                case 16:
                    int[] arr16 = p.ReadArray();
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
                    Console.WriteLine($"Результат: {p.findFirst(arr16, x16)}");
                    break;

                case 17:
                    int[] arr17 = p.ReadArray();
                    if (arr17 == null)
                    {
                        break;
                    }
                    Console.WriteLine($"Результат: {p.maxAbs(arr17)}");
                    break;

                case 18:
                    int[] arr18a = p.ReadArray();
                    if (arr18a == null)
                    {
                        break;
                    }
                    int[] arr18b = p.ReadArray();
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
                    Console.WriteLine($"Результат: {string.Join(", ", p.add(arr18a, arr18b, pos18))}");
                    break;

                case 19:
                    int[] arr19 = p.ReadArray();
                    if (arr19 == null)
                    {
                        break;
                    }
                    Console.WriteLine($"Результат: {string.Join(", ", p.reverseBack(arr19))}");
                    break;

                case 20:
                    int[] arr20 = p.ReadArray();
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
                    Console.WriteLine($"Результат: {string.Join(", ", p.findAll(arr20, x20))}");
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

class Methods
{
        public double fraction(double x)
    {
        return x - (int)x;
    }

    public int charToNum(char x)
    {
        return x - '0';
    }

    public bool is2Digits(int x)
    {
        return x >= 10 && x <= 99;
    }

    public bool isInRange(int a, int b, int num)
    {
        if (a <= b)
        {
            return a <= num && num <= b;
        }
        else
        {
            return b <= num && num <= a;
        }
    }

    public bool isEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    public int abs(int x)
    {
        if (x < 0)
        {
            return -x;
        }
        else
        {
            return x;
        }
    }

    public bool is35(int x)
    {
        return (x % 3 == 0) != (x % 5 == 0);
    }

    public int max3(int x, int y, int z)
    {
        int max = x;
        if (max < y)
        {
            max = y;
        }
        if (max < z)
        {
            max = z;
        }
        return max;
    }

    public int sum2(int x, int y)
    {
        int sum = x + y;
        if (sum >= 10 && sum <= 19)
        {
            return 20;
        }
        return sum;
    }

    public string day(int x)
    {
        switch (x)
        {
            case 1:
                return "понедельник";

            case 2:
                return "вторник";

            case 3:
                return "среда";

            case 4:
                return "четверг";

            case 5:
                return "пятница";

            case 6:
                return "суббота";

            case 7:
                return "воскресенье";

            default:
                return "это не день недели";
        }
    }

    public string listNums(int x)
    {
        string s = "0";
        for (int i = 1; i <= x; i++)
        {
            s += " " + i.ToString();
        }
        return s;
    }

    public string chet(int x)
    {
        string s = "0";
        for (int i = 2; i <= x; i += 2)
        {
            s += " " + i.ToString();
        }
        return s;
    }

    public int numLen(long x)
    {
        int count = 0;
        long temp = x;
        while (temp != 0)
        {
            count++;
            temp /= 10;
        }
        return count;
    }

    public void square(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void rightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= x - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public int[] ReadArray()
    {
        Console.Write("Введите размер массива: ");
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            return null;
        }

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите {i + 1} элемент: ");
            if (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                return null;
            }
        }
        return arr;
    }

    public int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    public int maxAbs(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > Math.Abs(max))
            {
                max = arr[i];
            }
        }
        return max;
    }

    public int[] add(int[] arr, int[] ins, int pos)
    {
        int[] res = new int[arr.Length + ins.Length];
        for (int i = 0; i < pos; i++)
        {
            res[i] = arr[i];
        }
        for (int i = 0; i < ins.Length; i++)
        {
            res[pos + i] = ins[i];
        }
        for (int i = pos; i < arr.Length; i++)
        {
            res[i + ins.Length] = arr[i];
        }

        return res;
    }

    public int[] reverseBack(int[] arr)
    {
        int[] res = new int[arr.Length];
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            res[arr.Length - i - 1] = arr[i];
        }
        return res;
    }

    public int[] findAll(int[] arr, int x)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                count++;
            }
        }
        int idx = 0;
        int[] res = new int[count];
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] == x)
            {
                res[idx] = j;
                idx++;
            }
        }
        return res;
    }
}
