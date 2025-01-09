using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class TwoSumTests
{
    [TestMethod]
    public void TestFindTwoSum()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = TwoSum.FindTwoSum(nums, target);
        CollectionAssert.AreEqual(new int[] { 2, 7 }, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestFindTwoSumNoSolution()
    {
        int[] nums = { 1, 2, 3 };
        int target = 6;
        TwoSum.FindTwoSum(nums, target);
    }
}
