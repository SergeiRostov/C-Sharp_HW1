// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());

if(a == 1)
{
   Console.WriteLine("Понедельник - день тяжелый)");
}

if(a == 2)
{
   Console.WriteLine("Пфф, это точно вторник");
}

if(a == 3)
{
   Console.WriteLine("Среда - маленькая пятница!");
}

if(a == 4)
{
   Console.WriteLine("Сегодня уже четверг");
}

if(a == 5)
{
   Console.WriteLine("ПЯТНИЦА!");
}

if(a == 6)
{
   Console.WriteLine("Ура, суббота!");
}

if(a == 7)
{
   Console.WriteLine("Воскресенье, завтра на работу...");
}

if(a == 0 && a > 8)
{
   Console.WriteLine("В неделе всего 7 дней");
}