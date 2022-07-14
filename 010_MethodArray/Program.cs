// See https://aka.ms/new-console-template for more information

Console.Clear();
Console.WriteLine("Hello, World!");
int[] array = { 1, 12, 34, 57, 21, 11, 9, 42, 12 };

int n = array.Length;
int find = 12;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}