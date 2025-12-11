// Copyright 2025 JamilWare Technologies LLC
// SPDX-License-Identifier: gpl-3.0

﻿namespace LeetCode
{
    public class TwoSum
    {
        public string Url => "https://leetcode.com/problems/two-sum/description/";
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] Run(int[] nums, int target)
        {
            // Using a dictionary for fast lookup on the current number and the lookup value that adds up to the target
            // This makes the algorithm complexity O(N) instead of O(n*2)
            var seen = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                var currentNumber = nums[i];

                seen.TryAdd(currentNumber, i);

                // Trying to find the lookup value in the dictionary since we have to find only one answer, not all possibilities.
                var lookupValue = target - currentNumber;

                if (seen.ContainsKey(lookupValue) && seen[lookupValue] != i)
                {
                    var lookupValueIndex = seen[lookupValue];
                    // The indices can be returned in any order
                    return (i < lookupValueIndex) ? [i, lookupValueIndex] : [lookupValueIndex, i];
                }
            }

            return [];
        }
    }
}
