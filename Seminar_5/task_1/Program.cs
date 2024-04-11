// Задача 1. Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// ФУНКЦИЯ ЗАПОЛНЕНИЯ ДВУМЕРНОГО МАССИВА

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

// ФУНКЦИЯ ВЫВОДА МАССИВА НА КОНСОЛЬ

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

// ФУКНКЦИЯ ВОЗВЕДЕНИЯ В КВАДРАТ

int[,] Sq(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                col[i, j] = col[i, j] * col[i, j];
            }
        }
    }
    return col;
}

// непосредственное выполнение программы  и обращение к функциям 

System.Console.WriteLine("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
int[,] arrRandom = RandomMas(arr);
PrintMas(arrRandom);
System.Console.WriteLine();
PrintMas(Sq(arrRandom));

int[,] arr_new = {{2,3,4,5},{2,6,5,6},{5,8,9,7}};
System.Console.WriteLine();
PrintMas(Sq(arr_new));

