using System;
using System.Collections.Generic;

public class TribonacciCalculator
{
    public List<int> GetSequence(int[] signature, int n)
    {
        List<int> result = new List<int>();
        if (n == 0) return result;

        for (int i = 0; i < Math.Min(signature.Length, n); i++)
            result.Add(signature[i]);

        while (result.Count < n)
        {
            int count = result.Count;
            // คำนวณโดยใช้ 3 ตัวล่าสุด
            result.Add(result[count - 1] + result[count - 2] + result[count - 3]);
        }
        return result;
    }
}