using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyProblem
{
    public class Twosum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int o = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (o == nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}