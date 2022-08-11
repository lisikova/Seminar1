Console.Write ("введите число 1: ");
int number1 = int.Parse (Console.ReadLine ());
Console.Write ("введите число 2: ");
int number2 = int.Parse (Console.ReadLine ());
if (number1 > number2)
{
Console.WriteLine ($"{number1} больше числа {number2}");
}
else 
{
Console.WriteLine ($"{number2} больше числа {number1}");
}