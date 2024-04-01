// Напишите функцию, которая вычисляет квадраты числе от 1 до N и выводит значения на экран.

// Если функция выполняет какое-то действие по типу - выводит на экран какое-то значение или текст,
// то тип данных у этой функции будет void, так как не имеет возвращаемого значения


// ФУНКЦИЯ НАПИСАНА ПРЕПОДАВАТЕЛЕМ
void PrintSquares(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}

PrintSquares(7);
System.Console.WriteLine();


// НАПИСАЛА ФУНКЦИЮ САМА
void SquareNumber(int n)
{
    int i = 1;
    while(i <= n)
    {
        System.Console.Write($"{i * i} ");
        i++;
    }
}

SquareNumber(5);