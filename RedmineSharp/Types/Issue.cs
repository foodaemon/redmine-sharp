using System;

namespace RedmineSharp.Types
{
	public class Issue
	{
		public int Id { get; set; }
		public string Subject { get; set; }
		public string Start_Date { get; set; }
		public string Description { get; set; }
		public int Done_Ratio { get; set; }
		public Author Author { get; set; }
		public Project Project { get; set; }
		public Priority Priority { get; set; }
		public string Created_On { get; set; }
		public int Estimated_Hours { get; set; }
		public Tracker Tracker { get; set; }
		public Status Status { get; set; }
		public string Updated_On { get; set; }
	}
}