/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__Short_min_multiply_17.cs
Label Definition File: CWE191_Integer_Underflow.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 191 Integer Underflow
* BadSource: min Set data to the min value for short
* GoodSource: A hardcoded non-zero, non-min, non-max, even number
* Sinks: multiply
*    GoodSink: Ensure there will not be an underflow before multiplying data by 2
*    BadSink : If data is negative, multiply by 2, which can cause an underflow
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__Short_min_multiply_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        short data;
        /* We need to have one source outside of a for loop in order
         * to prevent the compiler from generating an error because
         * data is uninitialized
         */
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = short.MinValue;
        for (int j = 0; j < 1; j++)
        {
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* POTENTIAL FLAW: if (data * 2) < short.MinValue, this will underflow */
                short result = (short)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        short data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        for (int j = 0; j < 1; j++)
        {
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* POTENTIAL FLAW: if (data * 2) < short.MinValue, this will underflow */
                short result = (short)(data * 2);
                IO.WriteLine("result: " + result);
            }
        }
    }

    /* goodB2G() - use badsource and goodsink*/
    private void GoodB2G()
    {
        short data;
        /* POTENTIAL FLAW: Use the minimum size of the data type */
        data = short.MinValue;
        for (int k = 0; k < 1; k++)
        {
            if(data < 0) /* ensure we won't have an overflow */
            {
                /* FIX: Add a check to prevent an underflow from occurring */
                if (data > (short.MinValue/2))
                {
                    short result = (short)(data * 2);
                    IO.WriteLine("result: " + result);
                }
                else
                {
                    IO.WriteLine("data value is too small to perform multiplication.");
                }
            }
        }
    }

    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }
#endif //omitgood
}
}
