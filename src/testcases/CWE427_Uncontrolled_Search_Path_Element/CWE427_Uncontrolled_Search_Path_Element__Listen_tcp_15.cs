/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE427_Uncontrolled_Search_Path_Element__Listen_tcp_15.cs
Label Definition File: CWE427_Uncontrolled_Search_Path_Element.label.xml
Template File: sources-sink-15.tmpl.cs
*/
/*
* @description
* CWE: 427 Uncontrolled Search Path Element
* BadSource: Listen_tcp Read data using a listening tcp connection
* GoodSource: Use a hardcoded path
* BadSink: Environment
* Flow Variant: 15 Control flow: switch(6)
*
* */

using TestCaseSupport;
using System;

using System.Web;
using System.Runtime.InteropServices;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE427_Uncontrolled_Search_Path_Element
{

class CWE427_Uncontrolled_Search_Path_Element__Listen_tcp_15 : AbstractTestCase
{
#if (!OMITBAD)
    /* uses badsource and badsink */
    public override void Bad()
    {
        string data = null;
        switch (6)
        {
        case 6:
            data = ""; /* Initialize data */
            /* Read data using a listening tcp connection */
            {
                TcpListener listener = null;
                try
                {
                    listener = new TcpListener(IPAddress.Parse("10.10.1.10"), 39543);
                    listener.Start();
                    using (TcpClient tcpConn = listener.AcceptTcpClient())
                    {
                        /* read input from socket */
                        using (StreamReader sr = new StreamReader(tcpConn.GetStream()))
                        {
                            /* POTENTIAL FLAW: Read data using a listening tcp connection */
                            data = sr.ReadLine();
                        }
                    }
                }
                catch (IOException exceptIO)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
                }
                finally
                {
                    if (listener != null)
                    {
                        try
                        {
                            listener.Stop();
                        }
                        catch(SocketException se)
                        {
                            IO.Logger.Log(NLog.LogLevel.Warn, se, "Error closing TcpListener");
                        }
                    }
                }
            }
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        /* POTENTIAL FLAW: Set a new environment variable with a path that is possibly insecure */
        Environment.SetEnvironmentVariable("PATH", data);
    }
#endif //omitbad
#if (!OMITGOOD)
    /* goodG2B1() - use goodsource and badsink by changing the  switch to switch(5) */
    private void GoodG2B1()
    {
        string data = null;
        switch (5)
        {
        case 6:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        default:
            /* FIX: Set the path as the "system" path */
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                data = "/bin";
            }
            else
            {
                data = "%SystemRoot%\\system32";
            }
            break;
        }
        /* POTENTIAL FLAW: Set a new environment variable with a path that is possibly insecure */
        Environment.SetEnvironmentVariable("PATH", data);
    }

    /* GoodG2B2() - use goodsource and badsink by reversing the blocks in the switch  */
    private void GoodG2B2()
    {
        string data = null;
        switch (6)
        {
        case 6:
            /* FIX: Set the path as the "system" path */
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                data = "/bin";
            }
            else
            {
                data = "%SystemRoot%\\system32";
            }
            break;
        default:
            /* INCIDENTAL: CWE 561 Dead Code, the code below will never run
             * but ensure data is inititialized before the Sink to avoid compiler errors */
            data = null;
            break;
        }
        /* POTENTIAL FLAW: Set a new environment variable with a path that is possibly insecure */
        Environment.SetEnvironmentVariable("PATH", data);
    }

    public override void Good()
    {
        GoodG2B1();
        GoodG2B2();
    }
#endif //omitgood
}
}
