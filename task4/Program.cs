Console.Write("enter number: ");
int number=Convert.ToInt32(Console.ReadLine());
if (number<0)
{
    //number=-number;
    Console.Write("enter positive number: ");
}
else
{
    int negNum=-number;
    while (negNum<=number)
    {
        Console.Write($"{negNum} ");
        negNum++;
    }
}