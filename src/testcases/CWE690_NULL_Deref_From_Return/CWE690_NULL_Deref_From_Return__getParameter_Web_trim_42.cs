/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__getParameter_Web_trim_42.cs
Label Definition File: CWE690_NULL_Deref_From_Return.label.xml
Template File: sources-sinks-42.tmpl.cs
*/
/*
 * @description
 * CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
 * BadSource: getParameter_Web Set data to return of getParameter_Web
 * GoodSource: Set data to fixed, non-null String
 * Sinks: trim
 *    GoodSink: Check data for null before calling trim()
 *    BadSink : Call trim() on possibly null object
 * Flow Variant: 42 Data flow: data returned from one method to another in the same class
 *
 * */

using TestCaseSupport;
using System;

using System.Web;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__getParameter_Web_trim_42 : AbstractTestCaseWeb
{
#if (!OMITBAD)
    private static string BadSource(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: data may be set to null */
        data = req.QueryString["CWE690"];
        return data;
    }

    public override void Bad(HttpRequest req, HttpResponse resp)
    {
        string data = BadSource(req, resp);
        /* POTENTIAL FLAW: data could be null */
        string stringTrimmed = data.Trim();
        IO.WriteLine(stringTrimmed);
    }
#endif //omitbad
#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    private static string GoodG2BSource(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* FIX: Set data to a fixed, non-null String */
        data = "CWE690";
        return data;
    }

    private static void GoodG2B(HttpRequest req, HttpResponse resp)
    {
        string data = GoodG2BSource(req, resp);
        /* POTENTIAL FLAW: data could be null */
        string stringTrimmed = data.Trim();
        IO.WriteLine(stringTrimmed);
    }

    /* goodB2G() - use badsource and goodsink */
    private static string GoodB2GSource(HttpRequest req, HttpResponse resp)
    {
        string data;
        /* POTENTIAL FLAW: data may be set to null */
        data = req.QueryString["CWE690"];
        return data;
    }

    private static void GoodB2G(HttpRequest req, HttpResponse resp)
    {
        string data = GoodB2GSource(req, resp);
        /* FIX: explicit check for null */
        if (data != null)
        {
            string stringTrimmed = data.Trim();
            IO.WriteLine(stringTrimmed);
        }
    }

    public override void Good(HttpRequest req, HttpResponse resp)
    {
        GoodG2B(req, resp);
        GoodB2G(req, resp);
    }
#endif //omitgood
}
}
