namespace LeetCode.Console.Problems._109._Convert_Sorted_List_to_Binary_Search_Tree;
public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }

  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 
public class Solution {
    public List<int> list = new List<int>();
    
    public TreeNode SortedListToBST(ListNode head) {
       
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
        
        if (list.Count == 0)
        {
            return null;
        }
 
        return GetSubTree(0, list.Count-1);
    }

    public TreeNode GetSubTree(int start, int end)
    {
        if (start > end)
        {
            return null;
        }
        
        var mid = start + (end - start) / 2;;
        var node = new TreeNode(list[mid])
        {
            left = GetSubTree(start, mid -1),
            right = GetSubTree(mid + 1, end)
        };

        return node;
    }
}