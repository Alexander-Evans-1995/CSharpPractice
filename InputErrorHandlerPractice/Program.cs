/*  Asks for two numbers between zero and two hundred and five. 
    After which the program divides the first number by the second
    The purpose of this program is to practice error handling.
        1. Inputs which are outside of the range
        2. Inputs which are not in the correct format*/

NumberDivider.NumberDividerRun();

/**Queries user for two inputs, and then checks if the inputs are integers.
   Once the user has entered integers, the program divides the first by the second: first/second. */
class NumberDivider {
    /**Run method for Number Divider*/
    public static void NumberDividerRun() {
        const int MAX = 255, MIN = 0;
        
        string inputMessageFirst = $"Enter an integer between {MIN} and {MAX}: ";
        string inputMessageSecond = $"Enter another integer between {MIN} and {MAX}: ";
        int inputNumberFirst, inputNumberSecond, result;

        inputNumberFirst = recieveValidateInput(inputMessageFirst, MAX, MIN);
        inputNumberSecond = recieveValidateInput(inputMessageSecond, MAX, MIN);

        result = inputNumberFirst / inputNumberSecond;

        System.Console.WriteLine($"{inputNumberFirst} divided by {inputNumberSecond} is {result}");

    }

    /**Used for NumberDividerRun. Ensures that the user enters an integer.
    @return int: integer which the user has entered.
    @input string: source of the string in NumberDividerRun, initial message prompt. 
           int: Maximum and minimum value.*/
    public static int recieveValidateInput(string inputMessage, int max, int min) {
        
        
        string? input;
        int inputNumber = 0;
        bool isNumber = false;
        
        while (isNumber == false) {
            System.Console.Write(inputMessage);
            input = System.Console.ReadLine();

            try {
                if (input is not null) {
                    System.Console.WriteLine("You have entered: " + input);
                    inputNumber = Int32.Parse(input);

                    if (inputNumber >= min && inputNumber <= max) 
                        isNumber = true;
                    
                    else
                        System.Console.WriteLine($"Please enter a number between {min} and {max}.");
                } // null check

                else
                    System.Console.WriteLine("Please enter a number.");
            } catch (FormatException e) {
                System.Console.WriteLine(e.Message);
            }
        }

        return inputNumber;
    }
}