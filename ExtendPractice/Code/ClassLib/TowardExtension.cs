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
        inputString = input.ToString();
        places = inputString.Length;



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
                places--;
            }

            inputString += " and ";
        } // places == 3

        if (places == 2) {
            // if there is one in the tens place.
            if (inputString[1] == '1') {
                switch(inputString[2]) {
                    case '0':
                        inputString += "ten";
                        break;
                    case '1':
                        inputString += "eleven";
                        break;
                    case '2':
                        inputString += "twelve";
                        break;
                    case '3':
                        inputString += "thirteen";
                        break;
                    case '4':
                        inputString += "fourteen";
                        break;
                    case '5':
                        inputString += "fifteen";
                        break;
                    case '6':
                        inputString += "sixteen";
                        break;
                    case '7':
                        inputString += "seventeen";
                        break;
                    case '8':
                        inputString += "eightteen";
                        break;
                    case '9':
                        inputString += "nineteen";
                        break;
                    default:
                        throw new Exception("An error has occured in places==2; inputString[1]");
                }
                return returnString;
            }

            // Standard
            switch(inputString[1]) {
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
                    throw new Exception();
            }

            // Standard spacing
            // Add a check for a zero in the ones place. If there is a zero, then return.
            // If not zero, then add "-".
        } 
        if (places == 1) {
            switch (input) {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new Exception("An error has occure in places=1 and switch(input).");
            }
        }
        return returnString;
    }
} // class

