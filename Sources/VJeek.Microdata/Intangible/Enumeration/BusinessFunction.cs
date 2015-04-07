using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VJeek.Microdata.Intangible.Enumeration
{
	[Flags]
	public enum BusinessFunction
	{
		ConstructionInstallation,
		Dispose,
		LeaseOut,
		Maintain,
		ProvideService,
		Repair,
		Sell,
		Buy
	}
}
