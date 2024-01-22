// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// Метод ввода данных
string[] ReadData(string msg)
{
    System.Console.WriteLine(msg);
    string[] = Console.ReadLine().Split(',');
    return array;
}

// Метод вывода результата
void PrintRezult(string[] array)
{
    if (array.Length == 0) {
        System.Console.WriteLine("[]");
        break;
    }
    
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

int m = ReadData("Введите число M : ");
int n = ReadData("Введите число N : ");

PrintRezult(array2);