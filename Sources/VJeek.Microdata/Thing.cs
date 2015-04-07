using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VJeek.Microdata
{
	public class Thing : BaseObject
	{
		/// <summary>
		/// An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. In RDFa syntax, it is better to use the native RDFa syntax - the 'typeof' attribute - for multiple types. Schema.org tools may have only weaker understanding of extra types, in particular those defined externally.
		/// </summary>
		[JsonProperty("additionalType")]
		public string AdditionalType { get; set; }

		/// <summary>
		/// An alias for the item.
		/// </summary>
		[JsonProperty("alternateName")]
		public string AlternateName { get; set; }

		/// <summary>
		/// A short description of the item.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		//todo: should be Thing > CreativeWork > MediaObject > ImageObject
		/// <summary>
		/// An image of the item. This can be a URL.
		/// </summary>
		[JsonProperty("image")]
		public string Image { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
		/// </summary>
		[JsonProperty("potentialAction")]
		public Microdata.Action PotentialAction { get; set; }

		/// <summary>
		/// URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Freebase page, or official website.
		/// </summary>
		[JsonProperty("sameAs")]
		public IList<string> SameAs { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }
	}
}
