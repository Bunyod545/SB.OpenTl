// ReSharper disable All

namespace OpenTl.Schema.Contacts
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x29a8962c)]
    public sealed class RequestBlockFromReplies : IRequest<OpenTl.Schema.IUpdates>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool DeleteMessage {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool DeleteHistory {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool ReportSpam {get; set;}

       [SerializationOrder(4)]
       public int MsgId {get; set;}

    }
}
