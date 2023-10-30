//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("enter 3-digital number: ");
int number=Convert.ToInt32(Console.ReadLine());

if (number/100==0 || number/100>9) 
{
    Console.WriteLine("it's not 3-digital number");
}
else
{
Console.WriteLine((number%100)/10);
}



//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("enter number: ");
int number2=Convert.ToInt32(Console.ReadLine());
if (number2<0) number2=-number2;

if (number2/100==0) 
{
    Console.WriteLine("there isn't 3rd digit");
}
else
{
    while(number2>999)
    {
        number2=number2/10;
    }
    Console.WriteLine($"the third digit is `{number2%10}`");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("enter week day: ");
int day=Convert.ToInt32(Console.ReadLine());

if (day<1 || day>7) 
{
     Console.WriteLine("it's not a week day");
}
else
{
   Console.WriteLine( (day>5)?"yes":"no");
    //if(day>5)
    //{
    //   Console.WriteLine("yes");
    //}
    //else
    //{
    //    Console.WriteLine("no");
    //}
}