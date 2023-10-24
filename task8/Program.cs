int num = new Random().Next(100, 1000);
Console.WriteLine($"start number: `{num}`");
int newnum = (num/100)*10+num%10;
Console.WriteLine($"final number: `{newnum}`");

int num1 = 16;
int num2 = 3;

int restnum=num1%num2;

if (restnum>0)
{
    Console.WriteLine(restnum);
}

