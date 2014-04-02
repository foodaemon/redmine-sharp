using System;

namespace RedmineSharp.Models
{
	public abstract class BaseModel
	{
		public int Offset { get; set; }
		public int Limit { get; set; }
		public int Total_Count { get; set; }
	} // class
} // namespace