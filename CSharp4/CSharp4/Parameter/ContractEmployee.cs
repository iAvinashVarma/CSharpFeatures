namespace CSharp4.Parameter
{
	public class ContractEmployee : Employee
	{
		public new string Name { get; set; }

		public override decimal IncrementPercent(decimal current, decimal previous)
		{
			return base.IncrementPercent(previous: previous, current: current);
		}
	}
}