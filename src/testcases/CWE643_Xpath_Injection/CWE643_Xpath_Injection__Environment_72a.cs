/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE643_Xpath_Injection__Environment_72a.cs
Label Definition File: CWE643_Xpath_Injection.label.xml
Template File: sources-sinks-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 643 Xpath Injection
 * BadSource: Environment Read data from an environment variable
 * GoodSource: A hardcoded string
 * Sinks:
 *    GoodSink: validate input through SecurityElement.Escape
 *    BadSink : user input is used without validate
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

using System.Web;

namespace testcases.CWE643_Xpath_Injection
{
class CWE643_Xpath_Injection__Environment_72a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string data;
        /* get environment variable ADD */
        /* POTENTIAL FLAW: Read data from an environment variable */
        data = Environment.GetEnvironmentVariable("ADD");
        Hashtable dataHashtable = new Hashtable(5);
        dataHashtable.Add(0, data);
        dataHashtable.Add(1, data);
        dataHashtable.Add(2, data);
        CWE643_Xpath_Injection__Environment_72b.BadSink(dataHashtable  );
    }
#endif //omitbad
#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    /* goodG2B() - use GoodSource and BadSink */
    private static void GoodG2B()
    {
        string data;
        /* FIX: Use a hardcoded string */
        data = "foo";
        Hashtable dataHashtable = new Hashtable(5);
        dataHashtable.Add(0, data);
        dataHashtable.Add(1, data);
        dataHashtable.Add(2, data);
        CWE643_Xpath_Injection__Environment_72b.GoodG2BSink(dataHashtable  );
    }

    /* goodB2G() - use BadSource and GoodSink */
    private static void GoodB2G()
    {
        string data;
        /* get environment variable ADD */
        /* POTENTIAL FLAW: Read data from an environment variable */
        data = Environment.GetEnvironmentVariable("ADD");
        Hashtable dataHashtable = new Hashtable(5);
        dataHashtable.Add(0, data);
        dataHashtable.Add(1, data);
        dataHashtable.Add(2, data);
        CWE643_Xpath_Injection__Environment_72b.GoodB2GSink(dataHashtable  );
    }
#endif //omitgood
}
}
