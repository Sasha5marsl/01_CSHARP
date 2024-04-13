// Задайте двумерный массив из целых чисел. 
// Сформируйте новый одномерный массив, 
// состоящий из средних арифметических значений по строкам двумерного массива.

int[,] RandomMas(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            col[i, j] = new Random().Next(0, 10);
        }
    }
    return col;
}


void PrintMas(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            System.Console.Write($"{col[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

// ФУНКЦИЯ СУММИРОВАНИЯ ЭЛЕМЕНТОВ В КАЖДОЙ СТРОКЕ

int[] Sum(int[,] coll)
{
    int[] summa = new int[coll.GetLength(0)];
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            sum = sum + coll[i, j];
        }
        summa[i] = sum;
        // отправляем сумму каждой строки в одномерный массив, 
        // чтобы не терять значение суммы каждой строки на новой итерации
    }
    return summa;
}

void PrintMass(int[] coon)
{
    foreach (var item in coon)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

// ФУНКЦИЯ ПОИСКА СРЕДНЕГО АРИФМЕТИЧЕСКОГО В ОДНОМЕРНОМ МАССИВЕ, 
// т.е теперь мы делим полученные суммы каждой строки на размер массива, в которой суммы сохранены

double[] Middle (int[] a, int[,] b)
{
    double[] c = new double[b.GetLength(0)];
    for (int i = 0; i < a.Length; i++)
    {
        c[i] = Convert.ToDouble(a[i]) / Convert.ToDouble(b.GetLength(1)); 
        //необходимо добавить конвектор, поскольку на вход поступают целые числа, а нам нужно вернуть дробные
    }
    return c;
} 

// ФУНКЦИЯ ВЫВОДА ОДНОМЕРНОГО МАССИВА С ТИПОМ DOUBLE

void PrintMass2(double[] coon)
{
    foreach (var item in coon)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}



System.Console.WriteLine("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
int[,] arrRandom = RandomMas(arr);
PrintMas(arrRandom);

System.Console.WriteLine(arrRandom);

int[] arr2 = Sum(arrRandom);
PrintMass(arr2);

// сумму нашли, теперь нужно найти среднее арифметическое 
// в созданном одномерном массиве из суммы элементов двумерного массива в каждой его строке

double[] arr3 = Middle(arr2,arrRandom);
PrintMass2(arr3);

// Итак, сначала мы создали двумерный массив. Затем заполнили его и вывели на экран.
// Затем написали 2 функции для поиска среднего арифметического каждой строки: 
// первая находит сумму всех элементов строки, записывая все это в доп. однородный массив;
// вторая делит сумму на размер исходного двумерного массива (количество эл-тов в строке исходного двумерного массива, 
// на вход принимая одномерный массив со значениями суммы и исходный одномерный массив. 



