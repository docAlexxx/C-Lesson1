
int counter(int x)
{
   if (x<0) x*=(-1);
    int count = 0;
    while (x>0)
    {
        x/=10;
        count++;
    }
    return count;
}


Console.Write("enter number: ");
int n=Convert.ToInt32(Console.ReadLine());

//if (int.TryParse(n,out int x))
//{
    Console.WriteLine($"quanity of digits is {counter(n)}");
//}
//else
//{
 //   Console.WriteLine($"Error! {n} is not number!");
//}