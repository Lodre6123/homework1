// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 ==0)
{
    Console.WriteLine($"число {number} четное");
}
else
{
    Console.WriteLine($"число {number} не четное");
}