using System;

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
