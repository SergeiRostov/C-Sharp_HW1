// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
    if (n >=100 && n <= 999 || n >=-999 && n <= -100)
    {
        Console.WriteLine($"{Math.Abs(n % 10)}");
    }
    else if (n < 100 && n > -100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
        else
        {
            int count = 0;
            int digits = Math.Abs(n);
            int dig3 = Math.Abs(n);
            while (digits > 0) 
            {
                digits = digits / 10;
                count++;
            }
            while (count > 3) 
            {
                dig3 = dig3 / 10;
                count = count - 1;
            }
        Console.WriteLine($"Третья цифра {dig3 % 10}");
        }
    
        
    
