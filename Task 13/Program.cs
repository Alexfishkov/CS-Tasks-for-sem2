Console.Clear();
Console.WriteLine("Проверяем, есть ли третья цифра в заданном вами числе и если да, показываем её");
Console.Write("Введите число в дипазоне от -2 147 483 647 до 2 147 483 647=>");
int yournumber = Math.Abs(Int32.Parse(Console.ReadLine()));

if (yournumber / 100 >= 1)
{
    while (yournumber >= 1000)
    {
        yournumber = yournumber / 10;
    }

    int a3 = yournumber % 10;
    Console.WriteLine($"Третьей цифрой вашего числа является: {a3}");
}

else Console.WriteLine("В вашем числе нет третьей цифры");