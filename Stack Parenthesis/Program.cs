using System;

namespace Stack_Parenthesis
{

    //Class to create test data for Matching Parenthesis Assignment 
    public class TestData
    {
        private int _testCaseNum;
        private static int NumTestCases = 15;     //Number of test cases
        private static char[] test0 = new[] { '{', '[', '(', ')', ']', '}' };  //Good
        private static char[] test1 = new[] { '{', '[', '(', ')', ']', ']' };  //Bad
        private static char[] test2 = new[] { '{', '[', '(', ')', ']' };       //Bad
        private static char[] test3 = new[] { '{', '(', ')', '}', '{', '}' };  //Good
        private static char[] test4 = new[] { '{', '[', '(', ')', '(', ')', ']', '}' };   //Good
        private static char[] test5 = new[] { '{', '[', '(', ')', '(', ')', ')', '}' };   //Bad
        private static char[] test6 = new[] { '{', '[', '(', ')', '(', ')', ']', '}', '}' };   //Bad
        private static char[] test7 = new[] { '{', '(', ')', '}', '[', ']' };  //Good
        private static char[] test8 = new[] { '{', '[', '(' };  //Bad
        private static char[] test9 = new[] { ')', ']', '}' };  //Bad
        private static char[] test10 = new[] { '{' };  //Bad
        private static char[] test11 = new[] { ']' };  //Bad
        private static char[] test12 = new[] { '{', '}' };  //Good
        private static char[] test13 = new[] { '(', ']' };  //Bad
        private static char[] test14 = new[] { '(', '[', ')', ']' };  //Bad

        private char[][] testCasePtr = new[] { test0, test1, test2, test3, test4, test5, test6, test7, test8,
                                                test9, test10, test11, test12, test13, test14 };

        public TestData()
        {
            _testCaseNum = 0;
        }

        public char[] GetTestData()
        {
            char[] rv = null;

            if (_testCaseNum < NumTestCases)
            {
                rv = testCasePtr[_testCaseNum];
                _testCaseNum++;
            }

            return rv;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            //Test Data
            TestData testData = new TestData();
            char[] testP;

            while (true)
            {
                testP = testData.GetTestData();  //Get next string to test
                if (testP == null) break;        //No more test data, so exit

                //Print string
                for (int i = 0; i < testP.Length; i++)
                {
                    Console.Write(testP[i]);
                }

                //Determine if String is Good or Bad and print results


                //Print newline
                Console.WriteLine();
            }
            //Done - So Pause to see output
            Console.ReadKey();
        }
    }
}
