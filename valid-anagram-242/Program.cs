var s = "a";
var t = "ab";

Console.WriteLine(IsAnagram(s, t));

bool IsAnagram(string s, string t)
{
    var sChars = new Dictionary<char, int>();
    var tChars = new Dictionary<char, int>();

    if (s.Length != t.Length) return false;

    for (int i = 0; i < s.Length; i++)
    {
        if (sChars.ContainsKey(s[i]))
        {
            sChars[s[i]]++;
        }
        else
        {
            sChars.Add(s[i], 1);
        }

        if (tChars.ContainsKey(t[i]))
        {
            tChars[t[i]]++;
        }
        else
        {
            tChars.Add(t[i], 1);
        }
    }

    if (sChars.OrderBy(s => s.Key).SequenceEqual(tChars.OrderBy(t => t.Key)))
    {
        return true;
    }

    return false;
}