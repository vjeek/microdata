using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

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
				Location = new Place()
				{
					Name = "venue name"
				}
			};

			System.Diagnostics.Debug.Write(@event.ToJson(Formatting.Indented));
		}
	}
}
