/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE690_NULL_Deref_From_Return__Class_StringBuilder_53a.cs
Label Definition File: CWE690_NULL_Deref_From_Return__Class.label.xml
Template File: sources-sinks-53a.tmpl.cs
*/
/*
 * @description
 * CWE: 690 Unchecked return value is null, leading to a null pointer dereference.
 * BadSource:  Use a custom method which may return null
 * GoodSource: Use a custom method that never returns null
 * Sinks: trim
 *    GoodSink: Check data for null before calling trim()
 *    BadSink : Call trim() on possibly null object
 * Flow Variant: 53 Data flow: data passed as an argument from one method through two others to a fourth; all four functions are in different classes in the same package
 *
 * */

using TestCaseSupport;
using System;

using System.Text;

namespace testcases.CWE690_NULL_Deref_From_Return
{
class CWE690_NULL_Deref_From_Return__Class_StringBuilder_53a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        StringBuilder data;
        /* POTENTIAL FLAW: Call getStringBuilderBad(), which may return null */
        data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringBuilderBad();
        CWE690_NULL_Deref_From_Return__Class_StringBuilder_53b.BadSink(data );
    }
#endif //omitbad
#if (!OMITGOOD)
    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }

    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        StringBuilder data;
        /* FIX: call getStringBuilderGood(), which will never return null */
        data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringBuilderGood();
        CWE690_NULL_Deref_From_Return__Class_StringBuilder_53b.GoodG2BSink(data );
    }

    /* goodB2G() - use badsource and goodsink */
    private void GoodB2G()
    {
        StringBuilder data;
        /* POTENTIAL FLAW: Call getStringBuilderBad(), which may return null */
        data = CWE690_NULL_Deref_From_Return__Class_Helper.getStringBuilderBad();
        CWE690_NULL_Deref_From_Return__Class_StringBuilder_53b.GoodB2GSink(data );
    }
#endif //omitgood
}
}
