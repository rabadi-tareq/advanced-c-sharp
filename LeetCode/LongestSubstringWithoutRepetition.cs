// Copyright 2025 JamilWare Technologies LLC
// SPDX-License-Identifier: gpl-3.0

﻿using System.Text;

namespace LeetCode;

public class LongestSubstringWithoutRepetition
{
    public string Url => "https://leetcode.com/problems/longest-substring-without-repeating-characters/description/";

    public int Run(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;
        if (s == " ")
            return 1;

        var list = new List<string>();

        var chars = s.ToCharArray();

        for (int i = 0; i < chars.Length; ++i)
        {
            list.Add(chars[i].ToString());

            var secondStringBuilder = new StringBuilder(chars[i].ToString());

            for (int j = i+1; j < chars.Length; ++j)
            {
                secondStringBuilder.Append(chars[j].ToString());
                list.Add(secondStringBuilder.ToString());
            }

        }

        return list.Select(l => l.ToCharArray()).Where(ar => ar.Distinct().Count() == ar.Length).Max(d => d.Length);
    }
}