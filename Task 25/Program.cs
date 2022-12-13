int A = inputNumber();
int B = inputNumber();
int Pow = func(A,B);
System.Console.WriteLine(Pow);


int func(int number1, int number2)
{
int res = 1;
if (number2 >= 0)
{
    for (int i = 1; i <= number2; i++)
    {
        res = res * number1;
    }
}
else 
{
    number2 *= -1;
    for (int i = 1; i <= number2; i++)
    {
        res = res * number1;
    }
}
return res;
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


