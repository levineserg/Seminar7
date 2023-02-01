// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// void FillArrayWithRandom(int[,] matrix, int m, int n)
// {
// for(int i = 0; i < m; i++)
// {
// for(int j = 0; j < n; j++)
// {
// Console.Write($"Введите {i} {j} элемент ");
// matrix[i,j] = Convert.ToInt32(Console.ReadLine());

// }

// }
// }
// void PrintArrayWithRandom(int[,] matrix, int m, int n)
// {
// for(int i = 0; i < m; i++)
// {
// for(int j = 0; j < n; j++)
// {
// Console.Write(matrix[i,j] + " ");
// }
// Console.WriteLine();
// }
// }
// Console.WriteLine("Введите число m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n:");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m,n];
// FillArrayWithRandom(matrix, m, n);
// PrintArrayWithRandom(matrix, m, n);

void FillArrayWithRandom(int[,] matrix, int m, int n)
{
for(int i = 0; i < m; i++)
{
for(int j = 0; j < n; j++)
{
matrix[i,j] = new Random().Next(-10, 11);
Console.Write(matrix[i,j] + " ");
}
Console.WriteLine();
}
}
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];
FillArrayWithRandom(matrix, m, n);