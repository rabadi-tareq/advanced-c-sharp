// Copyright 2025 JamilWare Technologies LLC
// SPDX-License-Identifier: gpl-3.0

﻿using LeetCode;
using Utilities;
namespace Tests
{
    [TestClass]
    public sealed class EasyProblemsTests
    {
        [TestMethod]
        [DataRow(new[]{2,5,5,11}, 10,DisplayName = "{2,5,5,11}, 10")]
        [DataRow(new[] { 2, 7, 11, 15 }, 9, DisplayName = "{2, 7, 11, 15}, 9")]
        [DataRow(new[] { 3 ,3 }, 6, DisplayName = "{ 3 ,3 }, 6")]
        [DataRow(new[] { 3, 2, 4 }, 6, DisplayName = "{ 3, 2, 4 }, 6")]
        public void TwoSum(params object[] dataRowInputs)
        {
            var twoSum = new TwoSum();
            var parameters = (object[])dataRowInputs[0];
            
            var numbers = (int[])parameters[0];
            var target = (int)parameters[1];

            var result = twoSum.Run(numbers, target);

            Assert.AreEqual(result.Sum(i => numbers[i]), target);

            Console.WriteLine(twoSum.Url);
        }

        [TestMethod]
        [DataRow(121,true, DisplayName = "121")]
        [DataRow(1221, true, DisplayName = "1221")]
        [DataRow(10,false, DisplayName = "10")]
        [DataRow(-121, false, DisplayName = "-121")]
        public void IsPalindrome(int x, bool result)
        {
            var isPalindrome = new IsPalindrome();

            Assert.AreEqual(isPalindrome.Run(x), result);

            Console.WriteLine(isPalindrome.Url);
        }

        [TestMethod]
        [DataRow(new[] {2,4,3},new[] { 5, 6, 4 },  DisplayName = "{2,4,3}, {5,6,4}")]
        public void AddTwoLinkedList(int[] firstNodeArray, int[] secondNodeArray)
        {
            var firstNode = new ListNode(firstNodeArray);
            var secondNode = new ListNode(secondNodeArray);

            var sumOfTwoLinkedLists = new AddTwoLinkedLists();
            var result = sumOfTwoLinkedLists.Run(firstNode, secondNode);

            Console.WriteLine(sumOfTwoLinkedLists.Url);
        }

        [TestMethod]
        [DataRow("abcabcbb",3, DisplayName = "abcabcbb")]
        [DataRow("bbbbb", 1, DisplayName = "bbbbb")]
        [DataRow("pwwkew", 3, DisplayName = "pwwkew")]
        [DataRow("", 0, DisplayName = "Empty String")]
        public void LongestSubstringWithoutRepetition(string str, int length)
        {
            var longestSubstringWithoutRepetition = new LongestSubstringWithoutRepetition();

            Assert.AreEqual(longestSubstringWithoutRepetition.Run(str), length);

            Console.WriteLine(longestSubstringWithoutRepetition.Url);
        }

        [TestMethod]
        [DataRow(new[] {"flower", "flow", "flight"},"fl", DisplayName = "\"flower\", \"flow\", \"flight\"")]
        [DataRow(new[] { "dog", "racecar", "car" },"", DisplayName = "\"dog\",\"racecar\",\"car\"")]
        public void LongestCommonPrefix(string[] words, string result)
        {
            var longestCommonPrefix = new LongestCommonPrefix();
            var outcome = longestCommonPrefix.Run(words);

            Assert.AreEqual(result, outcome);

            Console.WriteLine(longestCommonPrefix.Url);
        }

        [TestMethod]
        [DataRow("()",true,DisplayName = "()")]
        [DataRow("})", false, DisplayName = "})")]
        [DataRow("(){}[]", true, DisplayName = "(){}[]")]
        [DataRow("({[]})", true, DisplayName = "({[]})")]
        [DataRow("[", false, DisplayName = "[")]
        [DataRow("[[", false, DisplayName = "[[")]
        public void ValidParentheses(string s, bool result)
        {
            var parenthesesValidation = new ValidParentheses();
            var outcome = parenthesesValidation.Run(s);

            Assert.AreEqual(outcome, result);

            Console.WriteLine(parenthesesValidation.Url);
        }

        [TestMethod("Revisit")]
        [DataRow(new[] { 4, 2, 1 }, new[] { 1, 3, 4 }, new[] { 1, 1, 2, 3, 4, 4 }, DisplayName = "{1,1,2,3,4,4}")]
        [DataRow(new int[] { }, new int[] { }, new int[] { }, DisplayName = "Empty Nodes")]
        [DataRow(new int[] { }, new int[] {0}, new int[] {0}, DisplayName = "One Empty, the other is not")]
        public void MergeTwoSortedLists(int[] first, int[] second, int[] outcome)
        {
            var mergeTwoSortedLists = new MergeTwoSortedLists();

            var firstListNode = new ListNode(first);
            var secondListNode =  new ListNode(second);

            var result = mergeTwoSortedLists.Run(firstListNode, secondListNode);

            var outcomeNode = outcome.Length == 0 ? null : new ListNode(outcome);

            Assert.IsTrue(result.IsEqual(outcomeNode));
        }


        [TestMethod]
        public void RemoveDuplicatesFromSortedArray()
        {
            var removeDuplicatesFromSortedArray = new RemoveDuplicatesFromSortedArray();

            var result = removeDuplicatesFromSortedArray.Run(new[] { 1, 1, 2 });

        }
    }
    
}
