﻿namespace WebMVCR1.Models
{
	public class Person
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public override string ToString()
		{
			return FirstName.ToString() + " " + LastName.ToString();
		}
	}
}
