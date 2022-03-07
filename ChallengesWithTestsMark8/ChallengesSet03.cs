using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals) //done
        {
            //My way -- worked, but using linq is more optimized.
            //foreach (var val in vals)
            //{
            //    if (val == false)
            //    {
            //        return true;
            //    }                
            //}
            //return false;

            return vals.Contains(false);
            //throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers) //done
        {
            if(numbers == null)
            {
                return false;
            }
            var sumationOfOdds = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                    sumationOfOdds.Add(num);
                }
            }
            var total = sumationOfOdds.Sum();
            if (total % 2 != 0)
            {
                return true;
            }
            return false;
            //throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password) //done
        {
            int isUpper = 0;
            int isLower = 0;
            int isNumber = 0;
            foreach (var item in password)
            {
                bool result = Char.IsUpper(item);
                if (result == true)
                {
                    isUpper = 1;
                }
                
            }
            foreach (var item in password)
            {
                bool result = Char.IsLower(item);
                if (result == true)
                {
                    isLower = 1;
                }
            }
            foreach (var item in password)
            {
                bool result = Char.IsNumber(item);
                if (result == true)
                {
                    isNumber = 1;
                }
            }
            int answer = isUpper + isLower + isNumber;
            if(answer == 3)
            {
                return true;
            }
            return false;
            //throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val) //done
        {
            return val.First();
            //throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val) //done
        {
            return val.Last();
            //throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor) //done
        {
            if (divisor == 0) //Technically the answer should be undefined.
            {
                return 0;
            }
            return dividend / divisor;
            //throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums) //done
        {
            return nums.Last() - nums.First();
            //throw new NotImplementedException();
        }

        public int[] GetOddsBelow100() // done
        {
            //var oddsBelow100 = new int[49];
            //var position = 0;
            //for(int i = 0; i<101; i++)
            //{
            //    if (i% 2 != 0)
            //    {
            //        oddsBelow100[position] = i;
            //        position++;
            //    }
            //    Console.WriteLine(oddsBelow100);
            //}
            //return oddsBelow100;

            var oddsBelow100List = new List<int>();
            var position = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddsBelow100List.Add(i);
                    position++;
                    Console.WriteLine(i);
                }
            }
            var oddsBelow100List2 = oddsBelow100List.ToArray();
            return oddsBelow100List2;

            //throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words) //done
        {
           
            //words = words.Select(s => s.ToUpper()). ToArray();

            //uppercase.ToUpper();
            //words = uppercase;

            //foreach (var word in words) //apparantly foreach doesnt allow you to change values?!?!?!?
            //{
            //    foreach (var letter in word)
            //    {
            //        Char.ToUpper(letter);
            //    }
            //}
            for (int i=0; i<words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

            //throw new NotImplementedException();
        }
    }
}
