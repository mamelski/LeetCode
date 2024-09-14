

using LeetCode.Console.Problems._2._Add_Two_Numebers;


var l1 = new ListNode(9, new ListNode(9, new ListNode(9)));
var l2 = new ListNode(9, new ListNode(9));
var solution = new Solution().AddTwoNumbers(l1,l2);
    

Console.WriteLine($"{solution}");
