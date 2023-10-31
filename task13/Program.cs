int[] FillArray(int num)
{
int[] arr = new int[num];

for (int i = 0; i < num; i++)
{
arr[i] = new Random().Next(0, 2);
}

return arr;
}


System.Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"[{string.Join(", ", FillArray(number))}]");
