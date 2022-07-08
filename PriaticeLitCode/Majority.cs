using System;
using System.Collections.Generic;

namespace PriaticeLitCode
{
    public class Majority
    {
        public Majority()
        {
        }


        public static int GetMajorityNum(List<int> nums)
        {
            int nummax = 0;
            int maxnum = 0;
            Dictionary<int, int> numcountdic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (numcountdic.ContainsKey(nums[i]))
                    numcountdic[nums[i]]++;
                
                else
                    numcountdic[nums[i]] = 1;

                if (numcountdic[nums[i]]>nummax)
                {
                    maxnum = nums[i];
                }
            }
            return maxnum;


        }
    }
}
