namespace InheritanceClassLibrary;

class Program {
    public static void Main() {
        var shape = new Shape(5, 5);
        var rectangle = new Rectangle(6,8);

        System.Console.WriteLine("Shape Height: " + shape.Height + "\nShape Width: " + shape.Width);
    }
}