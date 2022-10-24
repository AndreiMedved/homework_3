// Task_04 Показать кубы чисел, заканчивающихся на четную цифру
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

int ReturnCube(int number)
{
    int coube = number*number*number;
    return coube;
}

int [] example = new int[10];
int index = 0;

FillArray(example);
PrintArray(example);

while(index < example.Length)
{
    if(example[index]%2 == 0)
    {
        Console.Write(ReturnCube(example[index]) + " ");
    }
    index++;

}

