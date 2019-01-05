using CSharp4.Variance.Model;
using System.Collections.Generic;

namespace CSharp4.Variance
{
	public class Contravariance
	{
		public Cat Winner(Cat catOne, Cat catTwo, IComparer<Cat> comparer)
		{
			return comparer.Compare(catOne, catTwo) > 0 ? catOne : catTwo;
		}
	}
}