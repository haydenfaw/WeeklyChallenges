using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c) //done
        {
            return char.IsLetter(c);
            //throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals) //done
        {
            return (vals.Length % 2 == 0);
            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number) //done
        {
            return (number % 2 == 0);
            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num) //done
        {
            return (num % 2 != 0);
            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers) //done
        {
            //if(numbers.Count() == 0 || numbers == null)
            if(numbers == null || numbers.Count() ==0)
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }
            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2) //done
        {
            return (str1.Length > str2.Length) ? str2.Length : str1.Length;
            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers) //done
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                //Using Linq = return numbers.Sum();
                var sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }
                return sum;
            }
            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers) //done
        {
            //var numbersEvens = new int[numbers.Length];
            if (numbers == null)
            {
                return 0;
            }
            //Using Linq = return numbers.Where(number => % 2 == 0).Sum();
            for (var i = numbers.Length -1; i > -1; i--)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] = 0;
                }
            }
            return numbers.Sum();
            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers) //done
        {
            if(numbers == null)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);
            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number) //done
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
            //throw new NotImplementedException();
        }
    }
}
