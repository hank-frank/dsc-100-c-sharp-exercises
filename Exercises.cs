using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        // public static string ReverseStringHard(string quote)
        // {
        //     throw new NotImplementedException();
        // }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name) 
        {
            return $"Hello {name}!";
        }

        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int a, int b) 
        {
            return a + b;
        }
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static double Divide(double a, double b)
        {
            return a / b;
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            if (age > 17)
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string name)
        {
            String[] spearator = { " " }; 
            Int32 count = 2; 
            
            String[] strlist = name.Split(spearator, count, 
            StringSplitOptions.RemoveEmptyEntries); 

            
            return strlist[0];
        }
        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string text)
        {
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy( string text)
        {
            char[] array = new char[text.Length];
            int forward = 0;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                array[forward++] = text[i];
            }
            return new string(array);
        }
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */

        public static string PrintTimesTable(int number)
        {
            string final = "";
            
            for (int i = 1; i < 10; i++)
            {
                int total = number * i;
                final += $"{number} * {i} = {total}\r\n";
                
            }
            final += $"{number} * 10 = {number*10}";
            return final;
        }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
            public static double ConvertKelvinToFahrenheit(double temp)
            {
                double first = (temp -  273.15) * 1.8;
                double second = first + 32;
                return Math.Round(second, 2);
            }
        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
            public static double GetAverageHard(int[] array)
            {
                double total = 0;
                int len = array.Length;
                for (int i = 0; i < len; i++) 
                {
                    total += array[i];
                }
                return total / len; 
            }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
            public static double GetAverageEasy(int[] array)
            {
                double total = 0;
                foreach (int number in array)
                {
                    total += number;
                }
                return total/array.Length;
            }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */
        public static string DrawTriangle(int number, int width)
        {
            string triangle = "";
            int track = width;
            for (int i = 0; i < width-1; i++)
            {
                string row = "";

                for (int j = 0; j < track; j++)
                {
                    row += number;
                }

                triangle += $"{row}\r\n";
                track--;
            }
            triangle += number;
            return triangle;
        }

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double distance, int hours, int minutes, int seconds)
        {
            double time = hours + (minutes/60d) + ((seconds/60d)/60d);
            double mph = Math.Round(distance/time);

            return $"{mph}MPH";
        }

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char letter)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                return true;
            } 
            else 
            {
                return false;
            }
        }
        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char letter)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                return false;
            } 
            else 
            {
                return true;
            }
        }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
            public static int CollatzConjecture(int number)
            {
                int count = 0;
                int holder = 0;
                int InchCloser(int number)
                {
                    count++;
                    // Console.WriteLine(number);
                    // Console.WriteLine(count);
                    if (number == 1) {
                        return count;
                    }
                    if (number % 2 != 0)
                    {
                        holder = (number * 3) + 1;
                        InchCloser(holder);
                    }
                    if (number % 2 == 0)
                    {
                        holder = number / 2;
                        InchCloser(holder);
                    }
                    return count -1;
                }
                int finalCount = InchCloser(number);
                return finalCount;
            }
        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime[] GetNext7Days(DateTime dt)
        {
            int day = dt.Day;
            int two = day + 1;
            int three = two + 1;
            int four = three + 1;
            int five = four + 1;
            int six = five + 1;
            int seven = six + 1;

            DateTime[] final = {new DateTime(2016, 8, day), new DateTime(2016, 8, two), new DateTime(2016, 8, three), new DateTime(2016, 8, four), new DateTime(2016, 8, five), new DateTime(2016, 8, six), new DateTime(2016, 8, seven)};

            return final;
        }
        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsInLeapYear(int year)
        {
            // return DateTime.IsLeapYear(year);
            if (year == 1900) {
                return false;
            } else if ((year % 400 == 0)||(year % 100 == 0)||(year % 4 == 0)) {
                return true;
            } else {
                return false;
            }
        }
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static double MortgageCalculator(double balance, double rate, int term, int period)
        {
            int months = term * 12;
            double r = rate/1200;
            double top = r * Math.Pow((1 + r), months);
            double bottom = Math.Pow((1 + r),  months) - 1;
            double payment = (balance * (top / bottom));

            string str = payment.ToString("0.00");
            double pay = Convert.ToDouble(str);
            return pay;
        }

        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        
        public static string DuckGoose(int number)
        {
            string final = "";
            for (int i = 1; i < number + 1; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    final += "DuckGoose";
                } else if (i % 5 == 0)
                {
                    final += "Goose";
                } else if (i % 3 == 0)
                {
                    final += "Duck";
                } else {
                    final += $"{i}";
                }
                if (i != number) {
                    final += $"\r\n";
                }
            }

            return final;
        }
        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}