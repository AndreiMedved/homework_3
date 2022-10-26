// Task_01 Найти кубы чисел от 1 до N

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

int[] numbers = new int[new Random().Next(1, 10)];
int i = 0;

FillArray(numbers);
PrintArray(numbers);

while (i < numbers.Length)
{
    Console.Write((Math.Pow(numbers[i], 3)) + " ");
    i++;
}