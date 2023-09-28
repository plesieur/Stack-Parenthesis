using System;

namespace Stack_Parenthesis
{

    //Class to create test data for Matching Parenthesis Assignment 
    public class TestData 
    {
        private int _testCaseNum;
        private static int NumTestCases = 6;
        private static string test0 = "1+2*3";      //7
        private static string test1 = "1*2+3";      //5
        private static string test2 = "1+2*3+4";    //11
        private static string test3 = "1*2+3*4";    //14
        private static string test4 = "12*2+100/4"; //49
        private static string test5 = "12*2-100/4"; //-1

                                
        private string[] testCasePtr = new[] { test0, test1, test2, test3, test4, test5 }; 
        public TestData()
        {
            _testCaseNum = 0;
        }

        public string GetTestData()
        {
            string rv = null;

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
            string testP;

            while (true)
            {
                testP = testData.GetTestData();  //Get next string to test
                if (testP == null) break;        //No more test data, so exit

                //Print string
                for (int i = 0; i < testP.Length; i++)
                {
                    Console.Write(testP[i]);
                }

                //Evaluate String and Print result


                //Print newline
                Console.WriteLine();
            }
            //Done - So Pause to see output
            Console.ReadKey();
        }
    }
}
