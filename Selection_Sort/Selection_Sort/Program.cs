// See https://aka.ms/new-console-template for more information
int[] arr = new int[5] { 4, 7, 2, 1, 8 };
int min = arr[0];
for (int i = 0; i < arr.Length-1; i++)
{
    int LowNumberIndex = i;
    for (int j = i+1; j < arr.Length; j++)
    {
        if (arr[j] < arr[LowNumberIndex])
        {
            LowNumberIndex = j;
        }
    }
    if(LowNumberIndex!=i)
    {
        int temp = arr[i];
        arr[i] = arr[LowNumberIndex];
        arr[LowNumberIndex] = temp;
    }
}
foreach (var value in arr)
{
    Console.WriteLine(value);
}
