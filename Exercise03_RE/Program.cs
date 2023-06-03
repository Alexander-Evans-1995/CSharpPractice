// Fizzbuzz Application June 3, 2023
using System;

Main.MainRun();
class Main {
    // Prints FizzBuzz!
    public static void MainRun() {
        string FizzBuzzToPrint = "";

        FizzBuzzToPrint = FizzBuzz.FizzBuzzRun();

        Console.WriteLine(FizzBuzzToPrint);
    }
}

class FizzBuzz {
    public static string FizzBuzzRun() {
        int counter = 1;
        const int CounterLimit = 100;
        string output = "";

        // Loop to go to fizzbuzz. Counts up to [100]
        while (counter <= CounterLimit) {
            if (counter%3 != 0 && counter%5 != 0) {
                output += counter;
            }

            else {
                if (counter%3 == 0) {
                    output += "fizz";
                }
                
                if (counter%5 == 0) {
                    output += "buzz";
                }
            }

            output += ", ";
            counter++;
        } // while count to CounterLimit loop

        return output;
    }// method fizzbuzz
} // class fizzbuzz