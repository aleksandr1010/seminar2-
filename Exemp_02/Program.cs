Console.WriteLine ("Введите координату х,не равную 0");
int x = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите координату y,не равную 0");
int y = int.Parse(Console.ReadLine());

if (x>0 && y>0)
{
    Console.WriteLine("Первая четверть");
}

if (x<0 && y>0)
{
    Console.WriteLine("Вторая четверть");
}
if (x<0 && y<0)
{
    Console.WriteLine("Третья четверть");
}
if (x>0 && y<0)
{
    Console.WriteLine("Четвертая четверть");
}
