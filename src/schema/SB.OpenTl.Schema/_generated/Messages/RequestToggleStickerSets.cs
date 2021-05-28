// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb5052fea)]
    public sealed class RequestToggleStickerSets : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Uninstall {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Archive {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool Unarchive {get; set;}

       [SerializationOrder(4)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputStickerSet> Stickersets {get; set;}

    }
}
