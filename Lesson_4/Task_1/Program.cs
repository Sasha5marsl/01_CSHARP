// Задача 1. 
// Создать двумерный массив с размерами
// 3 x 5, состоящий из целых чисел
// • Вывести его элементы на экран

// СОЗДАДИМ ДВУМЕРНЫЙ МАССИВ

int[,] matrix = new int [3,5];

// СОЗДАДИМ ЦИКЛ ДЛЯ ПРОХОДА ПО СТРОКАМ ДУМЕРНОГО МАССИВА 

Random rnd = new Random(); // Для заполнения массива случ. числами
for (int i = 0; i < matrix.GetLength(0); i++) // GetLength - обращаемся к этому св-ву для указания длины массива. 
// При этом, если мы указываем нолевое измерение (0) - значит обращаемся к кол-ву строк в дв.мас. - т.е. к кол-ву строк.
// Если указываем (1) - то обращаемся к кол-ву столбцов.
{
    for (int j = 0; j < matrix.GetLength(1); j++) // создаем внутри второй цикл для прохода по всем элементам двумерного массива 
    {
        matrix[i, j] = rnd.Next(1,11);
    }
}

// СОЗДАДИМ ЦИКЛ ДЛЯ ВЫВОДА МАССИВА НА ЭКРАН

for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine(); // Добавляем перенос на новую строку, чтобы создалась таблица 
}


// РЕШИМ ЗАДАЧУ ПРИ ПОМОЩИ ФУНКЦИЙ

// ФУНКЦИЯ СОЗДАНИЯ И ЗАПОЛНЕНИЯ ДВУМЕРНОГО МАССИВА СЛУЧ. ЧИСЛАМИ

int[,] CreateMatrix (int rowCount, int columsCount)
{
    int[,] matrix = new int [rowCount, columsCount];
    
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1,11);
        }
    }
    return matrix;
}

// ФУНКЦИЯ ВЫВОДА МАССИВА НА ЭКРАН

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
}
}

// ОБРАТИМСЯ К ФУНКЦИЯМ, СОЗДАВ ПЕРЕМЕННУЮ 
int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);