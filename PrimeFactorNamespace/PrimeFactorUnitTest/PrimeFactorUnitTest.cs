using Xunit;

namespace PrimeFactorNamespace;

public class UnitTest1
{
    [Fact]
    public void TestPrimeFactorTuple () {
        // arrange
        int factorial = 0, result = 0, input = 333, cache = 1;
        var primeFactorTest = new PrimeFactor();

        // act
        (factorial,result) = primeFactorTest.primeFactorial(input, cache);

        // assert
        Assert.Equal(3, factorial);
        Assert.Equal(111, result);
    }

    [Fact]
    public void TestPrimeFactorRun () {
        // arrange
        int input = 963;
        var expected = new List<int> {3, 107};
        var actual = new List<int> {};
        var primeFactorTest = new PrimeFactor();

        // act
        actual = primeFactorTest.PrimeFactorRun(input);

        // assert
        Assert.Equal(expected, actual);
    }
}