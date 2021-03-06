/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE197_Numeric_Truncation_Error__long_large_to_int_67a.cs
Label Definition File: CWE197_Numeric_Truncation_Error__long.label.xml
Template File: sources-sink-67a.tmpl.cs
*/
/*
 * @description
 * CWE: 197 Numeric Truncation Error
 * BadSource: large Set data to a number larger than int.MaxValue
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: to_int
 *    BadSink : Convert data to a int
 * Flow Variant: 67 Data flow: data passed in a class from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;

namespace testcases.CWE197_Numeric_Truncation_Error
{

class CWE197_Numeric_Truncation_Error__long_large_to_int_67a : AbstractTestCase
{

    public class Container
    {
        public long containerOne;
    }
#if (!OMITBAD)
    public override void Bad()
    {
        long data;
        /* FLAW: Use a number larger than int.MaxValue */
        data = int.MaxValue + 5L;
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE197_Numeric_Truncation_Error__long_large_to_int_67b.BadSink(dataContainer  );
    }
#endif //omitbad
#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B()
    {
        long data;
        /* FIX: Use a hardcoded number that won't cause underflow, overflow, divide by zero, or loss-of-precision issues */
        data = 2;
        Container dataContainer = new Container();
        dataContainer.containerOne = data;
        CWE197_Numeric_Truncation_Error__long_large_to_int_67b.GoodG2BSink(dataContainer  );
    }
#endif //omitgood
}
}
