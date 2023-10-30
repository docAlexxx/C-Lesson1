int readData (string msg)
{ 
    Console.Write("enter " + msg +": ");
    int num=Convert.ToInt32(Console.ReadLine());
    return num;
}

int sideLength(int x, int y)
{
    if(x>y) {
        return x-y;
    } else 
    {
        return y-x;
    }

}

double distance (int x, int y)
{
    double result=Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
    return Math.Round(result,2);
}

int xa=readData("first point x");
int ya=readData("first point y");
int xb=readData("second point x");
int yb=readData("second point y");

int firstSide= sideLength(xa,xb) ;

int secondSide= sideLength(ya,yb) ;

Console.Write($"lenth of line is {distance(firstSide,secondSide)}");
