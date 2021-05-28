// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x98657f0d)]
	public sealed class TPage : IPage
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Part {get; set;}

       [SerializationOrder(2)]
       [FromFlag("Flags", 1)]
       public bool Rtl {get; set;}

       [SerializationOrder(3)]
       [FromFlag("Flags", 2)]
       public bool V2 {get; set;}

       /// <summary>Binary representation for the 'Url' property</summary>
       [SerializationOrder(4)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       [SerializationOrder(5)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPageBlock> Blocks {get; set;}

       [SerializationOrder(6)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IPhoto> Photos {get; set;}

       [SerializationOrder(7)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IDocument> Documents {get; set;}

       [SerializationOrder(8)]
       [CanSerialize("Flags", 3)]
       public int Views {get; set;}

	}
}
