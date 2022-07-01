// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Эта программа принимает цифру, обозначающую день недели, и проверяет, является ли этот день выходным!");
Console.Write("Введите цифру: ");
int Num = int.Parse(Console.ReadLine());
void getWeekday()
{
    if ( Num > 7 | Num < 1) Console.WriteLine("Введено некорректное число/цифра");

    else if ( Num == 1 ) Console.WriteLine("Это понедельник, рабочий день.");

    else if ( Num == 2 ) Console.WriteLine("Это вторник, рабочий день.");

    else if ( Num == 3 ) Console.WriteLine("Это среда, рабочий день.");

    else if ( Num == 4 ) Console.WriteLine("Это четверг, рабочий день.");

    else if ( Num == 5 ) Console.WriteLine("Это пятница, рабочий день, но уже почти...");

    else if ( Num == 6 ) Console.WriteLine("Это суббота, выходной день.");

    else Console.WriteLine("Это воскресенье, выходной день.");
}
getWeekday();
