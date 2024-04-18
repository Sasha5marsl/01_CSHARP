// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] RandomMass(int m)
{
    int[] Number = new int[m];
    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = new Random().Next(1,10);
    }
    return Number;
}

void PrintMas(int[] col)
{
    foreach (var item in col)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

void PrintMass(int[] coon, int i = 0)
{
    if (i == coon.Length) return;
    PrintMass(coon, i + 1);
    System.Console.Write($"{coon[i]} ");
}

System.Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = RandomMass(n);
PrintMas(mas);
System.Console.WriteLine();
PrintMass(mas);