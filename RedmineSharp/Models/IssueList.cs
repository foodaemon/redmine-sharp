using System;
using System.Collections.Generic;
using RedmineSharp.Types;

namespace RedmineSharp.Models
{
	public class IssueList : BaseModel
	{
		public List<Issue> Issues { get; set; }
	} // class
} // namespace