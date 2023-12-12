using System;
using System.IO;
using System.Linq;

string filePath = "./names.txt";
string[] names = File.ReadAllText(filePath)
                    .Replace("\"", "")
                    .Split(',');

Array.Sort(names);

long totalScore = 0;

for (int i = 0; i < names.Length; i++)
{
    int nameValue = GetNameValue(names[i]);
    totalScore += (i + 1) * nameValue;
}

Console.WriteLine("Total Name Score: " + totalScore);


static int GetNameValue(string name)
{
    return name.Sum(c => char.ToUpper(c) - 'A' + 1);
}
