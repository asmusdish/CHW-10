void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

string[] Check3Values(string[] array)
{
    int newLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) newLength++;
    }

    string[] newArray = new string[newLength];

    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;

}

int n = 5;

string[] array = new string[n];
array[0] = "5";
array[1] = "ldfk";
array[2] = "its";
array[3] = "678ffff";
array[4] = "Ex";

Console.WriteLine("Исходный массив");
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Массив из сртрок, длинна которых меньше либо равна 3 символам");
PrintArray(Check3Values(array));