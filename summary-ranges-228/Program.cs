var nums = new[] {};

List<string> ranges = new IList<string>();

if (nums.Length == 0) return ranges;

int i = 0, n = nums.Length;

while (i < n)
{
    int start, end;

    start = nums[i];
    while (i + 1 < n && nums[i + 1] == nums[i] + 1) i++;

    end = nums[i];

    if (start == end)
        ranges.Add(start + "");
    else
        ranges.Add(start + "->" + end);

    i++;
}

ranges.ForEach(s => Console.WriteLine(s));