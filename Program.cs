using System;
using System.Net;

public class Programm
{
    public static void Main(string[] args)
    {
        int number_q;
        bool end_programm = false;
        int num_debug = 0    ;// 0 - обычное выполнение программы, иначе от 1 до 20 номер задания, которое будет выполнялся бесконечно
        Programm foo = new Programm();
        /*
        Console.WriteLine(foo.charToNum('3'));
        int output = foo.InputIntegerWithValidation("Введите число от 0 до 3", 0, 3);
        Console.WriteLine(output);
        */
        Console.WriteLine("Лабораторная работа №1\nБлоки по 5 заданий\nМой вариант нечетный\nДля выхода введите 0");
        while (!end_programm)
        {
            if (num_debug == 0)
            {
                number_q = foo.InputIntegerWithValidation("Введите номер задания от 1 до 20", 0, 20);
            }
            else
            {
                number_q = num_debug;
            }
            switch (number_q)
            {
                case 0:
                    Console.WriteLine("Завершение программы");
                    end_programm = true;
                    break;
                case 1:
                    /*
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;
                    */
                    Console.WriteLine("\nДробная часть");
                    Console.WriteLine(foo.fraction(foo.InputDoubleWithValidation("Введите любое рациональное число", double.MinValue, double.MaxValue)));
                    break;
                case 2:
                    Console.WriteLine("\nБукву в число");
                    Console.WriteLine(foo.charToNum(foo.InputIntegerCharWithValidation("Введите число от 0 до 9", 0, 9))); 
                    break;
                case 3:
                    Console.WriteLine("\nДвузначное"); 
                    Console.WriteLine(foo.is2Digits(foo.InputIntegerWithValidation("Введите целое число", int.MinValue, int.MaxValue)));
                    break;
                case 4:
                    Console.WriteLine("\nДиапазон");
                    Console.WriteLine(foo.isInRange(foo.InputIntegerWithValidation("Введите целое число a", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число b", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число num", int.MinValue, int.MaxValue)));
                    break;
                case 5:
                    Console.WriteLine("\nРавенство");
                    Console.WriteLine(foo.isEqual(foo.InputIntegerWithValidation("Введите целое число a", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число b", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число c", int.MinValue, int.MaxValue)));
                    break;
                case 6:
                    Console.WriteLine("\nМодуль числа");
                    Console.WriteLine(foo.abs(foo.InputIntegerWithValidation("Введите целое число", int.MinValue, int.MaxValue)));
                    break;
                case 7:
                    Console.WriteLine("\nТридцать пять");
                    Console.WriteLine(foo.is35(foo.InputIntegerWithValidation("Введите целое число", int.MinValue, int.MaxValue)));
                    break;
                case 8:
                    Console.WriteLine("\nТройной максимум");
                    Console.WriteLine(foo.max3(foo.InputIntegerWithValidation("Введите целое число x", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число y", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число z", int.MinValue, int.MaxValue)));
                    break;
                case 9:
                    Console.WriteLine("\nДвойная сумма");
                    Console.WriteLine(foo.sum2(foo.InputIntegerWithValidation("Введите целое число x", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число y", int.MinValue, int.MaxValue)));
                    break;
                case 10:
                    Console.WriteLine("\nДень недели");
                    Console.WriteLine(foo.day(foo.InputIntegerWithValidation("Введите целое число от 1 до 7", int.MinValue, int.MaxValue)));
                    break;
                case 11:
                    Console.WriteLine("\nЧисла подряд");
                    Console.WriteLine(foo.listNums(foo.InputIntegerWithValidation("Введите натуральное число", 0, int.MaxValue)));
                    break;
                case 12:
                    Console.WriteLine("\nЧетные числа");
                    Console.WriteLine(foo.chet(foo.InputIntegerWithValidation("Введите натуральное число", 0, int.MaxValue)));
                    break;
                case 13:
                    Console.WriteLine("\nДлина числа");
                    Console.WriteLine(foo.numLen(foo.InputLongWithValidation("Введите целое число", long.MinValue, long.MaxValue)));
                    break;
                case 14:
                    Console.WriteLine("\nКвадрат");
                    foo.square(foo.InputIntegerWithValidation("Введите натуральное число", 0, int.MaxValue));
                    break;
                case 15:
                    Console.WriteLine("\nПравый треугольник");
                    foo.rightTriangle(foo.InputIntegerWithValidation("Введите натуральное число", 0, int.MaxValue));
                    break;
                case 16:
                    Console.WriteLine("\nПоиск первого значения");
                    Console.WriteLine(foo.findFirst(foo.InputIntegerArrayWithValidation("Элементы массива - целые числа", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число, вхождение которого будет искаться", int.MinValue, int.MaxValue)));
                    break;
                case 17:
                    Console.WriteLine("\nПоиск максимального");
                    Console.WriteLine(foo.maxAbs(foo.InputIntegerArrayWithValidation("Элементы массива - целые числа", int.MinValue, int.MaxValue)));
                    break;
                case 18:
                    Console.WriteLine("\nДобавление массива в массив");
                    int[] arr1 =  foo.InputIntegerArrayWithValidation("Элементы 1 массива - целые числа", int.MinValue, int.MaxValue);
                    foo.PrintIntegerArray(foo.add(arr1, foo.InputIntegerArrayWithValidation("Элементы 2 массива - целые числа", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите натуральное число - индекс для вставки", 0, arr1.Length)));
                    break;
                case 19:
                    Console.WriteLine("\nВозвратный реверс");
                    foo.PrintIntegerArray(foo.reverseBack(foo.InputIntegerArrayWithValidation("Элементы массива - целые числа", int.MinValue, int.MaxValue)));
                    break;
                case 20:
                    Console.WriteLine("\nВсе вхождения");
                    foo.PrintIntegerArray(foo.findAll(foo.InputIntegerArrayWithValidation("Элементы массива - целые числа", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число, вхождение которого будет искаться", int.MinValue, int.MaxValue)));
                    break;
                default:
                    break;
            }
        }
    }


    public void PrintIntegerArray(int[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(input[i]);
            Console.Write(" ");
        }
    }
    public int[] InputIntegerArrayWithValidation(string s, int left, int right)
    {
        Console.WriteLine(s);
        int len = InputIntegerWithValidation("Введите длинну массива", 1, int.MaxValue);
        int[] numbers = new int[1];
        Array.Resize(ref numbers, len); 
        Console.WriteLine("Вводите элементы массива через enter");
        for (int i = 0; i < len; i++)
        {
            numbers[i] = InputIntegerWithValidation("", left, right);
        }
        return numbers;
    }
    public int InputIntegerWithValidation(string s, int left, int right) // Ввод целого числа с проверкой правильности ввода, в том числе принадлежности к указанному диапазону.                                                                                         
    {
        bool ok;
        int a;
        do
        {   if (s != "") Console.WriteLine(s); // да блен, переписывать 3/4 лабы, поскольку можно реализовать значение по умолчанию.. не
            ok = int.TryParse(Console.ReadLine(), out a);
            if (ok)
                if (a < left || a > right)
                    ok = false;
            if (!ok)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nВведенные данные имеют неверный формат или не принадлежат диапазону [{left}; {right}]");
                Console.WriteLine("Повторите ввод\n");
                Console.ForegroundColor = tmp;
            }
        } while (!ok);
        return a;
    }

    public char InputIntegerCharWithValidation(string s, int left, int right) // Ввод целого числа с проверкой правильности ввода, в том числе принадлежности к указанному диапазону.                                                                                         
    {
        bool ok;
        int a;
        string input;
        char output;
        do
        {
            if (s != "") Console.WriteLine(s); // да блен, переписывать 3/4 лабы, поскольку можно реализовать значение по умолчанию.. не
            input = Console.ReadLine();
            ok = int.TryParse(input, out a);
            if (ok)
                if (a < left || a > right)
                    ok = false;
            if (!ok)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nВведенные данные имеют неверный формат или не принадлежат диапазону [{left}; {right}]");
                Console.WriteLine("Повторите ввод\n");
                Console.ForegroundColor = tmp;
            }
        } while (!ok);
        output = Convert.ToChar(input);
        return output;
    }

    public long InputLongWithValidation(string s, long left, long right) // Ввод целого числа с проверкой правильности ввода, в том числе принадлежности к указанному диапазону.                                                                                         
    {
        bool ok;
        long a;
        do
        {
            Console.WriteLine(s);
            ok = long.TryParse(Console.ReadLine(), out a);
            if (ok)
                if (a < left || a > right)
                    ok = false;
            if (!ok)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nВведенные данные имеют неверный формат или не принадлежат диапазону [{left}; {right}]");
                Console.WriteLine("Повторите ввод\n");
                Console.ForegroundColor = tmp;
            }
        } while (!ok);
        return a;
    }

    public double InputDoubleWithValidation(string s, double left, double right) // Ввод целого числа с проверкой правильности ввода, в том числе принадлежности к указанному диапазону.                                                                                         
    {
        bool ok;
        double a;
        do
        {
            Console.WriteLine(s);
            ok = double.TryParse(Console.ReadLine(), out a);
            if (ok)
                if (a < left || a > right)
                    ok = false;
            if (!ok)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nВведенные данные имеют неверный формат или не принадлежат диапазону [{left}; {right}]");
                Console.WriteLine("Повторите ввод\n");
                Console.ForegroundColor = tmp;
            }
        } while (!ok);
        return a;
    }
    public double fraction(double x)
    {
        int y = (int) (Convert.ToDouble(x));
        return Math.Round(x - y, x.ToString().Length); //https://vk.com/video381616305_456239181
    }
    public int charToNum(char x)
    {
        return (Convert.ToInt32(x - 48));
    }

    public bool is2Digits(int x)
    {
        x = Math.Abs(x);
        return (x / 10 >= 1 && x / 100 < 1);
    }
    public bool isInRange(int a, int b, int num)
    {
        if (a > b)
        {
            return (num >= b && num <= a);
        }
        else
        {
            return ( num >= a && num <= b );
        }
    }
    public bool isEqual(int a, int b, int c)
    {
        return (a == b && a == c);
    }
    public int abs(int x)
    {
        if (x >= 0)
        {
            return x;
        }
        else
        {
            return (x * (-1));
        }
    }
    public bool is35(int x)
    {
        return ((x % 3 == 0 || x % 5 == 0) && !(x % 3 == 0 && x % 5 == 0));
    }
    public int max3(int x, int y, int z)
    {
        int max = y;
        if (x >= y)
        {
            max = x;
        }
        if (z >= max)
        {
            max = z;
        }
        return max;
    }
    public int sum2(int x, int y)
    {
        int sum = x + y;
        if (sum >= 10 &&  sum <= 19)
        {
            sum = 20;
        }
        return sum;
    }
    public String day(int x)
    {
        switch (x)
        {
            case 1:
                return "Понедельник";
            case 2:
                return "Вторник";
            case 3:
                return "Среда";
            case 4:
                return "Четверг";
            case 5:
                return "Пятница";
            case 6:
                return "Суббота";
            case 7:
                return "Воскресенье";
            default:
                return "это не день недели";

        }
    }
    public String listNums(int x)
    {
        string str = "";
        for (int i = 0; i <= x; i++)
        {
            str = str + Convert.ToString(i) + " ";
        }
        return str;
    }
    public String chet(int x)
    {
        string str = "";
        for (int i = 0; i <= x; i+=2)
        {
            str = str + Convert.ToString(i) + " ";
        }
        return str;
    }
    public int numLen(long x)
    {
        x = Math.Abs(x);
        if (x == 0) x = 1;// не ну че ты с этим нулем поделаешь
        int count = 0;
        while (x > 0)
        {
            x = x / 10;
            count++;
        }
        return count;
    }
    public void square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
    public void rightTriangle(int x)
    {
        /*
        * 00 01 02 03
        * 10 11 12 13
        * 20 21 22 23
        * 30 31 32 33
        */
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                if (i >= -j+x-1) //y = -x+len
                {
                    Console.Write("*");
                }
                else {
                    Console.Write(" ");
                }
            }
            Console.Write("\n");
        }
    }
    public int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) return i;
        }
        return -1;
    }
    public int maxAbs(int[] arr)
    {
        int max_index = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > Math.Abs(arr[max_index]))
            {
                max_index = i;
            }
        }
        return arr[max_index];
    }

    public int[] add(int[] arr, int[] ins, int pos)
    {
        int it = 0;
        int[] numbers = new int[1];
        Array.Resize(ref numbers, arr.Length + ins.Length);
        while (it < numbers.Length)
        {
            if (it < pos)
            {
                numbers[it] = arr[it];
            }
            else if (it >= pos && it < pos + ins.Length)
            {
                numbers[it] = ins[it - pos];
            }
            else
            {
                numbers[it] = arr[it - ins.Length];
            }
            it++;
        }
        return numbers;
    }
    public int[] reverseBack(int[] arr)
    {
        int buff;
        for (int i = 0; i < arr.Length/2; i++)
        {
            buff = arr[i];
            arr[i] = arr[arr.Length-1-i];
            arr[arr.Length-1-i] = buff;
        }
        return arr;
    }
    public int[] findAll(int[] arr, int x)
    {
        int[] indexes = new int[1];
        int new_len = 0;
        int jterator = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) new_len++; 
        }
        Array.Resize(ref indexes, new_len);
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) {
                indexes[jterator] = i;
                jterator++;
            }
        }
        return indexes;

    }
}


