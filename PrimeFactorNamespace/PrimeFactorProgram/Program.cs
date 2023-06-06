namespace PrimeFactorNamespace;

class PrimeFactorProgram {
    public static void Main() {
        PrimeFactor primeFactor = new PrimeFactor();
        var result = new List<int> {};
        int number = 964;
        
        result = primeFactor.PrimeFactorRun(number);
        if (result.Count == 0) {
            System.Console.Write("Empty list");
        }
    }
}