/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.WriteLine("Введите пятизначное число -> ");
string? num = Console.ReadLine();

if (num?[0] == num?[4] || num?[1] == num?[3])
{
    System.Console.WriteLine("Ваше число полидром -> " + num);
}
else
{
    System.Console.WriteLine("Ваше число не полидром -> " + num);
}

if (num?.Length > 5)
{
    System.Console.WriteLine("Введите правельно число, ваше число не пятизначное");
}
