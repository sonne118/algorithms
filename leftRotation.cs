using System;

public class Class1
{
    public Class1()
    {
        static int[] leftRotation(int[] arr, int n, int d)
        {
            Queue<int> tmp = new Queue<int>();
            for (int i = 0; i < d; i++)
                for (int j = n - 1; j >= 0; j = j - 2)
                {

                    if (j != 0)
                    {
                        tmp.Enqueue(arr[j - 1]);
                        arr[j - 1] = arr[j];
                    }
                    if (j == n - 1) { continue; }
                    if (j == 0) { arr[n - 1] = arr[j]; }
                    arr[j] = tmp.Dequeue();
                    if (j == 1)
                    {
                        arr[n - 1] = tmp.Dequeue();
                        break;
                    }
                }

            return arr;
        }

    }
}
