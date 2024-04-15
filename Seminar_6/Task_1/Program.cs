// Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// ПИШЕМ ФУНКЦИЮ ПО ЗАМЕНЕ ЭЛЕМЕНТОВ МАССИВА НА ТИП STRING

string CharsOgString(char[] arr)
{
    string st = "";
    foreach (var i in arr)
    {
        st += i; // сокращение от st = st + i
    }
    return st;
}

// ВТОРОЙ ВАРИАНТ ПРОХОДА ПО ЭЛЕМЕНТАМ МАССИВА ТИПА CHAR


string CharsOgString2(char[] arr)
{
    string st = "";
    for (int i = 0; i < arr.Length; i++)
    {
        st += arr[i];
    }
    return st;
}



// ЗАДАЕМ МАССИВ ТИПА CHAR

char[] chars = new char[] {'a', 'b', 'c', 'd'};
// string CharsOgString(chars); // функцию можно вызвать так
System.Console.WriteLine(CharsOgString(chars)); // или вот так
System.Console.WriteLine(CharsOgString2(chars));
