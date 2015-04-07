using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using VJeek.Microdata.Intangible.Enumeration;

namespace VJeek.Microdata.Intangible.StructuredValue
{
	public partial class ContactPoint : StructuredValue
	{
		[JsonProperty("areaServed")]
		public AdministrativeArea AreaServed { get; set; }

		[JsonProperty("availableLanguage")]
		public Language AvailableLanguage { get; set; }

		[JsonProperty("contactOption")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ContactPointOption ContactOption { get; set; }

		[JsonProperty("contactType")]
		public string ContactType { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("faxNumber")]
		public string FaxNumber { get; set; }

		[JsonProperty("hoursAvailable")]
		[JsonConverter(typeof(StringEnumConverter))]
		public OpeningHoursSpecification HoursAvailable { get; set; }
	}
}
