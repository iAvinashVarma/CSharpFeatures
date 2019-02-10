using System;

namespace CSharp4.Parameter.Model
{
	public class Employee
	{
		public string Name { get; set; }

		public virtual decimal IncrementPercent(decimal previous, decimal current)
		{
			decimal change = current - previous;
			return Math.Round(change / previous * 100, 2);
		}
	}
}