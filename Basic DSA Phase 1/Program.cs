using Basic_DSA_Phase_1.Basic_Problems;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Basic_DSA_Phase_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
            CountDigits countDigits = new CountDigits(number);
            int result = countDigits.CountDigitsInNumber();
            Console.WriteLine($"The number of digits in {number} is: {result}");

            number = 12345;
            ReverseNumber reverseNumber = new ReverseNumber(number);
            int reversedResult = reverseNumber.Reverse();
            Console.WriteLine($"The reverse of number {number} is {reversedResult}.");

            number = 123454321;
            Palindrome palindrome = new Palindrome(number);
            (bool, int) isPalindromeResult = palindrome.IsPalindrome();
            if (isPalindromeResult.Item1)
            {
                Console.WriteLine($"The reverse of {number} is {isPalindromeResult.Item2} and therefore it is palindrome number");
            }
            else
            {
                Console.WriteLine($"The reverse of number {number} is {isPalindromeResult.Item2} and therefore it is not palindrome");
            }

            number = 153;
            Armstrong armstrong = new Armstrong(number);
            (bool, int) isArmstrongResult = armstrong.IsArmstrong();
            if (isArmstrongResult.Item1)
            {
                Console.WriteLine($"The number {number} is an Armstrong number because the sum of the cubes of its digits is {isArmstrongResult.Item2}.");
            }
            else
            {
                Console.WriteLine($"The number {number} is not an Armstrong number because the sum of the cubes of its digits is {isArmstrongResult.Item2}.");

            }

            number = 36;
            Divisors divisors = new Divisors(number);
            List<int> divisorsResult = divisors.GetDivisors();
            Console.WriteLine($"The divisors of {number} are: {string.Join(", ", divisorsResult)}");

            number = 28;
            PrimeNumbers primeNumbers = new PrimeNumbers(number);
            bool isPrimeResult = primeNumbers.IsPrime();
            if (isPrimeResult)
            {
                Console.WriteLine($"The number {number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"The number {number} is not a prime number.");
                List<int> noPrimeDivisorsResult = primeNumbers.NoPrimeDivisors();
                Console.WriteLine($"The non-prime divisors of {number} are: {string.Join(", ", noPrimeDivisorsResult)}");
            }

        }
    }
}