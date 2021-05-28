// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3b1adf37)]
    public sealed class RequestReorderPinnedDialogs : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Force {get; set;}

       [SerializationOrder(2)]
       public int FolderId {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputDialogPeer> Order {get; set;}

    }
}
