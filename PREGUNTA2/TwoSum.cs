using System;
using System.Collections.Generic;

public class TwoSum
{
    //09/01/2025 7:34
    //Jonathan Ortega
    //INPUT: arreglo con numeros a sumar, valor objetivo
    //OUTPUT: dos números que suman el objetivo
    //EXCEPTION: si no hay dos números que sumen el objetivo
    public static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numDict.ContainsKey(complement))
            {
                return new int[] { complement, nums[i] };
            }
            numDict[nums[i]] = i;
        }

        throw new ArgumentException(":( Intenta otra vez");
    }
}
