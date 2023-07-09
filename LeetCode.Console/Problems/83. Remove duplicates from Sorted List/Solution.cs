namespace LeetCode.Console.Problems._83._Remove_duplicates_from_Sorted_List;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var node = head;
        while (node is not null)
        {
            if (node.next is not null)
            {
                if (node.val == node.next.val)
                {
                    node.next = node.next.next;
                    continue;
                }
            }

            node = node.next;
        }

        return head;
    }
}