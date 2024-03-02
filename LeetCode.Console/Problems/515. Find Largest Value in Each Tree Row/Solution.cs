namespace LeetCode.Console.Problems._515._Find_Largest_Value_in_Each_Tree_Row;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public IList<int> LargestValues(TreeNode root)
    {
        var result = new List<int>();
        
        if (root is null)
        {
            return result;
        }

        var currentLevel = new List<TreeNode>{ root };
        while (currentLevel.Count != 0)
        {
            var currentLevelMax = int.MinValue;
            var nextLevel = new List<TreeNode>();
            
            foreach (var node in currentLevel)
            {
                currentLevelMax = int.Max(currentLevelMax, node.val);
                
                if (node.left is not null)
                {
                    nextLevel.Add(node.left);
                }
                
                if (node.right is not null)
                {
                    nextLevel.Add(node.right);
                }
            }
            
            result.Add(currentLevelMax);
            currentLevel = nextLevel;
        }

        return result;
    }
}