/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE427_Uncontrolled_Search_Path_Element__ReadLine_17.cs
Label Definition File: CWE427_Uncontrolled_Search_Path_Element.label.xml
Template File: sources-sink-17.tmpl.cs
*/
/*
* @description
* CWE: 427 Uncontrolled Search Path Element
* BadSource: ReadLine Read data from the console using ReadLine()
* GoodSource: Use a hardcoded path
* BadSink: Environment
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.Runtime.InteropServices;

using System.IO;

namespace testcases.CWE427_Uncontrolled_Search_Path_Element
{

class CWE427_Uncontrolled_Search_Path_Element__ReadLine_17 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        string data;
        data = ""; /* Initialize data */
        {
            /* read user input from console with ReadLine */
            try
            {
                /* POTENTIAL FLAW: Read data from the console using ReadLine */
                data = Console.ReadLine();
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
        }
        for (int i = 0; i < 1; i++)
        {
            /* POTENTIAL FLAW: Set a new environment variable with a path that is possibly insecure */
            Environment.SetEnvironmentVariable("PATH", data);
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink by reversing the block outside the
     * for statement with the one in the for statement */
    private void GoodG2B()
    {
        string data;
        /* FIX: Set the path as the "system" path */
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            data = "/bin";
        }
        else
        {
            data = "%SystemRoot%\\system32";
        }
        for (int i = 0; i < 1; i++)
        {
            /* POTENTIAL FLAW: Set a new environment variable with a path that is possibly insecure */
            Environment.SetEnvironmentVariable("PATH", data);
        }
    }

    public override void Good()
    {
        GoodG2B();
    }
#endif //omitgood
}
}
