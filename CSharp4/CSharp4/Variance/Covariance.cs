using CSharp4.Variance.Model;
using System.Collections.Generic;

namespace CSharp4.Variance
{
	public class Covariance
	{
		public IEnumerable<string> GetAnimalNames(IEnumerable<Animal> animals)
		{
			foreach (Animal animal in animals)
			{
				yield return animal.Name;
			}
		}
	}
}