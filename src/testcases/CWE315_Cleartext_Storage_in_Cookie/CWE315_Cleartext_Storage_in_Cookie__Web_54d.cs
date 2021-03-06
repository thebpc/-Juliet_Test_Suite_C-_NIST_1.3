/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE315_Cleartext_Storage_in_Cookie__Web_54d.cs
Label Definition File: CWE315_Cleartext_Storage_in_Cookie__Web.label.xml
Template File: sources-sinks-54d.tmpl.cs
*/
/*
 * @description
 * CWE: 315 Cleartext storage of data in a cookie
 * BadSource:  Set data to credentials (without hashing or encryption)
 * GoodSource: Set data to a hash of credentials
 * Sinks:
 *    GoodSink: Hash data before storing in cookie
 *    BadSink : Store data directly in cookie
 * Flow Variant: 54 Data flow: data passed as an argument from one method through three others to a fifth; all five functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace testcases.CWE315_Cleartext_Storage_in_Cookie
{
class CWE315_Cleartext_Storage_in_Cookie__Web_54d
{
#if (!OMITBAD)
    public static void BadSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE315_Cleartext_Storage_in_Cookie__Web_54e.BadSink(data , req, resp);
    }
#endif

#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    public static void GoodG2BSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE315_Cleartext_Storage_in_Cookie__Web_54e.GoodG2BSink(data , req, resp);
    }

    /* goodB2G() - use badsource and goodsink */
    public static void GoodB2GSink(string data , HttpRequest req, HttpResponse resp)
    {
        CWE315_Cleartext_Storage_in_Cookie__Web_54e.GoodB2GSink(data , req, resp);
    }
#endif
}
}
