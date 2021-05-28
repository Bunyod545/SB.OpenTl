// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x63cacf26)]
	public sealed class TAutoDownloadSettings : IAutoDownloadSettings
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IAutoDownloadSettings Low {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IAutoDownloadSettings Medium {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IAutoDownloadSettings High {get; set;}

	}
}
