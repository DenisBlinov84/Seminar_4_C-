// Выводит массив из 8 элементов, заполненый нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] array = new int[8];
for (int i=0; i<8; i++)
{
    array[i]=new Random().Next(2);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
