// Задайте одномерный массив, заполненный случайными числами. 
// Определите количество простых чисел в этом массиве.

// ЗАПОЛНЯЕМ МАССИВ

int[] RandomMass(int m)
{
    int[] Number = new int[m];
    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = new Random().Next(1,100);
    }
    return Number;
}

// ПИШЕМ ФУНКЦИЮ ВЫВОДА ЭЛЕМЕНТОВ МАССИВА НА ЭКРАН 

void PrintMass(int[] coon)
{
    foreach (var item in coon)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

// ФУНКЦИЯ ОТБОРА ПРОСТЫХ ЧИСЕЛ - ЭТО ТЕ, ЧТО ДЕЛЯТСЯ ТОЛЬКО НА СЕБЯ И НА 1

bool prost(int num) 
// тип данных логический, где при соблюдении условий функция вернет ложь или истина
{
    for (int i = 2; i < num; i++)
    {
        if(num % i == 0) return false; 
        // если число делится на 2 без остатка, значит нам оно не подходит
    }
    System.Console.WriteLine(num);
    return true;
}

// ПИШЕМ ФУНКЦИЮ ДЛЯ ПЕРЕБОРА ЭЛЕМЕНТОВ, ИЗ ФУНКЦИИ ВЫШЕ, 
// КОТОРАЯ БУДЕТ ОТБИРАВТЬ ПРОСТЫЕ ЧИСЛА И ЗАВОДИТЬ В ЭТУ ФУНКЦИЮ, А ЭТА ФУНКЦИЯ БУДЕТ ИХ ПРОСТО СЧИТАТЬ

int Count(int[] col)
{
    int count = 0; // переменная счетчик подсчета искомых чисел 
    foreach (var i in col)
    {
        if(prost(i)) count++; // СОКРАЩЕННОЕ НАПИСАНИЕ УСЛОВИЯ 
        // в условии обращаемся к функции выше, которая поставляет нам искомые простые числа
    }
    return count;
}

// ПРОСИМ ПОЛЬЗОВАТЕЛЯ ВВЕСТИ РАЗМЕРНОСТЬ МАССИВА

System.Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

// РЕЗУЛЯТИВНОЕ ОБРАЩЕНИЕ К ФУНКЦИЯМ 

int[] mas = RandomMass(n);
PrintMass(mas);
System.Console.WriteLine($"Количество простых чисел в массиве равно: {Count(mas)} ");

