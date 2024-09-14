namespace LeetCode.Console.Problems._2._Add_Two_Numebers;

  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }

  public class Solution
  {
      public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
      {
          var result = new ListNode(0, null);
          var current = result;
          var tmp = 0;

          while (l1 != null || l2 != null || tmp > 0)
          {
              var l1Value = l1 != null ? l1.val : 0;
              var l2Value = l2 != null ? l2.val : 0;

              var sum = l1Value + l2Value + tmp;
              current.val = sum % 10;
              tmp = sum / 10;

              l1 = l1?.next;
              l2 = l2?.next;

              if (l1 != null || l2 != null || tmp > 0)
              {
                  current.next = new ListNode(0, null);
                  current = current.next;
              }
          }

          return result;
      }
  }