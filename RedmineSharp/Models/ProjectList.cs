using System;
using System.Collections.Generic;

namespace RedmineSharp.Models
{
	public class ProjectList : BaseModel
	{
		public List<Project> Projects { get; set; }
	} // class
} // namespace