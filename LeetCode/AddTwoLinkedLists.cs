using Utilities;

namespace LeetCode;

public class AddTwoLinkedLists
{
    public string Url => "https://leetcode.com/problems/add-two-numbers/description/";

    public ListNode Run(ListNode l1, ListNode l2)
    {
        var result = new ListNode();

        var currentFirstNode = l1;
        var currentSecondNode = l2;
        var currentResultNode = result;

        while (currentFirstNode != null)
        {
            var sum = currentFirstNode.val + currentSecondNode.val;

            if (sum >= 10)
            {
                currentResultNode.val = sum / 10;
            }


            currentResultNode.next = new ListNode();

            currentFirstNode = currentFirstNode.next;
            currentSecondNode = currentSecondNode.next;
            currentResultNode = currentResultNode.next;
        }

        return result;
    }
}