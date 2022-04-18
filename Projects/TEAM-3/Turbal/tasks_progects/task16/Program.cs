//4. Написати програму, яка знаходить в масиві найменше непарне число і показує його на екран.

int[] nums = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 5, 6, 7, 8 };
int count = nums.Count();

Console.WriteLine("Your array:");
for (int i = 0; i < count; i++)
    Console.Write("{0} ", nums[i]);
Console.WriteLine();

int? min = null;
for (int i = 0; i < count; i++)
    if ((nums[i] % 2 == 1) & ((nums[i] < min) | (min == null)))
        min = nums[i];
if (min == null)
    Console.WriteLine("Array have'n odd numbers!");
else
{
    Console.WriteLine($"The least odd number in array is:{min}");
}




