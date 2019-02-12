using CSharp4.Parameter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSharp4.Tests.Parameter
{
	[TestClass]
	public class _2NamedTest
	{
		public static readonly Parameters parameters = new Parameters();

		[TestMethod]
		public void TestNamedMethod001()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(key: 2, value: "Named");

			// Act
			KeyValuePair<int, string> actual = parameters.NamedMethod();

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestNamedMethod002()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(key: 22, value: "Possible");

			// Act
			KeyValuePair<int, string> actual = parameters.NamedMethod(key: 22, value: "Possible");

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestNamedMethod003()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(key: 33, value: "Named");

			// Act
			KeyValuePair<int, string> actual = parameters.NamedMethod(key: 33);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestNamedMethod004()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(key: 2, value: "Possible");

			// Act
			KeyValuePair<int, string> actual = parameters.NamedMethod(value: "Possible");

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}
	}
}