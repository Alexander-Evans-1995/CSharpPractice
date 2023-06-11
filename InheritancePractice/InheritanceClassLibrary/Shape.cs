namespace InheritanceClassLibrary;

/// <summary>
/// Any kind of shape
/// </summary>
public class Shape {
    public int Height;
    public int Width;
    public int Area;

    public Shape () {}
    public Shape (int height, int width) {
        Height = height;
        Width = width;
    }
}