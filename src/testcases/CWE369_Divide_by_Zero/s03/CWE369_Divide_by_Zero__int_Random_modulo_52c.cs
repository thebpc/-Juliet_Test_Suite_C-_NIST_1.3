/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__int_Random_modulo_52c.cs
Label Definition File: CWE369_Divide_by_Zero__int.label.xml
Template File: sources-sinks-52c.tmpl.cs
*/
/*
 * @description
 * CWE: 369 Divide by zero
 * BadSource: Random Set data to a random value
 * GoodSource: A hardcoded non-zero, non-min, non-max, even number
 * Sinks: modulo
 *    GoodSink: Check for zero before modulo
 *    BadSink : Modulo by a value that may be zero
 * Flow Variant: 52 Data flow: data passed as an argument from one method to another to another in three different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__int_Random_modulo_52c
{
#if (!OMITBAD)
    public static void BadSink(int data )
    {
        /* POTENTIAL FLAW: Zero modulus will cause an issue.  An integer division will
        result in an exception.  */
        IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(int data )
    {
        /* POTENTIAL FLAW: Zero modulus will cause an issue.  An integer division will
        result in an exception.  */
        IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink(int data )
    {
        /* FIX: test for a zero modulus */
        if (data != 0)
        {
            IO.WriteLine("100%" + data + " = " + (100 % data) + "\n");
        }
        else
        {
            IO.WriteLine("This would result in a modulo by zero");
        }
    }
#endif
}
}
