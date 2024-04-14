


string[] Fill_Array()
{
    Console.WriteLine("Введите данные через пробел, по окончании ввода нажмите Enter: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] Array = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return Array;
}

string Print_Array(string[] Array)
{
    string stringArray = "[";
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == Array.Length - 1)
        {
            stringArray += $"{Array[i]}";
            break;
        }
        stringArray += ($"{Array[i]}, ");
    }
    stringArray += "]";
    return stringArray;
}

int Count_String_Symbols(string[] Array)
{
    int counter = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] New_Array(string[] Array)
{
    int resultArrayLength = Count_String_Symbols(Array);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}

﻿string[] Array = Fill_Array();
string[] resultArray = New_Array(Array);
string FirstArray = Print_Array(Array);
string SecondArray = Print_Array(resultArray);
Console.WriteLine(FirstArray);
Console.WriteLine(SecondArray);