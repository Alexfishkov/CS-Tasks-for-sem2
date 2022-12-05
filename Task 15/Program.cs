Console.Clear();
Console.WriteLine("Определяем по номеру дня недели, является ли этот день выходным");
Console.Write("Введите номер дня недели=>");
int yournumber = Int32.Parse(Console.ReadLine());

if ((yournumber <= 7) && (yournumber >= 1))
{
    if ((yournumber <= 7) && (yournumber >= 6)) Console.WriteLine("Это выходной день :)");
    else Console.WriteLine("Это не выходной день");
}

else Console.WriteLine("Дня недели с таким номером нет!");