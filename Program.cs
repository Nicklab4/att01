// Метод ввода данных
string[] ReadData(string msg)
{
    System.Console.WriteLine(msg);
    string[] = Console.ReadLine().Split(',');
    return array;
}

// Метод вывода результата
void PrintRezult(string msg)
{
    System.Console.WriteLine(msg);
}


//////////////////////////////////////////////////////////////
/// Тело программы
//////////////////////////////////////////////////////////////

int m = ReadData("Введите число M : ");
int n = ReadData("Введите число N : ");

PrintRezult("M = " + m + ", N = " + n + ", -> " + SumNumRec(m, n));