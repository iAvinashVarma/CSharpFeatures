using System;

namespace CSharp5.AsyncWay.Model
{
	public class Person
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public byte Age { get; set; }

		public Gender Gender { get; set; }

		public DateTime DateOfBirth { get; set; }

		public bool IsRegistered { get; set; }

		public DateTime ModifiedDate { get; set; }
	}

	public enum Gender : byte
	{
		Unknown = 0,
		Male = 1,
		Female = 2
	}
}
