// Algorithim needs serious review.
// Every hundreds place needs to be put into actual language.
// Recommend loop to add to return array.

namespace TowardExtension;
/// <summary>
/// Class for Toward
/// </summary>
public static class TowardExtension
{
    /// <summary>
    /// An extension method which converts an integer 32 into normal language.
    /// EX: "567,400 -> Fifty-six hundred thousand".
    /// </summary>
    /// <param name="i">integer to be converted (static extension call)</param>
    /// <returns>string of normal language for an integer 32.</returns>
    public static string Toward(this int i) {
        string  iString, returnStringPartOne = "", 
                returnStringPartTwo = "", returnStringPartThree = "",
                returnString = "";
        char iCharOne, iCharTwo, iCharThree;
        int iStringLength;
        // used for tens place since the tens place has unique nomenclature. Default false
        bool tens = false;
        
        iString = i.ToString();
        iStringLength = iString.Length;
        iCharOne = iString[0];
        iCharTwo = iString[1];
        iCharThree = iString[2];

        
        
        // Needs to concat returnString from here on.
        if( i < 100) {
            if (tens == true)
                return returnString;

            else {
                returnString = returnStringPartOne + returnStringPartTwo;
                return returnString;
            }
        }
        
        switch (iStringLength) {
            // case three needs review. 
            // EX: 567 -> expected: Five Hundred and Sixty; actual: Five Hundred and Six
            case 3:
                returnString = returnStringPartOne + " hundred" + " and " + returnStringPartTwo;
                break;
            case 4:
                returnString = returnStringPartOne + " thousand" + " and " + returnStringPartTwo + " hundred";
                break;
            case 5:
                returnString += "  thousand";
                break;
            case 6:
                returnString += " ";
                break;
        } // swtich

        return "Not less than 100";
    } // method Toward

    /// <summary>
    /// Returns string of normal language for a number up to one hundred 
    /// </summary>
    /// <param name="towardArguments"></param>
    /// <returns></returns>
    public static string towardToString(int input) {
        int places;
        string returnString = "", inputString = "";

        if (input < 1 || input > 999)
            throw new ArgumentException("integer to convert is outside range.");
        
        // changes input to a string.
        // Testing
        inputString = input.ToString();
        places = inputString.Length;

        // No need for dynamic index because there is only one length option (3).
        if (places == 3) {
            switch (inputString[0]) {
                case '1':
                    returnString = "one hundred";
                    break;
                case '2':
                    returnString = "two hundred";
                    break;
                case '3':
                    returnString ="three hundred";
                    break;
                case '4':
                    returnString = "four hundred";
                    break;
                case '5':
                    returnString = "five hundred";
                    break;
                case '6':
                    returnString = "six hundred";
                    break;
                case '7':
                    returnString = "seven hundred";
                    break;
                case '8':
                    returnString = "eight hundred";
                    break;
                case '9':
                    returnString = "nine hundred";
                    break;
                default:
                    throw new Exception("An error has occured in inputString[0].");
            } // switch

            places--;

            // For x-zero-zero, x-zero-z
            if (returnString[1] == 0) {
                if (returnString[2] == 0)
                    return returnString;
                // decrements places since the tens place is zero.
                // New value of places is 1.
                places--;
            }

            returnString += " and ";
        } // if: places == 3

        // The index is set to inputString.Length - 2 and inputString.Length - 1.
        // This is because the inputString may be either three or two objects.
        // Since the index for the tenth position is dynamic; the index must be dynamic.
        // EX: 56  -> index = 0.
        //     567 -> index = 1.
        if (places == 2) {
            // if there is one in the tens place.
            // Returns string.
            if (inputString[inputString.Length - 2] == '1') {
                switch(inputString[inputString.Length - 1]) {
                    case '0':
                        returnString += "ten";
                        break;
                    case '1':
                        returnString += "eleven";
                        break;
                    case '2':
                        returnString += "twelve";
                        break;
                    case '3':
                        returnString += "thirteen";
                        break;
                    case '4':
                        returnString += "fourteen";
                        break;
                    case '5':
                        returnString += "fifteen";
                        break;
                    case '6':
                        returnString += "sixteen";
                        break;
                    case '7':
                        returnString += "seventeen";
                        break;
                    case '8':
                        returnString += "eightteen";
                        break;
                    case '9':
                        returnString += "nineteen";
                        break;
                    default:
                        throw new Exception("An error has occured in places==2; inputString[1]");
                }
                return returnString;
            }

            // Standard
            switch(inputString[inputString.Length - 2]) {
                
                case '2':
                    returnString += "twenty";
                    break;
                case '3':
                    returnString += "thirty";
                    break;
                case '4':
                    returnString += "fourty";
                    break;
                case '5':
                    returnString += "fifty";
                    break;
                case '6':
                    returnString += "sixty";
                    break;
                case '7':
                    returnString += "seventy";
                    break;
                case '8':
                    returnString += "eight";
                    break;
                case '9':
                    returnString += "nine";
                    break;
                default:
                    throw new Exception("An error has occured in places 2 standard switch.");
            }

            // Standard spacing
            // Check for a zero in the ones place. If there is a zero, then return.
            if (inputString[inputString.Length - 1] == '0')
                return returnString;
            
            // If not zero, then add "-".
            else {
                returnString += "-";
            }

            // decrement
            places--;
        } 

        // Dynamic index.
        if (places == 1) {
            switch (inputString[inputString.Length - 1]) {
                case '1':
                    returnString += "one";
                    return returnString;
                case '2':
                    returnString += "two";
                    return returnString;
                case '3':
                    returnString += "three";
                    return returnString;
                case '4':
                    returnString += "four";
                    return returnString;
                case '5':
                    returnString += "five";
                    return returnString;
                case '6':
                    returnString += "six";
                    return returnString;
                case '7':
                    returnString += "seven";
                    return returnString;
                case '8':
                    returnString += "eight";
                    return returnString;
                case '9':
                    returnString += "nine";
                    return returnString;
                default:
                    throw new Exception("An error has occure in places=1 and switch(input).\nInput String: " + inputString);
            }
        }
        
        return returnString;
    } // towardToString() method
} // class

