/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE369_Divide_by_Zero__float_listen_tcp_divide_17.cs
Label Definition File: CWE369_Divide_by_Zero__float.label.xml
Template File: sources-sinks-17.tmpl.cs
*/
/*
* @description
* CWE: 369 Divide by zero
* BadSource: listen_tcp Read data using a listening tcp connection
* GoodSource: A hardcoded non-zero number (two)
* Sinks: divide
*    GoodSink: Check for zero before dividing
*    BadSink : Dividing by a value that may be zero
* Flow Variant: 17 Control flow: for loops
*
* */

using TestCaseSupport;
using System;

using System.Web;

using System.IO;
using System.Net.Sockets;
using System.Net;

namespace testcases.CWE369_Divide_by_Zero
{
class CWE369_Divide_by_Zero__float_listen_tcp_divide_17 : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        float data;
        /* We need to have one source outside of a for loop in order
         * to prevent the compiler from generating an error because
         * data is uninitialized
         */
        data = -1.0f; /* Initialize data */
        /* Read data using a listening tcp connection */
        {
            TcpListener listener = null;
            /* Read data using a listening tcp connection */
            try
            {
                listener = new TcpListener(IPAddress.Parse("10.10.1.10"), 39543);
                using (TcpClient tcpConn = listener.AcceptTcpClient())
                {
                    /* read input from socket */
                    using (StreamReader sr = new StreamReader(tcpConn.GetStream()))
                    {
                        /* POTENTIAL FLAW: Read data using a listening tcp connection */
                        string stringNumber = sr.ReadLine();
                        if (stringNumber != null) // avoid NPD incidental warnings
                        {
                            try
                            {
                                data = int.Parse(stringNumber.Trim());
                            }
                            catch(FormatException exceptNumberFormat)
                            {
                                IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
                            }
                        }
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
            finally
            {
                try
                {
                    listener.Stop();
                }
                catch (SocketException se)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, se, "Problem closing socket");
                }
            }
        }
        for (int j = 0; j < 1; j++)
        {
            /* POTENTIAL FLAW: Possibly divide by zero */
            int result = (int)(100.0 / data);
            IO.WriteLine(result);
        }
    }
#endif //omitbad
#if (!OMITGOOD)
    /* goodG2B() - use goodsource and badsink */
    private void GoodG2B()
    {
        float data;
        /* FIX: Use a hardcoded number that won't a divide by zero */
        data = 2.0f;
        for (int j = 0; j < 1; j++)
        {
            /* POTENTIAL FLAW: Possibly divide by zero */
            int result = (int)(100.0 / data);
            IO.WriteLine(result);
        }
    }

    /* goodB2G() - use badsource and goodsink*/
    private void GoodB2G()
    {
        float data;
        data = -1.0f; /* Initialize data */
        /* Read data using a listening tcp connection */
        {
            TcpListener listener = null;
            /* Read data using a listening tcp connection */
            try
            {
                listener = new TcpListener(IPAddress.Parse("10.10.1.10"), 39543);
                using (TcpClient tcpConn = listener.AcceptTcpClient())
                {
                    /* read input from socket */
                    using (StreamReader sr = new StreamReader(tcpConn.GetStream()))
                    {
                        /* POTENTIAL FLAW: Read data using a listening tcp connection */
                        string stringNumber = sr.ReadLine();
                        if (stringNumber != null) // avoid NPD incidental warnings
                        {
                            try
                            {
                                data = int.Parse(stringNumber.Trim());
                            }
                            catch(FormatException exceptNumberFormat)
                            {
                                IO.Logger.Log(NLog.LogLevel.Warn, exceptNumberFormat, "Number format exception parsing data from string");
                            }
                        }
                    }
                }
            }
            catch (IOException exceptIO)
            {
                IO.Logger.Log(NLog.LogLevel.Warn, exceptIO, "Error with stream reading");
            }
            finally
            {
                try
                {
                    listener.Stop();
                }
                catch (SocketException se)
                {
                    IO.Logger.Log(NLog.LogLevel.Warn, se, "Problem closing socket");
                }
            }
        }
        for (int k = 0; k < 1; k++)
        {
            /* FIX: Check for value of or near zero before dividing */
            if (Math.Abs(data) > 0.000001)
            {
                int result = (int)(100.0 / data);
                IO.WriteLine(result);
            }
            else
            {
                IO.WriteLine("This would result in a divide by zero");
            }
        }
    }

    public override void Good()
    {
        GoodG2B();
        GoodB2G();
    }
#endif //omitgood
}
}
