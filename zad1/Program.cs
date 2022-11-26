// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Write("Введите число а: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Максимальное число {number1}, а минимальное {number2}");
}
else
{
    Console.WriteLine($"Максимальное число {number2}, а минимальное {number1} ");
}
