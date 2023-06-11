namespace InheritanceClassLibrary;

public class UnitTest1
{
    [Fact]
    public void RectangleTest()
    {
        // Values
        var rectangle = new Rectangle(6, 8);
        int expectedArea = 48, expectedHeight = 6, expectedWidth = 8;

        // Assert
        Assert.Equal(expectedArea, rectangle.Area);
        Assert.Equal(expectedHeight, rectangle.Height);
        Assert.Equal(expectedWidth, rectangle.Width);
    }
}