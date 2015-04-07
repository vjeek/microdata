using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VJeek.Microdata.Intangible.StructuredValue
{
	public partial class OpeningHoursSpecification : Thing
	{
		[JsonProperty("closes")]
		public TimeSpan Closes { get; set; }

		[JsonProperty("dayOfWeek")]
		public DayOfWeek DayOfWeek { get; set; }

		[JsonProperty("opens")]
		public TimeSpan Opens { get; set; }

		[JsonProperty("validFrom")]
		public DateTime ValidFrom { get; set; }

		[JsonProperty("validThrough")]
		public DateTime ValidThrough { get; set; }
	}
}
