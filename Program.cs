Console.Clear();

string[] array = { "hello", "2", "world", ":-)" };
//string[] array = {"1234", "1567", "-2", "computer science"};
//string[] array = { "Russia", "Denmark", "Kazan"};

string[] GetArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        char[] arr = Array[i].ToCharArray();        
        if (arr.Length > 3) Array[i] = "";
    }
    return Array;
}

void PrintArray(string[] Array)
{
    Console.Write($"[");
    for (int i = 0; i < Array.Length - 1; i++)
    {
        if (Array[i]!="")
        Console.Write($"{Array[i]}, ");
    }
    Console.Write($"{Array[Array.Length - 1]}]");
}

GetArray(array);
Array.Sort(array);
PrintArray(array);