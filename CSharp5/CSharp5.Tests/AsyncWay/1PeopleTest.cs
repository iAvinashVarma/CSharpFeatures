using CSharp5.AsyncWay;
using CSharp5.AsyncWay.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSharp5.Tests.AsyncWay
{
	[TestClass]
	public class _1PeopleTest
	{
		[TestMethod]
		[ExpectedException(typeof(HttpRequestException))]
		public async Task TestPeopleMethod001()
		{
			// Arrange
			People people = new People();

			// Act
			IEnumerable<Person> persons = await people.GetPeopleAsync();

			// Assert
			Assert.IsNotNull(persons);
			Assert.IsTrue(persons.Any());
		}
	}
}
