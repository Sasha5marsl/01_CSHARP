// Дано 5 гирь с разным весом в случайном порядке. 
// Найти вес самой тяжелой гири.

int a = 6;
int b = 7;
int c = 10;
int d = 4;
int e = 9;

// SHIFT+ALT+F - ФОРМАТИРОВАНИЕ ДОКУМЕНТА

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}
System.Console.WriteLine(max);