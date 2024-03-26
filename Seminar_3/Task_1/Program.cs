// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве. 
// Программа должна выдать ответ: Да/Нет.

using System.Globalization;

System.Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int [n];

// System.Console.WriteLine(mas);

// ПЕРЕБОР ЭЛЕМЕНТОВ МАССИВА

// через while
int ind = 0;
while (ind < mas.Length)
{
    System.Console.Write($"{mas[ind]} ");
    ind++;
}
System.Console.WriteLine();

// через for
for (int i = 0; i < mas.Length; i++)
{
    System.Console.Write($"{mas[i]} ");
}
System.Console.WriteLine();

// через foreach
foreach (int item in mas)
{
    System.Console.Write($"{item} ");
}
System.Console.WriteLine();

// Через функцию
void PrintMas(int[] col)
{
    foreach (int item in col)
{
    System.Console.Write($"{item} ");
}
System.Console.WriteLine();
}

PrintMas(mas);

// ЗАПОЛНЯЕМ МАССИВ ЧЕРЕЗ ФУЕКЦИЮ РАНДОМ

int[] RandomMas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1,9);
    }
    
    return col;
}

int[] new_mas = RandomMas(mas); // обращение к функции рандом для заполнения массива
PrintMas(new_mas); // вывод элементов массива на экран через функцию принт 

// ЗАДАЕМ ЧИСЛО И ИЩЕМ ЕГО В МАССИВЕ 

System.Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

// первый способ поиска

int flag = 0; // переменная флажок для пометки найденного числа
foreach (var item in new_mas)
{
    if (item == m) // проходя по массиву, как только foreach встретит заданное число
    // мы увеличим flag на +1
    {
        flag++;
    }
}

if (flag > 0) // соответственно, если flag больше нуля, то мы нашли наше число!
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}

// ЗАДАЕМ ЧИСЛО И ИЩЕМ ЕГО В МАССИВЕ - второй способ поиска

string S (int[] col, int m)
{
    foreach (var item in col)
    {
        if (item == m) return "Да";
    }
    return "Нет";
}
System.Console.WriteLine(S(new_mas, m));