// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите исходное число: ");
int initialN = int.Parse(Console.ReadLine());
Console.WriteLine("Введите проверяемое число: ");
int checkN = int.Parse(Console.ReadLine());

    if (initialN >= checkN)
        if (initialN % checkN == 0)
        {
            Console.WriteLine($"{checkN} кратно {initialN}");
        }
        else
        {
            Console.WriteLine($"{checkN} НЕ кратно {initialN}, остаток от деления {initialN % checkN}");
        }
    else 
    {
        float R = (float) initialN / checkN;
        Console.WriteLine($"{checkN} НЕ кратно {initialN}, остаток от деления {R}");
    }