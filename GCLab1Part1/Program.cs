using System;

namespace GCLab1Part1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Assigning variables 
            int input1, input2, firstnum1, firstnum2, secondnum1, secondnum2, thirdnum1, thirdnum2, total1, total2, total3;

            //User input for number1
            Console.WriteLine("Please enter a 3 digit number:");
            input1 = Convert.ToInt32(Console.ReadLine());

                //Validation of user's input for number1
            while (input1 < 100 || input1 >999)
            {
                Console.WriteLine("The number you entered is invalid, please re-enter a three digit number.");
                input1 = Convert.ToInt32(Console.ReadLine());
            }

            //User input for number2 
            Console.WriteLine("Please enter another 3 digit number:");
            input2 = Convert.ToInt32(Console.ReadLine());
           
                //Validation for number2
            while (input2 < 100 || input2 > 999)
            {
                Console.WriteLine("The number you entered is invalid, please reenter a three digit number.");
                input2 = Convert.ToInt32(Console.ReadLine());
            }

            //splitting the digits
            firstnum1 = (input1 / 100) % 10;
            firstnum2 = (input2 / 100) % 10;
            Console.WriteLine("The numbers in the hundreds place for the first and second 3 digit numbers are {0} and {1}, respectively", firstnum1, firstnum2);
            secondnum1 = (input1 / 10) % 10;
            secondnum2 = (input2 / 10) % 10;
            Console.WriteLine("The numbers in the tens place for the first and second 3 digit numbers arew {0} and {1}, respectively", secondnum1, secondnum2);
            thirdnum1 = input1 % 10;
            thirdnum2 = input2 % 10;
            Console.WriteLine("The numbers in the ones place for the first and second 3 digit numbers are {0} and {1}, respectively", thirdnum1, thirdnum2);

            //adding the ones, tens and hundreds
            total1 = firstnum1 + firstnum2;
            Console.WriteLine("The sum of the numbers in the hundreds place is {0}", total1);
            total2 = secondnum1 + secondnum2;
            Console.WriteLine("The sum of the numbers in the tens place is {0}", total2);
            total3 = thirdnum1 + thirdnum2;
            Console.WriteLine("The sum of the numbers in the ones place is {0}", total3);

            //Calling the method and printing the result
            if (Result(total1, total2, total3) == true){
                Console.WriteLine("True, the sum of the integers in the ones, tens and hundreds place are all equal.");
            }
            else{
                Console.WriteLine("False, the sum of the integers in the ones, tens and hundreds place are not equal.");
            }

        }
        //Declaring a method
        static bool Result(int a, int b, int c){
            if ( a == b){
                if (b == c)
                {
                    return true;
                }
                    else{
                        return false;
                    }
                }

            else {
                return false;
            }
        }
    }
}
