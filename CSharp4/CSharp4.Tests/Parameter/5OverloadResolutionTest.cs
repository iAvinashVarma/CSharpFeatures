using System;
using System.Collections.Generic;
using CSharp4.Parameter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp4.Tests.Parameter
{
	[TestClass]
	public class _5OverloadResolutionTest
	{
		public static readonly Parameters parameters = new Parameters();

		[TestMethod]
		public void TestResolutionMethod001()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(key: 1, value: "Numeric");

			// Act
			KeyValuePair<int, string> actual = parameters.OverloadResolution(1, "Numeric");

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestResolutionMethod002()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(key: 2, value: "Numeric");

			// Act
			KeyValuePair<int, string> actual = parameters.OverloadResolution(key: 2);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestResolutionMethod003()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(key: 3, value: "Optional");

			// Act
			KeyValuePair<int, string> actual = parameters.OverloadResolution(key: 3, value: "Optional");

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestResolutionMethod004()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(key: 4, value: "Sample");

			// Act
			KeyValuePair<int, string> actual = parameters.OverloadResolution(value: "Sample", key: 4);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestResolutionMethod005()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(key: 5, value: "Generic");

			// Act
			KeyValuePair<int, string> actual = parameters.OverloadResolution<int>(5);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestResolutionMethod006()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(key: 6, value: "Numeric");

			// Act
			KeyValuePair<int, string> actual = parameters.OverloadResolution(6);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestResolutionMethod007()
		{
			// Arrange
			KeyValuePair<int, string> expected = new KeyValuePair<int, string>(key: 7, value: "Generic");

			// Act
			KeyValuePair<int, string> actual = parameters.OverloadResolution(genKey: 7);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestResolutionMethod008()
		{
			// Arrange
			KeyValuePair<double, string> expected = new KeyValuePair<double, string>(key: 8.0, value: "Generic");

			// Act
			KeyValuePair<double, string> actual = parameters.OverloadResolution<double>(8.0);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestResolutionMethod009()
		{
			// Arrange
			KeyValuePair<double, string> expected = new KeyValuePair<double, string>(key: 9.0, value: "Floating");

			// Act
			KeyValuePair<double, string> actual = parameters.OverloadResolution(9.0);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestResolutionMethod010()
		{
			// Arrange
			KeyValuePair<double, string> expected = new KeyValuePair<double, string>(key: 10.0, value: "Generic");

			// Act
			KeyValuePair<double, string> actual = parameters.OverloadResolution(genKey: 10.0);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}
	}
}
