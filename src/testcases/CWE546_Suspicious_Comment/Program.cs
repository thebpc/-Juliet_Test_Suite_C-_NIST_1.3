using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace testcases.CWE546_Suspicious_Comment
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

			/* END-AUTOGENERATED-CSHARP-TESTS-4 */
	}

	private static void RunTestCWE5() {
	/* BEGIN-AUTOGENERATED-CSHARP-TESTS-5 */
			(new CWE546_Suspicious_Comment__BUG_01()).RunTest("CWE546_Suspicious_Comment__BUG_01");
			(new CWE546_Suspicious_Comment__BUG_02()).RunTest("CWE546_Suspicious_Comment__BUG_02");
			(new CWE546_Suspicious_Comment__BUG_03()).RunTest("CWE546_Suspicious_Comment__BUG_03");
			(new CWE546_Suspicious_Comment__BUG_04()).RunTest("CWE546_Suspicious_Comment__BUG_04");
			(new CWE546_Suspicious_Comment__BUG_05()).RunTest("CWE546_Suspicious_Comment__BUG_05");
			(new CWE546_Suspicious_Comment__BUG_06()).RunTest("CWE546_Suspicious_Comment__BUG_06");
			(new CWE546_Suspicious_Comment__BUG_07()).RunTest("CWE546_Suspicious_Comment__BUG_07");
			(new CWE546_Suspicious_Comment__BUG_08()).RunTest("CWE546_Suspicious_Comment__BUG_08");
			(new CWE546_Suspicious_Comment__BUG_09()).RunTest("CWE546_Suspicious_Comment__BUG_09");
			(new CWE546_Suspicious_Comment__BUG_10()).RunTest("CWE546_Suspicious_Comment__BUG_10");
			(new CWE546_Suspicious_Comment__BUG_11()).RunTest("CWE546_Suspicious_Comment__BUG_11");
			(new CWE546_Suspicious_Comment__BUG_12()).RunTest("CWE546_Suspicious_Comment__BUG_12");
			(new CWE546_Suspicious_Comment__BUG_13()).RunTest("CWE546_Suspicious_Comment__BUG_13");
			(new CWE546_Suspicious_Comment__BUG_14()).RunTest("CWE546_Suspicious_Comment__BUG_14");
			(new CWE546_Suspicious_Comment__BUG_15()).RunTest("CWE546_Suspicious_Comment__BUG_15");
			(new CWE546_Suspicious_Comment__BUG_16()).RunTest("CWE546_Suspicious_Comment__BUG_16");
			(new CWE546_Suspicious_Comment__BUG_17()).RunTest("CWE546_Suspicious_Comment__BUG_17");
			(new CWE546_Suspicious_Comment__FIXME_01()).RunTest("CWE546_Suspicious_Comment__FIXME_01");
			(new CWE546_Suspicious_Comment__FIXME_02()).RunTest("CWE546_Suspicious_Comment__FIXME_02");
			(new CWE546_Suspicious_Comment__FIXME_03()).RunTest("CWE546_Suspicious_Comment__FIXME_03");
			(new CWE546_Suspicious_Comment__FIXME_04()).RunTest("CWE546_Suspicious_Comment__FIXME_04");
			(new CWE546_Suspicious_Comment__FIXME_05()).RunTest("CWE546_Suspicious_Comment__FIXME_05");
			(new CWE546_Suspicious_Comment__FIXME_06()).RunTest("CWE546_Suspicious_Comment__FIXME_06");
			(new CWE546_Suspicious_Comment__FIXME_07()).RunTest("CWE546_Suspicious_Comment__FIXME_07");
			(new CWE546_Suspicious_Comment__FIXME_08()).RunTest("CWE546_Suspicious_Comment__FIXME_08");
			(new CWE546_Suspicious_Comment__FIXME_09()).RunTest("CWE546_Suspicious_Comment__FIXME_09");
			(new CWE546_Suspicious_Comment__FIXME_10()).RunTest("CWE546_Suspicious_Comment__FIXME_10");
			(new CWE546_Suspicious_Comment__FIXME_11()).RunTest("CWE546_Suspicious_Comment__FIXME_11");
			(new CWE546_Suspicious_Comment__FIXME_12()).RunTest("CWE546_Suspicious_Comment__FIXME_12");
			(new CWE546_Suspicious_Comment__FIXME_13()).RunTest("CWE546_Suspicious_Comment__FIXME_13");
			(new CWE546_Suspicious_Comment__FIXME_14()).RunTest("CWE546_Suspicious_Comment__FIXME_14");
			(new CWE546_Suspicious_Comment__FIXME_15()).RunTest("CWE546_Suspicious_Comment__FIXME_15");
			(new CWE546_Suspicious_Comment__FIXME_16()).RunTest("CWE546_Suspicious_Comment__FIXME_16");
			(new CWE546_Suspicious_Comment__FIXME_17()).RunTest("CWE546_Suspicious_Comment__FIXME_17");
			(new CWE546_Suspicious_Comment__HACK_01()).RunTest("CWE546_Suspicious_Comment__HACK_01");
			(new CWE546_Suspicious_Comment__HACK_02()).RunTest("CWE546_Suspicious_Comment__HACK_02");
			(new CWE546_Suspicious_Comment__HACK_03()).RunTest("CWE546_Suspicious_Comment__HACK_03");
			(new CWE546_Suspicious_Comment__HACK_04()).RunTest("CWE546_Suspicious_Comment__HACK_04");
			(new CWE546_Suspicious_Comment__HACK_05()).RunTest("CWE546_Suspicious_Comment__HACK_05");
			(new CWE546_Suspicious_Comment__HACK_06()).RunTest("CWE546_Suspicious_Comment__HACK_06");
			(new CWE546_Suspicious_Comment__HACK_07()).RunTest("CWE546_Suspicious_Comment__HACK_07");
			(new CWE546_Suspicious_Comment__HACK_08()).RunTest("CWE546_Suspicious_Comment__HACK_08");
			(new CWE546_Suspicious_Comment__HACK_09()).RunTest("CWE546_Suspicious_Comment__HACK_09");
			(new CWE546_Suspicious_Comment__HACK_10()).RunTest("CWE546_Suspicious_Comment__HACK_10");
			(new CWE546_Suspicious_Comment__HACK_11()).RunTest("CWE546_Suspicious_Comment__HACK_11");
			(new CWE546_Suspicious_Comment__HACK_12()).RunTest("CWE546_Suspicious_Comment__HACK_12");
			(new CWE546_Suspicious_Comment__HACK_13()).RunTest("CWE546_Suspicious_Comment__HACK_13");
			(new CWE546_Suspicious_Comment__HACK_14()).RunTest("CWE546_Suspicious_Comment__HACK_14");
			(new CWE546_Suspicious_Comment__HACK_15()).RunTest("CWE546_Suspicious_Comment__HACK_15");
			(new CWE546_Suspicious_Comment__HACK_16()).RunTest("CWE546_Suspicious_Comment__HACK_16");
			(new CWE546_Suspicious_Comment__HACK_17()).RunTest("CWE546_Suspicious_Comment__HACK_17");
			(new CWE546_Suspicious_Comment__LATER_01()).RunTest("CWE546_Suspicious_Comment__LATER_01");
			(new CWE546_Suspicious_Comment__LATER_02()).RunTest("CWE546_Suspicious_Comment__LATER_02");
			(new CWE546_Suspicious_Comment__LATER_03()).RunTest("CWE546_Suspicious_Comment__LATER_03");
			(new CWE546_Suspicious_Comment__LATER_04()).RunTest("CWE546_Suspicious_Comment__LATER_04");
			(new CWE546_Suspicious_Comment__LATER_05()).RunTest("CWE546_Suspicious_Comment__LATER_05");
			(new CWE546_Suspicious_Comment__LATER_06()).RunTest("CWE546_Suspicious_Comment__LATER_06");
			(new CWE546_Suspicious_Comment__LATER_07()).RunTest("CWE546_Suspicious_Comment__LATER_07");
			(new CWE546_Suspicious_Comment__LATER_08()).RunTest("CWE546_Suspicious_Comment__LATER_08");
			(new CWE546_Suspicious_Comment__LATER_09()).RunTest("CWE546_Suspicious_Comment__LATER_09");
			(new CWE546_Suspicious_Comment__LATER_10()).RunTest("CWE546_Suspicious_Comment__LATER_10");
			(new CWE546_Suspicious_Comment__LATER_11()).RunTest("CWE546_Suspicious_Comment__LATER_11");
			(new CWE546_Suspicious_Comment__LATER_12()).RunTest("CWE546_Suspicious_Comment__LATER_12");
			(new CWE546_Suspicious_Comment__LATER_13()).RunTest("CWE546_Suspicious_Comment__LATER_13");
			(new CWE546_Suspicious_Comment__LATER_14()).RunTest("CWE546_Suspicious_Comment__LATER_14");
			(new CWE546_Suspicious_Comment__LATER_15()).RunTest("CWE546_Suspicious_Comment__LATER_15");
			(new CWE546_Suspicious_Comment__LATER_16()).RunTest("CWE546_Suspicious_Comment__LATER_16");
			(new CWE546_Suspicious_Comment__LATER_17()).RunTest("CWE546_Suspicious_Comment__LATER_17");
			(new CWE546_Suspicious_Comment__TODO_01()).RunTest("CWE546_Suspicious_Comment__TODO_01");
			(new CWE546_Suspicious_Comment__TODO_02()).RunTest("CWE546_Suspicious_Comment__TODO_02");
			(new CWE546_Suspicious_Comment__TODO_03()).RunTest("CWE546_Suspicious_Comment__TODO_03");
			(new CWE546_Suspicious_Comment__TODO_04()).RunTest("CWE546_Suspicious_Comment__TODO_04");
			(new CWE546_Suspicious_Comment__TODO_05()).RunTest("CWE546_Suspicious_Comment__TODO_05");
			(new CWE546_Suspicious_Comment__TODO_06()).RunTest("CWE546_Suspicious_Comment__TODO_06");
			(new CWE546_Suspicious_Comment__TODO_07()).RunTest("CWE546_Suspicious_Comment__TODO_07");
			(new CWE546_Suspicious_Comment__TODO_08()).RunTest("CWE546_Suspicious_Comment__TODO_08");
			(new CWE546_Suspicious_Comment__TODO_09()).RunTest("CWE546_Suspicious_Comment__TODO_09");
			(new CWE546_Suspicious_Comment__TODO_10()).RunTest("CWE546_Suspicious_Comment__TODO_10");
			(new CWE546_Suspicious_Comment__TODO_11()).RunTest("CWE546_Suspicious_Comment__TODO_11");
			(new CWE546_Suspicious_Comment__TODO_12()).RunTest("CWE546_Suspicious_Comment__TODO_12");
			(new CWE546_Suspicious_Comment__TODO_13()).RunTest("CWE546_Suspicious_Comment__TODO_13");
			(new CWE546_Suspicious_Comment__TODO_14()).RunTest("CWE546_Suspicious_Comment__TODO_14");
			(new CWE546_Suspicious_Comment__TODO_15()).RunTest("CWE546_Suspicious_Comment__TODO_15");
			(new CWE546_Suspicious_Comment__TODO_16()).RunTest("CWE546_Suspicious_Comment__TODO_16");
			(new CWE546_Suspicious_Comment__TODO_17()).RunTest("CWE546_Suspicious_Comment__TODO_17");
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