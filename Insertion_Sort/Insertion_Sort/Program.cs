// See https://aka.ms/new-console-template for more information
int[] arr = new int[5] { 2, 5, 1, 4, 7 };
for (int i = 1; i < arr.Length; i++)
{
   
   int temp = arr[i];
    int index = i - 1;
    while (index>=0)
    {
        if (arr[index] > temp)
        {
            arr[index + 1] = arr[index];
            index--;
        }
        else
        {
            break;
        }
    }
    arr[index + 1] = temp;
}
foreach (int i in arr)
{ Console.WriteLine(i); }