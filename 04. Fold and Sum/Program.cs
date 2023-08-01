int[] initialSequence = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] firstRowLeft = new int[initialSequence.Length / 4];
int[] firstRowRight = new int[initialSequence.Length / 4];

for (int i = 0; i < firstRowLeft.Length; i++)
{
    firstRowLeft[i] = initialSequence[firstRowLeft.Length - 1 - i];
}

for (int i = 0; i < firstRowRight.Length; i++)
{
    firstRowRight[i] = initialSequence[initialSequence.Length - 1 - i];
}

int[] firstRow = firstRowLeft.Concat(firstRowRight).ToArray();
int[] secondRow = new int[initialSequence.Length / 2];

for (int i = 0; i < secondRow.Length; i++)
{
    secondRow[i] = initialSequence[firstRowLeft.Length + i];
}

int[] finalArray = new int[secondRow.Length];

for (int i = 0; i < finalArray.Length; i++)
{
    finalArray[i] = firstRow[i] + secondRow[i];
}

Console.WriteLine(string.Join(" ", finalArray));