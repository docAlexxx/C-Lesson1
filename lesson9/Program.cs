// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int EnterNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}

void ShowNumbers (int n)
{
    if (n==0) {return;}

    System.Console.Write(n);
    if (n>1) {System.Console.Write(", ");} 

    ShowNumbers (n-1);
}

ShowNumbers (EnterNumber("Задайте значение N: "));

System.Console.WriteLine();

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int EnterEdge(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}

int GetNumbersSum (int m, int n)
{
    if (m==n+1) {return 0;}
  
    return m+GetNumbersSum (m+1,n);
}

int m = EnterEdge("Введите первое число: ");
int n = EnterEdge("Введите второе число: ");

if (n>m)
{
   System.Console.Write($"Сумма чисел от {m} до {n} равна: {GetNumbersSum (m,n)}");
}
else
{
   System.Console.Write($"Сумма чисел от {n} до {m} равна: {GetNumbersSum (n,m)}");
}


System.Console.WriteLine();

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


int EnterNumbers(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}

int AkkermanFunction (int m, int n)
{
    if (m==0) 
    {
        return (n+1);
    }
    else if (n==0)
    {
        return AkkermanFunction (m-1,1);
    }
    else
    {
        return AkkermanFunction (m-1,AkkermanFunction(m,n-1));
    }

}


int m1 = EnterNumbers("Введите первое число: ");
int n1 = EnterNumbers("Введите второе число: ");

if (m<0 || n<0)
{
    System.Console.Write("Числа должны быть положительными!");
}
else
{
    System.Console.Write(AkkermanFunction(m1,n1));
}