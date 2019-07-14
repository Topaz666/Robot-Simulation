using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using static System.Console;

/*
 * Drawing the circuit elements by using the keywords of R, L, C, P, for Resistor, Inductor, capacitor and Power respectively
 * Rule: 1.the name of elements only accepts R, L, C, P and num 0-9 after these fours letters.
 *       2.every circuit elements need to bring all adjoining elements and at least two adjoining element for one element, they are sepearted by the comma.
*/
namespace circuit_png
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine(args.Length); 
            foreach (string arg in args)
            {
                string[] ElementGroup = arg.Split(',');
                foreach (string s in ElementGroup)
                {
                    char s[0];
                }
            }
        }
    }
}
