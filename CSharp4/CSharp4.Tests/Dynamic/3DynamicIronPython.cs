using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp4.Tests.Dynamic
{
	[TestClass]
	public class _3DynamicIronPython
	{
		[TestMethod]
		public void TestPythonInput001()
		{
			// Arrange
			string expected = "Howdy World";
			ScriptRuntime python = Python.CreateRuntime();
			dynamic script = python.UseFile(string.Format(@"{0}\{0}.py", "Script"));

			// Act
			dynamic actual = script.Welcome();

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestPythonOutput001()
		{
			// Arrange
			string expected = "Value from C#: Avi";
			ScriptRuntime python = Python.CreateRuntime();
			dynamic script = python.UseFile(string.Format(@"{0}\{0}.py", "Script"));
			script.SpecialCSharpValue = "Avi";

			// Act
			dynamic actual = script.OutputValue();

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
