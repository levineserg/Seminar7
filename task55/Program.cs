// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

void FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void FillNewArray(int[,] newMatrix, int[,] matrix, int n, int m)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            newMatrix[i, j] = matrix[j, i];
            Console.Write(newMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArrayWithRandom(matrix, m, n);
Console.WriteLine();
int[,] newMatrix = new int[n, m];
FillNewArray(newMatrix, matrix, n, m);
