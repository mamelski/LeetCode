using LeetCode.Console._88._Merge_Sorted_Array;

var solution = new Solution();


int[] num1 = [0];
int[] num2 = [1];
Solution.Merge(num1, 0, num2, 1);

foreach (var item in num1)
{
    Console.WriteLine(item);
}