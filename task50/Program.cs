//task50 Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет. Например, задан массив:1 4 7 2, 5 9 2 3,8 4 2 4 
//(1   7 -> такой позиции в массиве нет)

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);// [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleasMatrix(int[, ] matrix, int x, int y)
{
    if (x >= matrix.GetLength(0) || y >= matrix.GetLength(1) || x < 0 || y < 0)
        Console.WriteLine("К сожалению, вы ощиблись в координатах");
    else
        Console.WriteLine(matrix[x, y] );   
}         

Console.Clear();
Console.Write("Введите размер матрицы: "); 
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.Write("Введите позицию элемента: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
ReleasMatrix(matrix, coord[0] - 1, coord[1] - 1);
//Selekt... ToArray- перевод строки массива в число и создание нового массива чисел
//чтобы не переводить из строки в число, т.е. без использования Int.Parse

