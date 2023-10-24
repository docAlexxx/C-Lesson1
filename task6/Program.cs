int firstNumber = 5;
int secondNumber = 5;

int result = firstNumber-secondNumber;

switch(result)
{
    case <0:
    {
        Console.Write($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        break;
    }
    case >0:
    {
        Console.Write($"Второе число `{secondNumber}` меньше чем первое число `{firstNumber}`");
        break;
    }
    default:
    {
         Console.Write($"Введенные числа равны `{firstNumber}`");
        break;
    }

}
