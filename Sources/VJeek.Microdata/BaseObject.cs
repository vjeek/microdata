using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace VJeek.Microdata
{
	public abstract class BaseObject
	{
		[JsonProperty("@type", Order = 2)]
		public virtual string Type { get { return this.GetType().Name; } }

		public virtual string ToJson(Formatting formatting)
		{
			var settings = new JsonSerializerSettings()
			{
				ContractResolver = new DefaultContractResolver()
			};

			
			string item = JsonConvert.SerializeObject(this, formatting, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

			dynamic dItem = JsonConvert.DeserializeObject<dynamic>(item);

			dItem.Context = "http://schema.org";

			item = JsonConvert.SerializeObject(dItem, formatting, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

			item = item.Replace("Context", "@context");

			return "<script type=\"application/ld+json\">" + item + "</script>";
		}
	}
}
