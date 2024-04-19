using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {           
            if (numbers == null) { return false; }
            int sum = numbers.Sum();
            if (sum % 2 != 0)
            {
                return true;
            }   
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isLower = false;
            bool isUpper = false;
            bool isNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }

                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }

                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }
            }

            if (isLower == true && isUpper == true && isNumber == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            char[] chars = val.ToCharArray();
            return chars[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char[] chars = val.ToCharArray();
            return chars[chars.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            int subtract = nums[nums.Length - 1] - nums[0];
            return subtract;
        }

        public int[] GetOddsBelow100()
        {
            int[] numArr = new int[50];
            int index = 0;
            for (int i = 1; i < 100; i += 2)
            {
                numArr[index] = i;
                index++;
            }
            return numArr;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
