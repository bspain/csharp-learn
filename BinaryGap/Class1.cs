namespace BinaryGap;
public class Solution
{
    public static int DetectGap(int N)
    {
        string binary = Convert.ToString(N, 2);

        System.Console.WriteLine($"Testing {N} as '{binary}'");

        bool counting = false;
        int longestgap = 0;
        int gap = 0;
        foreach (char c in binary) {
            if (c == '1') {
                if (!counting) {
                    counting = true;
                    continue;
                } else {

                    // Promote gap is longest
                    if (gap > longestgap) {
                        longestgap = gap;
                    }

                    gap = 0;
                    continue;
                }
            } else if (c == '0') {
                if (counting) {
                    gap++;
                    continue;
                }
            }
        }

        return longestgap;
    }
}
