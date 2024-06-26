﻿// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n -1));
}

System.Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akk = Akkerman(m, n);
System.Console.WriteLine($"Функция Аккермана = {Akk} ");