using CSharp4.Parameter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSharp4.Tests.Parameter
{
	[TestClass]
	public class _1OptionalTest
	{
		public static readonly Parameters parameters = new Parameters();

		[TestMethod]
		public void TestOptionalMethod001()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(1, "Optional");

			// Act
			KeyValuePair<int, string> actual = parameters.OptionalMethod();

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestOptionalMethod002()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(2, "Possible");

			// Act
			KeyValuePair<int, string> actual = parameters.OptionalMethod(2, "Possible");

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestOptionalMethod003()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(3, "Optional");

			// Act
			KeyValuePair<int, string> actual = parameters.OptionalMethod(3);

			// Assert
			Assert.AreEqual(expected, actual);
		}
	}
}