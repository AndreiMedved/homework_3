// Task_3 Написать программу вычисления произведения чисел от 1 до N

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    while(index < count)
    {
        Console.Write(collection[index] + " ");
        index++;
    }
    Console.WriteLine();
}

int ProdReturn(int[] numbers)
{
    int index = 0;
    int length = numbers.Length;
    int prod = 1;
    while(index < length)
    {
        prod = prod * numbers[index];
        index++;
    }
    return prod;
}

int[] numbers = new int[4];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine(ProdReturn(numbers));

