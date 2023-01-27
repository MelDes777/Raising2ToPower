using System.Numerics;


BigInteger number = 2;

Console.WriteLine("Введите целое число (степень), в которую хотите возвести число 2");
string input = Console.ReadLine() ?? "";

if (!string.IsNullOrEmpty(input))
{

    _ = int.TryParse(input, out int power);

    if (power == 0)
    {
        Console.WriteLine("Вы ввели 0 или неподходящие символы, попробуйте снова");
        return;
    }
    if (power == 1)
    {
        Console.WriteLine("Вы ввели степень 1, число не изменилось. Все также 2. Попробуйте снова");
        return;
    }
    if (power < 0)
    {
        Console.WriteLine("Вы ввели отрицательную степень, попробуйте снова");
    }

    if (power <= 999)
    {
        int count = 0;
        for (int i = 0; i < power; i++)
        {
            number *= 2;
            count++;

            Console.Write($"Вы возвели 2 в степень {count} || Вы получили число {number}\n");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели число 1000 или больше, попробуйте снова");
    }
}
else
{
    Console.WriteLine("Вы отправили пустую строку, попробуйте снова");
}










