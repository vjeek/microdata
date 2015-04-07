using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.Microdata.Intangible.Enumeration
{
    [Flags] 
    public enum EventStatusType
    {
		EventCancelled = 1,

		EventPostponed = 2,

		EventRescheduled = 3,

		EventScheduled = 4
    }
}
