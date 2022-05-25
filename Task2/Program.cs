// Принимает на вход число и выдаёт количество цифр в числе.
// 456->3
// 78->2
// 89126->5

// void Sum(int num)
// {
//     int i=0;
//     while(num>0)
//     {
//         num=num/10;
//         i=i+1;
//     }
//     Console.WriteLine(i);
// }
// Sum(456);
// Sum(78);
// Sum(89126);

int NumCount(int num)
{
    string result = num.ToString(); // преобразуем число в строку
    return result.Length; // выводим количество элементов в строке
}
Console.WriteLine(NumCount(456));
Console.WriteLine(NumCount(78));
Console.WriteLine(NumCount(89126));
