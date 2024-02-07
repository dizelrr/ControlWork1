string[] createdArray = FillArray();
string[] resultArray = GenerateNewArray(createdArray);
string firstArray = PrintArray(createdArray);
string secondArray = PrintArray(resultArray);
Console.WriteLine(firstArray + " -> " + secondArray);
string[] FillArray()
{
    Console.WriteLine("Введите числа и слова через пробел и нажмите Enter: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] createdArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return createdArray;
}
string PrintArray(string[] createdArray)
{
    string stringArray = "[";
    for (int i = 0; i < createdArray.Length; i++)
    {
        if (i == createdArray.Length - 1)
        {
            stringArray += $"\"{createdArray[i]}\"";
            break;
        }
        stringArray += ($"\"{createdArray[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}
int CountStringSymbols(string[] createdArray)
{
    int counter = 0;
    foreach (string item in createdArray)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}
string[] GenerateNewArray(string[] createdArray)
{
    int resultArrayLength = CountStringSymbols(createdArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in createdArray)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}