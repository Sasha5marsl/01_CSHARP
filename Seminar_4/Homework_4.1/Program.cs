// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] RandomMass(int m)
{
    int[] Number = new int[m];
    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = new Random().Next(100,1000);
    }
    return Number;
}

void PrintMass(int[] coon)
{
    foreach (var item in coon)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

int Count(int[] col)
{
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if(col[i] % 2 == 0)
        {
            System.Console.WriteLine();
            System.Console.Write($"Подходящие числа: {col[i]} ");
            count++;
        }
    }
    return count;
}

System.Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = RandomMass(n);
PrintMass(arr);
int count = Count(arr);
System.Console.WriteLine();
System.Console.WriteLine($"Количество равно {count}");