using System;

namespace RedmineSharp
{
	public class Parent
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class Project
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Identifier { get; set; }

		public Parent Parent { get; set; }
	} // class
} // namespace