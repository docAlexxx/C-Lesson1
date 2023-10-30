Console.Write("enter x: ");
int x=Convert.ToInt32(Console.ReadLine());
Console.Write("enter y: ");
int y=Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
    {
        Console.Write("1");
    }
 else if (x<0 && y>0)
    {
        Console.Write("2");
    }   
else if ( x<0 && y<0)
    {
        Console.Write("3");
    }
else if (x>0 && y>0)
    {
        Console.Write("4");
    }
 else
 {
     Console.Write("point is on axe");
 }   



