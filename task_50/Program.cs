/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] FillAndPrintTwoDimArray(int rowsNumbers, int columnNumbers)
{
    int[,] myArray = new int[rowsNumbers, columnNumbers];
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = new Random().Next(1, 10);
            Console.Write($"{myArray[i, j]}  ");
        }
        Console.WriteLine();
    }
    return myArray;
}

int NumberSearch(int[,] myArray, int firstNumber, int secondNumber)
{
    int number = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            if (firstNumber - 1 == i && secondNumber - 1 == j)
                number = myArray[i, j];
        }
    }
    return number;
}
int rowsNumbers = new Random().Next(3, 5);
int columnNumbers = new Random().Next(3, 5);
int[,] array = FillAndPrintTwoDimArray(rowsNumbers, columnNumbers);
Console.Write("Введите строку числа: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец числа: ");
int x = Convert.ToInt32(Console.ReadLine());
int result = NumberSearch(array, y, x);
if (result == 0)
{
    Console.WriteLine("Числа с заданными параметрами не найдено");
}
else
{
    Console.WriteLine($"Это число {result}");
}