// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 8)
{
    if (num < 6)
    {
        Console.WriteLine("Будний день");
    }
    else
    {
        Console.WriteLine("Выходной день");
    }
}
else 
Console.WriteLine("СЕМЬ ДНЕЙ!");