/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

int num;
Console.WriteLine("Enter number: ");
num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0){
    Console.WriteLine("Ваш номер делиться на 2 без остатка: " + num);}

    else
    {
        Console.WriteLine("Ваш номер  не делиться на 2 без остатка: " + num);

    }



