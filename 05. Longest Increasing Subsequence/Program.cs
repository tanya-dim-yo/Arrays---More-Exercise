int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] len = new int[nums.Length];

for (int p = 0; p < nums.Length; p++)
{
    int left = 0;

    for (int i = 0; i < p; i++)
    {
        if (nums[i + 1] > nums[i])
        {
            left = i + 1;
        }
    }

    len[p] = 1 + len[left];

    len[p] = 1;
}
