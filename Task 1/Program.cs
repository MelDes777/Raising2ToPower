using System.Numerics;

Console.WriteLine("Введите целое число (степень) чтобы возвести в нее число 2");
string input = Console.ReadLine() ?? "";

if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int power))
{
    if (power == 0)
    {
        Console.WriteLine("Число 2 нельзя возводить в степень 0, попробуйте снова");
    }
    else if (power == 1)
    {
        Console.WriteLine("Число 2 возведенное в степень 1 это все также 2");
    }
    else if (power < 0)
    {
        Console.WriteLine("Отрицательные степени не поддерживаются, попробуйте снова");
    }
    else if (power > 999)
    {
        Console.WriteLine("Число которые вы ввели больше чем 999, попробуйте снова");
    }
    else
    {
        BigInteger result = BigInteger.Pow(2, power);
        Console.WriteLine($"Результат возведения числа 2 в степень {power} это {result}");
    }
}
else
{
    Console.WriteLine("Неправильный ввод, попробуйте снова");
}









