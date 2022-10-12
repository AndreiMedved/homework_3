// Task_02 Подсчитать сумму цифр в числе

int a = new Random().Next(100, 1000);
String number = Convert.ToString(a);
char n1 = number[0];
char n2 = number[1];
char n3 = number[2];
int num0 = n1 - '0';
int num1 = n2 - '0';
int num2 = n3 - '0';

Console.WriteLine(num0 + " " + num1 + " " + num2);
Console.WriteLine(num0 + num1 + num2);




