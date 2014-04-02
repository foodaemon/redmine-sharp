using System;
using RestSharp;

namespace RedmineSharp
{
	public class RedmineClient
	{
		public string Protocol { get; set; }
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="RedmineSharp.RedmineClient"/> use https.
		/// </summary>
		/// <value><c>true</c> if use https; otherwise, <c>false</c>.</value>
		public bool UseHttps { get; set; }

		/// <summary>
		/// Gets or sets the redmine URI.
		/// </summary>
		/// <value>The redmine URI.</value>
		public string RedmineUri { get; set; }

		/// <summary>
		/// Gets or sets the redmine port.
		/// </summary>
		/// <value>The redmine port.</value>
		public int RedminePort { get; set; }

		public RedmineClient ()
		{
			Protocol = UseHttps? "https" : "http";
			RedmineUri = "redmineuri.com/";
		}

		public RestResponse SendRequest(RestRequest request)
		{
			var client = new RestClient (Protocol + "://" + RedmineUri);
			request.AddHeader ("Content-Type", "application/json");
			request.AddParameter ("key", "your_redmine_key");
			request.AddParameter ("format", "json");

			return client.Execute (request) as RestResponse;
		}

	} // class
} // namespace