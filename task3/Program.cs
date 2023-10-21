Console.Write("enter weekday number: ");
string day;
int dayNumber=Convert.ToInt32(Console.ReadLine());
switch (dayNumber)
{
    case 1:
    {
        day="monday";
        break;
    }
    case 2:
    {
        day="tuesday";
        break;
    }
    case 3:
    {
        day="wednesday";
        break;
    } 
    case 4:
    {
        day="thursday";
        break;
    }
    case 5:
    {
        day="friday";
        break;
    }
    case 6:
    {
        day="saturday";
        break;
    }
    case 7:
    {
        day="sunday";
        break;
    }
    default:
    {
        day="there is no such day";
        break;
    }
}
Console.WriteLine(day);