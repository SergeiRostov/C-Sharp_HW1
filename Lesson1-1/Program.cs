// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите число А: "); 
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: "); 
int b = int.Parse(Console.ReadLine());

if(a == b*b)
{
    Console.WriteLine("Число А является квадратом числа В");
}
else
{
  Console.WriteLine("Число А НЕ является квадратом числа В");  
}



