
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int enter (string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int powR(int x, int y)
{
    int result =x;
    for (int i = 2; i < y+1; i++)
    {
        result*=x;
    }
    return result;
}

int number = enter("Введите число: ");
int pow = enter("Введите степень: ");

System.Console.WriteLine($"число {number} в степени {pow} равно {powR(number,pow)}");


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int enterNum (string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int sum(int x)
{
   if (x<0) x*=(-1);
    int result = 0;
    while (x>0)
    {
        result+=x%10;
        x/=10;
    }
    return result;
}

int num = enterNum("Введите число: ");
System.Console.WriteLine($"сумма цифр в числе {num} равна {sum(num)}");


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] FillArray(int num)
{
int[] arr = new int[num];

for (int i = 0; i < num; i++)
{
arr[i] =  fillNumber(i); //new Random().Next(0, 2);
}

return arr;
}

int fillNumber(int n)
{
    System.Console.Write($"Введите {n+1}-й элемент: ");
    return Convert.ToInt32(Console.ReadLine());
}


System.Console.Write("Введите количество элементов массива: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"[{string.Join(", ", FillArray(number1))}]");