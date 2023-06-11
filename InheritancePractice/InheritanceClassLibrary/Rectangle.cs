namespace InheritanceClassLibrary;
/// <summary>
/// A regular old rectangle. Adds area calculation to Rectangle.
/// </summary>
public class Rectangle : Shape
{
    public Rectangle(int height, int width) {
        Height = height;
        Width = width;

        Area = Height * Width;
    }
}
