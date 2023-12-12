using System;
using System.IO;
using System.Linq;

// read and parse txt
string filePath = "./names.txt";
string[] names = File.ReadAllText(filePath)
                    .Replace("\"", "")
                    .Split(',');

// alphabetically sort
Array.Sort(names);

long totalScore = 0;

// iterate and multiply sum of letters by names position
for (int i = 0; i < names.Length; i++)
{
    int nameValue = GetNameValue(names[i]);
    totalScore += (i + 1) * nameValue;
}

Console.WriteLine("Total Name Score: " + totalScore);


/// <summary>
/// Calculate sum of letter values in name e.g. A-1 B-2...
/// </summary>
/// <param name="name">Name to calculate sum of letters</param>
/// <returns>Sum of letter values of given name</returns>
static int GetNameValue(string name)
{
    return name.Sum(c => char.ToUpper(c) - 'A' + 1);
}
