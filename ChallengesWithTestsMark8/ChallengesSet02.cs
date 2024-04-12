﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] lowercaseCharArr = lowercaseAlphabet.ToCharArray();
            string uppercaseAlphabet = lowercaseAlphabet.ToUpper();
            char[] uppercaseCharArr = uppercaseAlphabet.ToCharArray();
            for (int i = 0; i < lowercaseCharArr.Length; i++)
            {
                if (c == lowercaseCharArr[i])
                {
                    return true;
                }
            }
            for (int x = 0; x < uppercaseCharArr.Length; x++)
            {
                if (c == uppercaseCharArr[x])
                {
                    return true;
                }
            }
            return false;

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0) { return true; }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0) { return true; }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0) { return true; }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) { return 0; }
            if (numbers.Count() == 0) { return 0; }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null) { return 0; }
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null) { return 0; }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null) { return false;}
            for (int i = 0; i < numbers.Count;i++)
            {
                sum += numbers[i];
            }
            if (sum % 2 != 0) { return true;}
            else { return false;}
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            List<int> posOddList = new List<int>();

            for (int i = 1; i < number; i++)
            {
                if (i > 0 && i % 2 != 0)
                {
                    posOddList.Add(i);
                }
            }
            return posOddList.Count;
        }
    }
}
