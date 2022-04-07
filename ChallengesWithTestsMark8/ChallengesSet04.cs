using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers) //done
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4) //done
        {

            int[] countOfStrings = {str1.Count(), str2.Count(), str3.Count(), str4.Count()};
            return countOfStrings.Min();
            //throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4) //done
        {
            int[] arrayOfNumbers = {number1, number2, number3, number4};
            return arrayOfNumbers.Min();
            //throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz) //done
        {
            biz.Name = "TrueCoders";
            //throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3) // done
        {
            return ((sideLength1 + sideLength2 > sideLength3) && (sideLength1 + sideLength3 > sideLength2) && (sideLength2 + sideLength3 > sideLength1)) ? true : false;
            //throw new NotImplementedException();         
        }

        public bool IsStringANumber(string input) //done
        {
            return (double.TryParse(input, out double i)) ? true : false;
            //throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs) //done
        {
            return ((objs.Where(x => x == null).Count()) > (objs.Where(x => x != null)).Count()) ? true : false;
            //throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers) //done
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Where(x => x%2 ==0).Sum() == 0)
            {
                return 0;
            }
            return numbers.Where(x => x % 2 == 0).Average();
            //throw new NotImplementedException();
        }

        public int Factorial(int number) //done
        {
            if(number ==0)
            {
                return 1;
            }
            for (int i = number - 1; i >= 1; i--)
            {
                number = number * i;
            }
            return (number >= 0) ? number : throw new ArgumentOutOfRangeException();
            //throw new NotImplementedException();
        }
    }
}
