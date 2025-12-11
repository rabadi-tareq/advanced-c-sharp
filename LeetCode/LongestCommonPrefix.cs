// Copyright 2025 JamilWare Technologies LLC
// SPDX-License-Identifier: gpl-3.0

﻿namespace LeetCode;

public class LongestCommonPrefix
{
    public string Url => "https://leetcode.com/problems/longest-common-prefix/";

    public string Run(string[] words)
    {
        // The longest common prefix can't be longer than the shortest word.
        var shortestWordLength = words.Min(item => item.Length);
        var maxPrefix = 0;

        for (var i = 0; i < shortestWordLength; ++i)
        {
            var currentChar = words[0][i];

            if (words.All(word => word[i] == currentChar))
                maxPrefix++;
            else
                break;
        }

        return words[0][0..maxPrefix];
    }
}