Console.Write("enter number: ");
int n=Convert.ToInt32(Console.ReadLine());
//int sum =0;

//for (int i = 1; i < n+1; i++)
//{
//    sum=sum+i;    //sum+=i;
//}

Console.WriteLine($"sum is {sum(n)}");


int sum(int x)
{
    if (x==1) return 1;
    else return x+sum(x-1);    
}