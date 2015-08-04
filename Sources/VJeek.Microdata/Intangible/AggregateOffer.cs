using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VJeek.Microdata.Intangible
{
	public class AggregateOffer : Offer
	{
		[JsonProperty("highPrice")]
		public decimal HighPrice { get; set; }

		[JsonProperty("lowPrice")]
		public decimal LowPrice { get; set; }

		[JsonProperty("offerCount")]
		public int OfferCount { get; set; }
	}
}
