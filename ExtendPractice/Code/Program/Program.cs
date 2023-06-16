// Program to interact with ClassLib
namespace TowardExtension;
/* using TowardExtension; */
class Program {
    public static void Main() {
        int test = 114;

        try {
        System.Console.WriteLine(TowardExtension.towardToString(test));
        } catch (Exception e) {
            System.Console.Write(e.Message);
        }
    }
}