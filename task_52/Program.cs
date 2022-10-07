/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void ColumnAverage(int[,] myArray)
{
    int rows = myArray.GetLength(0);
    int column = myArray.GetLength(1);
    Console.Write("Среднее арифметическое каждого столбца: ");
    double[] average = new double[column];
    double sum = 0;
    for(int j = 0; j < myArray.GetLength(1); j++)
    {
        for  (int i = 0; i < myArray.GetLength(0); i++)
        {
            sum += myArray[i, j];
        }
        average[j] = sum / rows;
        sum = 0;
    }
for ( int i1 = 0; i1 < average.Length; i1++)
{
    Console.Write($"{Math.Round(average[i1], 2)} ");
}
}
int rowsNumbers = new Random().Next(2, 4);
int columnNumbers = new Random().Next(3, 7);
int[,] array = FillAndPrintTwoDimArray(rowsNumbers, columnNumbers);
ColumnAverage(array);