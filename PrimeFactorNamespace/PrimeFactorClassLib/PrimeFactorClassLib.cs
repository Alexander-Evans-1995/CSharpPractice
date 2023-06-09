﻿using System.Collections.Generic;
namespace PrimeFactorNamespace;
public class PrimeFactor
{
    public const int MAX = 1000;
    private int[] _PRIME_ARRAY = new int[] {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997};
 
    /// <summary>
    /// Run method for PrimeFactor.
    /// Takes a number and returns its factorials (no repeats).
    /// </summary>
    /// <param name="input">Int. Number to find the factorials for.</param>
    /// <returns>Integer List that contains the factorials ascending.</returns>
    public List<int> PrimeFactorRun(int input) {
        int cache = 0, factorial = 0;
        var resultList = new List<int> {};
        bool isEven, isPrime, isDuplicate = false;

        if (input > MAX || input < 1)
            throw new ArgumentException("Input is not within the acceptable bounds.");

        if (input % 2 == 0) {
            isEven = true;
            resultList.Add(2);
        }

        else {
            isEven = false;
        }

        // Even Loop
        while (isEven) {
            input = input/2;

            if (checkEven(input) == false) {
                isEven = false;
            }
        }
        
        isPrime = checkPrime(input);
        
        while(isPrime == false) {
            (factorial, input) = primeFactorial(input, cache);
            System.Console.WriteLine("Line 39:\nFactorial: " + factorial + "\nInput: " + input);

            for (int i = cache; i < resultList.Count; i++) {
                if (resultList[i] == factorial) {
                    cache = i;
                    isDuplicate = true;
                    break;
                }
            }

            if (isDuplicate == false) {
                resultList.Add(factorial);
                System.Console.WriteLine(resultList[cache]);

            }

            isDuplicate = false;

            isPrime = checkPrime(input);
        }

        if (factorial != input) {
            resultList.Add(input);
        }

        return resultList;
    }

    /// <summary>
    /// Checks if the input is a prime number or not by iterating through.
    /// an array of prime numbers and comparing the input to them.
    /// </summary>
    /// <param name="input">int input, number to check if it is prime.
    /// Must be greater than 1 and less than or equal to MAX value. </param>
    /// <returns> bool, True if prime. False if compound.</returns>
    public bool checkPrime(int input) {
        if (input <= 1 || input > 1000) {
            throw new ArgumentException($"Parameter is out of bounds. Must be between: 2-{MAX}", nameof(input));
        }
        
        for (int i = 0; i < _PRIME_ARRAY.Length; i++) {
            if (_PRIME_ARRAY[i] == input) 
                return true;
            
            if (_PRIME_ARRAY[i] > input)
                return false;
        }

        return false;
    }

    /// <summary>
    /// Checks if the input is a prime number or not by iterating through.
    /// an array of prime numbers and comparing the input to them.
    /// </summary>
    /// <param name="input">int input, number to check if it is prime.
    /// Must be greater than 1 and less than or equal to MAX value.</param>
    /// <param name="cache"> int cache, index to start _PRIME_ARRAY search at. </param>
    /// <returns> bool, True if prime. False if compound.</returns>
    public bool checkPrime(int input, int cache) {
        if (input <= 1 || input > 1000) {
            throw new ArgumentException($"Parameter is out of bounds. Must be between: 2-{MAX}", nameof(input));
        }
        
        if (input < _PRIME_ARRAY[cache])
            throw new ArgumentException("Prime Array at index cache is higher than the input.");
        for (int i = cache; i < _PRIME_ARRAY.Length; i++) {
            if (_PRIME_ARRAY[i] == input) 
                return true;
            if (_PRIME_ARRAY[i] > input)
                    return false;
        }

    return false;
    }

    /// <summary>
    /// Returns whether the value is even or odd.
    /// </summary>
    /// <param name="input">Input to check if it is even.</param>
    /// <returns>bool, true if even, false if odd.</returns>
    public bool checkEven(int input) {
        if (input < 1)
            throw new ArgumentException("Input must be greater than zero.");
        
        if (input % 2 == 0) {
            return true;
        }
        
        return false;
    }

    /// <summary>
    /// Finds the factorial of a given number and returns the result as a tuple.
    /// Assumes input is prime, if not then will return (Input, 1).
    /// </summary>
    /// <param name="input">Integer. Value to find the factorials for.</param>
    /// <returns>Tuple. [Factorial, Result]. 
    /// [Factorial] is prime, whereas [Result] may or may not be prime.</returns>
    public (int, int) primeFactorial (int input) {
        if (input <= 1 || input > MAX)
            throw new ArgumentException("Input is out of bounds.");

        for (int i = 0; i < _PRIME_ARRAY.Length; i++) {
            if (input % _PRIME_ARRAY[i] == 0) {
                return (_PRIME_ARRAY[i], input/_PRIME_ARRAY[i]);
            } // if condition
        } // for loop

        throw new Exception("An error has occured in primeFactorial.");
    }

    public (int, int) primeFactorial (int input, int cache) {
        if (input <=1 || input > MAX)
            throw new ArgumentException("Input is out of bounds.");

        for (int i = cache; i < _PRIME_ARRAY.Length; i++) {
            if (input %_PRIME_ARRAY[i] == 0) {
                return (_PRIME_ARRAY[i], input/_PRIME_ARRAY[i]);
            }
        }

        throw new Exception("An error has occured in primeFactorial.");
    }
}