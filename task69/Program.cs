int Exp(int A, int B)
{
    int exp = 1;
    if (B == 0)
    {
        return exp;
    }
    return exp = A * Exp(A, B - 1);
}
Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int B = Convert.ToInt32(Console.ReadLine());
int exp = Exp(A, B);
Console.WriteLine(exp);
