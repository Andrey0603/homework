// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}
void PrintArrayDouble(double[] arr)
{
    //Console.WriteLine("[");
    for (int i = 0; i < arr.Length; i++)
    {
        //double nRound = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    //Console.WriteLine("]");
}

double[] GetSumMaxMinElem(double[] arr)
{
    double sumMaxNumber = 0;
    double sumMinNumber = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumMaxNumber += arr[i];
        else sumMinNumber += arr[i];
    }

    return new double[] { sumMaxNumber, sumMinNumber };
}

double GetSumMaxElem(double[] arr)
{
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }

    return sum;
}

double GetSumMinElem(double[] arr)
{
   double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }

    return sum;
}

double[] array = CreateArrayRndDouble(5, -88, 77);
Console.Write("[");
// PrintArray(array);
Console.WriteLine("]");

double[] sumMaxMinElem = GetSumMaxMinElem(array);

// Console.WriteLine($"Сумма максимальных элементов => {sumMaxMinElem[0]}");
// Console.WriteLine($"Сумма минимальных элементов => {sumMaxMinElem[1]}");

double sumMaxNumber = GetSumMaxElem(array);
double sumMinNumber = GetSumMinElem(array);

Console.WriteLine($"Сумма максимальных элементов => {sumMaxNumber}");
Console.WriteLine($"Сумма минимальных элементов => {sumMinNumber}");
Console.WriteLine($"Сумма разницы между суммой максимальных и минимальных => {sumMaxNumber-sumMinNumber }");



// Создал разницу между суммами, между максимальным и минимальным числами пока не сходится