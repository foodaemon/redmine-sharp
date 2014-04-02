using System;
using RestSharp;
using Newtonsoft.Json;
using RedmineSharp.Models;

namespace RedmineSharp
{
	public class IssueResource
	{
		private readonly RedmineClient _redmineClient;

		private const string _resource = "issues";

		public IssueResource(string redmineUri, string apiKey, bool useHttps = false)
		{
			_redmineClient = new RedmineClient (redmineUri, apiKey, useHttps);
		}

		public IssueList GetAllIssues()
		{
			var request = new RestRequest (_resource, Method.GET);

			var response = _redmineClient.SendRequest (request);
			var issueList = JsonConvert.DeserializeObject<IssueList> (response.Content);
			return issueList;
		}

		public IssueList GetIssuesByProjectId(int projectId)
		{
			var request = new RestRequest (_resource, Method.GET);
			request.AddParameter ("project_id", projectId);

			var response = _redmineClient.SendRequest (request);
			var issueList = JsonConvert.DeserializeObject<IssueList> (response.Content);
			return issueList;
		}
	} // class
} // namespace