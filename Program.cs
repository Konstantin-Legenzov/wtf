﻿/* Написать программу, которая из имебщегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первонаальный массив можно ввести с клавиатуры, либо задать 
на старте выполнение алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами.
Пример: ["hello", "2", "world", ":-)" -> ["2", ":-)"]   */



string[] array1 = { "hello", "2", "world", ":-)" };

int FindLengthArray(string[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            result = result + 1;
        }
    }
    return result;
}

string[] array2 = new string[FindLengthArray(array1)];

void FindWords(string[] arr, string[] arr2)
{
    for (int j = 0, i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            arr2[j] = arr[i];
            j = j + 1;
        }
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($" {arr[i]}");
    }
}


