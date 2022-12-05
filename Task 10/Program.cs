Console.Clear();
Console.WriteLine("Принимаем на вход 3-х значное число и ны выходе показываем его вторую цифру");
Console.Write("Введите 3-х значное целое число=>");
int yournumber = Int32.Parse(Console.ReadLine());

if ((yournumber / 100 >= 1) && (yournumber / 100 < 10))
{

    int a2 = (yournumber / 10) % 10;
    Console.WriteLine($"Второй цифрой этого числа является: {a2}");
}

else Console.WriteLine("Вы ввели не 3-х значное число");

