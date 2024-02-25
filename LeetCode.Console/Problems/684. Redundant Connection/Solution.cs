namespace LeetCode.Console.Problems._684._Redundant_Connection;

using System;

public class Solution
{
    int[] parent;

    public int[] FindRedundantConnection(int[][] edges)
    {
        parent = new int[edges.Length + 1];
        for (var i = 1; i < parent.Length; i++) {
            parent[i] = i;
        }

        var res = new List<int[]>();

        foreach (var edge in edges) {
            
            if (FindParent(edge[0]) != FindParent(edge[1])) {
                Union(edge[0], edge[1]);
            }
            else {
                res.Add(edge);
            }
        }
        return res[^1];
    }
    
    private int FindParent(int x) {
        if (parent[x] != x) {
            parent[x] = FindParent(parent[x]);
        }
        return parent[x];
    }
    
    private void Union(int x, int y) {
        parent[FindParent(x)] = parent[FindParent(y)];
    }

}