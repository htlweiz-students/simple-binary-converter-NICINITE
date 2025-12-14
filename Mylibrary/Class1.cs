using System;
namespace Mylibrary;

public static class Binary
{
    /// <summary>
    /// Converts an input string with only binary-numbers (0 and 1) 
    /// to a dezimal number! If there is a other number than 0 or 1, an Error will
    /// be return back.
    /// </summary>
    /// <param name="binary_code">Input string</param>
    /// <param name="sum"> Is the sum of all added binary numbers in dezimal</param>
    /// <param name="power"> To calculate the the power of 2 foreach binary-number</param>
    
    public static double Todezimal(string? binary_code) {
        double sum = 0;
        int power = 0;

        if (string.IsNullOrEmpty(binary_code)) {
            throw new ArgumentException("Error: Input is empty");
        }

        for(int count = binary_code.Length-1; count >= 0; count--) {
            if(binary_code[count] == '1') {
                sum += Math.Pow(2, power);
            } else if (binary_code[count] != '0') {
                throw new ArgumentException("Error: invalid binary number!");
            }
            power++;
        }

        return sum;
    } 
}
