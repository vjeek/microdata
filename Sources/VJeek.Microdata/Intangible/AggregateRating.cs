using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VJeek.Microdata.Intangible
{
	public partial class AggregateRating : Rating
	{
		[JsonProperty("itemReviewed")]
		public Thing ItemReviewed { get; set; }

		[JsonProperty("ratingCount")]
		public decimal RatingCount { get; set; }

		[JsonProperty("reviewCount")]
		public decimal ReviewCount { get; set; }
	}
}
