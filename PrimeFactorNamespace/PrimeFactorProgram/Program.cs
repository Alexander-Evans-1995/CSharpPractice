namespace PrimeFactorNamespace;

class PrimeFactorProgram {
    public static void Main() {
        PrimeFactor primeFactor = new PrimeFactor();
        int number = 992;
        int cache = 1;

        try {
            System.Console.Write(primeFactor.checkPrime(number, cache));
        } catch (ArgumentException e) {
            System.Console.Write(e.Message);
        }
    }
}