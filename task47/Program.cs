// task47 Задайте двумерный массив размером m x n, заполненный случайными вещественными
// числами. m=3, n=4. (0,5 7 -2 -0,2), (1 -3,3 8 -9,9), (8 7,8 -7,1 9)


void InputMatrix(double[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] coord = Console.ReadLine().Split(" ");
int row = int.Parse(coord[0]);
int column = int.Parse(coord[1]);
double[,] matrix = new double[row, column];
InputMatrix(matrix);