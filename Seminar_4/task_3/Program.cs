// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. 
// Старший разряд числа находится на 0-м индексе, младший – на последнем.
// Пример: [1 3 2 4 2 3] => 132423
//         [2 3 1] => 231

System.Console.Write("Введите размерность массива не более 8: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[N];

int[] RandomMass(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(0,10);
    }
    return col;
}

void PrintMass(int[] coon)
{
    foreach (var item in coon)
    {
        System.Console.Write($"{item}, ");
    }
    System.Console.WriteLine();
}

int FindIndex(int[] col)
{
    int number = 0;
    for (int i = 0; i < col.Length; i++)
    {
        number = number * 10 + col[i];
    }
    return number;
}

// МОЖНО ЧЕРЕЗ СТРОКУ

// string FindIndex(int[] col)
// {
//     string number = "";
//     for (int i = 0; i < col.Length; i++)
//     {
//         number = number + Convert.ToString(col[i]);
//     }
//     return number;
// }


int[] arr_1 = RandomMass(arr);
PrintMass(arr_1);
int str = FindIndex(arr);
System.Console.WriteLine();
System.Console.WriteLine(str);
