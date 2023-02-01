// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
void ChengeRows(int[,] matrix, int m, int n)
{
    int temp = 0;
    for (int j = 0; j < n; j++)
    {
        temp = matrix[0, j];
        matrix[0, j] = matrix[m - 1, j];
        matrix[m - 1, j] = temp;
    }
}
void PrintArray(int[,] matrix, int m, int n)
{
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + "\t");
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
ChengeRows(matrix, m, n);
PrintArray(matrix, m, n);
