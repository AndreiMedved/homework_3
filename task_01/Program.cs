// Task_01 Найти кубы чисел от 1 до N

int a = new Random().Next(-10, 10);
int b = new Random().Next(-10, 10);
int c = new Random().Next(-10, 10);
int d = new Random().Next(-10, 10);
int e = new Random().Next(-10, 10);
int f = new Random().Next(-10, 10);
int g = new Random().Next(-10, 10);
int i = 0;
int[] numbers = {a, b, c, d, e, f, g};

while (i < numbers.Length)
{
    Console.Write(numbers[i] + " ");
    i++;
}

i = 0;
Console.WriteLine("");

while (i < numbers.Length)
{
    Console.WriteLine(Math.Pow(numbers[i], 3));
    i++;
}