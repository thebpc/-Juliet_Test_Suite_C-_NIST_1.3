/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE23_Relative_Path_Traversal__Connect_tcp_54c.cs
Label Definition File: CWE23_Relative_Path_Traversal.label.xml
Template File: sources-sink-54c.tmpl.cs
*/
/*
 * @description
 * CWE: 23 Relative Path Traversal
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks: readFile
 *    BadSink : no validation
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE23_Relative_Path_Traversal
{
class CWE23_Relative_Path_Traversal__Connect_tcp_54c
{
#if (!OMITBAD)
    public static void BadSink(string data )
    {
        CWE23_Relative_Path_Traversal__Connect_tcp_54d.BadSink(data );
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(string data )
    {
        CWE23_Relative_Path_Traversal__Connect_tcp_54d.GoodG2BSink(data );
    }
#endif
}
}
