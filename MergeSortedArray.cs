using System;

public class MergeSortedArray
{
    public static int[] MergeSortedArray(int[] A, int m, int[] B, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;
        int[] C = new int[k + 1];
        while (k >= 0)
        {
            if (j < 0 || (i >= 0 && A[i] > B[j]))
                C[k--] = A[i--];
            else
                C[k--] = B[j--];
        }
        return C;
    }

}
