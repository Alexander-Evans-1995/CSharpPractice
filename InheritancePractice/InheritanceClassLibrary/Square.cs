namespace InheritanceClassLibrary;
public class Square : Shape
{
    public Square (int length) {
        Height = length;
        Width = length;

        Area = Height * Width;
    }
}
