// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void PrintNumber(int number)
{
    if(number == 0)
    {
        return;
    }
    PrintNumber(number-1);
    Console.Write(number + " ");
}
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintNumber(N);