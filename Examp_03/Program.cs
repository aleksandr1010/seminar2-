﻿// Программа проверяет пятизначное число на палиндром.
Console.WriteLine ("Введите число");
int x = int.Parse(Console.ReadLine());

if(x / 10000 == x % 10 && x / 1000 % 10 == x / 10 % 10)
{
    Console.WriteLine("Число является полиндромом");
}
else 
{
     Console.WriteLine("Число не является полиндромом");
}