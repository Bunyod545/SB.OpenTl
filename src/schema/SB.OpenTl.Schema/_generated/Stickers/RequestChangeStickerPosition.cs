// ReSharper disable All

namespace OpenTl.Schema.Stickers
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xffb6d4ca)]
    public sealed class RequestChangeStickerPosition : IRequest<OpenTl.Schema.Messages.IStickerSet>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputDocument Sticker {get; set;}

       [SerializationOrder(1)]
       public int Position {get; set;}

    }
}
