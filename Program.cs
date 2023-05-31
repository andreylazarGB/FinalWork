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
