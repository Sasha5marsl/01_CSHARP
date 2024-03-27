// Найдите произведения пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новый массив.
// Пример:
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)


// МОЁ РЕШЕНИЕ 

void PrintMas(int[] col)
{
    foreach (int item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

// ПИШЕМ ФУНКЦИЮ ДЛЯ ЗАПОЛНЕНИЯ МАССИВА В ЗАПРАШИВАЕМОМ ЧИСЛОВОМ ПРОМЕЖУТКЕ

int[] RandomMas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(0, 11);
    }

    return col;
}

// ЗАДАЕМ ПЕРЕМЕННУЮ, ОТВЕЧАЮЩАЯ ЗА РАЗМЕР МАССИВА, Т.Е. ЕГО ДЛИНУ

int n = Convert.ToInt32(Console.ReadLine());

// ОБРАЩАЕМСЯ К ФУНКЦИИ ЗАПОЛНЕНИЯ И ФУНКЦИИ ВЫВОДА МАССИВА НА ЭКРАН

int[] arr = RandomMas(new int[n]);
PrintMas(arr);

int index = 0;

while (index < arr.Length / 2)
{
    Console.Write(arr[index] * arr[arr.Length - index - 1] + " ");
    index++;
}