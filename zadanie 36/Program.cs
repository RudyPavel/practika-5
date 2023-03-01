int[] GenerateArray(int length)
{
    if(length < 1)
    {
        return new int[0];
    }        

    int[] a = new int[length];

    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        a[i] = rnd.Next(-100, 100);
    }

    return a;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        Console.Write(' ');
    }

    Console.WriteLine();
}

int PrintOddNumSum(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 == 1)
        {
            sum += arr[i];
        }
    }

    return sum;
}

Console.WriteLine("введите длину массива...");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = GenerateArray(length);
PrintArray(arr);
Console.WriteLine(PrintOddNumSum(arr));