using System;
using System.Numerics;

namespace Exercise02
{
    public class Class1
    {
        //Dynamic definition
        public static string IntegerValue;
        public static string DecribedValue;

        //Strong type definitions
        public static string Strong_Input_value;
        public static string One_Million_Val = "1000000";
        public static string One_million = "One million";
        public static string Two_million_Val = "2000000";
        public static string Two_million = "Two million";

        public void DescribeValue()
        {
            //Describe integer
            BigInteger _describeValue = BigInteger.Pow(Convert.ToInt64(IntegerValue), 3);
            DecribedValue = _describeValue.ToString();
        }
    }
}
