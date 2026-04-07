using Basic_DSA_Phase_1.Basic_Problems;
using Basic_DSA_Phase_1.Basic_Recursion;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Basic_DSA_Phase_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Basic Problems

            //int number = 12345;
            //CountDigits countDigits = new CountDigits(number);
            //int result = countDigits.CountDigitsInNumber();
            //Console.WriteLine($"The number of digits in {number} is: {result}");

            //number = 12345;
            //ReverseNumber reverseNumber = new ReverseNumber(number);
            //int reversedResult = reverseNumber.Reverse();
            //Console.WriteLine($"The reverse of number {number} is {reversedResult}.");

            //number = 123454321;
            //Palindrome palindrome = new Palindrome(number);
            //(bool, int) isPalindromeResult = palindrome.IsPalindrome();
            //if (isPalindromeResult.Item1)
            //{
            //    Console.WriteLine($"The reverse of {number} is {isPalindromeResult.Item2} and therefore it is palindrome number");
            //}
            //else
            //{
            //    Console.WriteLine($"The reverse of number {number} is {isPalindromeResult.Item2} and therefore it is not palindrome");
            //}

            //number = 153;
            //Armstrong armstrong = new Armstrong(number);
            //(bool, int) isArmstrongResult = armstrong.IsArmstrong();
            //if (isArmstrongResult.Item1)
            //{
            //    Console.WriteLine($"The number {number} is an Armstrong number because the sum of the cubes of its digits is {isArmstrongResult.Item2}.");
            //}
            //else
            //{
            //    Console.WriteLine($"The number {number} is not an Armstrong number because the sum of the cubes of its digits is {isArmstrongResult.Item2}.");

            //}

            //number = 36;
            //Divisors divisors = new Divisors(number);
            //List<int> divisorsResult = divisors.GetDivisors();
            //Console.WriteLine($"The divisors of {number} are: {string.Join(", ", divisorsResult)}");

            //number = 28;
            //PrimeNumbers primeNumbers = new PrimeNumbers(number);
            //bool isPrimeResult = primeNumbers.IsPrime();
            //if (isPrimeResult)
            //{
            //    Console.WriteLine($"The number {number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"The number {number} is not a prime number.");
            //    List<int> noPrimeDivisorsResult = primeNumbers.NoPrimeDivisors();
            //    Console.WriteLine($"The non-prime divisors of {number} are: {string.Join(", ", noPrimeDivisorsResult)}");
            //}
            //
            //GCD_Calculation gCD_Calculation = new GCD_Calculation(48, 23);
            //gCD_Calculation.GCDCalc();

            //Basic Recursion

            //something Something = new something();
            //Something.PrintSomething(5);

            //something Something1 = new something();
            //Something1.PrintSomething(5);
            //Console.WriteLine();

            //NameNTimes nameNTimes = new NameNTimes();
            //nameNTimes.PrintNameNTimes("John", 5);

            int n = Convert.ToInt32(Console.ReadLine());
            NTimes nTimes = new NTimes();
            //nTimes.Print1toNTimes(n);
            //nTimes.PrintnTo1Times(n);
            //int sumValue = nTimes.SumOfN(n);
            //Console.WriteLine($"The sum of {n} values is {sumValue}");

            //Console.WriteLine($"Factorial of {n} numbers is {nTimes.FactorialOfN(n)}"); 

            //Console.WriteLine($"Fibonacci Number for {n} numbers is {nTimes.FibonacciOfN(n)}");

            string[] Array = { "karthik", "sai", "teja", "reddy" };
            nTimes.ReverseArray(Array);
            nTimes.PalindromeCheck("karthik");
        }
    }
}






            //    int[] Array1 = { 0, 1, 2, 3, 4, 5 };
            //    for (int i = Array1.Length - 1; i >= 0; i--)
            //    {
            //        Console.WriteLine($"{Array1[i]} ");
            //    }
            //    Array1.Reverse();
            //    for (int i = 0; i < Array1.Length; i++)
            //    {
            //        Console.WriteLine($"{Array1[i]} ");
            //    }

            //    string str = "karthik";
            //    char[] charArray = str.ToCharArray();
            //    while(charArray.Length != 0)
            //    {
            //        if(charArray.Length == 1)
            //        {
            //            if(str == new string(charArray))
            //            {
            //                Console.WriteLine($"The string {str} is palindrome");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"The string {str} is not palindrome");
            //            }
            //        }
            //        charArray = charArray.Skip(1).Take(charArray.Length - 2).ToArray();
            //    }
            //}

            //Dictionary<int, int> memo = new Dictionary<int, int>();

            //public int Fibonacci(int n)
            //{
            //    if (n <= 1)
            //        return n;

            //    if (memo.ContainsKey(n))
            //        return memo[n];

            //    memo[n] = Fibonacci(n - 1) + Fibonacci(n - 2);

            //    return memo[n];
            //}