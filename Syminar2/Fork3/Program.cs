//System.Console.WriteLine("Задача 3 : Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

System.Console.WriteLine("Enter numbre day -> ");
int number_day = Convert.ToInt32(Console.ReadLine());

if (number_day == 6 || number_day == 7)
{
    System.Console.WriteLine("This number  correspond to the day of the week, weekend ");
}
else if (number_day < 1 || number_day > 7)
{
    System.Console.WriteLine("This number does not correspond to the day of the week");
}
else
{
    System.Console.WriteLine("This number  correspond to the day of the week, working day");
}