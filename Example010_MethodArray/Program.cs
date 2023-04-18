int[] array = {1, 12, 31, 4, 15, 88, 16, 17, 88};

int n = array.Length;
int find = 88;

int index = 0;

while (index < n )
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}