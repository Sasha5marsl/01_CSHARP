// Задайте одномерный массив, заполненный случайными числами. 
// Определите количество простых чисел в этом массиве.

int[] RandomMas(int m)
{
    int[] Number = new int[m];
    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = new Random().Next(1,100);
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

bool prost(int num)
{
    for (int i = 2; i < num; i++)
    {
        if(num % i == 0) return false;
    }
    System.Console.WriteLine(num);
    return true;
}


int Count(int[] col)
{
    int count = 0;
    foreach (var i in col)
    {
        if(prost(i)) count++;
    }
    return count;
}

System.Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = RandomMas(n);
PrintMass(mas);
System.Console.WriteLine($"Количество простых чисел в массиве равно: {Count(mas)} ");

