// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24
// 5->120

int SumNum(int num)
{
    int all_sum = 1;
    for (int i = 1; i <= num; i++)
    {
        all_sum *= i;
    }
    return all_sum;
}

Console.WriteLine(SumNum(4));
Console.WriteLine(SumNum(5));
