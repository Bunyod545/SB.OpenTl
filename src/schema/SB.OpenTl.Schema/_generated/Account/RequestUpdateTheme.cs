// ReSharper disable All

namespace OpenTl.Schema.Account
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5cb367d5)]
    public sealed class RequestUpdateTheme : IRequest<OpenTl.Schema.ITheme>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       /// <summary>Binary representation for the 'Format' property</summary>
       [SerializationOrder(1)]
       public byte[] FormatAsBinary { get => _FormatAsBinary; set { _Format = Encoding.UTF8.GetString(value); _FormatAsBinary = value; }}
       private byte[] _FormatAsBinary;
       private string _Format;
       public string Format { get => _Format; set { FormatAsBinary = Encoding.UTF8.GetBytes(value); _Format = value; }}

       [SerializationOrder(2)]
       public OpenTl.Schema.IInputTheme Theme {get; set;}

       /// <summary>Binary representation for the 'Slug' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public byte[] SlugAsBinary { get => _SlugAsBinary; set { _Slug = Encoding.UTF8.GetString(value); _SlugAsBinary = value; }}
       private byte[] _SlugAsBinary;
       private string _Slug;
       public string Slug { get => _Slug; set { SlugAsBinary = Encoding.UTF8.GetBytes(value); _Slug = value; }}

       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(4)]
       [CanSerialize("Flags", 1)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       [SerializationOrder(5)]
       [CanSerialize("Flags", 2)]
       public OpenTl.Schema.IInputDocument Document {get; set;}

       [SerializationOrder(6)]
       [CanSerialize("Flags", 3)]
       public OpenTl.Schema.IInputThemeSettings Settings {get; set;}

    }
}
