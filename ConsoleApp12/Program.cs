//ЗАДАНИЕ1-------------------------------------------------------------------------------------------------------

int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
int sum = 5;
List<string> pairs = new List<string>();
for (int i = 0; i < num.Length - 1; i++)
{
    for (int j = i + 1; j < num.Length; j++)
    {
        if (num[i] + num[j] == sum)
        {
            pairs.Add($"{num[i]}, {num[j]}");
        }
    }
}
foreach (string x in pairs)
{
    Console.WriteLine(x);
}

//ЗАДАНИЕ2-------------------------------------------------------------------------------------------------------

List<string> words = new List<string> { "dfghdfg", "dfgh", "hfdghaF", "oFSDFSfsd", "FSdfFDS" };
HashSet<string> iter = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
foreach (string word in words)
{
    iter.Add(word);
}
Console.WriteLine(iter.Count);

//ЗАДАНИЕ3------------------------------------------------------------------------------------------------------- 

List<int> sap = new List<int>();
for (int i = 1; i <= 100; i++)
{
    if (Enumerable.Range(1, 10).Any(x => x * x == i))
    {
        sap.Add(i);
    }
}
foreach (int square in sap)
{
    Console.WriteLine(square);
}

//ЗАДАНИЕ4-------------------------------------------------------------------------------------------------------

List<string> strings = new List<string> { "ytiu", "duyd", "gokgh", "ghshart" };
List<char> perk = new List<char> { 'm', 'd', 't', 'g', 'o' };
List<string> result = new List<string>();
foreach (string str in strings)
{
    bool containsAllVowels = perk.All(v => str.ToLower().Contains(v));
    if (containsAllVowels)
    {
        result.Add(str);
    }
}
foreach (string str in result)
{
    Console.WriteLine(str);
}

//ЗАДАНИЕ5-------------------------------------------------------------------------------------------------------

string input = "hello im sir beerman";
HashSet<char> uniqueChars = new HashSet<char>();
foreach (char c in input)
{
    uniqueChars.Add(c);
}
foreach (char c in uniqueChars)
{
    Console.WriteLine(c);
}