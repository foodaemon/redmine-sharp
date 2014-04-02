using System;
using NUnit.Framework;
using RestSharp;
using RedmineSharp;
using RedmineSharp.Resources;

namespace RedmineSharpTest
{
	[TestFixture]
	public class ProjectResourceTest
	{
		[Test]
		public void CanRetrieveProjectList()
		{
			var redmineClient = new RedmineClient ();

			var request = new RestSharp.RestRequest ("projects", Method.GET);
			var response = redmineClient.SendRequest (request);
			
			Assert.AreEqual (200, (int)response.StatusCode);

		}
	} // class
} // namespace