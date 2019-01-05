using CSharp4.Parameter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp4.Tests.Parameter
{
	[TestClass]
	public class _6UnexpectedBehavior
	{
		// Arrange
		private readonly decimal expected = 38.46M;
		private readonly decimal previous = 78000.00M;
		private readonly decimal current = 108000.00M;

		[TestMethod]
		public void TestUnexpectedMethod001()
		{
			// Act
			Employee employee = new Employee()
			{
				Name = "Steve"
			};
			decimal actual = employee.IncrementPercent(previous: previous, current: current);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestUnexpectedMethod002()
		{
			// Act
			Employee employee = new Employee()
			{
				Name = "Steve"
			};
			decimal actual = employee.IncrementPercent(previous, current);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestUnexpectedMethod003()
		{
			// Act
			ContractEmployee contractEmployee = new ContractEmployee()
			{
				Name = "Steve"
			};
			decimal actual = contractEmployee.IncrementPercent(previous: previous, current: current);

			// Assert
			Assert.AreEqual(expected: expected, actual: actual);
		}

		[TestMethod]
		public void TestUnexpectedMethod004()
		{
			// Act
			ContractEmployee contractEmployee = new ContractEmployee()
			{
				Name = "Steve"
			};
			decimal actual = contractEmployee.IncrementPercent(previous, current);

			// Assert
			Assert.AreNotEqual(notExpected: expected, actual: actual);
		}
	}
}
