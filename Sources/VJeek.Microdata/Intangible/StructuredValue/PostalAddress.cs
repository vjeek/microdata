using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VJeek.Microdata.Intangible.StructuredValue
{
	public partial class PostalAddress : ContactPoint
	{
		[JsonProperty("addressCountry")]
		public Country AddressCountry { get; set; }

		[JsonProperty("addressLocality")]
		public string AddressLocality { get; set; }

		[JsonProperty("addressRegion")]
		public string AddressRegion { get; set; }

		[JsonProperty("postOfficeBoxNumber")]
		public string PostOfficeBoxNumber { get; set; }

		[JsonProperty("postalCode")]
		public string PostalCode { get; set; }

		[JsonProperty("streetAddress")]
		public string StreetAddress { get; set; }

	}
}
