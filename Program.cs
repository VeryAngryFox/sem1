﻿//Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

int number;
Console.WriteLine("введите число:");
number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
   Console.WriteLine("четное число"); 
}
else
{
    Console.WriteLine("нечетное число");
}
Console.ReadKey();