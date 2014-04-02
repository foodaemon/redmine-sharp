using System;
using RestSharp;

namespace RedmineSharp
{
	public class RedmineClient
	{
		/// <summary>
		/// Gets or sets the protocol.
		/// </summary>
		/// <value>http or https</value>
		public string Protocol { get; set; }

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

		/// <summary>
		/// Gets or sets the API key.
		/// </summary>
		/// <value>The API key.</value>
		public string ApiKey { get; set; }


		public RedmineClient (string redmineUri, string apiKey, bool useHttps = false)
		{
			Protocol = useHttps? "https" : "http";
			RedmineUri = redmineUri;
			ApiKey = apiKey;
		}

		public RestResponse SendRequest(RestRequest request)
		{
			var client = new RestClient (Protocol + "://" + RedmineUri + "/");
			request.AddHeader ("Content-Type", "application/json");
			request.AddParameter ("format", "json");
			request.AddParameter ("key", ApiKey); //bce2ece43c06ecd151319bb70c85de312f5ef063
			return client.Execute (request) as RestResponse;
		}

	} // class
} // namespace