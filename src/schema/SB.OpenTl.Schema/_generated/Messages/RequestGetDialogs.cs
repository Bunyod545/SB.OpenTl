// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xa0ee3b73)]
    public sealed class RequestGetDialogs : IRequest<OpenTl.Schema.Messages.IDialogs>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool ExcludePinned {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 1)]
       public int FolderId {get; set;}

       [SerializationOrder(3)]
       public int OffsetDate {get; set;}

       [SerializationOrder(4)]
       public int OffsetId {get; set;}

       [SerializationOrder(5)]
       public OpenTl.Schema.IInputPeer OffsetPeer {get; set;}

       [SerializationOrder(6)]
       public int Limit {get; set;}

       [SerializationOrder(7)]
       public int Hash {get; set;}

    }
}
