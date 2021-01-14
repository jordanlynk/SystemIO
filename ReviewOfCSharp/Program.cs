using System;

namespace ReviewOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("This was your average, " + AverageOfNumbers(getNumbers())); */
            drawDiamond();
        }
        public static string getNumbers()
        {
            Console.WriteLine("Please enter a number between 2 and 10");
            return Console.ReadLine();
        }
        public static decimal AverageOfNumbers(string userNum)
        {   
            // converting parameter to an integer
            int arrayLength = Convert.ToInt32(userNum);
            decimal[] averageArray = new decimal[arrayLength];
            decimal sum = 0;
            // every time it iterates through, it assigns each index to the value input by the user
            for (int i = 0; i < averageArray.Length; i++)
            {
                Console.WriteLine("Please enter a random number.");
                averageArray[i] = Convert.ToDecimal(Console.ReadLine());
            }

            foreach (decimal num in averageArray)
            {
                sum += num;
            }
            decimal arrayLengthAsDecimal = Convert.ToDecimal(arrayLength);
            return Decimal.Divide(sum, arrayLengthAsDecimal);

        }
        static void drawDiamond()
        {
            char space = ' ';
            char asterisk = '*';
            int numberOfSpaces = 4;
            int numberOfAsterisk = 1;
            string finalOutput;

            for (int i = 1; i < 10; i++)
            {
                finalOutput = "";
                for (int j = 1; j < 10; j++)
                {
                    if (j < numberOfSpaces)
                    {
                        finalOutput += space;
                    }
                    else if (j < numberOfSpaces + numberOfAsterisk)
                    {
                        finalOutput += asterisk;
                    }
                    else
                    {
                        finalOutput += space;
                    }
                        
                }
                if (i < 5)
                {
                    numberOfSpaces--;
                    numberOfAsterisk += 2;
                }
                else
                {
                    numberOfSpaces++;
                    numberOfAsterisk -= 2;
                }
                Console.WriteLine(finalOutput);
                
            }
        }
    }


}
