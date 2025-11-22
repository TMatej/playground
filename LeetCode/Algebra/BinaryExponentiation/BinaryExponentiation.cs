using LeetCode.Common;

namespace LeetCode.Algebra.BinaryExponentiation;

internal class BinaryExponentiation : ISolution
{
    public void RunSolution()
    {
        var binaryExponentiator = new BinaryExponentiator();
        var a = 2L;
        var exponent = 7L;
        var result = binaryExponentiator.Compute(a, exponent);

        Console.WriteLine($"Result of binary exponentation for input {a} and exponent {exponent} is {result}");
    }
}

internal class BinaryExponentiator
{
    public long Compute(long a, long exponent)
    {
        if (exponent < 0)
            throw new ArgumentException("Negative exponent is not supported", nameof(exponent));

        var result = 1L;

        while (exponent > 0)                // O(log(exponent)) iterations
        {
            if ((exponent & 1) == 1L)       // multiply only if exponent (represented in binary format) has 1 in position 
            {
                result *= a;                // O(log(exponent)) multiplications of potentialy large number
            }

            a *= a;                         // O(log(exponent)) exponentiations of base
            exponent >>= 1;
        }

        return result;
    }
}