using LeetCode.Common;

namespace LeetCode.Algebra.BinaryExponentiation;

internal class BinaryExponentiationRecursive : ISolution
{
    public void RunSolution()
    {
        var binaryExponentiator = new BinaryExponentiatorRecursive();
        var a = 2L;
        var exponent = 7L;
        var result = binaryExponentiator.Compute(in a, exponent);

        Console.WriteLine($"Result of binary exponentation (recursive) for input {a} and exponent {exponent} is {result}");
    }
}

internal class BinaryExponentiatorRecursive
{
    public long Compute(in long a, long exponent)
    {
        if (exponent < 0)
            throw new ArgumentException("Negative exponent is not supported", nameof(exponent));

        return ComputeRecursiveStep(in a, exponent);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    ///     3 recursive cases:
    ///         -> a^n = 1, when n is 0
    ///         -> a^n = (a^(n/2))^2, when n is even
    ///         -> a^n = (a^((n-1)/2))^2 * a, when n is odd
    /// </remarks>
    private long ComputeRecursiveStep(in long a, long exponent)
    {
        if (exponent == 0)
            return 1;

        var partialResult = ComputeRecursiveStep(in a, exponent / 2);

        if (exponent % 2 == 0)
        {
            return partialResult * partialResult;
        }

        return partialResult * partialResult * a;
    }
}
