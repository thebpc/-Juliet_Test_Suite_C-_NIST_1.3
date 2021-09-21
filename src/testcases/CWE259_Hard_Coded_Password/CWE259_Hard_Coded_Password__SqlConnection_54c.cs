/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE259_Hard_Coded_Password__SqlConnection_54c.cs
Label Definition File: CWE259_Hard_Coded_Password.label.xml
Template File: sources-sink-54c.tmpl.cs
*/
/*
 * @description
 * CWE: 259 Hard Coded Password
 * BadSource: hardcodedPassword Set data to a hardcoded string
 * GoodSource: Read data from the console using readLine()
 * Sinks: SqlConnection
 *    BadSink : data used as password in database connection
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.IO;

namespace testcases.CWE259_Hard_Coded_Password
{
class CWE259_Hard_Coded_Password__SqlConnection_54c
{
#if (!OMITBAD)
    public static void BadSink(string data )
    {
        CWE259_Hard_Coded_Password__SqlConnection_54d.BadSink(data );
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(string data )
    {
        CWE259_Hard_Coded_Password__SqlConnection_54d.GoodG2BSink(data );
    }
#endif
}
}
