
int arrLenght = 8;
int[] arr = Auto(arrLenght);
System.Console.WriteLine(string.Join(" | ", arr));


int[] Auto(int len)
{
int[] arr = new int[len];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rand.Next(0, 100);
}
return arr;
}


