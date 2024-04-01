// Переформатируем код, написанный при помощи циклов в код, 
// написанный при помощи функций 

// СОЗДАНИЕ МАССИВА
int n = 10;
int [] arr = new int [n];

// ЗАПОЛНЕНИЕ МАССИВА

int i = 0;
while (i < n)
{
    arr[i] = i + 1;
    i++;
}

// ВЫВОД ЭЛЕМЕНТОВ МАССИВА НА ЭКРАН

i = 0;
while (i < n)
{
    System.Console.Write($"{arr[i]} ");
    i++;
}


// СУММИРОВАНИЕ ВСЕХ ЭЛЕМЕНТОВ МАССИВА

i = 0;
int sum = 0;
while (i < n)
{
    sum = sum + arr[i];
    i++;
}

// ПРОИЗВЕДЕНИЕ ВСЕХ ЭЛЕМЕНТОВ МАССИВА

i = 0;
int product = 1;
while (i < n)
{
    product = product * arr[i];
    i++;
}

// ВЫВОД РЕЗУЛЬТАТОВ НА ЭКРАН

System.Console.WriteLine();
System.Console.Write($"Сумма: {sum} ");
System.Console.WriteLine();
System.Console.Write($"Произведение: {product} ");

// ПРЕОБРАЗУЕМ В ФУНКЦИИ

// Создание массива оставим без изменений

int g = 10;
int [] array = new int [g];

// Пишем функции по заполнению массива и выводу элементов на экран

void PrintArr(int[] col)
{
    foreach (int item in col)
{
    System.Console.Write($"{item} ");
}
System.Console.WriteLine();
}

PrintArr(array);


// ЗАПОЛНЯЕМ МАССИВ ЧЕРЕЗ ФУНКЦИЮ РАНДОМ

int[] RandomArr(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1,11);
    }
    
    return col;
}

int[] new_arr = RandomArr(array); // обращение к функции рандом для заполнения массива
PrintArr(new_arr); // вывод элементов массива на экран через функцию принт

// ПИШЕМ ФУНКЦИЮ СУММИРОВАНИЯ ЭЛЕМЕНТОВ

int GetSumOfElements(int[] array)
{
    int sum = 0;
    foreach (int e in array)
    {
        sum += e;
    }
    return sum;
}

int sum_1 = GetSumOfElements(array);
System.Console.WriteLine(sum_1);

// ПИШЕМ ФУНКЦИЮ ПРОИЗВЕДЕНИЯ ЭЛЕМЕНТОВ

int GetProductOfElements(int[] array)
{
    int product = 1;
    foreach (int m in array)
    {
        product *= m;
    }
    return product;
}

int product_1 = GetProductOfElements(array);
System.Console.WriteLine(product_1);






