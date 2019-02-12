using CSharp4.Variance;
using CSharp4.Variance.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp4.Tests.Variance
{
	[TestClass]
	public class _1Covariance
	{
		[TestMethod]
		public void TestMethod001()
		{
			// Arrange
			IEnumerable<Cat> cats = new List<Cat>
			{
				new Cat("Troublemaker"),
				new Cat("Alpithar")
			};
			Covariance covariance = new Covariance();

			// Act
			IEnumerable<string> result = covariance.GetAnimalNames(cats);

			// Assert
			Assert.IsTrue(result.Any(a => a.Equals("TroubleMaker", StringComparison.OrdinalIgnoreCase)));
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidCastException))]
		public void TestMethod002()
		{
			// Arrange
			List<string> strings = new List<string>
			{
				"One",
				"Two"
			};
			strings.Add("Three");

			IList<string> iListStrings = strings;
			iListStrings.Add("Four");

			// Act
			IList<object> objectList = (IList<object>)strings;
			objectList.Add(5);
		}

		[TestMethod]
		public void TestMethod003()
		{
			// Arrange
			List<string> strings = new List<string>
			{
				"One",
				"Two"
			};
			strings.Add("Three");

			IList<string> iListStrings = strings;
			iListStrings.Add("Four");

			// Act
			IEnumerable<object> objectSequence = strings;

			// Assert
			Assert.IsTrue(objectSequence.Any());
		}
	}
}