using Microsoft.CSharp.RuntimeBinder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace CSharp4.Tests.Dynamic
{
	[TestClass]
	public class _1DynamicBasicsTest
	{
		private dynamic key;

		[TestMethod]
		public void TestDynamic001()
		{
			// Arrange
			dynamic name = "Avinash";
			int expected = 7;

			// Act
			int actual = name.Length;

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		[ExpectedException(typeof(RuntimeBinderException))]
		public void TestDynamic002()
		{
			// Arrange
			dynamic number = 9;

			// Act
			int actual = number.RedRose();
		}

		[TestMethod]
		[ExpectedException(typeof(RuntimeBinderException))]
		public void TestDynamic003()
		{
			// Arrange
			key = "Changed";
			key = 9;

			// Act
			int actual = key.Length;
		}

		[TestMethod]
		[ExpectedException(typeof(RuntimeBinderException))]
		public void TestDynamic004()
		{
			// Arrange
			dynamic[] things = new dynamic[]
			{
				"Changes",
				9
			};

			// Act
			foreach (dynamic thing in things)
			{
				dynamic length = thing.Length;
#pragma warning disable
				Debug.WriteLine("{0}", length);
#pragma warning restore
			}
		}

		[TestMethod]
		[ExpectedException(typeof(RuntimeBinderException))]
		public void TestDynamic005()
		{
			// Arrange
			IEnumerable<dynamic> things = GetDynamicElements();

			// Act
			foreach (dynamic thing in things)
			{
#pragma warning disable
				Debug.WriteLine("{0}", thing);
#pragma warning restore
			}
		}

		private IEnumerable<dynamic> GetDynamicElements()
		{
			yield return "Avinash";
			yield return 1209;
			yield return 98.5F;
			yield return 28.7M;
			yield return true;
		}
	}
}