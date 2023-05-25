public class Program
{
    /*
    Write a function that takes in an array of at least three integers and without sorting the input array, returns a sorted array of the three largest integers in the input array.

    Example:
    Input: [10, 141, 60, 500, 1, -100, 15]
    Output: [ 60, 141, 500]
    */
    public static void Main()
    {
        var input = new int[] { 10, 141, 60, 500, 1, -100, 15 };
        var result = FindThreeMaxNumbers(input);

        Console.WriteLine(string.Join(",", result));
    }

    private static int[] FindThreeMaxNumbers(int[] input)
    {
        var s = new Stack<int>();
        var tmps = new Stack<int>();

        var arr = new int[3];

        int max = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (i == 0)
            {
                max = input[i];
                s.Push(max);
            }

            else if (input[i] > s.Take(3).Min())
            {
                max = input[i];

                if (s.Peek() != max)
                    s.Push(max);
            }
        }

        while (s.Count > 0)
        {
            var tmp = s.Pop();

            while (tmps.Count > 0 && tmps.Peek() > tmp)
            {
                s.Push(tmps.Pop());
            }

            tmps.Push(tmp);
        }


        for (int k = 2; k >= 0; k--)
        {
            arr[k] = tmps.Pop();
        }

        return arr;
    }
}