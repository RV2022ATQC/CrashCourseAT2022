// See https://aka.ms/new-console-template for more information


//3. Написати програму, яка знаходить в масиві значення, що повторюються два і більше разів, і показує їх на екран.


int count = 0;


int[] nums = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 5, 6, 7, 8 };
count = nums.Count();

int[] rez = new int[count];

Console.WriteLine("Here is your array:");

for (int i = 0; i < count; i++)
    Console.Write("{0} ", nums[i]);

int j = 0;
Console.WriteLine("Items that occur more than 2 times:");
for (int i = 0; i < count; i++)
{
    var t = nums.Count(n => n == nums[i]);
    if (t >= 2)
        if (rez.Count(m => m == nums[i]) == 0)
        {
            rez[j] = nums[i];
            j++;
        }

        
}

for (int i = 0; i < j; i++)
    Console.Write("{0} ", rez[i]);



