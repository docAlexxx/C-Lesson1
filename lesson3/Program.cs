bool isEqual(char a, char b)
{
    return a==b;
}

Console.Write("enter number: ");
string number=Convert.ToString(Console.ReadLine());
string msg="";

int len=number.Length;
for (int i=0; i<len/2; i++)
{
    if (!isEqual(number[i],number[len-1-i]))
       {
        msg="the number is not Palindrome";
        break;
       } 

        msg="the number is Palindrome";
}

Console.Write(msg);

