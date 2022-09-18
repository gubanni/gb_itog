int CountElement (string[] array)
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
            count ++;
    }
    return count;
}

string[] ConvertArray (string[] array, int size)
{
    int j = 0;
    string[] resultArray = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

string[] originalArray = {"print","hello","car","|:(","><"};
int sizeArray = CountElement(originalArray);
string[] NewArray = new string[sizeArray];
NewArray = ConvertArray(originalArray, sizeArray);
Console.Write(string.Join(", ", finalArray));