string[] firstArray = new string[5] { "Hello", "2", "world", ":-)", "qte" };
string[] secondArray = new string[firstArray.Length];
void SecondArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}
SecondArray(firstArray, secondArray);
Console.WriteLine($"Исходный массив: [{string.Join(", ", firstArray)}]");
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", secondArray)}]");