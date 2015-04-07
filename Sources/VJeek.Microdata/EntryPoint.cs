using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VJeek.Microdata
{
	public partial class EntryPoint : Thing
	{
		[JsonProperty("contentType")]
		public string ContentType { get; set; }

		[JsonProperty("encodingType")]
		public string EncodingType { get; set; }

		[JsonProperty("httpMethod")]
		public string HttpMethod { get; set; }

		[JsonProperty("urlTemplate")]
		public string UrlTemplate { get; set; }
	}
}
