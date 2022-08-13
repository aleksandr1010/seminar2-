//Ввозведите число А в натуральную степень В используя цикл
Console.WriteLine("Введите значение a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b:");
int b = int.Parse(Console.ReadLine());
int count = 1;
int sum = a;

while(count<b)
{
    sum = sum * a;
    count++;
}
Console.WriteLine(sum);
