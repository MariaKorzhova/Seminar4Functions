// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int res = inputNumber();
System.Console.WriteLine(Sum(res));

int Sum(int number2)
{
string number1 = Convert.ToString(number2);
int len = number1.Length;
int Sum1 = 0;
for (int i = 0; i <= len-1; i++)
{
    Sum1 = Sum1 + (number2 % 10);
    number2 = number2 / 10;
}
return Sum1; 
}



int inputNumber()
{
int number;
string text;

while (true)
{
Console.Write("Введите число: ");
text = Console.ReadLine();
if (int.TryParse(text, out number))
{
break; 
}
Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
return number;
}


