// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных (aouei).
// Пример:
// “hello” => 2
// “world” => 1

// ДАННЫЕ СТРОКИ НУЖНЫ ДЛЯ ОТОБРАЖЕНИЯ РУССКИХ СИМВОЛОВ В КОНСОЛИ 
using System;
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

// ПИШЕМ МЕТОД ПО ПОИСКУ КОЛИЧЕСТВА ГЛАССНЫХ В СТРОКЕ 
int FindVowels(string str)
{
    string vowels = "aoueiаоуиеяАЯЕОИ"; 
    // задаем строку, где указываем все гласные буквы
    int count = 0;
    // переменная счетчик
    for (int i = 0; i < str.Length; i++) 
    // цикл для перебора всех элементов внешней строки (той, что будет введена пользователем и подана в эту функцию)
    {
        for (int j = 0; j < vowels.Length; j++) 
        // цикл для перебора внутренней строки, указывающей на гласные буквы - для дальнейшего сравнения
        {
            if (str[i] == vowels[j]) 
            // пишем условие, при котором счетчик будет увеличиваться, 
            // если элемент внешней строки будет равен элементам внутренней. Т.е. должно быть совпадение с гласными.
            {
                count++;
                break;
            }
        }
    }
    return count;
}

System.Console.Write("Введите строку: ");
string n = Console.ReadLine()!;

System.Console.WriteLine(FindVowels(n));



string st = "HFHFJKDLH";
System.Console.WriteLine(st);