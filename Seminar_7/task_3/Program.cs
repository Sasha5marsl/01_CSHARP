// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.

// через строку

void Consonants(string s)
{
    if (s.Length == 0) return;
    string st = "aoyuei";
    if(st.Contains(s[0]) == false) Console.Write($"{s[0]}");
    // обращаемся через метод Contains к нулевому элементу строки
    Consonants(s[1..]); 
    // синтаксический сахар для строк: 
    // s[1..] - указываем в аргументе, чтобы функция взяла все символы от 1 и до конца
    // если так s[1..5], то до верхней границы не включительно
}

// через int

void Consonants2(string s, int i = 0)
{
    string st = "aoyuei";
    if(i == s.Length) return;
    if (st.Contains(s[i]) == false) Console.Write($"{s[i]}");
    Consonants2(s, i + 1);
}

string st = Console.ReadLine()!;
Consonants(st);
System.Console.WriteLine();
Consonants2(st);
System.Console.WriteLine();


// данную запись можно сократить при помощи восклицательного знака (!)
// (st.Contains(s[i]) == false) равно  (!st.Contains(s[i])

// Например
System.Console.WriteLine(false); // так и выведет false
System.Console.WriteLine(!false); // а так выведет true

// т.е. знак ! меняет "false" на "true", а "true" на "false"

// обращение к элементам массива через указание диапазона в квадратных скобках
string st = "qwersdgdgdgdgdgdgdg";
Console.WriteLine(st[2..5]);
string[] mas = new string[]{"1","2", "3"};
string[] mas2 = mas[2..];
Console.WriteLine(mas2[0]);