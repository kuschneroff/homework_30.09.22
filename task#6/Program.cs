﻿/*Задача 6: Напишите программу,
которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число");
string number = Console.ReadLine();

int result = int.Parse(number);

if (result % 2 == 0)
    Console.WriteLine($"{result} = ЧЕТНОЕ число ");

else
    Console.WriteLine($"{result} = НЕЧЕТНОЕ Число ");