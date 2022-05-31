// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());
if (n > 99 && n < 1000)
{
    n = n / 10 % 10;
    Console.WriteLine($"Вторая цифра этого числа: {n}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}




