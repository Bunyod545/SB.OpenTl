// ReSharper disable All

namespace OpenTl.Schema.Stats
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xdcdf8607)]
    public sealed class RequestGetMegagroupStats : IRequest<OpenTl.Schema.Stats.IMegagroupStats>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Dark {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputChannel Channel {get; set;}

    }
}
