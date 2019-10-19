using System;
using static System.Console;

namespace CheckDiget
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = ReadLine(); //4 digit code from user ex"7781"
            

            if (code.Length == 4) //check for length
            {

                string triDig = code.Substring(0, 3); //first 3 digits
                string checkDig = code.Substring(3, 1); // last digit
                int checkIfInt;

                if (Int32.TryParse(code, out checkIfInt)) //checks to see if string can convert
                {
                    int r = Convert.ToInt32(triDig) % 7; //remainder of division of 7
                    int check = Convert.ToInt32(checkDig); //converting last digit to int
                    
                    if (r == check) //check to see if last digit equal remainder
                    {
                        WriteLine("The account number is valid"); //true
                    }
                    else
                    {
                        WriteLine("Invalid"); //false
                    }
                }
                else
                {
                    WriteLine("please enter a number");
                }
                

                
            }
            else
            {
                WriteLine("Code length is invalid");
            }
            
        }
    }
}
