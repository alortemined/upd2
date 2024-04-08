using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> current = new List<int>();
        Array.Sort(candidates); 

        FindCombinations(candidates, target, 0, current, result);

        return result;
    }

    private void FindCombinations(int[] candidates, int target, int start, List<int> current, IList<IList<int>> result) {
        if (target == 0) {
            
            result.Add(new List<int>(current));
            return;
        }

        for (int i = start; i < candidates.Length; i++) {
            if (candidates[i] > target) {
                break; 
            }

            if (i > start && candidates[i] == candidates[i - 1]) {
                continue; 
            }

            current.Add(candidates[i]);
            FindCombinations(candidates, target - candidates[i], i + 1, current, result);
            current.RemoveAt(current.Count - 1); 
        }
    }
}

class Program {
    static void Main(string[] args) {
        int[] candidates = {2, 3, 6, 7};
        int target = 7;

        Solution solution = new Solution();
        IList<IList<int>> combinations = solution.CombinationSum(candidates, target);

        foreach (IList<int> combination in combinations) {
            Console.WriteLine(string.Join(", ", combination.Select(i => i.ToString()).ToArray()));
        }

    }
}