using System.Transactions;
using Utilities;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCode;

public class MergeTwoSortedLists
{
    public string Url => "https://leetcode.com/problems/merge-two-sorted-lists/";

    public ListNode Run(ListNode list1, ListNode list2)
    {
        var sortedList1 = new List<int>(GetListRepresentation(list1));
        var sortedList2 = new List<int>(GetListRepresentation(list2));

        var result = new List<int>(sortedList1);

        foreach (var item in sortedList2)
        {
            result.Add(item);
        }

        result.Sort();

        var resultArray = result.ToArray();

        var node = CreateFromArray(resultArray);

        return node;
    }

    private ListNode CreateFromArray(int[] array)
    {
        if (array.Length == 0)
            return null;

        var node = new ListNode(array[0]);

        node.next = CreateFromArray(array[1..]);

        return node;
    }

    private bool IsEmptyNode(ListNode node)
    {
        return node == null;

    }
    private List<int> GetListRepresentation(ListNode node)
    {
        var result = new List<int>();

        if (IsEmptyNode(node))
            return result;

        result.Add(node.val);

        var head = node.next;

        while (head != null)
        {

            result.Add(head.val);
            head = head.next;

            if (head.next == null)
            {
                result.Add(head.val);
                break;
            }
        }

        return result;
    }
    

}