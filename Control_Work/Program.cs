﻿Console.Clear();
Console.WriteLine("Пожалуйста, введите размер вашего массива (число от 3 до 9");
int lenghtArray = int.Parse(Console.ReadLine());


string[] Array(int lengthArray)
{
    string[] array = new string[lengthArray];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите ваше слово (число): ");
        array[i] = Console.ReadLine();
    }
    return array;
}
