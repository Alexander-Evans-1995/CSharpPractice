// Changes towardToString() param from int to string.

namespace TowardExtension;
/// <summary>
/// Class for Toward
/// </summary>
public static class TowardExtension
{
    /// <summary>
    /// An extension method which converts a positive integer 32 into normal language.
    /// EX: "567,400 -> Fifty-six hundred thousand".
    /// </summary>
    /// <param name="i">positive integer to be converted (static extension call)</param>
    /// <returns>string of normal language for an integer 32.</returns>
    public static string Toward(this int i) {
        string iString, returnString = "", subString;
        int modulus, count = 0;

        // zero check
        if (i == 0)
            return "zero";

        iString = i.ToString();
        modulus = iString.Length % 3;

        for (int x = iString.Length - 1; x > 1; x-=3) {
            subString = iString.Substring(x-2, 3);
            subString = towardToString(subString);

            if (count == 0 && subString != "") 
                returnString = subString;       
            else if (count == 1 && subString != "")
                returnString = subString + " thousand and " + returnString;
            else if (count == 2 && subString != "")
                returnString = subString + " million and " + returnString;

            count++;
        }
        
        if (modulus != 0) {
            // sets subString
            if (modulus == 1)
                subString = towardToString(iString.Substring(0, 1));
            else
                subString = towardToString(iString.Substring(0, 2));

            if (returnString == "") {
                // Determines size of number.
                if (count == 3) 
                    return subString + " billion";
                
                else if (count == 2)
                    return subString + " million";
                
                else if (count == 1)
                    return subString + " thousand";
                
                else 
                    return subString;
            }
            // Determines size of number.
            if (count == 3) 
                returnString = subString + " billion and " + returnString;
            
            else if (count == 2)
                returnString = subString + " million and " + returnString;
            
            else if (count == 1)
                returnString = subString + " thousand and " + returnString;
            
            else 
                returnString = subString;
        }

        return returnString;
    } // method Toward

    /// <summary>
    /// Returns string of normal lan uage for a number up to one hundred 
    /// </summary>
    /// <param name="towardArguments">String from 1 - 100</param>
    /// <returns></returns>
    static string towardToString(string inputString) {
        int places;
        string returnString = "";
        
        // Checks if zero-zero-zero.
        // Returns empty string
        if (inputString == "000")
            return "";
        
        // changes input to a string.
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
            if (inputString[1] == '0') {
                if (inputString[2] == '0')
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
                case '0':
                    break;
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
                    returnString += "eighty";
                    break;
                case '9':
                    returnString += "ninety";
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

