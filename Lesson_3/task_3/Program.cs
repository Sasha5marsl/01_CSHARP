// В задаче необходимо заменить четные числа массива на нули, т.е. обнулить четные числа 

void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

// Напишем функцию для вывода полученных значений из первой функции

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        System.Console.Write($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5 };
// задаем новый массив для передачи значений в функции
// вызываем функции 
ZeroEvenElements(array);
PrintArray(array);
