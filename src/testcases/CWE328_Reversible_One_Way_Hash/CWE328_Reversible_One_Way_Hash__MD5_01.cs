/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE328_Reversible_One_Way_Hash__MD5_01.cs
Label Definition File: CWE328_Reversible_One_Way_Hash.label.xml
Template File: point-flaw-01.tmpl.cs
*/
/*
* @description
* CWE: 328 Reversible One Way Hash
* Sinks: MD5
*    GoodSink: SHA512
*    BadSink : MD5
* Flow Variant: 01 Baseline
*
* */

using TestCaseSupport;
using System;

using System.Text;
using System.Security.Cryptography;

namespace testcases.CWE328_Reversible_One_Way_Hash
{
class CWE328_Reversible_One_Way_Hash__MD5_01 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        using (HashAlgorithm md5 = new MD5CryptoServiceProvider())
        {
            /* FLAW: Insecure cryptographic hashing algorithm (MD5) */
            byte[] textWithUTF8 = Encoding.UTF8.GetBytes("Test Input"); /* INCIDENTAL FLAW: Hard-coded input to hash algorithm */
            byte[] textWithReversibleHash = md5.ComputeHash(textWithUTF8);
            IO.WriteLine(IO.ToHex(textWithReversibleHash));
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    public override void Good()
    {
        Good1();
    }

    private void Good1()
    {
        using (HashAlgorithm sha512 = new SHA512CryptoServiceProvider())
        {
            /* FIX: Secure cryptographic hashing algorithm (SHA-512) */
            byte[] textWithUTF8 = Encoding.UTF8.GetBytes("Test Input"); /* INCIDENTAL FLAW: Hard-coded input to hash algorithm */
            byte[] textWithReversibleHash = sha512.ComputeHash(textWithUTF8);
            IO.WriteLine(IO.ToHex(textWithReversibleHash));
        }
    }
#endif //omitgood
}
}
