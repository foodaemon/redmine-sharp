using System;
using RestSharp;
using Newtonsoft.Json;
using RedmineSharp.Models;

namespace RedmineSharp.Resources
{
	public class ProjectResource
	{
		private readonly RedmineClient _redmineClient;

		private const string _resource = "projects";

		public ProjectResource(string redmineUri, string apiKey, bool useHttps = false)
		{
			_redmineClient = new RedmineClient (redmineUri, apiKey, useHttps);
		}

		public ProjectList GetAllProjects(int offset = 0, int limit = 25)
		{
			var request = new RestRequest (_resource, Method.GET);
			request.AddParameter ("offset", offset);
			request.AddParameter ("limit", limit);

			var response = _redmineClient.SendRequest (request);

			var projectList = JsonConvert.DeserializeObject<ProjectList> (response.Content);

			return projectList;
		}
	} // class
} // namespace