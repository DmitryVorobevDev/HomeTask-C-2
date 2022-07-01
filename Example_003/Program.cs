// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Эта программа показывает третью цифру в числе!");
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine());
void GetNumber()
{
    if ( Num > 99 )
        {
        string StrNum = Num.ToString();
        Console.WriteLine($"Третья цифра в вашем числе: {StrNum[2]}");
        }
    else Console.WriteLine("Введеное число не имеет третьего символа");
}
GetNumber();
Console.ReadKey();
