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
        string iString, returnStringPartOne = "", returnStringPartTwo = "", returnString = "";
        char iCharOne, iCharTwo;
        int iStringLength;
        // used for tens place since the tens place has unique nomenclature. Default false
        bool tens = false; 
        
        iString = i.ToString();
        iStringLength = iString.Length;
        iCharOne = iString[0];
        iCharTwo = iString[1];

        switch (iCharOne) {
            case '1':
                tens = true;
                break;
            case '2':
                returnStringPartOne = "twenty";
                break;
            case '3':
                returnStringPartOne = "thirty";
                break;
            case '4':
                returnStringPartOne = "fourty";
                break;
            case '5':
                returnStringPartOne = "fifty";
                break;
            case '6':
                returnStringPartOne = "sixty";
                break;
            case '7':
                returnStringPartOne = "seventy";
                break;
            case '8':
                returnStringPartOne = "eighty";
                break;
            case '9':
                returnStringPartOne = "ninety";
                break;
            default: 
                throw new Exception("An error has occured with iCharOne switch.");
        }

        if (tens == true) {
            switch (iCharTwo) {
                case '1':
                    returnString = "eleven";
                    break;
                case '2':
                    returnString = "twelve";
                    break;
                case '3':
                    returnString = "thirteen";
                    break;
                case '4':
                    returnString = "fourteen";
                    break;
                case '5':
                    returnString = "fifteen";
                    break;
                case '6':
                    returnString = "sixteen";
                    break;
                case '7':
                    returnString = "seventeen";
                    break;
                case '8':
                    returnString = "eighteen";
                    break;
                case '9':
                    returnString = "nineteen";
                    break;
                default:
                    throw new Exception("An error has occured with switch(iCharTwo) - tens == true");
            }
        } // if statement
        else {    
            switch (iCharTwo) {
                case '1':
                    returnStringPartTwo = " one";
                    break;
                case '2':
                    returnStringPartTwo = " two";
                    break;
                case '3':
                    returnStringPartTwo = " three";
                    break;
                case '4':
                    returnStringPartTwo = " four";
                    break;
                case '5':
                    returnStringPartTwo = " five";
                    break;
                case '6':
                    returnStringPartTwo = " six";
                    break;
                case '7':
                    returnStringPartTwo = " seven";
                    break;
                case '8':
                    returnStringPartTwo = " eight";
                    break;
                case '9':
                    returnStringPartTwo = " nine";
                    break;
                default:
                    throw new Exception("An error has occured with switch(iCharTwo) tens == false");     
            } // switch
        } // else
        
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
    } // method
} // class

