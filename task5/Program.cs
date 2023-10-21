Console.Write("enter 3-digit number: ");
int number=Convert.ToInt32(Console.ReadLine());
if (number>99 && number<1000)
{
int result= number%10;
   Console.Write(result);
}
else
{
   Console.Write("it's not a 3-digit number"); 
}