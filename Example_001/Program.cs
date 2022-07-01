// Задача 1: Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.

Console.WriteLine("Эта программа показывает вторую цифру в числе!");
Console.Write("Введите трехзначное число: ");
int Num = int.Parse(Console.ReadLine());
void GetAnswear()
{
if ( Num > 99 && Num < 1000)
{
int TempNum = Num / 10;
int SecondSymbol = TempNum % 10;
Console.WriteLine($"Вторая цифра в вашем числе: {SecondSymbol}");
}
else Console.WriteLine("Введено некоректное число");
}
GetAnswear();
Console.ReadKey();