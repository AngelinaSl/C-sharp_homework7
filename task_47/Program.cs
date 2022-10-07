/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void FillAndPrintTwoDimArray(int rowsNumbers, int columnNumbers)
{
    double [,] myArray = new double [rowsNumbers, columnNumbers];
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for ( int j = 0; j < myArray.GetLength(1); j++)
    {
        myArray [i,j] = new Random().Next(-10, 10) + new Random().NextDouble ();
        Console.Write($"{Math.Round (myArray[i,j], 1)}  ");

    }
    Console.WriteLine();
}
}
int rowsNumbers = new Random().Next(3,5);
int columnNumbers = new Random().Next(3,5);
FillAndPrintTwoDimArray (rowsNumbers, columnNumbers);