// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

string Sort(int M, int N)
{
    if (M == N) return Convert.ToString(N); 
    return M + " " + Sort(M + 1, N);
}

System.Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine(Sort(M, N));