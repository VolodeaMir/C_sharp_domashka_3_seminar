﻿/*
Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
Console.Write("Введите число полиндром: ");
int num = int.Parse(Console.ReadLine()!);
// Console.Write(num / 10000);
int result1 = num / 10000; // Находим первую цифру из нашего пятизначного числа
int result2 = num / 1000 % 10; // Находим вторую цифру из нашего пятизначного числа
int result3 = num / 10 % 10; // Находим четвертую цифру из нашего пятизначного числа 
                             // цифру по середине нет смысла выводить - она одна и та-же как не поверни.
int result4 = num % 10; // Находим первую цифру из нашего пятизначного числа
string result5 = "";

if (result1 == result4 && result2 == result3) result5 = "Число является палиндромом";
else result5 = "Число не является палиндромом";
Console.WriteLine(result5);