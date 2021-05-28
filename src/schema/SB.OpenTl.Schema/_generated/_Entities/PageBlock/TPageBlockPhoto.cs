// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x1759c560)]
	public sealed class TPageBlockPhoto : IPageBlock
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public long PhotoId {get; set;}

       [SerializationOrder(2)]
       public OpenTl.Schema.IPageCaption Caption {get; set;}

       /// <summary>Binary representation for the 'Url' property</summary>
       [SerializationOrder(3)]
       [CanSerialize("Flags", 0)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       [SerializationOrder(4)]
       [CanSerialize("Flags", 0)]
       public long WebpageId {get; set;}

	}
}
