using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VJeek.Microdata.Intangible.StructuredValue
{
	public partial class QuantitativeValue : StructuredValue
	{
		[JsonProperty("maxValue")]
		public decimal MaxValue { get; set; }

		[JsonProperty("minValue")]
		public decimal MinValue { get; set; }

		[JsonProperty("unitCode")]
		public string UnitCode { get; set; }

		[JsonProperty("valueReference")]
		public object ValueReference { get; set; }
	}
}
