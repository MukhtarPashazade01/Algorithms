// See https://aka.ms/new-console-template for more information
int[] arr = new int[5] { 5, 3, 2, 7, 1 };
int temp = 0;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length - i - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;


        }
    }
}
foreach (int i in arr)
{
    Console.WriteLine(i);
}
