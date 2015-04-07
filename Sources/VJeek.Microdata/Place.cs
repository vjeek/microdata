using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VJeek.Microdata.Intangible.StructuredValue;

namespace VJeek.Microdata
{
	public partial class Place : Thing
	{
		[JsonProperty("address")]
		public PostalAddress Address { get; set; }
	}
}
