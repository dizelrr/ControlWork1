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
    string[] workArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArray;
}
