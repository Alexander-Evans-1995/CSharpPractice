namespace PrimeFactorNamespace;

class PrimeFactorProgram {
    public static void Main() {
        PrimeFactor primeFactor = new PrimeFactor();
        int number = 973;
        /* int cache = 1; */

        try {
            System.Console.Write(primeFactor.primeFactorial(number));
        } catch (ArgumentException e) {
            System.Console.Write(e.Message);
        }
    }
}