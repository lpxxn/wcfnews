using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string pattern = @"^[0-9\-\s\(\)]*$";
            
            Regex regex = new Regex(pattern);
            
            const string inputData = @"010-122301dfg1";
            bool isMatch = regex.IsMatch(inputData);

            //"传真格式为:XXX-12345678或1234567"
        }
    }
}
