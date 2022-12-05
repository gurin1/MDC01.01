int x = 5;

int[] a = new[] { 2, 8, 3, 6, 9, 4, 5 };

int count = 0;
int sum = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > x)
    {
        sum += a[i];
        count++;
    }
}

Console.WriteLine(sum / count);

