// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xe63fadeb)]
    public sealed class RequestExportMessageLink : IRequest<OpenTl.Schema.IExportedMessageLink>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Grouped {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Thread {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IInputChannel Channel {get; set;}

       [SerializationOrder(4)]
       public int Id {get; set;}

    }
}
