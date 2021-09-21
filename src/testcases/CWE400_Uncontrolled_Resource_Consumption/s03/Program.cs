using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace testcases.CWE400_Uncontrolled_Resource_Consumption
{
	class Program {

		static void Main(string[] args) {
			
			if(args.Any()) {
			
				if(args[0].Equals("-h", StringComparison.OrdinalIgnoreCase) || 
                   args[0].Equals("--help", StringComparison.OrdinalIgnoreCase)) {
			
					Console.WriteLine("To use this main, you can either run the program with no " +
					"command line arguments to run all test cases or you can specify one or more classes to test");
					System.Environment.Exit(1);
				}
				
				/* User supplied some class names on the command line, just use those with introspection
				 *
				 * string classNames[] = { "CWE481_Assigning_instead_of_Comparing__boolean_01",
				 *		"CWE476_Null_Pointer_Dereference__getProperty_01" };
				 * could read class names from command line or use
				 * http://sadun-util.sourceforge.net/api/org/sadun/util/
				 * ClassPackageExplorer.html
				 */

				foreach (string className in args) {

					try {
						
						/* String classNameWithPackage = "testcases." + className; */
						
						/* Console.WriteLine("classNameWithPackage = " + classNameWithPackage); */

						Type myClass = Type.GetType(className);
						object myObject = Activator.CreateInstance(myClass);
						myClass.InvokeMember("runTest", 
							BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, 
							null, 
							myObject, 
							new object[] { className });

					} catch (Exception ex) {

						Console.WriteLine("Could not run test for class " + className);
						Console.WriteLine(ex.StackTrace);

					}
					
					Console.WriteLine(""); /* leave a blank line between classes */

				}

			} else {
			
				/* No command line args were used, we want to run every testcase */
				
				/* needed to separate these calls into other methods because
				   we were running into the size limit Java has for a single method */
				RunTestCWE1();
				RunTestCWE2();
				RunTestCWE3();
				RunTestCWE4();
				RunTestCWE5();
				RunTestCWE6();
				RunTestCWE7();
				RunTestCWE8();
				RunTestCWE9();
			}			
		}

	private static void RunTestCWE1() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-1 */

			/* END-AUTOGENERATED-CSHARP-TESTS-1 */
	}

	private static void RunTestCWE2() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-2 */

			/* END-AUTOGENERATED-CSHARP-TESTS-2 */
	}

	private static void RunTestCWE3() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-3 */

			/* END-AUTOGENERATED-CSHARP-TESTS-3 */
	}

	private static void RunTestCWE4() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-4 */
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_01()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_01");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_02()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_02");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_03()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_03");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_04()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_04");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_05()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_05");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_06()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_06");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_07()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_07");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_08()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_08");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_09()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_09");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_10()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_10");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_11()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_11");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_12()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_12");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_13()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_13");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_14()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_14");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_15()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_15");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_16()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_16");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_17()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_17");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_21()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_21");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_22a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_22a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_31()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_31");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_41()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_41");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_42()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_42");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_45()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_45");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_51a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_51a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_52a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_52a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_53a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_53a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_54a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_54a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_61a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_61a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_66a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_66a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_67a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_67a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_68a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_68a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_71a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_71a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_72a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_72a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_73a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_73a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_74a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_74a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_75a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_75a");
			(new CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_81a()).RunTest("CWE400_Uncontrolled_Resource_Consumption__sleep_ReadLine_81a");
			/* END-AUTOGENERATED-CSHARP-TESTS-4 */
	}

	private static void RunTestCWE5() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-5 */

			/* END-AUTOGENERATED-CSHARP-TESTS-5 */
	}

	private static void RunTestCWE6() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-6 */

			/* END-AUTOGENERATED-CSHARP-TESTS-6 */
	}

	private static void RunTestCWE7() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-7 */

			/* END-AUTOGENERATED-CSHARP-TESTS-7 */
	}

	private static void RunTestCWE8() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-8 */

			/* END-AUTOGENERATED-CSHARP-TESTS-8 */
	}

	private static void RunTestCWE9() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-9 */

			/* END-AUTOGENERATED-CSHARP-TESTS-9 */
	}
}
}