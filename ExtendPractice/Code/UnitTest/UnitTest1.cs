namespace TowardExtension;

public class UnitTest1
{
    [Fact]
    public void towardToString()
    {
        int input = 564;
        string expected = "five hundred and sixty-four";
        string actual;

        actual = TowardExtension.towardToString(input);
        System.Console.WriteLine(actual);
        
        Assert.Equal(expected, actual);
    }
}