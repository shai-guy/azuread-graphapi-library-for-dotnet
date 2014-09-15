namespace Microsoft.Azure.ActiveDirectory.GraphClient.Extensions
{
	using System;
	using System.Collections.Specialized;
	using System.Web;

	public static class UriBuilderExtensions
	{
		/// <summary>
		/// Adds a name/value pair to the query
		/// </summary>
		/// <param name="uriBuilder"></param>
		/// <param name="paramName"></param>
		/// <param name="paramValue"></param>
		/// <returns></returns>
		public static UriBuilder AddParameter(this UriBuilder uriBuilder, string paramName, string paramValue)
		{
			NameValueCollection query = HttpUtility.ParseQueryString(uriBuilder.Query);
			query[paramName] = paramValue;
			uriBuilder.Query = query.ToString();

			return uriBuilder;
		}
	}
}
