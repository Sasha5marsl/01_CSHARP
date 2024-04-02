// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример: [1 5 11 21 81 4 0 91 2 3]  => 2


System.Console.Write("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[N];

int[] RandomMass(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1,100);
    }
    return col;
}

// ПИШЕМ ФУНКЦИЮ, КОТОРАЯ ВЕДЕТ ПОДСЧЕТ ЧИСЕЛ, 
// ОДНОВРЕМЕННО ЗАКАНЧИВАЮЩИХСЯ НА 1 И КРАТНЫ 7 

int Count(int[] col)
{
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if(col[i] % 10 == 1 && col[i] % 7 == 0) 
        // деление на 10 по модулю показывает нам последнюю цифру числа и выводит остаток от деления
        {
            System.Console.WriteLine();
            System.Console.Write($"Подходящие числа: {col[i]} ");
            count++;
        }
    }
    return count;
}

void PrintMass(int[] coon)
{
    foreach (var item in coon)
    {
        System.Console.Write($"{item}, ");
    }
    System.Console.WriteLine();
}

int[] mas = RandomMass(arr);
PrintMass(mas);
int count = Count(mas);
System.Console.WriteLine();
System.Console.WriteLine($"Количество равно {count}");