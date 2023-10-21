Console.Write("enter first number: ");
int numberFirst=Convert.ToInt32(Console.ReadLine());
string answer;
Console.Write("enter second number: ");
int numberSecond=Convert.ToInt32(Console.ReadLine());
if (numberFirst==numberSecond*numberSecond) 
{answer="yes";}
else
{answer="no";}

Console.WriteLine(answer);
