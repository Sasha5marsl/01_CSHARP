// Задача 3: Напишите программу, 
// которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

 int num = new Random().Next(10,100);
System.Console.WriteLine(num);

int first = num % 10;
int second = num / 10;
System.Console.WriteLine($"{first} и {second}");

int max = first;

if (first > second)
{
    max = first;
}
else
{
    max = second;
}
System.Console.WriteLine(max);
