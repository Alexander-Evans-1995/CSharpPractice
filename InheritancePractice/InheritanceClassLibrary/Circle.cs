namespace InheritanceClassLibrary;
public class Circle : Shape
{
    int Radius;
    double CircleArea;
    public Circle (int radius) {
        Radius = radius;
        CircleArea = radius*radius*3.14;
    }
}
