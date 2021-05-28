// ReSharper disable All

namespace OpenTl.Schema.Stickers
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf1036780)]
    public sealed class RequestCreateStickerSet : IRequest<OpenTl.Schema.Messages.IStickerSet>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Masks {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Animated {get; set;}

       [SerializationOrder(3)]
       public OpenTl.Schema.IInputUser UserId {get; set;}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(4)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       /// <summary>Binary representation for the 'ShortName' property</summary>
       [SerializationOrder(5)]
       public byte[] ShortNameAsBinary { get => _ShortNameAsBinary; set { _ShortName = Encoding.UTF8.GetString(value); _ShortNameAsBinary = value; }}
       private byte[] _ShortNameAsBinary;
       private string _ShortName;
       public string ShortName { get => _ShortName; set { ShortNameAsBinary = Encoding.UTF8.GetBytes(value); _ShortName = value; }}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IInputDocument Thumb {get; set;}

       [SerializationOrder(7)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IInputStickerSetItem> Stickers {get; set;}

    }
}
