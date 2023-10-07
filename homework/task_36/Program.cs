// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}
void PrintArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }

}

int GetsumOddPositionElem(int[] arr)
{
    int sumOddPosition = 0;
    int i = 0;
    while (i < arr.Length)
    {
        sumOddPosition += arr[i];
        i = i + 2;
    }

    return sumOddPosition;
}

int[] array = CreateArrayRndInt(4, 3, 23);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");


int sumOddPositionElem = GetsumOddPositionElem(array);

Console.WriteLine($"Сумма  элементов стоящих на нечетных позициях => {sumOddPositionElem}");
