﻿// Вычислить факториал от натурального числа N

int Fact(int n)
{
    if (n == 1 || n == 0) // параметр или ||
    {
        System.Console.WriteLine($"Stop: {n}");
        return 1;
    }
    System.Console.WriteLine(n);
    return n * Fact(n - 1);
}

System.Console.WriteLine(Fact(5));

// F11 - шаг с заходом. Если на пути отладчика встречается функция, 
// то отладчик зайдет в тело функции и начнет её выполнять
// F11 - шаг с обходом. Действие обратное первому. 
// Заходить в тело функции не будет, а просто перейдет к след. строке кода  
// F5 - команда продолжить (до следующей точки остановки)


// Нахождение факториала лучше выполнять при помощи цикла

int Fact2(int m)
{
    int res = 1;
    for (int i = 2; i <= m; i++)
    {
        res *= i;
    }
    return res;
}

System.Console.WriteLine(Fact2(5));