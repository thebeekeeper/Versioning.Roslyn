using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Run00.TestSample
{
	[DataContract]
	public class Order
	{
		[DataMember]
		public Guid Id { get; private set; }

		[DataMember]
		public IEnumerable<LineItem> LineItems { get; set; }
	}
}
