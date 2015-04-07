using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using VJeek.Microdata.Intangible;
using VJeek.Microdata.Intangible.Enumeration;
using Newtonsoft.Json.Converters;

namespace VJeek.Microdata
{
	public partial class Event : Thing
	{
		[JsonProperty("attendee")]
		public Thing Attendee { get; set; }

		[JsonProperty("doorTime")]
		public DateTime? DoorTime { get; set; }

		[JsonProperty("duration")]
		public TimeSpan? Duration { get; set; }

		[JsonProperty("endDate")]
		public DateTime? EndDate { get; set; }

		[JsonProperty("eventStatus")]
		[JsonConverter(typeof(StringEnumConverter))]
		public EventStatusType EventStatus { get; set; }

		[JsonProperty("location")]
		public Thing Location { get; set; }

		[JsonProperty("offers")]
		public List<Offer> Offers { get; set; }

		[JsonProperty("organizer")]
		public Thing Organizer { get; set; }

		[JsonProperty("performer")]
		public Thing Performer { get; set; }

		[JsonProperty("previousStartDate")]
		public DateTime? PreviousStartDate { get; set; }

		[JsonProperty("recordedIn")]
		public CreativeWork RecordedIn { get; set; }

		[JsonProperty("startDate")]
		public DateTime StartDate { get; set; }

		[JsonProperty("subEvent")]
		public Event SubEvent { get; set; }

		[JsonProperty("SuperEvent")]
		public Event SuperEvent { get; set; }

		[JsonProperty("typicalAgeRange")]
		public string TypicalAgeRange { get; set; }

		[JsonProperty("workPerformed")]
		public CreativeWork WorkPerformed { get; set; }
	}
}
