Console.Write("Введите элементы массива через пробел ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);


int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int [nums.Length];

    for(int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int count = 0;
int index = 0;
while (index < baseArray.Length)
{
    if (baseArray[index] > 0)
    {
        Console.Write(baseArray[index] + " ");
        count++;
    }
    index++;    
}
Console.WriteLine();
Console.WriteLine("Количество искомых чисел " + count);