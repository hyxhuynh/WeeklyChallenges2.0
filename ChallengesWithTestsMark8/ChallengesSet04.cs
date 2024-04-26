using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sumEvensSubtractOdds = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEvensSubtractOdds += numbers[i];
                }
                if (numbers[i] % 2 != 0)
                {
                    sumEvensSubtractOdds -= numbers[i];
                }
            }
            return sumEvensSubtractOdds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] stringLength = {str1.Length, str2.Length, str3.Length, str4.Length};
            return stringLength.Min();

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = {number1, number2, number3, number4};
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3
                && sideLength1 + sideLength3 > sideLength2
                && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            decimal number;
            bool isANumber = decimal.TryParse(input, out number);
            if (isANumber)
            {
                return true;
            }
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int numberOfNulls = 0;
            int arrayLength = objs.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                if (objs[i] == null)
                {
                    numberOfNulls++;
                }
                if (numberOfNulls > arrayLength - numberOfNulls)
                {
                    return true;
                }
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            double sumOfEvens = 0;
            double numOfEvens = 0;
            for (int i=0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumOfEvens = sumOfEvens + numbers[i];
                    numOfEvens++;
                }
            }

            if (numOfEvens == 0 || sumOfEvens == 0)
            {
                return 0;
            }

            return sumOfEvens / numOfEvens;
        }

        public int Factorial(int number)
        {   
            if (number == 0)
            {
                return 1;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return number * Factorial(number -1);
        }
    }
}
