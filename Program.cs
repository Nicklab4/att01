﻿// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// Метод ввода данных
// На вход подаётся строка, она разбивается и выводится массив срок 
string[] ReadData(string msg)
{
    System.Console.WriteLine(msg);
    string[] array = Console.ReadLine().Split(',');
    return array;
}

// Метод обработки данных
string[] SortString(string[] array, int numChar)
{
    int count = 0;
    // Подсчёт количества элементов соответствующих условию
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numChar)
            count++;
    }
    
    // Создание и заполнение нового массива соответствующего условию
    string[] array2 = new string[count];

    // После создания массива, count обнуляется для повторного использования
    count = 0;

    // Заполнение нового массива в соответствии с условием
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numChar){
            array2[count] = array[i];
            count++;
        }
    }

    return array2;
}

// Метод вывода результата
// На вход подаётся массив строк, который выводится на консоль в форматированном виде
void PrintRezult(string[] array)
{

    // Если массив пустой выводится пустое значение и прерывается выполнение метода
    if (array.Length == 0) {
        System.Console.WriteLine("[]");
        return;
    }
    
    // Формирование форматированного вывода
    System.Console.Write("[\"");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write("\", \"");
    }
    System.Console.Write("\"]");
}


//////////////////////////////////////////////////////////////
/// Тело программы
//////////////////////////////////////////////////////////////

string[] array = ReadData("Введите массив строк через запятую: ");

PrintRezult(SortString(array, 3));