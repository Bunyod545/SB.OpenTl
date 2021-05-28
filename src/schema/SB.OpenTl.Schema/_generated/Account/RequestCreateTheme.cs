// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x8432c21f)]
    public sealed class RequestCreateTheme : IRequest<OpenTl.Schema.ITheme>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       /// <summary>Binary representation for the 'Slug' property</summary>
       [SerializationOrder(1)]
       public byte[] SlugAsBinary { get => _SlugAsBinary; set { _Slug = Encoding.UTF8.GetString(value); _SlugAsBinary = value; }}
       private byte[] _SlugAsBinary;
       private string _Slug;
       public string Slug { get => _Slug; set { SlugAsBinary = Encoding.UTF8.GetBytes(value); _Slug = value; }}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(2)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       [SerializationOrder(3)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IInputDocument Document {get; set;}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.IInputThemeSettings Settings {get; set;}

    }
}
