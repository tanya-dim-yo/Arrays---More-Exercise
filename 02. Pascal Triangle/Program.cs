int n = int.Parse(Console.ReadLine());
ulong[] previousArray = new ulong[n];

for (int i = 1; i <= n; i++)
{
    ulong[] array = new ulong[i];
    array[0] = 1;
    array[array.Length - 1] = 1;

    if (array.Length > 2)
    {
        for (int j = 1; j <= array.Length - 2; j++)
        {
            array[j] = previousArray[j - 1] + previousArray[j];
        }
    }

    previousArray = array;
    Console.WriteLine(string.Join(" ", array));
}