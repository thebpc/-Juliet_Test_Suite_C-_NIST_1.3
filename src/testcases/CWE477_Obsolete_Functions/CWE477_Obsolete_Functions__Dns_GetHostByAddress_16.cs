/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE477_Obsolete_Functions__Dns_GetHostByAddress_16.cs
Label Definition File: CWE477_Obsolete_Functions.label.xml
Template File: point-flaw-16.tmpl.cs
*/
/*
* @description
* CWE: 477 Use of Obsolete Functions
* Sinks: Dns_GetHostByAddress
*    GoodSink: Use of preferred System.Net.Dns.GetHostEntry() method
*    BadSink : Use of deprecated System.Net.Dns.GetHostByAddress() method
* Flow Variant: 16 Control flow: while(true)
*
* */

using TestCaseSupport;
using System;

using System.Net;

namespace testcases.CWE477_Obsolete_Functions
{
class CWE477_Obsolete_Functions__Dns_GetHostByAddress_16 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        while(true)
        {
            IPAddress hostIPAddress = IPAddress.Parse("8.8.8.8");
            /* FLAW: Use of deprecated Dns.GetHostByAddress() method */
            IPHostEntry hostInfo = Dns.GetHostByAddress(hostIPAddress);
            IO.WriteLine("Host name : " + hostInfo.HostName);
            break;
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* Good1() change the conditions on the while statements */
    private void Good1()
    {
        while(true)
        {
            IPAddress hostIPAddress = IPAddress.Parse("8.8.8.8");
            /* FIX: Use preferred Dns.GetHostEntry() method */
            IPHostEntry hostInfo = Dns.GetHostEntry(hostIPAddress);
            IO.WriteLine("Host name : " + hostInfo.HostName);
            break;
        }
    }

    public override void Good()
    {
        Good1();
    }
#endif //omitgood
}
}
