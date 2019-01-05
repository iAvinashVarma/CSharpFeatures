using CSharp4.Variance.Model;
using System.Collections.Generic;

namespace CSharp4.Variance.Comparator
{
	public class AnimalSizeComparator : IComparer<Animal>
	{
		public int Compare(Animal x, Animal y)
		{
			if (x.Size == y.Size)
			{
				return 0;
			}
			if (x.Size < y.Size)
			{
				return -1;
			}
			return 1;
		}
	}
}