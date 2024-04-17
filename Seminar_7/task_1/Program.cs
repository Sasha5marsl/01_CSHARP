// Задача 1. Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.

int SumNum(int num)
{
    if(num == 0) return 0;
    int res = num % 10 + SumNum(num / 10);
    return res;
}

System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(SumNum(n));

// n = 123 % 10
// 123 % 10 -> 3
// 123 / 10 -> 12
// m = 12 % 10
// 12 / 10 -> 1
