/* TEMPLATE GENERATED TESTCASE FILE
Filename: CWE256_Unprotected_Storage_of_Credentials__basic_72a.cs
Label Definition File: CWE256_Unprotected_Storage_of_Credentials__basic.label.xml
Template File: sources-sinks-72a.tmpl.cs
*/
/*
 * @description
 * CWE: 256 Unprotected Storage of Credentials
 * BadSource:  Read password from a .txt file
 * GoodSource: Read password from a .txt file (from the property named password) and then decrypt it
 * Sinks:
 *    GoodSink: Decrypt password and use decrypted password as password to connect to DB
 *    BadSink : Use password as password to connect to DB
 * Flow Variant: 72 Data flow: data passed in a Hashtable from one method to another in different source files in the same package
 *
 * */

using TestCaseSupport;
using System.Collections;
using System;

using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace testcases.CWE256_Unprotected_Storage_of_Credentials
{
class CWE256_Unprotected_Storage_of_Credentials__basic_72a : AbstractTestCase
{
#if (!OMITBAD)
    public override void Bad()
    {
        string password;
        password = ""; /* init password */
        /* retrieve the password */
        try
        {
            password = Encoding.UTF8.GetString(File.ReadAllBytes("../../../common/strong_password_file.txt"));
        }
        catch (IOException exceptIO)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "Error with file reading", exceptIO);
        }
        /* POTENTIAL FLAW: The raw password read from the .txt file is passed on (without being decrypted) */
        Hashtable passwordHashtable = new Hashtable(5);
        passwordHashtable.Add(0, password);
        passwordHashtable.Add(1, password);
        passwordHashtable.Add(2, password);
        CWE256_Unprotected_Storage_of_Credentials__basic_72b.BadSink(passwordHashtable  );
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
        string password;
        password = ""; /* init password */
        /* retrieve the password */
        try
        {
            password = Encoding.UTF8.GetString(File.ReadAllBytes("../../../common/strong_password_file.txt"));
        }
        catch (IOException exceptIO)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "Error with file reading", exceptIO);
        }
        /* FIX: password is decrypted before being passed on */
        {
            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes("ABCDEFGHABCDEFGH");
                aesAlg.IV = new byte[16];
                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(File.ReadAllBytes("../../../common/strong_password_file.txt")))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            password = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
        Hashtable passwordHashtable = new Hashtable(5);
        passwordHashtable.Add(0, password);
        passwordHashtable.Add(1, password);
        passwordHashtable.Add(2, password);
        CWE256_Unprotected_Storage_of_Credentials__basic_72b.GoodG2BSink(passwordHashtable  );
    }

    /* goodB2G() - use BadSource and GoodSink */
    private static void GoodB2G()
    {
        string password;
        password = ""; /* init password */
        /* retrieve the password */
        try
        {
            password = Encoding.UTF8.GetString(File.ReadAllBytes("../../../common/strong_password_file.txt"));
        }
        catch (IOException exceptIO)
        {
            IO.Logger.Log(NLog.LogLevel.Warn, "Error with file reading", exceptIO);
        }
        /* POTENTIAL FLAW: The raw password read from the .txt file is passed on (without being decrypted) */
        Hashtable passwordHashtable = new Hashtable(5);
        passwordHashtable.Add(0, password);
        passwordHashtable.Add(1, password);
        passwordHashtable.Add(2, password);
        CWE256_Unprotected_Storage_of_Credentials__basic_72b.GoodB2GSink(passwordHashtable  );
    }
#endif //omitgood
}
}
