int SumNumber(int number)
{
    if(number == 0)
    {
        return 0;
    }
    return number%10 + SumNumber(number/10);
}
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = SumNumber(N);
Console.WriteLine(sum);