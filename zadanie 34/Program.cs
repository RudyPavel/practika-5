int[] GenerateArray(int length)
{
    int[] a = new int[length];

    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        a[i] = rnd.Next(100, 999);
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

bool IsEvenNum(int num)
{
    if (num % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int PrintEvenNumCount(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(IsEvenNum(arr[i]))
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine("введите длину массива...");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = GenerateArray(length);
PrintArray(arr);
Console.WriteLine(PrintEvenNumCount(arr));