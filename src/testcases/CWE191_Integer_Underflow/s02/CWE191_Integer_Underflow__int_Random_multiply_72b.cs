/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE191_Integer_Underflow__int_Random_multiply_72b.cs
Label Definition File: CWE191_Integer_Underflow__int.label.xml
Template File: sources-sinks-72b.tmpl.cs
*/
/*
 * @description
 * CWE: 191 Integer Underflow
 * BadSource: Random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: multiply
 *    GoodSink: Ensure there will not be an underflow before multiplying data by 2
 *    BadSink : If data is negative, multiply by 2, which can cause an underflow
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System;
using System.Collections;

using System.Web;

namespace testcases.CWE191_Integer_Underflow
{
class CWE191_Integer_Underflow__int_Random_multiply_72b
{
#if (!OMITBAD)
    public static void BadSink(Hashtable dataHashtable )
    {
        int data = (int) dataHashtable[2];
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < int.MinValue, this will underflow */
            int result = (int)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use GoodSource and BadSink */
    public static void GoodG2BSink(Hashtable dataHashtable )
    {
        int data = (int) dataHashtable[2];
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* POTENTIAL FLAW: if (data * 2) < int.MinValue, this will underflow */
            int result = (int)(data * 2);
            IO.WriteLine("result: " + result);
        }
    }

    /* goodB2G() - use BadSource and GoodSink */
    public static void GoodB2GSink(Hashtable dataHashtable )
    {
        int data = (int) dataHashtable[2];
        if(data < 0) /* ensure we won't have an overflow */
        {
            /* FIX: Add a check to prevent an underflow from occurring */
            if (data > (int.MinValue/2))
            {
                int result = (int)(data * 2);
                IO.WriteLine("result: " + result);
            }
            else
            {
                IO.WriteLine("data value is too small to perform multiplication.");
            }
        }
    }
#endif
}
}
