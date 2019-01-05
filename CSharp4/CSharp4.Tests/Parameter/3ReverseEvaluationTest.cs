using CSharp4.Parameter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace CSharp4.Tests.Parameter
{
	[TestClass]
	public class _3ReverseEvaluationTest
	{
		public static readonly Parameters parameters = new Parameters();

		[TestMethod]
		public void TestEvaluationMethod001()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(key: A, value: B);

			// Act
			KeyValuePair<int, string> actual = parameters.NamedMethod(key: A, value: B);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestEvaluationMethod002()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(key: A, value: B);

			// Act
			KeyValuePair<int, string> actual = parameters.NamedMethod(value: B, key: A);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		private int A
		{
			get
			{
				Debug.WriteLine("Invoked A");
				return 9;
			}
		}

		private string B
		{
			get
			{
				Debug.WriteLine("Invoked B");
				return "Avi";
			}
		}
	}
}