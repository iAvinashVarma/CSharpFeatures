using CSharp4.Variance;
using CSharp4.Variance.Comparator;
using CSharp4.Variance.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSharp4.Tests.Variance
{
	[TestClass]
	public class _2ContravarianceTest
	{
		[TestMethod]
		public void TestMethod001()
		{
			// Arrange
			IComparer<Animal> compareAnimals = new AnimalSizeComparator();
			Contravariance contravariance = new Contravariance();
			Cat catOne = new Cat("NallaPilli")
			{
				Size = 10
			};
			Cat catTwo = new Cat("ThellaPilli")
			{
				Size = 9
			};

			// Act
			Cat actual = contravariance.Winner(catOne, catTwo, compareAnimals);

			// Assert
			Assert.AreEqual(catOne, actual);
		}
	}
}