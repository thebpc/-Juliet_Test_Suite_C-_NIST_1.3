/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__double_large_to_long_31.cs
Label Definition File: CWE197_Numeric_Truncation_Error__double.label.xml
Template File: sources-sink-31.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than float.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_long
 *    BadSink : Convert data to a long
 * Flow Variant: 31 Data flow: make a copy of data within the same method
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__double_large_to_long_31 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        double dataCopy;
        {
            double data;
            /* FLAW: Use a number larger than long.MaxValue */
            data = float.MaxValue + 5;
            dataCopy = data;
        }
        {
            double data = dataCopy;
            {
                /* POTENTIAL FLAW: Convert data to a long, possibly causing a truncation error */
                IO.WriteLine((long)data);
            }
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        double dataCopy;
        {
            double data;
            /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
            data = 2;
            dataCopy = data;
        }
        {
            double data = dataCopy;
            {
                /* POTENTIAL FLAW: Convert data to a long, possibly causing a truncation error */
                IO.WriteLine((long)data);
            }
        }
    }
#endif //omitgood
}
}
