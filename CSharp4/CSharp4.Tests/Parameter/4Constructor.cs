using CSharp4.Parameter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSharp4.Tests.Parameter
{
	[TestClass]
	public class _4Constructor
	{
		[TestMethod]
		public void TestConstructor001()
		{
			// Arrange
			KeyValuePair<int, int> expected = new KeyValuePair<int, int>(key: 3, value: 4);
			Parameters parameters = new Parameters();

			// Act
			KeyValuePair<int, int> actual = parameters.Output();

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestConstructor002()
		{
			// Arrange
			KeyValuePair<int, int> expected = new KeyValuePair<int, int>(key: 1, value: 2);
			Parameters parameters = new Parameters(key: 1, value: 2);

			// Act
			KeyValuePair<int, int> actual = parameters.Output();

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestConstructor003()
		{
			// Arrange
			KeyValuePair<int, int> expected = new KeyValuePair<int, int>(key: 1, value: 4);
			Parameters parameters = new Parameters(key: 1);

			// Act
			KeyValuePair<int, int> actual = parameters.Output();

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestConstructor004()
		{
			// Arrange
			KeyValuePair<int, int> expected = new KeyValuePair<int, int>(key: 3, value: 2);
			Parameters parameters = new Parameters(value: 2);

			// Act
			KeyValuePair<int, int> actual = parameters.Output();

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}
	}
}