using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VJeek.Microdata.Intangible.Enumeration;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace VJeek.Microdata
{
	public partial class Action : Thing
	{
		[JsonProperty("actionStatus")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ActionStatusType ActionStatus { get; set; }

		[JsonProperty("agent")]
		public Thing Agent { get; set; }

		[JsonProperty("endTime")]
		public DateTime? EndTime { get; set; }

		[JsonProperty("error")]
		public Thing Error { get; set; }

		[JsonProperty("instrument")]
		public Thing Instrument { get; set; }

		[JsonProperty("location")]
		public Thing Location { get; set; }

		[JsonProperty("object")]
		public Thing ActionObject { get; set; }

		[JsonProperty("participant")]
		public Thing Participant { get; set; }

		[JsonProperty("result")]
		public Thing Result { get; set; }

		[JsonProperty("startTime")]
		public DateTime? StartTime { get; set; }

		[JsonProperty("target")]
		public EntryPoint Target { get; set; }
	}
}
