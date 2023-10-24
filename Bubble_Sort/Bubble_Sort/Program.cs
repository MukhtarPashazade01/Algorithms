// See https://aka.ms/new-console-template for more information
int[] arr = new int[5] { 5, 3, 2, 7, 1 };
int bigValue = 0;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] < arr[j])
        {
            bigValue = arr[j];
            arr[j] = arr[i];
            arr[i] = bigValue;

           
        }
    }
}
foreach (int i in arr)
{
    Console.WriteLine(i);
}
