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
        a[i] = rnd.Next(1, 100);
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

int GetMax(int[] arr)
{
    int max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }

    return max;
}

int GetMin(int[] arr)
{
    int min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if(min > arr[i])
        {
            min = arr[i];
        }
    }

    return min;
}

Console.WriteLine("введите длину массива...");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = GenerateArray(length);
PrintArray(arr);
Console.WriteLine(GetMax(arr) - GetMin(arr));