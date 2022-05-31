// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число от 10 до 99: ");
int n = int.Parse(Console.ReadLine());

int first = n / 10;
int second = n % 10;
    if(first >= second)
{
   Console.WriteLine($"Наибольшая цифра {first}");
}
    else
{
    Console.WriteLine($"Наибольшая цифра {second}");
}


