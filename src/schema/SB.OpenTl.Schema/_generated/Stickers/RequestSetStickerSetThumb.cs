// ReSharper disable All

namespace OpenTl.Schema.Stickers
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9a364e30)]
    public sealed class RequestSetStickerSetThumb : IRequest<OpenTl.Schema.Messages.IStickerSet>
    {
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputStickerSet Stickerset {get; set;}

       [SerializationOrder(1)]
       public OpenTl.Schema.IInputDocument Thumb {get; set;}

    }
}
