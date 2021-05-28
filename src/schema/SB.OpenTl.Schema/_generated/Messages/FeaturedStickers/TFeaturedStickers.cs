// ReSharper disable All

namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xb6abc341)]
	public sealed class TFeaturedStickers : IFeaturedStickers
	{
       [SerializationOrder(0)]
       public int Hash {get; set;}

       [SerializationOrder(1)]
       public int Count {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IStickerSetCovered> Sets {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.TVector<long> Unread {get; set;}

	}
}
