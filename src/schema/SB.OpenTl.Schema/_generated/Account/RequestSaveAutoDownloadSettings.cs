// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x76f36233)]
    public sealed class RequestSaveAutoDownloadSettings : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Low {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool High {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IAutoDownloadSettings Settings {get; set;}

    }
}
