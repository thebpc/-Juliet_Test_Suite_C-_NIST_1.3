/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE83_XSS_Attribute__Web_Params_Get_Web_22b.cs
Label Definition File: CWE83_XSS_Attribute__Web.label.xml
Template File: sources-sink-22b.tmpl.cs
*/
/*
 * @description
 * CWE: 83 Cross Site Scripting (XSS) in attributes; Examples(replace QUOTE with an actual double quote): ?img_loc=http://www.google.comQUOTE%20onerror=QUOTEalert(1) and ?img_loc=http://www.google.comQUOTE%20onerror=QUOTEjavascript:alert(1)
 * BadSource: Params_Get_Web Read data from a querystring using Params.Get()
 * GoodSource: A hardcoded string
 * Sinks: Write
 *    BadSink : XSS in img src attribute
 * Flow Variant: 22 Control flow: Flow controlled by value of a public static variable. Sink functions are in a separate file from sources.
 *
 * */

using TestCaseSupport;
using System;

using System.Web;


namespace testcases.CWE83_XSS_Attribute
{

class CWE83_XSS_Attribute__Web_Params_Get_Web_22b
{
#if (!OMITBAD)
    public static string BadSource(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (CWE83_XSS_Attribute__Web_Params_Get_Web_22a.badPublicStatic)
        {
            /* POTENTIAL FLAW: Read data from a querystring using Params.Get */
            data = req.Params.Get("name");
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        return data;
    }
#endif

#if (!OMITGOOD)
    /* goodG2B1() - use goodsource and badsink by setting the static variable to false instead of true */
    public static string GoodG2B1Source(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (CWE83_XSS_Attribute__Web_Params_Get_Web_22a.goodG2B1PublicStatic)
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        else
        {
            /* FIX: Use a hardcoded string */
            data = "foo";
        }
        return data;
    }

    /* GoodG2B2() - use goodsource and badsink by reversing the blocks in the if in the sink function */
    public static string GoodG2B2Source(HttpRequest req, HttpResponse resp)
    {
        string data;
        if (CWE83_XSS_Attribute__Web_Params_Get_Web_22a.GoodG2B2PublicStatic)
        {
            /* FIX: Use a hardcoded string */
            data = "foo";
        }
        else
        {
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
        }
        return data;
    }
#endif
}
}
