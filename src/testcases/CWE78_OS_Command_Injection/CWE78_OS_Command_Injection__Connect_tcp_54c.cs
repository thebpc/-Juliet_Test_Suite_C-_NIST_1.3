/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE78_OS_Command_Injection__Connect_tcp_54c.cs
Label Definition File: CWE78_OS_Command_Injection.label.xml
Template File: sources-sink-54c.tmpl.cs
*/
/*
 * @description
 * CWE: 78 OS Command Injection
 * BadSource: Connect_tcp Read data using an outbound tcp connection
 * GoodSource: A hardcoded string
 * Sinks: exec
 *    BadSink : dynamic command execution with Runtime.getRuntime().exec()
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE78_OS_Command_Injection
{
class CWE78_OS_Command_Injection__Connect_tcp_54c
{
#if (!OMITBAD)
    public static void BadSink(string data )
    {
        CWE78_OS_Command_Injection__Connect_tcp_54d.BadSink(data );
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(string data )
    {
        CWE78_OS_Command_Injection__Connect_tcp_54d.GoodG2BSink(data );
    }
#endif
}
}
