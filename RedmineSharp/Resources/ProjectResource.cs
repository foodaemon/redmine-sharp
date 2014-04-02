using System;
using RestSharp;
using Newtonsoft.Json;
using RedmineSharp.Models;

namespace RedmineSharp.Resources
{
	public class ProjectResource
	{
		public string Resource 
		{ 
			get { return "projects"; } 
		} 

		public ProjectList GetAllProjects()
		{
			var redmineClient = new RedmineClient();
			var request = new RestRequest (Resource, Method.GET);

			var response = redmineClient.SendRequest (request);

			var projectList = JsonConvert.DeserializeObject<ProjectList> (response.Content);

			return projectList;
		}
	} // class
} // namespace