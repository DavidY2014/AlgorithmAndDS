using System;

namespace CommonAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //new Solution().IsAnagram("anagram", "nagaram");
            //var ret = new Solution().IsAnagram("ab", "a");
            //var ret = new Solution().IsAnagram("aacc", "ccac");
            var ret = new Solution().IsValid("}");
            if (ret)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
