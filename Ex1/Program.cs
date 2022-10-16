// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Clear();
Console.WriteLine("Введите номер задачи (64, 66 или 68) для проверки:");
int num = int.Parse(Console.ReadLine());
if (num == 64) Task64();
else if (num == 66) Task66();
else if (num == 68) Task68();
else Console.WriteLine("Дополнительных задач не решала.");


void Task64()
{
    //     Задача 64: Задайте значения N и M. Напишите программу, которая 
    //выведет все чётные натуральные числа в промежутке от M до N 
    //с помощью рекурсии.
    // M = 1; N = 5 -> 2, 4
    // M = 4; N = 8 -> 4, 6, 8


    Console.Clear();
    Console.Write("Введите число m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n = ");
    int n = Convert.ToInt32(Console.ReadLine());

    Recurs(m, n);

    void Recurs(int m, int n)
    {
        if (m <= n)
        {
            if (m % 2 == 0) Console.Write(m + ", ");
            m++;
            Recurs(m, n);
        }
        else return;
    }
};

void Task66()
{
    //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
    //сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

    // M = 1; N = 15 -> 120
    // M = 4; N = 8 -> 30

    Console.Clear();
    Console.Write("Введите число m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    Recurs(m, n);

    void Recurs(int m, int n)
    {

        if (m <= n)
        {
            sum = sum + m;
            m++;
            Recurs(m, n);
        }

        else
        {
            Console.Write(sum + ", ");
            return;
        }
    }
};

void Task68()
{
    //Задача 68: Задайте значения M и N. Напишите программу, которая 
    //найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

    //M = 28; N = 7 -> 7

    Console.Clear();
    Console.Write("Введите число m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число n = ");
    int n = Convert.ToInt32(Console.ReadLine());

    NOD(m, n);

    void NOD(int min, int max)
    {
        if (min > max) { int temp = min; min = max; max = temp; }
        int k = min;
        if (k >= 1)
        {
            if ((max % k == 0) && (min % k == 0)) { Console.WriteLine(k); return; }
            else
            {
                k--;
                //min = k;
                NOD(k, max);
                //Console.Write(min);
            }
        }
        else
        {
            Console.WriteLine("НОД = 1");
            return;
        }
    }
};

