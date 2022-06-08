int[] array = { 11, 21, 31, 41, 17, 15, 61, 17, 18, 19 };

int n = array.Length;
int find = 17;

int index = 0;

while (index < n)
{

    if(array[index]
        == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1;
}
