// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное значное число: ");
int n = int.Parse(Console.ReadLine());
int first = n / 100;
int third = n % 10;
Console.WriteLine($"Число без второй цифры: {first}{third}");


