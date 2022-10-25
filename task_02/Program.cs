//Task_02 Подсчитать сумму цифр в числе


int a = new Random().Next(100, 1000);
int SumOfNumbers(int number)
{
    String num = Convert.ToString(number);
    int length = num.Length;
    char[] numbers = new char[length];
    int index = 0;
    int sum = 0;
    while(index < length)
    {
        numbers[index] = num[index];
        sum = sum + (numbers[index] - '0');
        index++;
    }
    return sum;
}

Console.WriteLine(a);
Console.WriteLine(SumOfNumbers(a));

/* 
int a=  123;
String num = Convert.ToString(a);
int length = num.Length;
Console.WriteLine(a + " " + length);
Console.WriteLine(num[0] + " " + num[1] + " " + num[2]);
*/



