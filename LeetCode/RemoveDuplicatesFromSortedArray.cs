namespace LeetCode;

public class RemoveDuplicatesFromSortedArray
{
    public string Url => "https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/";

    public int Run(int[] nums)
    {
        var result = new SortedSet<int>();
        
        foreach (var item in nums)
        {
            result.Add(item);
        }

        nums = result.ToArray();
        return result.Count;
    }
}