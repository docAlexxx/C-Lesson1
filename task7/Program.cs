int num = new Random().Next(10, 100);
Console.Write($"number: `{num}`");
int x = num/10;
int y = num%10;
if (x==y) 
{
   Console.Write("equals");
}
else if (x>y) 
{
   Console.Write(x);
}
else
{
    Console.Write(y);
}
