/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE81_XSS_Error_Message__Web_ReadLine_71a.cs
Label Definition File: CWE81_XSS_Error_Message__Web.label.xml
Template File: sources-sink-71a.tmpl.cs
*/
/*
 * @description
 * CWE: 81 Cross Site Scripting (XSS) in Error Message
 * BadSource: ReadLine Read data from the console using ReadLine()
 * GoodSource: A hardcoded string
 * Sinks: ErrorStatusCode
 *    BadSink : XSS in StatusCode
 * Flow Variant: 71 Data flow: data passed as an Object reference argument from one method to another in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;

namespace testcases.CWE81_XSS_Error_Message
{

class CWE81_XSS_Error_Message__Web_ReadLine_71a : AbstractTestCaseWeb
{
#if (!OMITBAD)
    public override void Bad(HttpRequest req, HttpResponse resp)
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
        CWE81_XSS_Error_Message__Web_ReadLine_71b.BadSink((Object)data , req, resp );
    }
#endif //omitbad
#if (!OMITGOOD)
    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
    }

    /* goodG2B() - use goodsource and badsink */
    private static void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        CWE81_XSS_Error_Message__Web_ReadLine_71b.GoodG2BSink((Object)data , req, resp );
    }
#endif //omitgood
}
}
