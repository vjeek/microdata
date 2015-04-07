using System;
using VJeek.Microdata.Intangible.Enumeration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using VJeek.Microdata.Intangible.StructuredValue;

namespace VJeek.Microdata.Intangible
{
	public class Offer : Thing
	{
		[JsonProperty("acceptedPaymentMethod")]
		public PaymentMethod AcceptedPaymentMethod { get; set; }

		[JsonProperty("addOn")]
		public Offer AddOn { get; set; }

		[JsonProperty("advanceBookingRequirement")]
		public QuantitativeValue AdvanceBookingRequirement { get; set; }

		[JsonProperty("aggregateRating")]
		public AggregateRating AggregateRating { get; set; }

		[JsonProperty("availability")]
		public ItemAvailability Availability { get; set; }

		[JsonProperty("availabilityEnds")]
		public DateTime? AvailabilityEnds { get; set; }

		[JsonProperty("availabilityStarts")]
		public DateTime? AvailabilityStarts { get; set; }

		[JsonProperty("availableAtOrFrom")]
		public Place AvailableAtOrFrom { get; set; }

		[JsonProperty("availableDeliveryMethod")]
		public DeliveryMethod AvailableDeliveryMethod { get; set; }

		[JsonProperty("businessFunction")]
		public BusinessFunction BusinessFunction { get; set; }

		[JsonProperty("category")]
		public string Category { get; set; }

		//todo: implement
	}
}
