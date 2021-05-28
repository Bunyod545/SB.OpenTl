// ReSharper disable All

namespace OpenTl.Schema.Payments
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3e24e573)]
	public sealed class TBankCardData : IBankCardData
	{
       /// <summary>Binary representation for the 'Title' property</summary>
       [SerializationOrder(0)]
       public byte[] TitleAsBinary { get => _TitleAsBinary; set { _Title = Encoding.UTF8.GetString(value); _TitleAsBinary = value; }}
       private byte[] _TitleAsBinary;
       private string _Title;
       public string Title { get => _Title; set { TitleAsBinary = Encoding.UTF8.GetBytes(value); _Title = value; }}

       [SerializationOrder(1)]
       public OpenTl.Schema.TVector<OpenTl.Schema.IBankCardOpenUrl> OpenUrls {get; set;}

	}
}
