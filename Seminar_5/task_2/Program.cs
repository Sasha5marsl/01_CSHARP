// Задача 2. Задайте двумерный массив. 
// Найдите сумму элементов, 
// находящихся на диагонали (с индексами (0,0); (1;1) и т.д.)


// РЕШЕНИЕ ОДНОГРУППНИКА

// ФУНКЦИЯ ПО ЗАПОЛНЕНИЮ ДВУМЕРНОГО МАССИВА
int[,] UpdateList(int[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            list[i, j] = new Random().Next(0, 10);
        }
    }
    return list;
}

// ФУНКЦИЯ ПО ВЫВОДУ МАССИВА
void PrintList(int[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            Console.Write($"{list[i, j]} ");
        }
        Console.WriteLine();
    }
}

// ФУНКЦИЯ ПО ПОИСКУ ЧЕТНЫХ ЭЛЕМЕНТОВ И ИХ СУММИРОВАНИЕ
int[,] SerchList(int[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                list[i, j] *= list[i, j];
            }
        }
    }
    return list;
}

// ФУНКЦИЯ ПО ПОИСКУ ЭЛЕМЕНТОВ С ОДИНАКОВЫМИ ИНДЕКСАМИ
int DiagList(int[,] list, int min)
{
    int res = 0;

    for (int i = 0; i < min; i++)
    {
        res += list[i, i];
    }

    return res;
}

// ПОИСК ЧТО МЕНЬШЕ СТРОКА ИЛИ СТОЛБЕЦ 
int SerchMin(int[,] list)
{
    if (list.GetLength(0) < list.GetLength(1))
    {
        return list.GetLength(0);
    }
    return list.GetLength(1);
}

Console.Write("Enter size...");
int firstSize = int.Parse(Console.ReadLine());

Console.Write("Enter size2...");
int secondSize = int.Parse(Console.ReadLine());

int[,] list2D = new int[firstSize, secondSize];
list2D = UpdateList(list2D);
PrintList(list2D);
int res = DiagList(list2D, SerchMin(list2D));

Console.WriteLine("sum = " + res);
