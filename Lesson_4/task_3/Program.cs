﻿string GetLettersCreateString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLettersCreateString(str);
System.Console.WriteLine(result);
