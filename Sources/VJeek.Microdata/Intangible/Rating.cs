using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VJeek.Microdata.Intangible
{
	public partial class Rating : Thing
	{
		[JsonProperty("bestRating")]
		public decimal BestRating { get; set; }

		[JsonProperty("ratingValue")]
		public decimal RatingValue { get; set; }

		[JsonProperty("worstRating")]
		public string WorstRating { get; set; }
	}
}
