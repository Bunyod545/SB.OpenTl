// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xf568028a)]
	public sealed class TBankCardOpenUrl : IBankCardOpenUrl
	{
       /// <summary>Binary representation for the 'Url' property</summary>
       [SerializationOrder(0)]
       public byte[] UrlAsBinary { get => _UrlAsBinary; set { _Url = Encoding.UTF8.GetString(value); _UrlAsBinary = value; }}
       private byte[] _UrlAsBinary;
       private string _Url;
       public string Url { get => _Url; set { UrlAsBinary = Encoding.UTF8.GetBytes(value); _Url = value; }}

       /// <summary>Binary representation for the 'Name' property</summary>
       [SerializationOrder(1)]
       public byte[] NameAsBinary { get => _NameAsBinary; set { _Name = Encoding.UTF8.GetString(value); _NameAsBinary = value; }}
       private byte[] _NameAsBinary;
       private string _Name;
       public string Name { get => _Name; set { NameAsBinary = Encoding.UTF8.GetBytes(value); _Name = value; }}

	}
}
