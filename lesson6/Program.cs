
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int EnterNumbers(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        if (GetNumber($"Введите {i}-е число:") > 0) { result++; };
    }

    return result;
}

int GetNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


string GetMessage(int posQty)
{
    if (posQty > 0)

    {
        return $"Чисел больше нуля: {posQty}";
    }
    else
    {
        return "Положительных чисел нет.";
    }
}

System.Console.WriteLine(GetMessage(EnterNumbers(GetNumber("Сколько чисел введете? "))));





//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double EnterKoef(string msg)
{
    System.Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}

double[] Coordinates(double k1, double k2, double b1, double b2)
{
    double[] arr = new double[2];

    arr[0] = (b2 - b1) / (k1 - k2);
    arr[1] = arr[0] * k1 + b1;

    return arr;
}

double k1 = EnterKoef("Введите коэфиициент k1 в уравнении y=k1*x+b1:");
double b1 = EnterKoef("Введите коэфиициент b1 в уравнении y=k1*x+b1:");
double k2 = EnterKoef("Введите коэфиициент k2 в уравнении y=k2*x+b2:");
double b2 = EnterKoef("Введите коэфиициент b2 в уравнении y=k2*x+b2:");
string msg = "";

if (k1 == k2)
{
    if (b1 == b2)
    {
        msg = "Прямые совпадают";
    }
    else
    {
        msg = "Прямые не пересекаются";
    }
}
else
{
    msg = $"Координаты точки пересечения: ({string.Join(", ", Coordinates(k1, k2, b1, b2))})";
}

System.Console.WriteLine(msg);




