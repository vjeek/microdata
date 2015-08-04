using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using VJeek.Microdata.Intangible;
using VJeek.Microdata.Intangible.StructuredValue;

namespace VJeek.Microdata.Tests
{
	[TestClass]
	public class MicrodataTests
	{
		[TestMethod]
		public void EventTests()
		{
			var @event = new Event()
			{
				Name = "event name",
				StartDate = DateTime.Now,
				Location = new Place()
				{
					Name = "venue name",
					Address = new PostalAddress()
					{
						AddressCountry = new Country()
						{
							Name = "Россия"
						},
						AddressLocality = "г. Москва",
						AddressRegion = "Москва",
						StreetAddress = "ул.Садовническая 76"
					}
				},
				Offers = new List<Offer>()
				{
					new AggregateOffer()
					{
						LowPrice = 1000,
						HighPrice = 2000,
						OfferCount = 100
					}
				}
			};

			System.Diagnostics.Debug.Write(@event.ToJson(true));
		}
	}
}
