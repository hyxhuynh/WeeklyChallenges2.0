using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            // Eg. 21/20 = 1.05 then roundUpQuotient = 2; therefore, next divisible number is 20 * 2 = 40
            int roundUpQuotient = (startNumber / n) + 1;
            int nextDivisibleNum = (n * roundUpQuotient);
            return nextDivisibleNum;

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null) return false;
            if (numbers.Length == 0) return false;
            int counter = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] <= numbers[i + 1])
                {
                    counter++;
                }
            }
            // if arr = [1, 2, 3, 4, 5], we are comparing 1 to 2, 2 to 3, 3 to 4, 4 to 5, which we compare 4 times
            // 1 < 2 true, 2 < 3 true, 3 < 4 true, 4 < 5 true --> no. of 'true' = 4 or arr.Length - 1
            if (counter == numbers.Length - 1)
            {
                return true;
            }
            return false;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 1; i < numbers.Length; ++i)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            } 
            string sentence = string.Empty;
            for (int i = 0;i < words.Length; i++) 
            {
                if (words[i].Trim().Length > 0)
                {
                    // Remove spaces and add a space after each word
                    sentence += words[i].Trim() + " ";
                }
            }
            // if the string only has white spaces
            if (sentence.Length == 0)
            {
                return "";
            }
            // Remove the last space added for the last word.
            // "This is a sentence "
            sentence = sentence.Trim(); // "This is a sentence"
            sentence += "."; // "This is a sentence."
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            } 
            List<double> everyFourthList = new List<double>();
            // Since index starts from 0, the 4th element has index = 3
            for (int i = 3; i < elements.Count; i += 4)
            {
                everyFourthList.Add(elements[i]);
            }
            return everyFourthList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool isEqualToTargetNum = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    int sum = nums[i] + nums[j];
                    if (sum == targetNumber)
                    {
                        isEqualToTargetNum = true;
                        return isEqualToTargetNum;
                    }
                }
            }
            return isEqualToTargetNum;
        }
    }
}
