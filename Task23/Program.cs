﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число, дабы узреть его таблицу кубов: ");
int number = Convert.ToInt32(Console.ReadLine());
Square(number);

void Square(int num)
{
    int first = 1;
    while (first <= num)
    {
        int powed = first * first * first;
        Console.Write($"{powed}  ");
        first++;
    }
}